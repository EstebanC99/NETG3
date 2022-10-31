CREATE TABLE [dbo].[t_Materia](
	[ID_Materia] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NOT NULL,
	[HsSemanales] INT NOT NULL,
	[HsTotales] INT NOT NULL,
	[ID_Plan] INT NULL, 
    CONSTRAINT [PK_t_Materia] PRIMARY KEY ([ID_Materia]),
	CONSTRAINT [FK_t_Materia_t_Plan] FOREIGN KEY ([ID_Plan]) REFERENCES [t_Plan]([ID_Plan]) ON DELETE SET NULL
)