USE master;
GO

-- Crear la base de datos
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'GestionGastosDB')
BEGIN
    CREATE DATABASE [GestionGastosDB];
END
GO

-- Usar la base de datos recién creada
USE [GestionGastosDB];
GO

-- Crear tabla Departamento
CREATE TABLE [dbo].[Departamento](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    KEY CLUSTERED ([ID] ASC)
);
GO

-- Crear tabla Empleado
CREATE TABLE [dbo].[Empleado](
    [ID] [int] IDENTITY(1,1) NOT NULL,
      NOT NULL,
    [Depart,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([DepartamentoID]) REFERENCES [dbo].[Departamento] ([ID])
);
GO

-- Crear tabla Gastos
CREATE TABLE [dbo].[Gastos](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [Fecha] [date] NOT NULL,
      NOT NULL,
    [Monto] [decimal](10, 2) NOT NOT NULL,
    [DepartamentoID] [int] NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([EmpleadoID]) REFERENCES [dbo].[Empleado] ([ID]),
    FOREIGN KEY ([DepartamentoID]) REFERENCES [dbo].[Departamento] ([ID])
);
GO

-- Insertar datos en Departamento
SET IDENTITY_INSERT [dbo].[Departamento] ON;
INSERT INTO [dbo].[Departamento] ([ID], [Nombre]) VALUES (1, N'IT');
INSERT INTO [dbo].[Departamento] ([ID], [Nombre]) VALUES (2, N'Desarrollo');
INSERT INTO [dbo].[Departamento] ([ID], [Nombre]) VALUES (3, N'Diseño');
INSERT INTO [dbo].[Departamento] ([ID], [Nombre]) VALUES (4, N'Marketing');
SET IDENTITY_INSERT [dbo].[Departamento] OFF;
GO

-- Insertar datos en Empleado
SET IDENTITY_INSERT [dbo].[Empleado] ON;
INSERT INTO [dbo].[Empleado] ([ID], [Nombre], [DepartamentoID]) VALUES (1, N'Zoila Baca', 1);
INSERT INTO [dbo].[Empleado] ([ID], [Nombre], [DepartamentoID]) VALUES (2, N'Aquiles C', 2);
INSERT INTO [dbo].[Empleado] ([ID], [Nombre], [DepartamentoID]) VALUES (3, N'Johnny Melas', 3);
SET IDENTITY_INSERT [dbo].[Empleado] OFF;
GO

-- Insertar datos en Gastos
SET IDENTITY_INSERT [dbo].[Gastos] ON;
INSERT INTO [dbo].[Gastos] ([ID], [Fecha], [Descripcion], [Monto], [EmpleadoID], [DepartamentoID])
VALUES 
    (1, '2024-11-16', N'UPS', 60.00, 1, 1),
    (2, '2024-11-22', N'Monitor Secundario', 250.00, 3, 2),
    (3, '2024-11-23', N'Rollup', 60.00, 3, 3),
    (4, '2024-11-25', N'UPS', 60.00, 1, 1);
SET IDENTITY_INSERT [dbo].[Gastos] OFF;
GO

-- Confirmar que la base de datos está lista para escritura
ALTER DATABASE [GestionGastosDB] SET READ_WRITE;
GO
