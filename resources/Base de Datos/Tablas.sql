CREATE DATABASE durOS;
USE durOS;

CREATE TABLE Productos (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    CodigoProducto VARCHAR(50) UNIQUE NOT NULL,
    NombreProducto VARCHAR(100) NOT NULL,
    InventarioMinimo INT NOT NULL,
    InventarioActual INT NOT NULL,
    PrecioPublico DECIMAL(10,2) NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    status ENUM('Activo', 'Inactivo') NOT NULL
);

CREATE TABLE Ticket (
    idT INT AUTO_INCREMENT PRIMARY KEY,
    Folio VARCHAR(50) UNIQUE NOT NULL,
    Fecha DATETIME NOT NULL,
    Mesa INT NOT NULL,
    Total DECIMAL(10,2) NOT NULL
);

CREATE TABLE ContenidoTicket (
    idCT INT AUTO_INCREMENT PRIMARY KEY,
    fkFolio VARCHAR(50) NOT NULL,
    Producto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (fkFolio) REFERENCES Ticket(Folio) ON DELETE CASCADE,
    FOREIGN KEY (Producto) REFERENCES Productos(ID) ON DELETE CASCADE
);

DELIMITER //
DROP PROCEDURE IF EXISTS p_Contenido;
CREATE PROCEDURE p_Contenido
(
	IN _fkFolio VARCHAR(255)
)
BEGIN 
	DECLARE 
	DECLARE productoNom VARCHAR(100);
	SELECT nombreProducto FROM productos WHERE _Producto = ID INTO productoNom;
	
	SELECT productoNom AS 'Producto', cantidad 
	
	if X < 1 then
		SELECT 'Error' AS rs, 'Correo o Contrasena Incorrectos' AS texto;
	ELSE 
		SELECT 'C0rr3ct0' AS rs, 'Sesion Iniciada' AS texto;
	END if;
END //
DELIMITER ;













CREATE TABLE Usuarios (
    idU INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    contrasena VARCHAR(255) NOT NULL,
    tipoUsuario ENUM('Empleado', 'Encargado', 'Administrador') NOT NULL,
    status ENUM('Activo', 'Inactivo') NOT NULL
);

CREATE TABLE movimientos (
	idM INT PRIMARY KEY AUTO_INCREMENT,
	concepto VARCHAR(255) NOT NULL,
	cantidad DECIMAL(10,2) NOT NULL,
	tipo ENUM('Entrada', 'Salida'),
	Fecha DATE NOT NULL
);

CREATE TABLE turnos (
	idTu INT PRIMARY KEY AUTO_INCREMENT,
	encargado VARCHAR(100) NOT NULL,
	fondoCaja DECIMAL(10,2) NOT NULL,
	tipo ENUM('Entrada', 'Salida'),
	Fecha DATE NOT NULL
);