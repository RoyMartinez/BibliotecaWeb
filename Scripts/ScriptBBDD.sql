/*CREACION DE LA BASE DE DATOS*/
/************************************************************************************/
/************************************************************************************/
/************************************************************************************/
Drop Database if Exists BibliotecaWeb;
go
Create Database BibliotecaWeb;
go
Use BibliotecaWeb;
go
/*CREACION DE LA BASE DE DATOS*/
/************************************************************************************/
/************************************************************************************/
/************************************************************************************/
/*==================================================================================
Tabla: Carrera
Nota : Tabla Catalogo donde se registraran las distintas carreras del Estudiante
===================================================================================*/
Create Table Carrera
(
	Id Int Identity(1,1),
	Nombre nvarchar(50) not null Unique,--El nombre de la carrera, Por Ejemplo Ing. en Computación debe ser Unico y no quedar en blanco
	Constraint pkCarrera Primary key (Id)
);
/*==================================================================================
Tabla: Estudiante
Nota : Tabla donde se ubicara el registro de los datos del estudiante
===================================================================================*/
Create Table Estudiante
(
	Id int Identity(1,1),
	Carnet nvarchar(15) not null Unique,--el carnet de identificacion del estudiante  debe ser Unico y no quedar en blanco
	Nombre nvarchar(100),
	Edad int,
	Direccion nvarchar(100),
	Carrera int,
	Constraint pkEstudiante Primary Key (Id),
	Constraint fkEstudianteCarrera Foreign Key (Carrera) References Carrera(Id)
);
/*==================================================================================
Tabla: Nacionalidad
Nota : Tabla Catalogo donde se Registraran la nacionalidad del autor
===================================================================================*/
Create Table Nacionalidad
(
	Id int Identity(1,1),
	Nacionalidad nvarchar(50) not null Unique, --Ej:Nicaraguense debe ser Unico y no quedar en blanco
	Constraint pkNacionalidad Primary Key (Id)
);
/*==================================================================================
Tabla: Autor
Nota : Tabla donde se ubicara el registro de los datos de los autores de un libro
===================================================================================*/
Create Table Autor
(
	Id int identity(1,1),
	Nombre nvarchar(100) Unique,
	Nacionalidad int,
	Constraint pkAutor Primary Key (Id),
	Constraint fkAutorNacionalidad foreign key (Nacionalidad) References Nacionalidad(Id)
);
/*==================================================================================
Tabla: Editorial
Nota : Tabla catalogo donde se registraran las editoriales
===================================================================================*/
Create Table Editorial
(
	Id int Identity(1,1),
	Nombre nvarchar(50) not null Unique,--El nombre de la editorial el cual debe de ser Unico y no quedar en blanco
	FechaRegistro date default GETDATE(),
	Constraint pkEditorial Primary Key (Id)
);
/*==================================================================================
Tabla: Area
Nota : Tabla catalogo donde se registraran las areas 
===================================================================================*/
Create Table Area
(
	Id int Identity(1,1),
	Nombre nvarchar(50) not null Unique,--El nombre del área el cual debe de ser Unico y no quedar en blanco
	FechaRegistro date default GETDATE(),
	Constraint pkArea Primary Key (Id)
);
/*==================================================================================
Tabla: Libro
Nota : Tabla donde se registran los datos concernientes al libro
===================================================================================*/
Create Table Libro
(
	Id int Identity(1,1),
	Titulo nvarchar(100),
	Editorial int,
	Area int,
	Constraint pkLibro Primary Key (Id),
	Constraint fkLibroEditorial Foreign Key (Editorial) References Editorial(Id),
	Constraint fkLibroArea Foreign Key (Area) References Area(Id)
);
/*==================================================================================
Tabla: LibroXAutor
Nota : Tabla resultado de la normalizacion entre la relacion Muchos a Muchos de Libro con Autor
===================================================================================*/
Create Table LibroXAutor
(
	Autor int,
	Libro int
	Constraint pkLibroXAutor Primary Key (Autor,Libro),
	Constraint fkLibroXAutorAutor Foreign Key (Autor) References Autor(Id),
	Constraint fkLibroXAutorLibro Foreign Key (Libro) References Libro(Id)
);
/*==================================================================================
Tabla: Prestamo
Nota : Tabla resultado de la normalizacion entre la relacion Muchos a Muchos de Libro con Estudiabte
===================================================================================*/
Create Table Prestamo
(
	Estudiante int,
	Libro int,
	FechaPrestamo DateTime Default GetDate(),--la fecha y hora del prestamo, Este campo es parte de la llave primaria y por defecto se pone la hora del sistema
	FechaDevolucion Date Default CAST(GetDate()+7 as Date),--la fecha en que tiene que ser devuelto el libro
	Devuelto nvarchar(1) Default 'N',--Indica si el libro esta devuelto o no. (S)=Devuelto;(N)=no Devuelto;
	Constraint pkPrestamo Primary Key (Estudiante,Libro),
	Constraint fkPrestamoEstudiante Foreign Key (Estudiante) References Estudiante(Id),
	Constraint fkPrestamoLibro Foreign Key (Libro) References Libro(Id)
);
/*Inserción de Datos Iniciales*/
/************************************************************************************/
/************************************************************************************/
/************************************************************************************/
/*==================================================================================
Tabla: Carrera
Nota : Datos Iniciales para la tabla Carrera; al inicio el Id que se asignara al ser identidad
===================================================================================*/
/*1*/Insert Into Carrera(Nombre)
		          Values('Ingenieria en Computación');
/*2*/Insert Into Carrera(Nombre)
				  Values('Ingenieria en Sistemas');
/*3*/Insert Into Carrera(Nombre)
			      Values('Contabilidad');
/*4*/Insert Into Carrera(Nombre)
				  Values('Administracion');
/*5*/Insert Into Carrera(Nombre)
			      Values('Matematicas');
/*==================================================================================
Tabla: Estudiante
Nota : Datos Iniciales para la tabla Carrera; al inicio el Id que se asignara al ser identidad
	   (Com)=Computacion;(Sis)=Sistema;(Con)=Contabilidad;(Adm)=Administracion;(Mat)=Matematicas;
===================================================================================*/
--Ingenieria En Computacion
/*1*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('001-Com','Roy Roger Martinez Cano',25,'Colonia Primero de Mayo',1);
/*2*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('002-Com','Allan Daniel Bell Aburto',35,'Waspar Sur',1);
--Ingenieria En Sistema
/*3*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('001-Sis','Orlando Josue Baltodano Altamirano',25,'Departamento de Carazo',2);
/*4*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('002-Sis','Jersson Martin Mongue Herrera',35,'Barrio Boer Managua',2);
--Contabilidad
/*5*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('001-Con','Luis Miguel Gonzales Moreno',20,'Departamento de Masaya',3);
/*6*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('002-Con','Junieth Valezca Espinoza Zapata',21,'Ciudad Sandino',3);
--Administracion
/*7*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('001-Adm','Willians Javier Alvarado Aguilar',27,'Ciudad Sandino',4);
/*8*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('002-Adm','Juan Jose Garcia Perez',21,'Altagracia',4);
--Matematicas
/*9*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('001-Mat','Julio Cesar Sandino Sanchez',31,'Memorial Sandino',5);
/*10*/Insert Into Estudiante(Carnet,Nombre,Edad,Direccion,Carrera) 
					Values('002-Mat','Luis Eduardo Chavez Mairena',32,'Lomas de Monserrat',5);
/*==================================================================================
Tabla: Nacionalidad
Nota : Datos Iniciales para la tabla Nacionalidad; al inicio el Id que se asignara al ser identidad
===================================================================================*/
/*1*/Insert into Nacionalidad(Nacionalidad)
			      Values('Nicaraguense');
/*2*/Insert into Nacionalidad(Nacionalidad)
			      Values('Costarricense');
/*3*/Insert into Nacionalidad(Nacionalidad)
			      Values('Peruano');
/*4*/Insert into Nacionalidad(Nacionalidad)
			      Values('Uruguaya');
/*5*/Insert into Nacionalidad(Nacionalidad)
			      Values('Estadounidence');
/*==================================================================================
Tabla: Autor
Nota : Datos Iniciales para la tabla Autor; al inicio el Id que se asignara al ser identidad
===================================================================================*/
/*1*/Insert Into Autor(Nombre,Nacionalidad)
		   Values('Luis Chavez',1);
/*2*/Insert Into Autor(Nombre,Nacionalidad)
		   Values('Carlos Fallas',2);
/*3*/Insert Into Autor(Nombre,Nacionalidad)
		   Values('Diego Muñoz ',3);
/*4*/Insert Into Autor(Nombre,Nacionalidad)
		   Values('Martin Quintana',4);
/*5*/Insert Into Autor(Nombre,Nacionalidad)
		   Values('Bill Gates ',5);
/*6*/Insert Into Autor(Nombre,Nacionalidad)
		   Values('Paul Allen',5);
/*==================================================================================
Tabla: Editorial
Nota : Datos Iniciales para la tabla Editorial; al inicio el Id que se asignara al ser identidad
	   La fecha tiene default la del sistema asi que no es necesario ingresarla en el Insert
===================================================================================*/
/*1*/Insert Into Editorial(Nombre)
				    Values('Susaeta');
/*2*/Insert Into Editorial(Nombre)
				    Values('Escuela de Costa Rica');
/*3*/Insert Into Editorial(Nombre)
				    Values('Escuela de Peru');
/*4*/Insert Into Editorial(Nombre)
				    Values('Escuela de Uruguay');
/*5*/Insert Into Editorial(Nombre)
				    Values('Microsoft Press');
/*==================================================================================
Tabla: Area
Nota : Datos Iniciales para la tabla Area; al inicio el Id que se asignara al ser identidad
	   La fecha tiene default la del sistema asi que no es necesario ingresarla en el Insert
===================================================================================*/
/*1*/Insert Into Area(Nombre)
				    Values('Informatica');
/*2*/Insert Into Area(Nombre)
				    Values('Contabilidad');
/*3*/Insert Into Area(Nombre)
				    Values('Administracion');
/*4*/Insert Into Area(Nombre)
				    Values('Matematicas');
/*==================================================================================
Tabla: Libro
Nota : Datos Iniciales para la tabla Libro; al inicio el Id que se asignara al ser identidad
===================================================================================*/
--Area:Informatica--Editorial:Microsoft Press
/*1*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Programacion C#',5,1);
/*2*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Asp. Net',5,1);
--Area:Contabilidad--Editorial:Escuela de Costa Rica
/*3*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Contabilidad Basica por Elias Lara',2,2);
--Area:Contabilidad--Editorial:Escuela de Peru
/*4*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Contabilidad Avanzada por Elias Lara',2,3);
--Area:Administracion--Editorial:Escuela de Uruguay
/*5*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Introduccion a la Administracion de empresas',3,3);
--Area:Matematicas--Editorial:Susaeta
/*6*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Trigonometria',5,4);
/*7*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Algebra',5,4);
/*8*/Insert Into Libro(Titulo,Editorial,Area)
		       Values('Calculo',5,4);
/*==================================================================================
Tabla: LibroXAutor
Nota : Datos Iniciales para la tabla LibroXAutor; 
===================================================================================*/
--Libro:Asp. Net, Autor:Luis Chavez
Insert Into LibroXAutor(Autor,Libro)
					  Values(1,2);
--Libro:Calculo, Autor:Luis Chavez
Insert Into LibroXAutor(Autor,Libro)
					  Values(1,8);
--Libro:Asp. Net, Autor:Carlos Fallas
Insert Into LibroXAutor(Autor,Libro)
					  Values(2,2);
--Libro:Algebra, Autor:Carlos Fallas
Insert Into LibroXAutor(Autor,Libro)
					  Values(2,7);
--Libro:Contabilidad Basica por Elias Lara, Autor:Diego Muñoz
Insert Into LibroXAutor(Autor,Libro)
					  Values(3,3);
--Libro:Trigonometria, Autor:Diego Muñoz
Insert Into LibroXAutor(Autor,Libro)
					  Values(3,6);
--Libro:Contabilidad Avanzada por Elias Lara, Autor:Martin Quintana
Insert Into LibroXAutor(Autor,Libro)
					  Values(4,4);
--Libro:Introduccion a la Administracion de empresas, Autor:Martin Quintana
Insert Into LibroXAutor(Autor,Libro)
					  Values(4,5);
--Libro:Programacion C#, Autor:Bill Gates
Insert Into LibroXAutor(Autor,Libro)
					  Values(5,1);
--Libro:Programacion C#, Autor:Paul Allen
Insert Into LibroXAutor(Autor,Libro)
					  Values(6,1);
/*==================================================================================
Tabla: Prestamo
Nota : Datos Iniciales para la tabla Prestamo; al inicio el Id que se asignara al ser identidad
===================================================================================*/
--Estudiante:Roy Roger Martinez Cano--Libro:Programacion C#
Insert Into Prestamo(Estudiante,Libro)
			  Values(1,1);
--Estudiante:Allan Daniel Bell Aburto--Libro:Asp. Net
Insert Into Prestamo(Estudiante,Libro)
			  Values(2,2);
--Estudiante:Orlando Josue Baltodano Altamirano--Libro:Contabilidad Basica por Elias Lara
Insert Into Prestamo(Estudiante,Libro)
			  Values(3,3);
--Estudiante:Jersson Martin Mongue Herrera--Libro:Contabilidad Avanzada por Elias Lara
Insert Into Prestamo(Estudiante,Libro)
			  Values(4,4);
--Estudiante:Luis Miguel Gonzales Moreno--Libro:Introduccion a la Administracion de empresas
Insert Into Prestamo(Estudiante,Libro)
			  Values(5,5);
--Estudiante:Junieth Valezca Espinoza Zapata--Libro:Trigonometria
Insert Into Prestamo(Estudiante,Libro)
			  Values(6,6);
--Estudiante:Willians Javier Alvarado Aguilar--Libro:Algebra
Insert Into Prestamo(Estudiante,Libro)
			  Values(7,7);
--Estudiante:Juan Jose Garcia Perez--Libro:Calculo
Insert Into Prestamo(Estudiante,Libro)
			  Values(8,8);
--Estudiante:Julio Cesar Sandino Sanchez--Libro:Calculo
Insert Into Prestamo(Estudiante,Libro)
			  Values(9,8);
--Estudiante:Luis Eduardo Chavez Mairena--Libro:Calculo
Insert Into Prestamo(Estudiante,Libro)
			  Values(10,8);
