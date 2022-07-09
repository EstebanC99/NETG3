CREATE TABLE [dbo].[t_Persona](
	[ID_Persona] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Legajo] [int] NULL,
	[TipoPersona] [int] NOT NULL,
	[ID_Plan] [int] NULL, 
    CONSTRAINT [PK_t_Persona] PRIMARY KEY ([ID_Persona]),
	CONSTRAINT [FK_t_Persona_t_Plan] FOREIGN KEY ([ID_Plan]) REFERENCES [t_Plan]([ID_Plan])
)