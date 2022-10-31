CREATE TABLE [dbo].[t_AlumnoInscripcion](
	[ID_Inscripcion] INT IDENTITY(1,1) NOT NULL,
	[ID_Persona_Alumno] INT NOT NULL,
	[ID_Curso] INT NOT NULL,
	[Condicion] VARCHAR(50) NOT NULL,
	[Nota] INT NULL, 
    CONSTRAINT [PK_t_AlumnoInscripcion] PRIMARY KEY ([ID_Inscripcion]),
	CONSTRAINT [FK_t_AlumnoInscripcion_t_Persona] FOREIGN KEY ([ID_Persona_Alumno]) REFERENCES [t_Persona]([ID_Persona]) ON DELETE CASCADE,
	CONSTRAINT [FK_t_AlumnoInscripcion_t_Curso] FOREIGN KEY ([ID_Curso]) REFERENCES [t_Curso]([ID_Curso]) ON DELETE CASCADE
)