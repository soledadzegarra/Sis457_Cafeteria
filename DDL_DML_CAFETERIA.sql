CREATE DATABASE LabCafeteria;
GO
USE [master]
GO
CREATE LOGIN [usrcafeteria] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [LabCafeteria],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [LabCafeteria]
GO
CREATE USER [usrcafeteria] FOR LOGIN [usrcafeteria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrcafeteria]
GO

CREATE TABLE Producto (
    id INT PRIMARY KEY IDENTITY(1,1),
    codigo VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250),
    saldo DECIMAL NOT NULL DEFAULT 0,
    precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
);


CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
);

CREATE TABLE Empleado (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL,
    nombres VARCHAR(30) NOT NULL,
    primerApellido VARCHAR(30) NULL,
    segundoApellido VARCHAR(30) NULL,
    direccion VARCHAR(250) NOT NULL,
    celular BIGINT NOT NULL,
    cargo VARCHAR(50) NOT NULL, 
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
);


CREATE TABLE Usuario (
    id INT PRIMARY KEY IDENTITY(1,1),
    idEmpleado INT NOT NULL, 
    usuario VARCHAR(50) UNIQUE NOT NULL,
    clave VARCHAR(255) NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);

CREATE TABLE Pedido (
    id INT PRIMARY KEY IDENTITY(1,1),
    idUsuario INT NOT NULL,
    idCliente INT NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Venta_Usuario FOREIGN KEY(idUsuario) REFERENCES Usuario(id),
    CONSTRAINT fk_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
);

CREATE TABLE DetallePedido (
    id INT PRIMARY KEY IDENTITY(1,1),
    idPedido INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL,
    precioUnitario DECIMAL NOT NULL,
    total DECIMAL NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_DetallePedido_Pedido FOREIGN KEY(idPedido) REFERENCES Pedido(id),
    CONSTRAINT fk_DetallePedido_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);

