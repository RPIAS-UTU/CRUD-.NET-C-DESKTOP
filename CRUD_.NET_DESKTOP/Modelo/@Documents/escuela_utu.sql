--
-- Base de datos: `escuela_utu`
--
DROP DATABASE IF EXISTS `escuela_utu`;
CREATE DATABASE IF NOT EXISTS `escuela_utu` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `escuela_utu`;

--
-- Estructura de tabla para la tabla `persona`
--

DROP TABLE IF EXISTS `persona`;
CREATE TABLE `persona` (
  `id_persona` int(11) NOT NULL,
  `cedula` int(11) NOT NULL,
  `primer_nombre` varchar(120) NOT NULL,
  `segundo_nombre` varchar(120) DEFAULT NULL,
  `primer_apellido` varchar(120) NOT NULL,
  `segundo_apellido` varchar(120) DEFAULT NULL,
  `fecha_nac` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`id_persona`, `cedula`, `primer_nombre`, `segundo_nombre`, `primer_apellido`, `segundo_apellido`, `fecha_nac`) VALUES
(1, 5422312, 'Pedro', 'Jose', 'Pedrosa', 'Joseosa', '1975-11-03'),
(2, 4212312, 'Maria', 'Jose', 'Gonzales', 'Pedrosa', '1990-01-12'),
(3, 3233421, 'Mario', 'Alvaro', 'Lopes', 'Martinez', '1999-02-15'),
(4, 4123223, 'Hector', 'Mateo', 'Gonzalez', '', '2002-01-03'),
(5, 3124567, 'Richard', 'Jose', 'Perez', 'Galeano', '1993-11-04'),
(6, 2342345, 'Nubel', 'Mario', 'Sisneros', 'Ramirez', '1977-08-03'),
(7, 3259122, 'Franco', 'Joaquín', 'Machado', 'Rosales', '2000-04-24'),
(8, 2925122, 'Juan', 'Manuel', 'Perez', 'Rodriguez', '2006-05-02'),
(9, 3529122, 'Alejandra', 'Manuela', 'Gutierrez', 'Martinez', '2010-04-04'),
(10, 59245911, 'Gabriela', 'Elena', 'Piris', 'Rolin', '1980-11-03');

-- --------------------------------------------------------
-- --------------------------------------------------------
--
-- Estructura de tabla para la tabla `roles`
--
DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `id` int(11) NOT NULL primary key auto_increment,
  `rol` varchar(250) DEFAULT NULL,
  `habilitado` bit NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `roles` (`id`, `rol`,`habilitado`) VALUES
(1, 'administrador', 1), 
(2, 'operador', 1), 
(3, 'usuario', 1); 

-- --------------------------------------------------------
-- --------------------------------------------------------
--
-- Estructura de tabla para la tabla `usuarios`
--
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL primary key auto_increment,
  `usuario` varchar(250) DEFAULT NULL,
  `pass` varchar(250) DEFAULT NULL,
  `id_rol` int(11) DEFAULT NULL,
  `habilitado` bit NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `usuarios` (`usuario`, `pass`, `id_rol`, `habilitado`) VALUES
('admin@admin.com', 'fc8252c8dc55839967c58b9ad755a59b61b67c13227ddae4bd3f78a38bf394f7',1,1), -- PASS SHA256 :: admin
('operador@operador.com', '33b99168919a3a42b8a8aa4ce051bf7219692a565cf46a41dcbfd198433e48b2',2, 0), -- PASS SHA256 :: operador
('usuario@usuario.com', 'cb5d1d59df179c99288dd5d46a3b5d4f835993745b2a0b4886420b9c11d90860', 3,1); -- PASS SHA256 :: usuario












DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `sp_agregar_persona`$$
CREATE PROCEDURE `sp_agregar_persona` 
(
  IN `ci` INT, 
  IN `n1` VARCHAR(50), 
IN `n2` VARCHAR(50), IN `a1` VARCHAR(50), 
IN `a2` VARCHAR(50), IN `fnac` 
VARCHAR(10), 

INOUT `id_ingresado` INT

)  

BEGIN 

INSERT INTO persona (
    cedula, 
    primer_nombre, 
    segundo_nombre, 
    primer_apellido, 
    segundo_apellido, 
    fecha_nac
) VALUES (
    ci, 
    n1, 
    n2, 
    a1, 
    a2, 
    fnac
);

SELECT @@identity INTO id_ingresado;
END$$

DROP PROCEDURE IF EXISTS `sp_obtener_personas`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_obtener_personas` ()  BEGIN 
-- Dentro del SP el Delimitador sguirá siendo (;) 
 SELECT 
 P.cedula 
,CONCAT(P.primer_nombre, " ", P.primer_apellido ) AS nombre
FROM persona AS P;

END$$

DROP PROCEDURE IF EXISTS `sp_obtener_persona_por_cedula`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_obtener_persona_por_cedula` (`ci` INT)  BEGIN 
-- Dentro del SP el Delimitador sguirá siendo (;) 
 SELECT 
 P.cedula 
,CONCAT(P.primer_nombre, " ", P.primer_apellido ) AS nombre
FROM persona AS P
WHERE cedula = ci;

END$$

DELIMITER ;

-- --------------------------------------------------------




-- --------------------------------------------------------


--
-- Estructura de tabla para la tabla `usuarios`
--
DROP TABLE IF EXISTS `usuarios_api`;
CREATE TABLE `usuarios_api` (
  `UsuarioId` int(11) NOT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Estado` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios_api` (`UsuarioId`, `Usuario`, `Password`, `Estado`) VALUES
(1, 'usuario1@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Activo'),
(2, 'usuario2@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Activo'),
(3, 'usuario3@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Activo'),
(4, 'usuario4@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Activo'),
(5, 'usuario5@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Activo'),
(6, 'usuario6@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Activo'),
(7, 'usuario7@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Inactivo'),
(8, 'usuario8@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Inactivo'),
(9, 'usuario9@gmail.com', 'e10adc3949ba59abbe56e057f20f883e', 'Inactivo');

-- --------------------------------------------------------
--
-- Estructura de tabla para la tabla `usuarios_token`
--
DROP TABLE IF EXISTS `usuarios_token`;
CREATE TABLE `usuarios_token` (
  `TokenId` int(11) NOT NULL ,
  `UsuarioId` varchar(45) DEFAULT NULL,
  `Token` varchar(45) DEFAULT NULL,
  `Estado` varchar(45) CHARACTER SET armscii8 DEFAULT NULL,
  `Fecha` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- AUTO_INCREMENT de la tabla `usuarios_api`
--
/*
ALTER TABLE `usuarios_api`
  MODIFY `UsuarioId` int(11) NOT NULL AUTO_INCREMENT;
*/

-- AUTO_INCREMENT de la tabla `usuarios`
--
/*
ALTER TABLE `usuarios_token`
  MODIFY `TokenId` int(11) NOT NULL AUTO_INCREMENT;
  
  ALTER TABLE `usuarios_token`
  ADD PRIMARY KEY (`TokenId`);
  */
  
--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `FK_persona_empleados` (`id_persona`);

--
-- Indices de la tabla `jornalero`
--
ALTER TABLE `jornalero`
  ADD PRIMARY KEY (`id_jornalero`),
  ADD KEY `FK_empleados_jornalero` (`id_empleado`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`id_persona`);

--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `jornalero`
--
ALTER TABLE `jornalero`
  MODIFY `id_jornalero` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `persona`
--
ALTER TABLE `persona`
  MODIFY `id_persona` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `FK_persona_empleados` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id_persona`);

--
-- Filtros para la tabla `jornalero`
--
ALTER TABLE `jornalero`
  ADD CONSTRAINT `FK_empleados_jornalero` FOREIGN KEY (`id_empleado`) REFERENCES `empleado` (`id_empleado`);
COMMIT;

/*
DROP USER IF EXISTS 'admin'@'localhost';
CREATE USER 'admin'@'localhost' IDENTIFIED BY '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918';
GRANT ALL PRIVILEGES ON *.* TO 'admin'@'localhost';
DROP USER IF EXISTS 'user'@'localhost';
CREATE USER 'user'@'localhost' IDENTIFIED BY '04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb';
GRANT ALL PRIVILEGES ON *.* TO 'user'@'localhost';
DROP USER IF EXISTS 'miuser'@'localhost';
CREATE USER 'miuser'@'localhost' IDENTIFIED BY '04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb';
GRANT ALL PRIVILEGES ON *.* TO 'miuser'@'localhost';
*/

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
© 2022 GitHub, Inc.
Terms
Privacy
Security
Status
Docs
Contact GitHub
Pricing
API
Training
Blog
About
Loading complete