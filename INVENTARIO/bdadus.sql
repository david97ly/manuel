CREATE DATABASE adus;
USE adus;

CREATE TABLE menu(
	 IdOpc integer(11) NOT NULL AUTO_INCREMENT,
	 cNomOpc varchar(20),
	 nIdBar integer(11),
	 cAccion varchar(50),
	 cDescripcion varchar(50),
	PRIMARY KEY (IdOpc)
)TYPE=MyIsam;

CREATE TABLE usr(
	 IdUsr char(15) NOT NULL,
	 cNom varchar(20),
	 cApe varchar(20),
	 cClave varchar(80),
	 cEstado varchar(2),
	PRIMARY KEY (IdUsr)
) TYPE=InnoDB;
INSERT INTO usr (IdUsr,cNom,cApe,cClave,cEstado) VALUES
('admin','Usuario','Administrador',MD5('admin'),'A');

CREATE TABLE grp(
	 IdGrp integer(11) NOT NULL AUTO_INCREMENT,
	 cGrp varchar(20),
	PRIMARY KEY (IdGrp)
) TYPE=MyIsam;

CREATE TABLE grpUsr(
	 IdGrpUsr integer(11) NOT NULL AUTO_INCREMENT ,
	 IdGrp integer(11) NOT NULL,
	 IdUsr varchar(15) NOT NULL,
	PRIMARY KEY (IdGrpUsr),
              index (IdGrp),
              index(IdUsr),
              foreign key (IdGrp) references grp(IdGrp),
              foreign key (IdUsr) references usr(IdUsr)
) TYPE=MyIsam;

CREATE TABLE permisos(
	 IdPermiso integer(11) NOT NULL AUTO_INCREMENT,
	 IdGrp integer(11) NOT NULL,
	 IdOpc integer(11) NOT NULL,
	PRIMARY KEY (IdPermiso),
             index (IdGrp),
             index (IdOpc),
             foreign key (IdGrp) references grp(IdGrp),
             foreign key (IdOpc) references menu(IdOpc)
)TYPE=MyIsam;

INSERT INTO `grp` (cGrp) VALUES ('Administrador');
INSERT INTO `menu` (cNomOpc, nIdBar, cAccion,cDescripcion) VALUES ('Maestros',0,"Ninguna","Maestros");
INSERT INTO `menu` (cNomOpc, nIdBar, cAccion,cDescripcion) VALUES ('Grupos',1,"mGrupo","Maestro Grupos");
INSERT INTO `menu` (cNomOpc, nIdBar, cAccion,cDescripcion) VALUES ('Usuarios',1,"mUsuarios","Maestro de usuarios");
INSERT INTO `menu` (cNomOpc, nIdBar, cAccion,cDescripcion) VALUES ('Menu',1,"mMenu","Maestro del menu");
INSERT INTO `menu` (cNomOpc, nIdBar, cAccion,cDescripcion) VALUES ('Configuracion',0,"Ninguna","Configuracion");
INSERT INTO `menu` (cNomOpc, nIdBar, cAccion,cDescripcion) VALUES ('Grupos de usuarios',5,"frmUsuarios","Grupos de usuarios");
INSERT INTO `menu` (cNomOpc, nIdBar, cAccion,cDescripcion) VALUES ('Permisos',5,"frmPermisos","Permisos");

INSERT INTO `grpusr` (idGrp,IdUsr) VALUES ('1','admin');
INSERT INTO `permisos` (idgrp,idOpc) VALUES ('1','1');
INSERT INTO `permisos` (idgrp,idOpc) VALUES ('1','2');
INSERT INTO `permisos` (idgrp,idOpc) VALUES ('1','3');
INSERT INTO `permisos` (idgrp,idOpc) VALUES ('1','4');
INSERT INTO `permisos` (idgrp,idOpc) VALUES ('1','5');
INSERT INTO `permisos` (idgrp,idOpc) VALUES ('1','6');
INSERT INTO `permisos` (idgrp,idOpc) VALUES ('1','7');
