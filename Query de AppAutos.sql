create database aplicacioncarros;
use aplicacioncarros;

CREATE TABLE inventario (
IdVehiculo INT IDENTITY (1000,1) CONSTRAINT Pk_Inventario PRIMARY KEY,
Modelo VARCHAR(60),
Marca VARCHAR(60),
Color VARCHAR(60),
Año INT,
Precio INT,
Kilometraje INT,
Transmisión VARCHAR(60))

CREATE TABLE Cliente (
IdCliente INT IDENTITY (1000,1) CONSTRAINT Pk_Cliente PRIMARY KEY,
Nombre VARCHAR(60),
Apellido VARCHAR(60),
Telefono INT, 
Edad INT,
Domicilio VARCHAR(60))

CREATE TABLE Cliente (
IdCliente INT IDENTITY (1000,1) CONSTRAINT Pk_Cliente PRIMARY KEY,
Nombre VARCHAR(60),
Apellido VARCHAR(60),
Telefono VARCHAR (10), 
Edad INT,
Domicilio VARCHAR(60))

CREATE TABLE VENTAS (
Cliente INT CONSTRAINT Fk_VentasCliente FOREIGN KEY REFERENCES Cliente (IdCliente),
Contacto VARCHAR(60),
Credito INT,
Plazo INT,
Cantidad INT,
PagosRealizados INT,
Vehiculo INT CONSTRAINT Fk_VentasVehiculo FOREIGN KEY REFERENCES Inventario(IdVehiculo))

CREATE TABLE LOGIN (
LoginID INT IDENTITY (1000,1) CONSTRAINT Pk_LoginSales PRIMARY KEY,
Username VARCHAR(60),
Password VARCHAR(60))

INSERT INTO LOGIN 
VALUES ('admin','password123')
INSERT INTO inventario
VALUES ('2015','Nissan','Azul','2015','100000','0','Manual')
INSERT INTO Cliente
values ('John','Jones','8110233456','25','Abbey Road')

SELECT * FROM Cliente
SELECT * FROM LOGIN
SELECT * FROM inventario
SELECT * FROM Ventas

SELECT * FROM ALUMNOS

update inventario 


SELECT IdVehiculo,Modelo,Marca,Color,Año,Precio,Kilometraje,Transmisión FROM inventario ORDER BY Marca, Modelo ASC;

SELECT IdVehiculo,Modelo,Marca,Color,Año,Precio,Kilometraje,Transmisión FROM inventario ORDER BY Marca ASC;

CREATE VIEW V_ConsultaInventario AS
Select Marca,Modelo,Color,Año,Precio,Kilometraje,Transmisión 
FROM inventario

CREATE VIEW V_ConsultaCliente AS
Select Nombre, Apellido, Telefono, Edad, Domicilio
From Cliente


SELECT * FROM V_ConsultaInventario
SELECT * FROM V_ConsultaCliente

DROP VIEW V_ConsultaInventario
DROP TABLE Cliente
DROP TABLE VENTAS
DROP TABLE LOGIN

