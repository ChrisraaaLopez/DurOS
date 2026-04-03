
--        Ingresar Producto nuevo
DELIMITER //
DROP PROCEDURE IF EXISTS p_InsertarProducto;
CREATE PROCEDURE p_InsertarProducto
(
	IN _codigoProducto VARCHAR(50),
	IN _nombreProducto VARCHAR(100),
	IN _inventarioMinimo INT,
	IN _inventarioActual INT,
	IN _precioPublico DECIMAL(10,2),
	IN _precioUnitario DECIMAL(10,2)
)
BEGIN 
	DECLARE x INT;
	SELECT COUNT(*) FROM prodUctos WHERE codigoProducto=_codigoProducto AND status = 'Activo' INTO x;
	
	if X >= 1 then
		SELECT 'Error' AS rs, 'Producto Existente' AS texto;
	ELSE 
		INSERT INTO productos VALUES (NULL, _codigoProducto, _nombreProducto, _inventarioMinimo, _inventarioActual, _precioPublico, _precioUnitario, 'Activo');
		SELECT 'Correcto' AS rs, 'Sesion Iniciada' AS texto;
	END if;
END //
DELIMITER ;



--         Borrar Producto
DELIMITER //
DROP PROCEDURE IF EXISTS p_eliminarProducto;
CREATE PROCEDURE p_eliminarProducto
(
	IN _codigoProducto VARCHAR(50)
)
BEGIN 
	DECLARE x INT;
	SELECT COUNT(*) FROM prodUctos WHERE codigoProducto=_codigoProducto AND status = 'Activo' INTO x;
	
	if X < 1 then
		SELECT 'Error' AS rs, 'El producto no existe' AS texto;
	ELSE 
		UPDATE productos
		SET status = 'Inactivo'
		WHERE codigoProducto = _codigoProducto;
		
		SELECT 'Correcto' AS rs, 'Producto eliminado' AS texto;
	END if;
END //
DELIMITER ;



--         Modificar Producto
DELIMITER //
DROP PROCEDURE IF EXISTS p_modificarProducto;
CREATE PROCEDURE p_modificarProducto
(
	IN _id INT, 
	IN _codigoProducto VARCHAR(50),
	IN _nombreProducto VARCHAR(100),
	IN _inventarioMinimo INT,
	IN _inventarioActual INT,
	IN _precioPublico DECIMAL(10,2),
	IN _precioUnitario DECIMAL(10,2)
)
BEGIN 
	DECLARE x INT;
	SELECT COUNT(*) FROM prodUctos WHERE ID=_id AND status = 'Activo' INTO x;
	
	if X < 1 then
		SELECT 'Error' AS rs, 'El producto no existe' AS texto;
	ELSE 
		UPDATE productos
		SET codigoProducto = _codigoProducto,
			 nombreProducto = _nombreProducto,
			 inventarioMinimo = _inventarioMinimo,
			 inventarioActual = _inventarioActual,
			 precioPublico = _precioPublico,
			 precioUnitario = _precioUnitario
		WHERE ID = _id;
		
		SELECT 'Correcto' AS rs, 'Producto modificado' AS texto;
	END if;
END //
DELIMITER ;






-- Eliminar Producto
UPDATE productos
		SET STATUS = 'Inactivo'
		WHERE codigoProducto = '';










