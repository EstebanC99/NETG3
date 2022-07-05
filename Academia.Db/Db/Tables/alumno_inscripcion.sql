CREATE TABLE [dbo].[alumnos_inscripciones](
	[id_inscripcion] [int] IDENTITY(1,1) NOT NULL,
	[id_alumno] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[condicion] [varchar](50) NOT NULL,
	[nota] [int] NULL,
 CONSTRAINT [PK_alumnos_inscripciones] PRIMARY KEY CLUSTERED 
(
	[id_inscripcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_alumnos_inscripciones_cursos]    Script Date: 05/26/2015 10:40:53 ******/
ALTER TABLE [dbo].[alumnos_inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_alumnos_inscripciones_cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[cursos] ([id_curso])
GO

ALTER TABLE [dbo].[alumnos_inscripciones] CHECK CONSTRAINT [FK_alumnos_inscripciones_cursos]
GO
/****** Object:  ForeignKey [FK_alumnos_inscripciones_personas]    Script Date: 05/26/2015 10:40:53 ******/
ALTER TABLE [dbo].[alumnos_inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_alumnos_inscripciones_personas] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[personas] ([id_persona])
GO

ALTER TABLE [dbo].[alumnos_inscripciones] CHECK CONSTRAINT [FK_alumnos_inscripciones_personas]