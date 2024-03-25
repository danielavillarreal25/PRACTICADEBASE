CREATE DATABASE NUEVABASE
Use NUEVABASE

SELECT * FROM Hoja1$

ALTER TABLE Hoja1$
DROP COLUMN F8;


CREATE TABLE Proveedores (
    IDProveedor VARCHAR(255) PRIMARY KEY,
    Proveedor VARCHAR(255),
    ContactoComercial VARCHAR(255),
    Email VARCHAR(255),
    Telefono VARCHAR(255)
);


CREATE TABLE Compras (
    IDProveedor VARCHAR(255),
    SaldoPendiente DECIMAL (10, 2),
    FechaUltimaCompra DATETIME,
    FOREIGN KEY (IDProveedor) REFERENCES Proveedores(IDProveedor)
);


-- Insertar datos en la tabla Proveedores
INSERT INTO Proveedores (IDProveedor, Proveedor, ContactoComercial, Email, Telefono)
SELECT ID, Proveedor, ContactoComercial, Email, Teléfono
FROM Hoja1$

SELECT * FROM Proveedores

-- Insertar datos en la tabla Compras
INSERT INTO Compras (IDProveedor, SaldoPendiente, FechaUltimaCompra)
SELECT ID, CAST(SaldoPendiente AS DECIMAL(10,2)), FechaUltimaCompra ---conversión de tipo de datos durante la inserción. El saldo pendiente se convierte de money a decimal
FROM Hoja1$;

SELECT * FROM Compras

-- Crear un índice en la columna IDProveedor de la tabla Compras
CREATE INDEX idx_IDProveedor ON Compras (IDProveedor);
EXEC sp_helpindex 'compras';




SELECT DISTINCT fechaultimacompra
FROM Compras

SELECT * FROM Compras