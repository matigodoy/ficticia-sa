CREATE TABLE [dbo].[Persona] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]      NVARCHAR (100) NOT NULL,
    [Identificacion] NVARCHAR (100) NOT NULL,
    [Edad]        INT            NOT NULL,
    [Genero]      NVARCHAR (100) NOT NULL,
    [Estado]      NVARCHAR (100) NOT NULL,
    [Maneja]      NVARCHAR (100) NOT NULL,
    [UsaLentes]   NVARCHAR (100) NOT NULL,
    [Diabetico]   NVARCHAR (100) NOT NULL,
    [Enfermedad]  NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Usuario] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]      NVARCHAR (100) NOT NULL,
    [Contrasena]  NVARCHAR (100) NOT NULL,
    [PersonaId]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Usuario_Persona] FOREIGN KEY ([PersonaId]) REFERENCES [dbo].[Persona] ([Id])
);

CREATE PROCEDURE [dbo].[InsertarUsuario]
    @Nombre NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @PersonaId INT
AS
BEGIN
    INSERT INTO [dbo].[Usuario] ([Nombre], [Contrasena], [PersonaId])
    VALUES (@Nombre, @Contrasena, @PersonaId)
END

CREATE PROCEDURE [dbo].[ActualizarUsuario]
    @Id INT,
    @Nombre NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @PersonaId INT
AS
BEGIN
    UPDATE [dbo].[Usuario]
    SET [Nombre] = @Nombre,
        [Contrasena] = @Contrasena,
        [PersonaId] = @PersonaId
    WHERE [Id] = @Id
END

CREATE PROCEDURE [dbo].[EliminarUsuario]
    @Id INT
AS
BEGIN
    DELETE FROM [dbo].[Usuario]
    WHERE [Id] = @Id
END

CREATE PROCEDURE [dbo].[ObtenerUsuario]
    @Id INT
AS
BEGIN
    SELECT [Id], [Nombre], [Contrasena], [PersonaId]
    FROM [dbo].[Usuario]
    WHERE [Id] = @Id
END

CREATE PROCEDURE [dbo].[ObtenerUsuarios]
AS
BEGIN
    SELECT [Id], [Nombre], [Contrasena], [PersonaId]
    FROM [dbo].[Usuario]
END

CREATE PROCEDURE [dbo].[usp_ListarPersonas]
AS
BEGIN
    SELECT * FROM Persona
END

CREATE PROCEDURE [dbo].[usp_ObtenerPersona]
    @Id INT
AS
BEGIN
    SELECT * FROM Persona WHERE Id = @Id
END

CREATE PROCEDURE [dbo].[usp_Login]
    @user NVARCHAR(100),
	@password NVARCHAR(100)
AS
BEGIN
    SELECT [Id], [Nombre], [Contrasena], [PersonaId]
    FROM [dbo].[Usuario]
    WHERE [Nombre] = @user
	AND	[Contrasena] = @password
END

CREATE PROCEDURE [dbo].[usp_CrearPersona]
    @Nombre NVARCHAR(100),
    @Identificacion NVARCHAR(100),
    @Edad INT,
    @Genero NVARCHAR(100),
    @Estado NVARCHAR(100),
    @Maneja NVARCHAR(100),
    @UsaLentes NVARCHAR(100),
    @Diabetico NVARCHAR(100),
    @Enfermedad NVARCHAR(100)
AS
BEGIN
    INSERT INTO Persona (Nombre, Identificacion, Edad, Genero, Estado, Maneja, UsaLentes, Diabetico, Enfermedad)
    VALUES (@Nombre, @Identificacion, @Edad, @Genero, @Estado, @Maneja, @UsaLentes, @Diabetico, @Enfermedad)
END

CREATE PROCEDURE [dbo].[usp_EditarPersona]
    @Id INT,
    @Nombre NVARCHAR(100),
    @Identificacion NVARCHAR(100),
    @Edad INT,
    @Genero NVARCHAR(100),
    @Estado NVARCHAR(100),
    @Maneja NVARCHAR(100),
    @UsaLentes NVARCHAR(100),
    @Diabetico NVARCHAR(100),
    @Enfermedad NVARCHAR(100)
AS
BEGIN
    UPDATE Persona
    SET Nombre = @Nombre,
        Identificacion = @Identificacion,
        Edad = @Edad,
        Genero = @Genero,
        Estado = @Estado,
        Maneja = @Maneja,
        UsaLentes = @UsaLentes,
        Diabetico = @Diabetico,
        Enfermedad = @Enfermedad
    WHERE Id = @Id
END

CREATE PROCEDURE [dbo].[usp_EliminarPersona]
    @Id INT
AS
BEGIN
    DELETE FROM Persona WHERE Id = @Id
END

EXEC usp_CrearPersona 'Juan', '123456789', 20, 'Masculino', 'Soltero', 'Si', 'No', 'No', 'No'
EXEC usp_CrearPersona 'Maria', '987654321', 18, 'Femenino', 'Soltera', 'No', 'Si', 'No', 'No'
EXEC usp_CrearPersona 'Pedro', '123456789', 20, 'Masculino', 'Soltero', 'Si', 'No', 'No', 'No'
EXEC usp_CrearPersona 'Juana', '987654321', 18, 'Femenino', 'Soltera', 'No', 'Si', 'No', 'No'
EXEC usp_CrearPersona 'Pablo', '123456789', 20, 'Masculino', 'Soltero', 'Si', 'No', 'No', 'No'
EXEC usp_CrearPersona 'Ana', '987654321', 18, 'Femenino', 'Soltera', 'No', 'Si', 'No', 'No'

EXEC InsertarUsuario 'juanelcrack','123','1'