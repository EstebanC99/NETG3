CREATE TABLE [dbo].[t_DocenteCurso](
	[ID_DocenteCurso] INT IDENTITY(1,1) NOT NULL,
	[ID_Curso] INT NOT NULL,
	[ID_Persona_Docente] INT NOT NULL,
	[Cargo] INT NOT NULL, 
    CONSTRAINT [PK_t_DocenteCurso] PRIMARY KEY ([ID_DocenteCurso]),
	CONSTRAINT [FK_t_DocenteCurso_t_Curso] FOREIGN KEY ([ID_Curso]) REFERENCES [t_Curso]([ID_Curso]),
	CONSTRAINT [FK_t_DocenteCurso_t_Persona_Docente] FOREIGN KEY ([ID_Persona_Docente]) REFERENCES [t_Persona]([ID_Persona])
)