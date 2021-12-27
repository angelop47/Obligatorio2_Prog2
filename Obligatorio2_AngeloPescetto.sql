create database obligatorio2_AngeloPescetto;
use obligatorio2_AngeloPescetto;

create table autor(
id_autor integer primary key,
nombre_autor varchar(20),
apellido_autor varchar(20),
fechaNac_autor varchar(20),
fechaFall_autor varchar(20),
nacionalidad_autor varchar(20)
);

create table lectores(
id_lector integer primary key,
nombre_lector varchar(20),
apellido_lector varchar(20)
);

create table paises(
id_pais integer primary key,
nombre_pais varchar(20)
);

create table genero(
id_genero integer primary key,
nombre_genero varchar(20)
);

create table libros(
id_libro integer primary key,
titulo_libro varchar(20),
genero_libro varchar(20),
año_libro varchar(20),
autor_libro varchar(20),
precio_libro varchar(20),
comentario_libro varchar(20)
);

Create table ventas(
id_venta integer primary key,
fecha_venta varchar(20),
libro_venta varchar(20),
lector_venta varchar(20),
precio_venta varchar(20),
);

INSERT INTO libros (id_libro,titulo_libro,genero_libro,año_libro,autor_libro,precio_libro,comentario_libro) 
VALUES(1,'titulo1','genero1','12/12/1221','autor1','1234','comentario');
INSERT INTO libros (id_libro,titulo_libro,genero_libro,año_libro,autor_libro,precio_libro,comentario_libro) 
VALUES(2,'titulo2','genero2','12/12/1221','autor2','1234','comentario');
INSERT INTO libros (id_libro,titulo_libro,genero_libro,año_libro,autor_libro,precio_libro,comentario_libro) 
VALUES(3,'titulo3','genero3','12/12/1221','autor3','1234','comentario');
INSERT INTO libros (id_libro,titulo_libro,genero_libro,año_libro,autor_libro,precio_libro,comentario_libro) 
VALUES(4,'titulo4','genero4','12/12/1221','autor4','1234','comentario');
INSERT INTO libros (id_libro,titulo_libro,genero_libro,año_libro,autor_libro,precio_libro,comentario_libro) 
VALUES(5,'titulo5','genero5','12/12/1221','autor5','1234','comentario');

INSERT INTO paises (id_pais,nombre_pais) 
VALUES(1,'Uruguay');
INSERT INTO paises (id_pais,nombre_pais) 
VALUES(2,'Argentina');
INSERT INTO paises (id_pais,nombre_pais) 
VALUES(3,'Brasil');
INSERT INTO paises (id_pais,nombre_pais) 
VALUES(4,'Chile');

INSERT INTO genero (id_genero,nombre_genero) 
VALUES(1,'Literatura');
INSERT INTO genero (id_genero,nombre_genero) 
VALUES(2,'Historia');
INSERT INTO genero (id_genero,nombre_genero) 
VALUES(3,'Narrativo');
INSERT INTO genero (id_genero,nombre_genero) 
VALUES(4,'Cuentos');


INSERT INTO autor (id_autor,nombre_autor,apellido_autor,fechaNac_autor,FechaFall_autor,nacionalidad_autor) 
VALUES(1,'Nombre1','Apellido1','11/11/1111','11/11/1111','Uruguay');
INSERT INTO autor (id_autor,nombre_autor,apellido_autor,fechaNac_autor,FechaFall_autor,nacionalidad_autor) 
VALUES(2,'Nombre2','Apellido2','11/11/1111','11/11/1111','Argentina');
INSERT INTO autor (id_autor,nombre_autor,apellido_autor,fechaNac_autor,FechaFall_autor,nacionalidad_autor) 
VALUES(3,'Nombre3','Apellido3','11/11/1111','11/11/1111','Brasil');
INSERT INTO autor (id_autor,nombre_autor,apellido_autor,fechaNac_autor,FechaFall_autor,nacionalidad_autor) 
VALUES(4,'Nombre4','Apellido4','11/11/1111','11/11/1111','Chile');

INSERT INTO lectores (id_Lector,nombre_Lector,apellido_Lector) 
VALUES(1,'Nombre1','Apellido1');
INSERT INTO lectores (id_Lector,nombre_Lector,apellido_Lector) 
VALUES(2,'Nombre2','Apellido1');
INSERT INTO lectores (id_Lector,nombre_Lector,apellido_Lector) 
VALUES(3,'Nombre3','Apellido1');
INSERT INTO lectores (id_Lector,nombre_Lector,apellido_Lector) 
VALUES(4,'Nombre4','Apellido1');

INSERT INTO ventas (id_venta,fecha_venta,libro_venta,lector_venta,precio_venta)
VALUES(1,'11/11/1111','titulo1','nombre1','100')

select v.*
from ventas v

select l.*
from libros l