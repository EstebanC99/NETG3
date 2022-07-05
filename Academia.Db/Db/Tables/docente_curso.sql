CREATE TABLE [dbo].[docentes_cursos](
	[id_dictado] [int] IDENTITY(1,1) NOT NULL,
	[id_curso] [int] NOT NULL,
	[id_docente] [int] NOT NULL,
	[cargo] [int] NOT NULL,
 CONSTRAINT [PK_docentes_cursos] PRIMARY KEY CLUSTERED 
(
	[id_dictado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_docentes_cursos_cursos]    Script Date: 05/26/2015 10:40:53 ******/
ALTER TABLE [dbo].[docentes_cursos]  WITH CHECK ADD  CONSTRAINT [FK_docentes_cursos_cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[cursos] ([id_curso])
GO

ALTER TABLE [dbo].[docentes_cursos] CHECK CONSTRAINT [FK_docentes_cursos_cursos]
GO
/****** Object:  ForeignKey [FK_docentes_cursos_personas]    Script Date: 05/26/2015 10:40:53 ******/
ALTER TABLE [dbo].[docentes_cursos]  WITH CHECK ADD  CONSTRAINT [FK_docentes_cursos_personas] FOREIGN KEY([id_docente])
REFERENCES [dbo].[personas] ([id_persona])
GO

ALTER TABLE [dbo].[docentes_cursos] CHECK CONSTRAINT [FK_docentes_cursos_personas]