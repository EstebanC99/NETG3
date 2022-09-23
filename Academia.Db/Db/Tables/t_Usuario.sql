CREATE TABLE [dbo].t_Usuario(
	[ID_Usuario] INT IDENTITY(1,1) NOT NULL,
	[NombreUsuario] VARCHAR(50) NOT NULL,
	[Clave] VARCHAR(50) NOT NULL,
	[Habilitado] BIT NOT NULL,
	[CambiaClave] BIT NULL,
	[ID_Persona] INT NULL,
	[ID_Rol] INT NULL DEFAULT 1, 
    CONSTRAINT [PK_t_Usuario] PRIMARY KEY ([ID_Usuario]),
	CONSTRAINT [FK_t_Usuario_t_Persona] FOREIGN KEY ([ID_Persona]) REFERENCES [t_Persona]([ID_Persona]) ON DELETE CASCADE,
	CONSTRAINT [FK_t_Usuario_t_Rol] FOREIGN KEY ([ID_Rol]) REFERENCES [t_Rol]([ID_Rol]) ON DELETE SET NULL
)