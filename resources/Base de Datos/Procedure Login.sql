--        Trigger login
DELIMITER //
DROP PROCEDURE IF EXISTS p_Validar;
CREATE PROCEDURE p_Validar
(
	IN _nombre VARCHAR(255),
	IN _contrasena VARCHAR(255)
)
BEGIN 
	DECLARE x INT;
	SELECT COUNT(*) FROM usuarios WHERE nombre=_nombre AND contrasena = _contrasena AND status = 'Activo' INTO x;
	
	if X < 1 then
		SELECT 'Error' AS rs, 'Correo o Contrasena Incorrectos' AS texto;
	ELSE 
		SELECT 'C0rr3ct0' AS rs, 'Sesion Iniciada' AS texto;
	END if;
END //
DELIMITER ;

CALL p_Validar('Christian', SHA1('7410'));


