CREATE TABLE [dbo].[t_Especialidad](
	[ID_Especialidad] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_t_Especialidad] PRIMARY KEY ([ID_Especialidad])
)