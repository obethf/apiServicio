-- Crear base de datos
CREATE DATABASE ProgramacionWebII;
GO

USE ProgramacionWebII;
GO

-- Crear tabla Estudiantes
CREATE TABLE Estudiantes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NombreCompleto NVARCHAR(100),
    Rol NVARCHAR(50)
);
GO

-- Insertar datos
INSERT INTO Estudiantes (NombreCompleto, Rol) VALUES
('Obeth Flores Choque', 'Estudiante');