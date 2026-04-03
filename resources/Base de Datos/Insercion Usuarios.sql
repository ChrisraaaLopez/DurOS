USE durOS;

-- Insercion de usuarios admins
INSERT INTO Usuarios (nombre, contrasena, tipoUsuario, status)
VALUES ('Jonathan', SHA1('8520'), 'Administrador', 'Activo');

INSERT INTO Usuarios (nombre, contrasena, tipoUsuario, status)
VALUES ('Christian', SHA1('7410'), 'Administrador', 'Activo');