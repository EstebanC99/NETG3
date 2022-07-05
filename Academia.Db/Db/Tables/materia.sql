CREATE TABLE [dbo].[materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[desc_materia] [varchar](50) NOT NULL,
	[hs_semanales] [int] NOT NULL,
	[hs_totales] [int] NOT NULL,
	[id_plan] [int] NOT NULL, 
    CONSTRAINT [PK_materias] PRIMARY KEY ([id_materia]),
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_materias_planes]    Script Date: 05/26/2015 10:40:53 ******/
ALTER TABLE [dbo].[materias]  WITH CHECK ADD  CONSTRAINT [FK_materias_planes] FOREIGN KEY([id_plan])
REFERENCES [dbo].[planes] ([id_plan])
GO

ALTER TABLE [dbo].[materias] CHECK CONSTRAINT [FK_materias_planes]