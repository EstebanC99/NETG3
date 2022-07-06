CREATE TABLE [dbo].[t_ModuloUsuario](
	[ID_ModuloUsuario] INT IDENTITY(1,1) NOT NULL,
	[ID_Modulo] INT NOT NULL,
	[ID_Usuario] INT NOT NULL,
	[Alta] BIT NULL,
	[Baja] BIT NULL,
	[Modificacion] BIT NULL,
	[Consulta] BIT NULL, 
    CONSTRAINT [PK_t_ModuloUsuario] PRIMARY KEY ([ID_ModuloUsuario]),
	CONSTRAINT [FK_t_ModuloUsuario_t_Modulo] FOREIGN KEY ([ID_Modulo]) REFERENCES [t_Modulo]([ID_Modulo]),
	CONSTRAINT [FK_t_ModuloUsuario_t_Usuario] FOREIGN KEY ([ID_Usuario]) REFERENCES [t_Usuario]([ID_Usuario])
)