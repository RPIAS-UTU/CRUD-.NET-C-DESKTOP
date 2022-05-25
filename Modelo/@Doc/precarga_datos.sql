USE catering;

/*INSERT DE CATEGORIAS*/
INSERT INTO categorias (categoria_nombre) VALUES
("sandwiches"),
("masitas"),
("aperitivos"),
("pasteleria"),
("parrilla"),
("sopas"),
("ensaladas"),
("panaderia"),
("bebidas");

/*INSERT DE PRODUCTOS*/
INSERT INTO productos (producto_nombre,producto_precio,categoria_id) VALUES
("sandwich de jamon y queso", 20, 1),
("sandwich de verduras con pate de aceitunas", 20, 1),
("sandwich ensalada de pollo y aguacate", 18, 1),
("sandwich higos, piñones y queso muzzarella", 21, 1),
("sandwich de aguacate y quesos con bacon de pavo", 24, 1),
("sandwich de rúcula y bacon ahumado", 23, 1),
("sandwich de pera, gorgonzola y bacon", 25, 1),
("éclairs", 19, 2),
("tartles", 25, 2),
("bruscheta", 25, 2),
("canapés", 23, 3),
("devilled eggs", 15, 3),
("smoked egg", 12, 3),
("dainty biscuits", 10, 3),
("baked meringues", 12, 3),
("macarons", 25, 3),
("pastel de nata", 20, 3),
("sausage rolls", 13, 3),
("torta de la selva negra", 30, 4),
("torta de ricotta", 28, 4),
("torta libra", 32, 4),
("torta de queso", 40, 4),
("torta diablo", 35, 4),
("torta de zanahoria", 29, 4),
("chuletas de cerdo", 80, 5),
("jugosas costillas", 80, 5),
("bistec", 100, 5),
("bruschetta de pollo", 50, 5),
("hamburguesas", 30, 5),
("pollo y verduras", 70, 5),
("sopa de cebolla", 50, 6),
("sopa de albonigas", 55, 6),
("sopa de pescado", 58, 6),
("sopa de pollo", 60, 6),
("ensalada de verduras", 68, 7),
("ensalada de pollo", 60, 7),
("ensalada de pasta", 60, 7),
("ensalada de arroz", 55, 7),
("ensalada de pasta y atun", 68, 7),
("ensalada de patatas", 56, 7),
("ensalada de col", 50, 7),
("ensalada césar", 70, 7),
("pan tradicional", 40, 8),
("pan integral", 45, 8),
("pan de otros cereales", 50, 8),
("pan de semillas", 55, 8),
("pan francés", 45, 8),
("pan tostado", 35, 8),
("croissants", 15, 8),
("bagel", 18,8),
("café negro", 40, 9),
("café cortado", 50, 9),
("té negro", 50, 9),
("té verde", 55, 9),
("té de manzanilla", 45, 9),
("champagne", 1000, 9),
("sidra", 150, 9),
("whiskey", 1000, 9),
("agua mineral con gas", 30, 9),
("agua mineral sin gas", 30, 9),
("jugo de naranja", 100, 9),
("jugo de manzana", 95, 9); /*62



/*INSERT DE PAQUETES*/

INSERT INTO paquetes (paquete_nombre,paquete_precio) VALUES
("Desayuno empresarial", 2525),
("Desayuno light", 1245),
("Buffet parrilla", 6200),
("Buffet reunion", 4960),
("Merienda empresarial", 2535),
("Merienda light", 1045),
("Cena ejecutiva", 8100),
("Fiesta formal", 12440);

/*INSERT DE PRODUCTOS DE PAQUETES*/

INSERT INTO productos_paquetes (producto_id, paquete_id, producto_paquete_cantidad) VALUES
(52,1,15),/*750*/
(48,1,30),/*1050*/
(49,1,15),/*225*/
(61,1,5),/*500*/

( 55,2,15),/*675*/
( 50,2,15),/*270*/
( 2,2,15),/*300*/

( 56,3,2),/*2000*/
( 28,3,40),/*2000*/
( 26,3,20),/*1600*/
( 60,3,20),/*600*/

( 27,4,20),/*2000*/
( 60,4,20),/*600*/
( 36,4,20),/*1200*/
( 33,4,20),/*1160*/

(52 ,5,15),/*750*/
(59,5,15),/*450*/
(18 ,5,45),/*585*/
(16 ,5,30),/*750*/

( 51,6,10),/*400*/
( 3,6,10),/*180*/
( 8,6,10),/*190*/
( 46,6,5),/*275*/

( 58,7,3),/*3000*/
( 59,7,20),/*300*/
( 61,7,8),/*800*/
( 36,7,20),/*1200*/
( 27,7,20),/*2000*/
( 22,7,20),/*800*/

( 1,8,90),/*1800*/
( 26,8,30),/*2400*/
( 5,8,60),/*1440*/
( 59,8,30),/*900*/
( 56,8,5),/*5000*/
( 19,8,30);/*900*/


/*INSERT DE ROLES*/
insert into roles (rol_nombre) values
("usuario"),
("administrador");

/*INSERT DE USUARIOS*/
insert into usuarios (usuario_mail,usuario_password,usuario_nombre,usuario_apellido,usuario_telefono,usuario_activo, rol_id) values
("asd@gmail.com","017f703e717fa5c2313cb2cefd06faf8afb31a0a79f75ab3959b354aafd8732a","asd","asd","099966787",1 ,1),
("admin@gmail.com","b227bff0d28823d4599a39a5b55725b0811c9c13184087e9a122eb572e6ff139","admin","admin","099684805",1 ,2),
("juan@gmail.com","d03000c97fab78deb7a0e9ed0b51c7a4ce4f6f22e9b9ff7fe5fd0adcd7fbb73b","Juan","Gonzalez","099966787",1 ,1),
("maria@gmail.com","04d8bd13b8fb608c28d35232ac522c6b266c5ff90a7bdbe09500619e88f1b8b8","Maria","Dominguez","095280798",1 ,1),
("alberto@gmail.com","2dc2e09b7a779c00b491f7c1ac1a937d198b7b7a57eabef3f908fed05d1cecd1","Alberto","Perez","094262958",1 ,1),
("dalmiro@gmail.com","70fc72d39123dd09f7871e516937f8d14410261fbe40218c15c1419fa18b1860","Dalmiro","Macias","099275161",1 ,1),
("aniela@gmail.com","a535e31180a7f9cc0e8ae464a13f1e249d08298b26c2df07beb5309bc0fcc750","Aniela","Armas","093611451",1 ,1),
("felipe@gmail.com","69dd14ddcc09c43f61b3ad8e6ea18e681e6beb5ad55f732f2ac2c96009ab832a","Felipe","Lorente","091879511",1 ,1),
("olga@gmail.com","d1af6bf5090f1b644ad9bf07f44e20b2d86b50a92568f5189515eb4a4f88008d","Olga","Gisbert","096869966",1 ,1),
("richard@gmail.com","d1cadc3eaa4c06449253291ed45c63ce2a551422ea6118fd0b61b518a0eb6c16","Richard","Perelo","094107634",1 ,1),
("mariana@gmail.com","bbaca45a758152141ea0cdcc8ae43fb298aa5225764a29260803b88976f438a6","Mariana","Escobar","091955696",1 ,1);

/*INSERT DE DIRECCIONES*/

INSERT INTO direcciones (direccion_descripcion,usuario_id) VALUES
("Acevedo Díaz 1145",1),
("Colonia 1455",3 ),
("Av. 18 de Julio 1677",4 ),
("Francisco Canaro 134",5 ),
("Palmar 335",6 ),
("Paysandú 567",7 ),
("Av. Uruguay 1223",8 ),
("Guayabos 780",9 ),
("José Enrique Rodó 1357",10 ),
("Soriano 1422",11);

/*INSERT DE METODOS DE PAGO*/

INSERT INTO metodosPago (medotoPago_nombre) VALUES
("Credito"),
("Debito"),
("Efectivo");

/*INSERT DE CARRITOS*/

INSERT INTO carritos (usuario_id) VALUES
(1),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10),
(11);

/*INSERT DE PAQUETES EN LOS CARRITOS*/

INSERT INTO paquetes_carritos (paquete_id,carrito_id,paquete_carrito_cantidad) VALUES
(1 ,1,2),
(5 ,1,1),
( 3,2,1),
( 5,4,2),
(1 ,6,1),
(6 ,6,1),
(8 ,7,1),
(2 ,7,1),
( 7,9,1),
( 4,9,1),
(5,10,1);

/* INSERT DE PEDIDOS*/

INSERT INTO pedidos  (usuario_id,pedido_creacion,pedido_entrega,pedido_precio,pedido_estado,metodoPago_id) VALUES

(4,"2022-02-01 12:05:00","2022-02-02 11:00:23",6200,"entregado",1),
(6,"2022-03-20 15:10:00","2022-03-22 08:10:47",1245,"entregado",2),
(8,"2022-04-12 09:36:00","2022-04-15 07:32:54",2525,"entregado",3);



/*INSERT DE LAS LINEAS DE LOS PEDIDOS*/

INSERT INTO pedidos_paquetes (pedido_id,paquete_id) VALUES
(1 , 3),
(2 , 2),
(3 , 1);




