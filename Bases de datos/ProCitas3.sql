DROP DATABASE ProCitas;
CREATE DATABASE ProCitas;
USE ProCitas;
SET LANGUAGE us_english;

--Tablas
CREATE TABLE CITIZEN(
	dui VARCHAR(12) NOT NULL,
	nameCITIZEN varchar(60) NOT NULL,
	phone VARCHAR(8) NOT NULL,
	mail VARCHAR(35) NULL,
	time_effect TIME NULL,
	date_effect DATE NULL,
	time_wline TIME,
	date_wline DATE,
	id_employee INT NOT NULL,
	id_cabin INT NOT NULL,
	id_institution INT NULL,
	id_direction INT NOT NULL,
	id_info_vaccination INT,
	id_side_effects INT,
	id_diseases INT NULL
);

CREATE TABLE INFO_VACCINATION(
	id INT IDENTITY PRIMARY KEY,
	date_appointment1 DATE,
	time_appointment1 TIME,
	vaccination_place VARCHAR(40),
	date_appointment2 DATE,
	time_appointment2 TIME
);

CREATE TABLE SIDE_EFFECTS(
	id INT PRIMARY KEY,
	side_effects VARCHAR(60),
);

CREATE TABLE DIRECTION(
	id INT PRIMARY KEY NOT NULL,
	department VARCHAR(50) NOT NULL,
	street VARCHAR(50) NOT NULL,
	municipality VARCHAR(50) NOT NULL,
);

CREATE TABLE EMPLOYEE(
	id INT PRIMARY KEY NOT NULL,
	nameEMPLOYEE VARCHAR(60) NOT NULL,
	mail VARCHAR(35) NOT NULL,
	user_g VARCHAR(12),
	passwordd VARCHAR(8), 
	id_record INT,
	id_direction INT NOT NULL,
	id_type_employee INT
);

CREATE TABLE RECORD(
	id INT PRIMARY KEY,
	dateR DATE,
	timeR TIME
);

CREATE TABLE CABIN(
	id INT PRIMARY KEY NOT NULL,
	phone VARCHAR(8) NOT NULL,
	mail VARCHAR(35) NOT NULL,
	id_direction INT NOT NULL
);

CREATE TABLE TYPE_EMPLOYEE(
	id INT PRIMARY KEY NOT NULL,
	type_employee VARCHAR(15) NOT NULL
);

CREATE TABLE EMPLOYEEXCABIN(
	id_employee INT NOT NULL,
	id_cabin INT NOT NULL,
);

CREATE TABLE  DISEASES(
	id INT PRIMARY KEY NOT NULL,
	diseases VARCHAR(80) NOT NULL
);

CREATE TABLE INSTITUTION(
	id INT PRIMARY KEY NOT NULL,
	identifier_number VARCHAR(8) NOT NULL,
	nameINSTITUTION VARCHAR(80) NOT NULL
);

--PK Y FK------------------
--CITIZEN
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_employee) REFERENCES EMPLOYEE(id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_cabin) REFERENCES CABIN(id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_institution) REFERENCES INSTITUTION(id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_direction) REFERENCES DIRECTION(id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_info_vaccination) REFERENCES info_vaccination(id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_side_effects) REFERENCES SIDE_EFFECTS(id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_diseases) REFERENCES DISEASES(id);
--EMPLOYEE
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_record) REFERENCES RECORD(id);
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_direction) REFERENCES DIRECTION(id);
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_type_employee) REFERENCES TYPE_EMPLOYEE(id);
--EMPLOYEEXCABIN
ALTER TABLE EMPLOYEEXCABIN ADD PRIMARY KEY (id_employee, id_cabin);
ALTER TABLE EMPLOYEEXCABIN ADD FOREIGN KEY (id_employee) REFERENCES EMPLOYEE(id);
ALTER TABLE EMPLOYEEXCABIN ADD FOREIGN KEY (id_cabin) REFERENCES CABIN(id);
--CABIN
ALTER TABLE CABIN ADD FOREIGN KEY (id_direction) REFERENCES DIRECTION(id);

--Banco de datos DIRECTION
INSERT INTO DIRECTION VALUES('1','San Salvador','25 street Poniente','San Salvador');
INSERT INTO DIRECTION VALUES('2','San Salvador','Boulevard Manuel Enrique Araujo','San Salvador');
INSERT INTO DIRECTION VALUES('3','San Salvador','Autopista Comalapa','San Salvador');
INSERT INTO DIRECTION VALUES('4','San Salvador','Boulevard Monseñor Romero','San Salvador');
INSERT INTO DIRECTION VALUES('5','Ahuachapan','3a Avenida Sur','Apaneca');
INSERT INTO DIRECTION VALUES('6','Ahuachapan','9a Calle Poniente','Ataco');
INSERT INTO DIRECTION VALUES('7','Ahuachapan','1a Avenida Sur','Jujutla');
INSERT INTO DIRECTION VALUES('8','Ahuachapan','Calle Gerardo Barrios','Apaneca');
INSERT INTO DIRECTION VALUES('9','La Paz','3a Calle','Zacatecoluca');
INSERT INTO DIRECTION VALUES('10','La Paz','2a Calle Poniente','Olocuilta');
INSERT INTO DIRECTION VALUES('11','La Paz','Ctra. Panamericana','San Luis Talpa');
INSERT INTO DIRECTION VALUES('12','La Paz','2a Calle Poniente','Zacatecoluca');
INSERT INTO DIRECTION VALUES('13','Morazan','5a Calle','Cacaopera');
INSERT INTO DIRECTION VALUES('14','Morazan','2a Calle','Cacaopera');
INSERT INTO DIRECTION VALUES('15','Morazan','2 Avenida Norte','Cacaopera');
INSERT INTO DIRECTION VALUES('16','Morazan','2a Calle','Cacaopera');
INSERT INTO DIRECTION VALUES('17','Sonsonate','Calle San Antonio','Juayua');
INSERT INTO DIRECTION VALUES('18','Sonsonate','SON 19','Acajutla');
INSERT INTO DIRECTION VALUES('19','Sonsonate','Boulevard Las Palmeras','Juayua');
INSERT INTO DIRECTION VALUES('20','Sonsonate','Ruta de las flores','Juayua');
INSERT INTO DIRECTION VALUES('21','Santa Ana','25 street Poniente','Chalchuapa');
INSERT INTO DIRECTION VALUES('22','Santa Ana','1a Avenida Sur','Coatepeque');
INSERT INTO DIRECTION VALUES('23','Santa Ana','3a Avenida Sur','Metapan');
INSERT INTO DIRECTION VALUES('24','Santa Ana','1a Avenida Sur','Chalcuapa');
INSERT INTO DIRECTION VALUES('25','Usulutan','Avenida Guandique','Jucuapa');
INSERT INTO DIRECTION VALUES('26','Usulutan','Avenida Guandique','Jucuapa');
INSERT INTO DIRECTION VALUES('27','Usulutan','5 Avenida Sur','Usulutan');
INSERT INTO DIRECTION VALUES('28','Usulutan','3 Avenida Norte','Usulutan');
INSERT INTO DIRECTION VALUES('29','San Miguel','3a Avenida Sur','Lolotique');
INSERT INTO DIRECTION VALUES('30','San Miguel','1a Avenida Sur','Lolotique');
INSERT INTO DIRECTION VALUES('31','San Miguel','Calle San Pablo','Comacaran');
INSERT INTO DIRECTION VALUES('32','San Miguel','1a Avenida Sur','Moncagua');
INSERT INTO DIRECTION VALUES('33','Cabañas','Calle Ireneo Chacon','Ilobasco');
INSERT INTO DIRECTION VALUES('34','Cabañas','Carretera a Ilobasco','Dolores');
INSERT INTO DIRECTION VALUES('35','Cabañas','7a Calle','San Isidro');
INSERT INTO DIRECTION VALUES('36','Cabañas','5a Calle','Jutiapa');
INSERT INTO DIRECTION VALUES('37','Chalatenango','25 street Poniente','Chalatenango');
INSERT INTO DIRECTION VALUES('38','Chalatenango','5a Calle','Comapala');
INSERT INTO DIRECTION VALUES('39','Chalatenango','5a Calle','Comapala');
INSERT INTO DIRECTION VALUES('40','Chalatenango','2 Avenida Norte','Chalatenango');
INSERT INTO DIRECTION VALUES('41','San Vicente','3a Avenida Sur','Apastepeque');
INSERT INTO DIRECTION VALUES('42','San Vicente','3a Avenida Sur','Apastepeque');
INSERT INTO DIRECTION VALUES('43','San Vicente','3a Avenida Sur','Apastepeque');
INSERT INTO DIRECTION VALUES('44','San Vicente','1a Avenida Sur','Apastepeque');
INSERT INTO DIRECTION VALUES('45','La Union','5a Calle','Bolivar');
INSERT INTO DIRECTION VALUES('46','La Union','3a Avenida Sur','El Carmen');
INSERT INTO DIRECTION VALUES('47','La Union','1a Avenida Sur','Intipuca');
INSERT INTO DIRECTION VALUES('48','La Union','5a Calle','Bolivar');
INSERT INTO DIRECTION VALUES('49','La libertad','1a Avenida Sur','Antiguo Cuscatlan');
INSERT INTO DIRECTION VALUES('50','La libertad','2a Avenida Norte','Santa Tecla');
INSERT INTO DIRECTION VALUES('51','La libertad','3a Avenida Sur','Antiguo Cuscatlan');
INSERT INTO DIRECTION VALUES('52','La libertad','25 street Poniente','Santa Tecla');
INSERT INTO DIRECTION VALUES('53','Cuscatlan','3 Avenida Sur','Suchitoto');
INSERT INTO DIRECTION VALUES('54','Cuscatlan','3 Avenida Norte','Suchitoto');
INSERT INTO DIRECTION VALUES('55','Cuscatlan','3 Avenida Norte','Suchitoto');
INSERT INTO DIRECTION VALUES('56','Cuscatlan','3 Avenida Norte','Suchitoto');

--Banco de datos TYPE_EMPLOYEE
INSERT INTO TYPE_EMPLOYEE VALUES('1','Encargado');
INSERT INTO TYPE_EMPLOYEE VALUES('2','Gestor');

--Banco de datos DISEASES
INSERT INTO DISEASES VALUES('1','Cáncer');
INSERT INTO DISEASES VALUES('2','Diabetes');
INSERT INTO DISEASES VALUES('3','Artritis');
INSERT INTO DISEASES VALUES('4','Asma');

--Banco de datos de SIDE_EFFECTS
INSERT INTO SIDE_EFFECTS VALUES('1','Dolor y/o sensibilidad en el sitio de la inyección');
INSERT INTO SIDE_EFFECTS VALUES('2','Enrojecimiento en el sitio de la inyección');
INSERT INTO SIDE_EFFECTS VALUES('3','Fatiga');
INSERT INTO SIDE_EFFECTS VALUES('4','Dolor de cabeza');
INSERT INTO SIDE_EFFECTS VALUES('5','Fiebre');
INSERT INTO SIDE_EFFECTS VALUES('6','Mialgia');
INSERT INTO SIDE_EFFECTS VALUES('7','Artralgia');
INSERT INTO SIDE_EFFECTS VALUES('8','Anafilaxia');

--Banco de datos INSTITUTION
INSERT INTO INSTITUTION VALUES('1','ED655741','educacion');
INSERT INTO INSTITUTION VALUES('2','S1662546','salud');
INSERT INTO INSTITUTION VALUES('3','PNC19147','policia nacional civil');
INSERT INTO INSTITUTION VALUES('4','G5596854','gobierno');
INSERT INTO INSTITUTION VALUES('5','FA331248','fuerza armada');
INSERT INTO INSTITUTION VALUES('6','P2461057','periodismo');
INSERT INTO INSTITUTION VALUES('7','T0587316','turismo');
INSERT INTO INSTITUTION VALUES('8','A8054935','agricultura');
INSERT INTO INSTITUTION VALUES('9','OP962404','obras publicas');
INSERT INTO INSTITUTION VALUES('10','E9957801','economia');

--Banco de datos CABIN
INSERT INTO CABIN VALUES('1','79968165','cabinasansalvador@gob.sv','4');
INSERT INTO CABIN VALUES('2','76839474','cabinaahuachapan@gob.sv','16');
INSERT INTO CABIN VALUES('3','75932558','cabinalalibertad@gob.sv','8');
INSERT INTO CABIN VALUES('4','79758486','cabinasantaana@gob.sv','40');
INSERT INTO CABIN VALUES('5','72983505','cabinasonsonate@gob.sv','12');
INSERT INTO CABIN VALUES('6','72835384','cabinausulutan@gob.sv','32');
INSERT INTO CABIN VALUES('7','74713990','cabinasanmiguel@gob.sv','52');
INSERT INTO CABIN VALUES('8','71199480','cabinalaunion@gob.sv','43');
INSERT INTO CABIN VALUES('9','73420371','cabinamorazan@gob.sv','28');
INSERT INTO CABIN VALUES('10','73420371','cabinachalatenango@gob.sv','24');
INSERT INTO CABIN VALUES('11','78526526','cabinacabañas@gob.sv','36');
INSERT INTO CABIN VALUES('12','79968165','cabinacuscatlan@gob.sv','56');
INSERT INTO CABIN VALUES('13','76839474','cabinalapaz@gob.sv','20');
INSERT INTO CABIN VALUES('14','75932558','cabinasanvicente@gob.sv','48');

--Banco de datos EMPLOYEE
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('1','Eleuterio Carrero','eleuterio@gmail.com','Carrero','123410','6','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('2','Toni Costa','toni@gmail.com','Costa','toni503','18','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('3','Yeray Candela','yeray@gmail.com','Candela','77664422','22','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('4','Florin Martínez','florin@gmail.com','Martínez','987654','34','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('5','Teresa Peral','teresa@gmail.com','Peral','tErEsA','46','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('6','Elisa Peiro','elisia@gmail.com','Peiro','000000','26','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('7','Sofia Olmedo','sofia@gmail.com','Olmedo','sofiO','50','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('8','Casilda Valera','casilda@gmail.com','Valera','casiLda','38','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('9','Nina Huertas','nina@gmail.com','Huertas','nina5264','54','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('10','Jeronima Castellanos','jeronima@gmail.com','Castellanos','JeCast','41','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('11','Emilio Rios','emilio@gmail.com','Rios','emiliori','30','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('12','Ernesto Juarez','ernesto@gmail.com','Juarez','ejuarez1','2','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('13','Diana Ayuso','diana@gmail.com','Ayuso','dianalmb','10','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,user_g,passwordd,id_direction,id_type_employee) VALUES('14','Yassine Ruz','yassine@gmail.com','Ruz','yassiner','14','2');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('15','Marwa Cebrian','marwa@gmail.com','3','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('16','Imane Manso','imane@gmail.com','7','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('17','Francesc Bermejo','francesc@gmail.com','11','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('18','Marius Alarcon','marius@gmail.com','15','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('19','Ceferino de Haro','ceferino@gmail.com','19','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('20','Luis Torres','luis@gmail.com','23','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('21','Gael García','gael@gmail.com','27','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('22','Bibiana Romera','bibiana@gmail.com','31','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('23','Martin Villaverde','martin@gmail.com','35','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('24','Mayra Arias','mayra@gmail.com','39','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('25','Nicoleta Vergara','nicoleta@gmail.com','42','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('26','Michelle Contreras','michelle@gmail.com','46','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('27','Zohra Baez','zohra@gmail.com','50','1');
INSERT INTO EMPLOYEE(id,nameEmployee,mail,id_direction,id_type_employee) VALUES('28','Angeles Orellana','angeles@gmail.com','54','1');

--Banco de datos CITIZEN
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('1','065791834','Julie Fleming','79968165','julie@gmail.com','5','1','2','1');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('2','054782115','Avye Wiley','76839474','avye@gmail.com','1','3','7','5');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('3','092155486','Regan Greene','75932558','regan@gmail.com','7','5','4','9');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction,id_diseases) VALUES('4','032559722','Karly Charles','79758486','karly@gmail.com','10','2','7','13','1');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('5','014789254','Melodie George','72983505','melodie@gmail.com','2','13','5','17');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction,id_diseases) VALUES('6','032668951','Dai Oneill','72835384','dai@gmail.com','3','10','8','21','2');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('7','025896307','Mari Cross','74713990','mari@gmail.com','9','9','3','25');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction,id_diseases) VALUES('8','012865909','TaShya Simpson','71199480','tashya@gmail.com','4','6','10','29','4');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('9','032598755','Sonia Woodward','77427371','sonia@gmail.com','6','11','4','33');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('10','032569877','Vania Benitez','73420371','vania@gmail.com','12','4','7','37');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction,id_diseases) VALUES('11','054896227','Rodrigo Carrero','78526526','rodrigo@gmail.com','14','8','1','41','2');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('12','014865993','Carlos Estevez','71968865','carlos@gmail.com','8','14','6','45');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction) VALUES('13','025874889','Jason Cruz','76259774','jason@gmail.com','11','7','9','49');
INSERT INTO CITIZEN(id,dui,nameCitizen,phone,mail,id_employee,id_cabin,id_institution,id_direction,id_diseases) VALUES('14','032589655','Alessandro Pineda','71335758','alessandro@gmail.com','13','12','5','53','3');






