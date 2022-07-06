CREATE TABLE [dbo].[t_Comision](
	[ID_Comision] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NOT NULL,
	[AnioEspecialidad] INT NOT NULL,
	[ID_Plan] INT NOT NULL, 
    CONSTRAINT [PK_t_Comision] PRIMARY KEY ([ID_Comision]),
	CONSTRAINT [FK_t_Comision_t_Plan] FOREIGN KEY ([ID_Plan]) REFERENCES [t_Plan]([ID_Plan])
)