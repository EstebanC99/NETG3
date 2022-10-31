CREATE TABLE [dbo].[t_Curso](
	[ID_Curso] INT IDENTITY(1,1) NOT NULL,
	[ID_Materia] INT NOT NULL,
	[ID_Comision] INT NULL,
	[AnioCalendario] INT NOT NULL,
	[Cupo] INT NOT NULL, 
    CONSTRAINT [PK_t_Curso] PRIMARY KEY ([ID_Curso]),
	CONSTRAINT [FK_t_Curso_t_Materia] FOREIGN KEY ([ID_Materia]) REFERENCES [t_Materia]([ID_Materia]) ON DELETE CASCADE,
	CONSTRAINT [FK_t_Curso_t_Comision] FOREIGN KEY ([ID_Comision]) REFERENCES [t_Comision]([ID_Comision]) ON DELETE SET NULL
)