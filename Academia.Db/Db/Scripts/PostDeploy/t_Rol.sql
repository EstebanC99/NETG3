MERGE t_Rol t
USING
(
	SELECT *
	FROM
	(
		VALUES
		(1, 'Alumno'),
		(2, 'Profesor'),
		(100, 'Administrador')
	) i (ID_Rol, Descripcion)
) ii ON (ii.ID_Rol = t.ID_Rol)
WHEN MATCHED THEN UPDATE SET
	t.Descripcion = ii.Descripcion
WHEN NOT MATCHED BY TARGET THEN INSERT
	(ID_Rol, Descripcion)
	VALUES
	(ii.ID_Rol, ii.Descripcion);