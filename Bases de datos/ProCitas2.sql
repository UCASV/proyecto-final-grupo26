DROP DATABASE ProCitas;
CREATE DATABASE ProCitas;
USE ProCitas;
SET LANGUAGE us_english;

--Tablas
CREATE TABLE CIUDADANO(
	id INT PRIMARY KEY NOT NULL,
	dui VARCHAR(12) NOT NULL,
	nombre varchar(60) NOT NULL,
	telefono VARCHAR(8) NOT NULL,
	correo VARCHAR(35) NOT NULL,
	hora_fila_espera TIME,
	fecha_fila_espera DATE,
	id_empleado INT NOT NULL,
	id_cabina INT NOT NULL,
	id_institucion INT NOT NULL,
	id_direccion INT NOT NULL,
	id_info_vacunacion INT,
	id_efectos_secundarios INT,
	id_enfermedades INT
);

CREATE TABLE INFO_VACUNACION(
	id INT PRIMARY KEY,
	fecha_cita1 DATE,
	hora_cita1 TIME,
	lugar_vacunacion VARCHAR(40),
	fecha_cita2 DATE,
	hora_cita2 TIME
);

CREATE TABLE EFECTOS_SECUNDARIOS(
	id INT PRIMARY KEY,
	descripcion_efecto VARCHAR(80),
	hora_efecto TIME,
	fecha_efecto DATE,
);

CREATE TABLE DIRECCION(
	id INT PRIMARY KEY NOT NULL,
	departamento VARCHAR(50) NOT NULL,
	calle VARCHAR(50) NOT NULL,
	municipio VARCHAR(50) NOT NULL,
);

CREATE TABLE EMPLEADO(
	id INT PRIMARY KEY NOT NULL,
	nombre VARCHAR(60) NOT NULL,
	correo VARCHAR(35) NOT NULL,
	usuario VARCHAR(12),
	contraseña VARCHAR(8), 
	id_registro INT,
	id_direccion INT NOT NULL,
	id_tipo_empleado INT
);

CREATE TABLE REGISTRO(
	id INT PRIMARY KEY,
	fecha DATE,
	hora TIME
);

CREATE TABLE CABINA(
	id INT PRIMARY KEY NOT NULL,
	telefono VARCHAR(8) NOT NULL,
	correo VARCHAR(35) NOT NULL,
	id_direccion INT NOT NULL
);

CREATE TABLE TIPO_EMPLEADO(
	id INT PRIMARY KEY NOT NULL,
	tipo_empleado VARCHAR(15) NOT NULL
);

CREATE TABLE EMPLEADOXCABINA(
	id_empleado INT NOT NULL,
	id_cabina INT NOT NULL,
);

CREATE TABLE ENFERMEDADES(
	id INT PRIMARY KEY NOT NULL,
	enfermedades VARCHAR(80) NOT NULL
);

CREATE TABLE INSTITUCION(
	id INT PRIMARY KEY NOT NULL,
	numero_identidicador VARCHAR(8) NOT NULL,
	nombre VARCHAR(80) NOT NULL
);

--PK Y FK------------------
--CIUDADANO
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_empleado) REFERENCES EMPLEADO(id);
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_cabina) REFERENCES CABINA(id);
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_institucion) REFERENCES INSTITUCION(id);
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_direccion) REFERENCES DIRECCION(id);
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_info_vacunacion) REFERENCES INFO_VACUNACION(id);
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_efectos_secundarios) REFERENCES EFECTOS_SECUNDARIOS(id);
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_enfermedades) REFERENCES ENFERMEDADES(id);
--EMPLEADO
ALTER TABLE EMPLEADO ADD FOREIGN KEY (id_registro) REFERENCES REGISTRO(id);
ALTER TABLE EMPLEADO ADD FOREIGN KEY (id_direccion) REFERENCES DIRECCION(id);
ALTER TABLE EMPLEADO ADD FOREIGN KEY (id_tipo_empleado) REFERENCES TIPO_EMPLEADO(id);
--EMPLEADOXCABINA
ALTER TABLE EMPLEADOXCABINA ADD PRIMARY KEY (id_empleado, id_cabina);
ALTER TABLE EMPLEADOXCABINA ADD FOREIGN KEY (id_empleado) REFERENCES EMPLEADO(id);
ALTER TABLE EMPLEADOXCABINA ADD FOREIGN KEY (id_cabina) REFERENCES CABINA(id);
--CABINA
ALTER TABLE CABINA ADD FOREIGN KEY (id_direccion) REFERENCES DIRECCION(id);

--Banco de datos DIRECCION
INSERT INTO DIRECCION VALUES('1','San Salvador','25 calle Poniente','San Salvador');
INSERT INTO DIRECCION VALUES('2','San Salvador','Boulevard Manuel Enrique Araujo','San Salvador');
INSERT INTO DIRECCION VALUES('3','San Salvador','Autopista Comalapa','San Salvador');
INSERT INTO DIRECCION VALUES('4','San Salvador','Boulevard Monseñor Romero','San Salvador');
INSERT INTO DIRECCION VALUES('5','Ahuachapan','3a Avenida Sur','Apaneca');
INSERT INTO DIRECCION VALUES('6','Ahuachapan','9a Calle Poniente','Ataco');
INSERT INTO DIRECCION VALUES('7','Ahuachapan','1a Avenida Sur','Jujutla');
INSERT INTO DIRECCION VALUES('8','Ahuachapan','Calle Gerardo Barrios','Apaneca');
INSERT INTO DIRECCION VALUES('9','La Paz','3a Calle','Zacatecoluca');
INSERT INTO DIRECCION VALUES('10','La Paz','2a Calle Poniente','Olocuilta');
INSERT INTO DIRECCION VALUES('11','La Paz','Ctra. Panamericana','San Luis Talpa');
INSERT INTO DIRECCION VALUES('12','La Paz','2a Calle Poniente','Zacatecoluca');
INSERT INTO DIRECCION VALUES('13','Morazan','5a Calle','Cacaopera');
INSERT INTO DIRECCION VALUES('14','Morazan','2a Calle','Cacaopera');
INSERT INTO DIRECCION VALUES('15','Morazan','2 Avenida Norte','Cacaopera');
INSERT INTO DIRECCION VALUES('16','Morazan','2a Calle','Cacaopera');
INSERT INTO DIRECCION VALUES('17','Sonsonate','Calle San Antonio','Juayua');
INSERT INTO DIRECCION VALUES('18','Sonsonate','SON 19','Acajutla');
INSERT INTO DIRECCION VALUES('19','Sonsonate','Boulevard Las Palmeras','Juayua');
INSERT INTO DIRECCION VALUES('20','Sonsonate','Ruta de las flores','Juayua');
INSERT INTO DIRECCION VALUES('21','Santa Ana','25 calle Poniente','Chalchuapa');
INSERT INTO DIRECCION VALUES('22','Santa Ana','1a Avenida Sur','Coatepeque');
INSERT INTO DIRECCION VALUES('23','Santa Ana','3a Avenida Sur','Metapan');
INSERT INTO DIRECCION VALUES('24','Santa Ana','1a Avenida Sur','Chalcuapa');
INSERT INTO DIRECCION VALUES('25','Usulutan','Avenida Guandique','Jucuapa');
INSERT INTO DIRECCION VALUES('26','Usulutan','Avenida Guandique','Jucuapa');
INSERT INTO DIRECCION VALUES('27','Usulutan','5 Avenida Sur','Usulutan');
INSERT INTO DIRECCION VALUES('28','Usulutan','3 Avenida Norte','Usulutan');
INSERT INTO DIRECCION VALUES('29','San Miguel','3a Avenida Sur','Lolotique');
INSERT INTO DIRECCION VALUES('30','San Miguel','1a Avenida Sur','Lolotique');
INSERT INTO DIRECCION VALUES('31','San Miguel','Calle San Pablo','Comacaran');
INSERT INTO DIRECCION VALUES('32','San Miguel','1a Avenida Sur','Moncagua');
INSERT INTO DIRECCION VALUES('33','Cabañas','Calle Ireneo Chacon','Ilobasco');
INSERT INTO DIRECCION VALUES('34','Cabañas','Carretera a Ilobasco','Dolores');
INSERT INTO DIRECCION VALUES('35','Cabañas','7a Calle','San Isidro');
INSERT INTO DIRECCION VALUES('36','Cabañas','5a Calle','Jutiapa');
INSERT INTO DIRECCION VALUES('37','Chalatenango','25 calle Poniente','Chalatenango');
INSERT INTO DIRECCION VALUES('38','Chalatenango','5a Calle','Comapala');
INSERT INTO DIRECCION VALUES('39','Chalatenango','5a Calle','Comapala');
INSERT INTO DIRECCION VALUES('40','Chalatenango','2 Avenida Norte','Chalatenango');
INSERT INTO DIRECCION VALUES('41','San Vicente','3a Avenida Sur','Apastepeque');
INSERT INTO DIRECCION VALUES('42','San Vicente','3a Avenida Sur','Apastepeque');
INSERT INTO DIRECCION VALUES('43','San Vicente','3a Avenida Sur','Apastepeque');
INSERT INTO DIRECCION VALUES('44','San Vicente','1a Avenida Sur','Apastepeque');
INSERT INTO DIRECCION VALUES('45','La Union','5a Calle','Bolivar');
INSERT INTO DIRECCION VALUES('46','La Union','3a Avenida Sur','El Carmen');
INSERT INTO DIRECCION VALUES('47','La Union','1a Avenida Sur','Intipuca');
INSERT INTO DIRECCION VALUES('48','La Union','5a Calle','Bolivar');
INSERT INTO DIRECCION VALUES('49','La libertad','1a Avenida Sur','Antiguo Cuscatlan');
INSERT INTO DIRECCION VALUES('50','La libertad','2a Avenida Norte','Santa Tecla');
INSERT INTO DIRECCION VALUES('51','La libertad','3a Avenida Sur','Antiguo Cuscatlan');
INSERT INTO DIRECCION VALUES('52','La libertad','25 calle Poniente','Santa Tecla');
INSERT INTO DIRECCION VALUES('53','Cuscatlan','3 Avenida Sur','Suchitoto');
INSERT INTO DIRECCION VALUES('54','Cuscatlan','3 Avenida Norte','Suchitoto');
INSERT INTO DIRECCION VALUES('55','Cuscatlan','3 Avenida Norte','Suchitoto');
INSERT INTO DIRECCION VALUES('56','Cuscatlan','3 Avenida Norte','Suchitoto');

--Banco de datos TIPO_EMPLEADO
INSERT INTO TIPO_EMPLEADO VALUES('1','Encargado');
INSERT INTO TIPO_EMPLEADO VALUES('2','Gestor');

--Banco de datos ENFERMEDADES
INSERT INTO ENFERMEDADES VALUES('1','Cáncer');
INSERT INTO ENFERMEDADES VALUES('2','Diabetes');
INSERT INTO ENFERMEDADES VALUES('3','Artritis');
INSERT INTO ENFERMEDADES VALUES('4','Asma');

--Banco de datos INSTITUCION
INSERT INTO INSTITUCION VALUES('1','ED655741','educacion');
INSERT INTO INSTITUCION VALUES('2','S1662546','salud');
INSERT INTO INSTITUCION VALUES('3','PNC19147','policia nacional civil');
INSERT INTO INSTITUCION VALUES('4','G5596854','gobierno');
INSERT INTO INSTITUCION VALUES('5','FA331248','fuerza armada');
INSERT INTO INSTITUCION VALUES('6','P2461057','periodismo');
INSERT INTO INSTITUCION VALUES('7','T0587316','turismo');
INSERT INTO INSTITUCION VALUES('8','A8054935','agricultura');
INSERT INTO INSTITUCION VALUES('9','OP962404','obras publicas');
INSERT INTO INSTITUCION VALUES('10','E9957801','economia');

--Banco de datos CABINA
INSERT INTO CABINA VALUES('1','79968165','cabinasansalvador@gob.sv','4');
INSERT INTO CABINA VALUES('2','76839474','cabinaahuachapan@gob.sv','16');
INSERT INTO CABINA VALUES('3','75932558','cabinalalibertad@gob.sv','8');
INSERT INTO CABINA VALUES('4','79758486','cabinasantaana@gob.sv','40');
INSERT INTO CABINA VALUES('5','72983505','cabinasonsonate@gob.sv','12');
INSERT INTO CABINA VALUES('6','72835384','cabinausulutan@gob.sv','32');
INSERT INTO CABINA VALUES('7','74713990','cabinasanmiguel@gob.sv','52');
INSERT INTO CABINA VALUES('8','71199480','cabinalaunion@gob.sv','43');
INSERT INTO CABINA VALUES('9','73420371','cabinamorazan@gob.sv','28');
INSERT INTO CABINA VALUES('10','73420371','cabinachalatenango@gob.sv','24');
INSERT INTO CABINA VALUES('11','78526526','cabinacabañas@gob.sv','36');
INSERT INTO CABINA VALUES('12','79968165','cabinacuscatlan@gob.sv','56');
INSERT INTO CABINA VALUES('13','76839474','cabinalapaz@gob.sv','20');
INSERT INTO CABINA VALUES('14','75932558','cabinasanvicente@gob.sv','48');

--Banco de datos EMPLEADO
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('1','Eleuterio Carrero','eleuterio@gmail.com','Carrero','123410','6','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('2','Toni Costa','toni@gmail.com','Costa','toni503','18','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('3','Yeray Candela','yeray@gmail.com','Candela','77664422','22','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('4','Florin Martínez','florin@gmail.com','Martínez','987654','34','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('5','Teresa Peral','teresa@gmail.com','Peral','tErEsA','46','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('6','Elisa Peiro','elisia@gmail.com','Peiro','000000','26','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('7','Sofia Olmedo','sofia@gmail.com','Olmedo','sofiO','50','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('8','Casilda Valera','casilda@gmail.com','Valera','casiLda','38','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('9','Nina Huertas','nina@gmail.com','Huertas','nina5264','54','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('10','Jeronima Castellanos','jeronima@gmail.com','Castellanos','JeCast','41','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('11','Emilio Rios','emilio@gmail.com','Rios','emiliori','30','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('12','Ernesto Juarez','ernesto@gmail.com','Juarez','ejuarez1','2','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('13','Diana Ayuso','diana@gmail.com','Ayuso','dianalmb','10','2');
INSERT INTO EMPLEADO(id,nombre,correo,usuario,contraseña,id_direccion,id_tipo_empleado) VALUES('14','Yassine Ruz','yassine@gmail.com','Ruz','yassiner','14','2');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('15','Marwa Cebrian','marwa@gmail.com','3','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('16','Imane Manso','imane@gmail.com','7','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('17','Francesc Bermejo','francesc@gmail.com','11','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('18','Marius Alarcon','marius@gmail.com','15','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('19','Ceferino de Haro','ceferino@gmail.com','19','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('20','Luis Torres','luis@gmail.com','23','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('21','Gael García','gael@gmail.com','27','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('22','Bibiana Romera','bibiana@gmail.com','31','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('23','Martin Villaverde','martin@gmail.com','35','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('24','Mayra Arias','mayra@gmail.com','39','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('25','Nicoleta Vergara','nicoleta@gmail.com','42','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('26','Michelle Contreras','michelle@gmail.com','46','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('27','Zohra Baez','zohra@gmail.com','50','1');
INSERT INTO EMPLEADO(id,nombre,correo,id_direccion,id_tipo_empleado) VALUES('28','Angeles Orellana','angeles@gmail.com','54','1');

--Banco de datos CIUDADANO
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('1','065791834','Julie Fleming','79968165','julie@gmail.com','5','1','2','1');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('2','054782115','Avye Wiley','76839474','avye@gmail.com','1','3','7','5');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('3','092155486','Regan Greene','75932558','regan@gmail.com','7','5','4','9');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion,id_enfermedades) VALUES('4','032559722','Karly Charles','79758486','karly@gmail.com','10','2','7','13','1');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('5','014789254','Melodie George','72983505','melodie@gmail.com','2','13','5','17');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion,id_enfermedades) VALUES('6','032668951','Dai Oneill','72835384','dai@gmail.com','3','10','8','21','2');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('7','025896307','Mari Cross','74713990','mari@gmail.com','9','9','3','25');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion,id_enfermedades) VALUES('8','012865909','TaShya Simpson','71199480','tashya@gmail.com','4','6','10','29','4');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('9','032598755','Sonia Woodward','77427371','sonia@gmail.com','6','11','4','33');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('10','032569877','Vania Benitez','73420371','vania@gmail.com','12','4','7','37');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion,id_enfermedades) VALUES('11','054896227','Rodrigo Carrero','78526526','rodrigo@gmail.com','14','8','1','41','2');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('12','014865993','Carlos Estevez','71968865','carlos@gmail.com','8','14','6','45');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion) VALUES('13','025874889','Jason Cruz','76259774','jason@gmail.com','11','7','9','49');
INSERT INTO CIUDADANO(id,dui,nombre,telefono,correo,id_empleado,id_cabina,id_institucion,id_direccion,id_enfermedades) VALUES('14','032589655','Alessandro Pineda','71335758','alessandro@gmail.com','13','12','5','53','3');





