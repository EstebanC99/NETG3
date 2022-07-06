CREATE TABLE [dbo].[t_Plan](
	[ID_Plan] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NOT NULL,
	[ID_Especialidad] INT NOT NULL, 
    CONSTRAINT [PK_t_Plan] PRIMARY KEY ([ID_Plan]),
	CONSTRAINT [FK_t_Plan_t_Especialidad] FOREIGN KEY ([ID_Especialidad]) REFERENCES [t_Especialidad]([ID_Especialidad])
)
