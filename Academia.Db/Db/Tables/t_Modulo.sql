CREATE TABLE [dbo].[t_Modulo](
	[ID_Modulo] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NULL,
	[Ejecuta] VARCHAR(50) NULL, 
    CONSTRAINT [PK_t_Modulo] PRIMARY KEY ([ID_Modulo])
)