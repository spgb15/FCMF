CREATE DATABASE DB_ReinaFacultad

USE DB_ReinaFacultad

CREATE TABLE perfilUsuario(
	id_perfil			INT				PRIMARY KEY		IDENTITY(1,1),
	modulo				VARCHAR(255)	NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE) 
);

INSERT INTO perfilUsuario(modulo) VALUES ('administrador,'),('gestor'),('estudiante')


CREATE TABLE usuario(
	id_usuario			INT				PRIMARY KEY		IDENTITY(1,1),
	nombres				VARCHAR(255)	NOT NULL,
	username			VARCHAR(255)	NOT NULL,
	contrasenia			VARCHAR(255)	NOT NULL,
	mail				VARCHAR(255)	NOT NULL,
	id_perfil			INT				NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),
	FOREIGN KEY (id_perfil) REFERENCES perfilUsuario(id_perfil)
)

CREATE TABLE datosPersonales(
	id_datosPersonales	INT				PRIMARY KEY		IDENTITY(1,1),
	nombres				VARCHAR(255)	NOT NULL,
	fechaNac			DATE			NOT NULL,
	direccion			VARCHAR(500)	NOT NULL,
	teléfono			VARCHAR(20)		NOT NULL,
	mail				VARCHAR(100)	NOT NULL,
	url_foto			VARCHAR(255)	NOT NULL,
	titulo				VARCHAR(255)	NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),
)

CREATE TABLE album(
	id_album			INT				PRIMARY KEY		IDENTITY(1,1),
	nombreAlbum			VARCHAR(100)	NOT NULL,	
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),	
)

CREATE TABLE fotos(
	id_foto				INT				PRIMARY KEY		IDENTITY(1,1),
	id_album			INT				NOT NULL,
	titulo				VARCHAR(100)	NOT NULL,
	descripcion			VARCHAR(500)	NOT NULL,
	url_foto			VARCHAR(255)	NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),	
	FOREIGN KEY (id_album) REFERENCES album(id_album)
)

CREATE TABLE comentarios(
	id_comentario		INT				PRIMARY KEY		IDENTITY(1,1),
	id_foto				INT				NOT NULL,
	id_estudiante		INT				NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),
	FOREIGN KEY (id_foto) REFERENCES fotos(id_foto),
	FOREIGN KEY (id_estudiante) REFERENCES usuario(id_usuario)

);

CREATE TABLE reinado(
	id_reinado			INT				PRIMARY KEY		NOT NULL
);

CREATE TABLE candidata(
	id_candita			INT				PRIMARY KEY		IDENTITY(1,1),
	id_datosPersonales	INT				NOT NULL,
	id_album			INT				NOT NULL,
	id_reinado			INT				NOT NULL,
	pasatiempos			VARCHAR(500)	NOT NULL,
	habilidades			VARCHAR(500)	NOT NULL,
	intereses			VARCHAR(500)	NOT NULL,
	aspiraciones		VARCHAR(500)	NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),
	FOREIGN KEY (id_datosPersonales) REFERENCES datosPersonales(id_datosPersonales),
	FOREIGN KEY (id_album) REFERENCES album(id_album),
	FOREIGN KEY (id_reinado) REFERENCES Reinado(id_reinado)
)

CREATE TABLE votacionFotogenia(
	id_fotogenia		INT				PRIMARY KEY		IDENTITY(1,1),
	id_candita			INT				NOT NULL,
	id_usuario			INT				NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),
	FOREIGN KEY (id_candita) REFERENCES candidata(id_candita),
	FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
)

CREATE TABLE votacionReina(
	id_reina			INT				PRIMARY KEY		IDENTITY(1,1),
	id_candita			INT				NOT NULL,
	id_usuario			INT				NOT NULL,
	estado				CHAR			NOT NULL		DEFAULT		'A',
	fechaReg			DATE			NOT NULL		DEFAULT		CAST(GETDATE() AS DATE),
	FOREIGN KEY (id_candita) REFERENCES candidata(id_candita),
	FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
)


