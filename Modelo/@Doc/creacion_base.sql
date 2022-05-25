/*
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
Borra la base si existe y vuelve a crearla nuevamente vacia
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
*/
DROP DATABASE IF EXISTS catering;
CREATE DATABASE catering;
USE catering;

CREATE TABLE roles(
rol_id INT PRIMARY KEY AUTO_INCREMENT,
rol_nombre VARCHAR(50)
);

/*
- - - - - - - - - - - - - -
	CREACION DE TABLAS
- - - - - - - - - - - - - -
*/

CREATE TABLE usuarios(
usuario_id INT PRIMARY KEY AUTO_INCREMENT,
usuario_mail VARCHAR(150) NOT NULL UNIQUE,
usuario_password VARCHAR(150) NOT NULL,
usuario_nombre VARCHAR(150),
usuario_apellido VARCHAR(150),
usuario_telefono VARCHAR(50),
usuario_activo BIT(1),
rol_id INT,
FOREIGN KEY (rol_id) REFERENCES roles(rol_id)
);

CREATE TABLE direcciones(
direccion_id INT PRIMARY KEY AUTO_INCREMENT,
direccion_descripcion VARCHAR(250),
usuario_id INT,
FOREIGN KEY (usuario_id) REFERENCES usuarios(usuario_id)
);

CREATE TABLE carritos(
carrito_id INT PRIMARY KEY AUTO_INCREMENT,
usuario_id INT,
FOREIGN KEY (usuario_id) REFERENCES usuarios(usuario_id)
);

CREATE TABLE metodosPago(
metodoPago_id INT PRIMARY KEY AUTO_INCREMENT,
medotoPago_nombre VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE pedidos(
pedido_id INT PRIMARY KEY AUTO_INCREMENT,
usuario_id INT,
FOREIGN KEY (usuario_id) REFERENCES usuarios(usuario_id),
pedido_creacion DATETIME NOT NULL,
pedido_entrega DATETIME NOT NULL,
pedido_precio DECIMAL(10,2) NOT NULL,
pedido_estado VARCHAR(50) NOT NULL,
metodoPago_id INT,
FOREIGN KEY (metodoPago_id) REFERENCES metodosPago(metodoPago_id)
);

CREATE TABLE paquetes(
paquete_id INT PRIMARY KEY AUTO_INCREMENT,
paquete_nombre VARCHAR(150) NOT NULL UNIQUE,
paquete_precio DECIMAL(10,2) NOT NULL
);

CREATE TABLE paquetes_carritos(
paquete_id INT,
FOREIGN KEY (paquete_id) REFERENCES paquetes(paquete_id),
carrito_id INT,
FOREIGN KEY (carrito_id) REFERENCES carritos(carrito_id),
PRIMARY KEY(paquete_id, carrito_id),
paquete_carrito_cantidad INT
);

CREATE TABLE pedidos_paquetes(
pedido_id INT,
FOREIGN KEY (pedido_id) REFERENCES pedidos(pedido_id),
paquete_id INT,
FOREIGN KEY (paquete_id) REFERENCES paquetes(paquete_id),
PRIMARY KEY(pedido_id, paquete_id)
);

CREATE TABLE categorias(
categoria_id INT PRIMARY KEY AUTO_INCREMENT,
categoria_nombre VARCHAR(50) NOT NULL
);

CREATE TABLE productos(
producto_id INT PRIMARY KEY AUTO_INCREMENT,
producto_nombre VARCHAR(150) NOT NULL,
producto_precio DECIMAL(10,2) NOT NULL,
producto_imagen VARCHAR(250),
categoria_id INT,
FOREIGN KEY (categoria_id) REFERENCES categorias(categoria_id)
);

CREATE TABLE productos_paquetes(
producto_id INT,
FOREIGN KEY (producto_id) REFERENCES productos(producto_id),
paquete_id INT,
FOREIGN KEY (paquete_id) REFERENCES paquetes(paquete_id),
PRIMARY KEY(producto_id, paquete_id),
producto_paquete_cantidad INT NOT NULL
);