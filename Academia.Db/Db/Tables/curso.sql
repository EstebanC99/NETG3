CREATE TABLE [dbo].[cursos](
	[id_curso] [int] IDENTITY(1,1) NOT NULL,
	[id_materia] [int] NOT NULL,
	[id_comision] [int] NOT NULL,
	[anio_calendario] [int] NOT NULL,
	[cupo] [int] NOT NULL,
 CONSTRAINT [PK_cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_cursos_comisiones]    Script Date: 05/26/2015 10:40:53 ******/
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_comisiones] FOREIGN KEY([id_comision])
REFERENCES [dbo].[comisiones] ([id_comision])
GO

ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_comisiones]
GO
/****** Object:  ForeignKey [FK_cursos_materias]    Script Date: 05/26/2015 10:40:53 ******/
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_materias] FOREIGN KEY([id_materia])
REFERENCES [dbo].[materias] ([id_materia])
GO

ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_materias]