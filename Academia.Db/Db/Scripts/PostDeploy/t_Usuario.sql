SET IDENTITY_INSERT t_Usuario ON;
MERGE t_Usuario t
USING
(
	SELECT *
	FROM
	(
		VALUES
		(1, 'admin', 'admin', 1, null, 1, 100)
	) i (ID_Usuario, NombreUsuario, Clave, Habilitado, CambiaClave, ID_Persona, ID_Rol)
) ii ON (ii.ID_Usuario = t.ID_Usuario)
WHEN MATCHED THEN UPDATE SET
	t.NombreUsuario = ii.NombreUsuario,
	t.Clave = ii.Clave,
	t.Habilitado = ii.Habilitado,
	t.CambiaClave = ii.CambiaClave,
	t.ID_Persona = ii.ID_Persona,
	t.ID_Rol = ii.ID_Rol
WHEN NOT MATCHED BY TARGET THEN INSERT
	(ID_Usuario, NombreUsuario, Clave, Habilitado, CambiaClave, ID_Persona, ID_Rol)
	VALUES
	(ii.ID_Usuario, ii.NombreUsuario, ii.Clave, ii.Habilitado, ii.CambiaClave, ii.ID_Persona, ii.ID_Rol);
SET IDENTITY_INSERT t_Usuario OFF;