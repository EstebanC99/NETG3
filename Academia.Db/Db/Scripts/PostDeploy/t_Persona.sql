SET IDENTITY_INSERT t_Persona ON;
MERGE t_Persona t
USING
(
	SELECT *
	FROM
	(
		VALUES
		(1, 'Administrador', 'Administrador', '', 'admin@mail.com', '', '2022-01-01', 11111, 100, null)
	) i (ID_Persona, Nombre, Apellido, Direccion, Email, Telefono, FechaNacimiento, Legajo, TipoPersona, ID_Plan)
) ii ON (ii.ID_Persona = t.ID_Persona)
WHEN MATCHED THEN UPDATE SET
	t.Nombre = ii.Nombre,
	t.Apellido = ii.Apellido,
	t.Direccion = ii.Direccion,
	t.Email = ii.Email,
	t.Telefono = ii.Telefono,
	t.FechaNacimiento = ii.FechaNacimiento,
	t.Legajo = ii.Legajo,
	t.TipoPersona = ii.TipoPersona,
	t.ID_Plan = ii.ID_Plan			
WHEN NOT MATCHED BY TARGET THEN INSERT
	(ID_Persona, Nombre, Apellido, Direccion, Email, Telefono, FechaNacimiento, Legajo, TipoPersona, ID_Plan)
	VALUES
	(ii.ID_Persona, ii.Nombre, ii.Apellido, ii.Direccion, ii.Email, ii.Telefono, ii.FechaNacimiento, ii.Legajo, ii.TipoPersona, ii.ID_Plan);
SET IDENTITY_INSERT t_Persona OFF;
