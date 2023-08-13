
USE [DB_ReinaFacultad]

Create Procedure InsertarPerfilUsuario

@mod varchar(255), @est char(1), @feRe date

as

Insert INTO perfilUsuario (modulo, estado, fechaReg)values(@mod, @est, @feRe);


Create Procedure ModificarPerfilUsuario

@id_per int, @mod varchar(255), @est char(1), @feRe date

as

UPDATE perfilUsuario set modulo=@mod, estado=@est, fechaReg=@feRe WHERE id_perfil=@id_per;


CREATE PROCEDURE EliminarPerfiUsuario

@id_per int

as

DELETE perfilUsuario WHERE id_perfil=@id_per;

CREATE PROCEDURE ObtenerPerfilUsuario
AS
BEGIN
    SELECT * FROM perfilUsuario; 
END


Create Procedure InsertarUsuario

@nom varchar(225), @userna varchar(255), @cont varchar(250), @mail varchar(255), @id_per int, @est char(1), @feRe date

as


INSERT INTO usuario (nombres, username, contrasenia, mail, id_perfil, estado, fechaReg)
VALUES ('admin', 'admin', 'admin', 'admin@admin.com', 1, 'A', GETDATE());

INSERT INTO usuario (nombres, username, contrasenia, mail, id_perfil, estado, fechaReg)
VALUES ('gestor', 'gestor', 'gestor', 'gestor@gestor.com', 2, 'A', GETDATE());


Create Procedure ModificarUsuario

@id_usu int, @nom varchar(225), @userna varchar(255), @cont varchar(250), @mail varchar(255), @id_per int, @est char, @feRe date


as

UPDATE usuario set nombres=@nom, username=@userna, contrasenia=@cont, mail=@mail, id_perfil=@id_per, estado=@est, fechaReg=@feRe WHERE id_usuario=@id_usu;


CREATE PROCEDURE EliminarUsuario

@id_usu int

as

DELETE usuario WHERE id_usuario=@id_usu;

CREATE PROCEDURE ObtenerUsuario
AS
BEGIN
    SELECT * FROM usuario; 
END



Create Procedure InsertarDatosPersonales

@nom varchar(255), @feNac date, @dir varchar(500), @tel varchar(20), @mail varchar(100), @url_foto varchar(255), @titu varchar(255),@est char, @feRe date

as

Insert Into datosPersonales (nombres, fechaNac, direccion, teléfono, mail, url_foto, titulo, estado, fechaReg ) values(@nom, @feNac, @dir, @tel, @mail, @url_foto, @titu, @est, @feRe);

Create Procedure ModificarDatosPersonales

@id_daPer int, @nom varchar(255), @feNac date, @dir varchar(500), @tel varchar(20), @mail varchar(100), @url_foto varchar(255), @titu varchar(255), @est char, @feRe date

as

UPDATE datosPersonales set nombres=@nom, fechaNac=@feNac, direccion=@dir, teléfono=@tel, mail=@mail, url_foto=@url_foto, titulo=@titu, estado=@est, fechaReg=@feRe WHERE id_datosPersonales=@id_daPer;


CREATE PROCEDURE EliminarDatosPersonales

@id_datosPer int

as

DELETE datosPersonales WHERE id_datosPersonales=@id_datosPer;

CREATE PROCEDURE ObtenerDatosPersonales
AS
BEGIN
    SELECT * FROM datosPersonales; 
END

CREATE PROCEDURE ObtenerComboDatosPersonales
AS
BEGIN
    SELECT id_datosPersonales, nombres FROM datosPersonales; 
END

Create Procedure InsertarReinado

@id_reinado int

as

Insert Into reinado values(@id_reinado);


CREATE PROCEDURE EliminarReinado

@id_reinado int

as

DELETE reinado WHERE id_reinado=@id_reinado;

CREATE PROCEDURE ObtenerReinado
AS
BEGIN
    SELECT * FROM reinado; 
END

Create Procedure InsertarCandidata

@id_daPer int, @id_reinado int, @pasti varchar(500), @habi varchar(500), @int varchar(500), @asp varchar(500), @est char, @feRe date

as

Insert INTO candidata (id_datosPersonales, id_reinado, pasatiempos, habilidades, intereses, aspiraciones, estado, fechaReg) values(@id_daPer, @id_reinado, @pasti, @habi, @int, @asp, @est, @feRe);

Create Procedure ModificarCandidata

@id_can int, @id_daPer int, @id_reinado int, @pasti varchar(500), @habi varchar(500), @int varchar(500), @asp varchar(500),@est char, @feRe date

as

UPDATE candidata set id_datosPersonales=@id_daPer, id_reinado=@id_reinado, pasatiempos=@pasti, habilidades=@habi,  intereses=@int, aspiraciones=@asp, estado=@est, fechaReg=@feRe WHERE id_candita=@id_can;


CREATE PROCEDURE EliminarCandidata

@id_can int

as

DELETE candidata WHERE id_candita=@id_can;

CREATE PROCEDURE ObtenerCandidata
AS
BEGIN
    SELECT * FROM candidata; 
END


Create Procedure InsertarAlbum

@id_can int, @nomAl varchar(100),@est char, @feRe date

as

Insert INTO album (id_candidata, nombreAlbum, estado, fechaReg) values(@id_can, @nomAl, @est, @feRe);

Create Procedure ModificarAlbum

@id_al int, @id_can int, @nomAl varchar(100), @est char, @feRe date

as

UPDATE album set id_candidata=@id_can, nombreAlbum=@nomAl, estado=@est, fechaReg=@feRe WHERE id_album=@id_al;


CREATE PROCEDURE EliminarAlbum

@id_al int

as

DELETE album WHERE id_album=@id_al;

CREATE PROCEDURE ObtenerAlbum
AS
BEGIN
    SELECT * FROM album; 
END


Create Procedure InsertarFotos

@id_al int, @id_can int, @titu varchar(100), @des varchar(500), @url_foto varchar(255),@est char, @feRe date

as

Insert INTO fotos (id_album, id_candidata, titulo, descripcion, url_foto, estado, fechaReg) values(@id_al, @id_can, @titu, @des, @url_foto, @est, @feRe);

Create Procedure ModificarFotos

@id_fo int, @id_al int, @id_can int, @titu varchar(100), @des varchar(500), @url_foto varchar(255), @est char(1), @feRe date

as

UPDATE fotos set id_album=@id_al, id_candidata=@id_can,  titulo=@titu, descripcion=@des, url_foto=@url_foto, estado=@est, fechaReg=@feRe WHERE id_foto=@id_fo;


CREATE PROCEDURE EliminarFotos

@id_fo int

as

DELETE fotos WHERE id_foto=@id_fo;

CREATE PROCEDURE ObtenerFotos
AS
BEGIN
    SELECT * FROM fotos; 
END


Create Procedure InsertarComentarios

@id_fo int, @id_est int,@est char, @feRe date

as

Insert Into comentarios (id_foto, id_estudiante, estado, fechaReg) values(@id_fo, @id_est, @est, @feRe);

Create Procedure ModificarComentarios

@id_com int, @id_fo int, @id_est int, @est char, @feRe date

as

UPDATE comentarios set id_foto=@id_fo, id_estudiante=@id_est, estado=@est, fechaReg=@feRe WHERE id_comentario=@id_com;


CREATE PROCEDURE EliminarComentarios

@id_com int

as

DELETE comentarios WHERE id_comentario=@id_com;

CREATE PROCEDURE ObtenerComentarios
AS
BEGIN
    SELECT * FROM comentarios; 
END


Create Procedure InsertarVotacionFotogenia

@id_can int, @id_usu int,@est char, @feRe date

as

Insert Into votacionFotogenia (id_candita, id_usuario, estado, fechaReg) values(@id_can, @id_usu, @est, @feRe)

Create Procedure ModificarVotacionFotogenia

@id_foge int, @id_can int, @id_usu int, @est char(1), @feRe date

as

UPDATE votacionFotogenia set id_candita=@id_can, id_usuario=@id_usu, estado=@est, fechaReg=@feRe WHERE id_fotogenia=@id_foge;


CREATE PROCEDURE EliminarVotacionFotogenia

@id_foge int

as

DELETE votacionFotogenia WHERE id_fotogenia=@id_foge;

CREATE PROCEDURE ObtenerVotacionFotogenia
AS
BEGIN
    SELECT * FROM votacionFotogenia; 
END


Create Procedure InsertarVotacionReina

@id_can int, @id_usu int, @est char, @feRe date

as

Insert Into votacionReina (id_candita, id_usuario, estado, fechaReg) values(@id_can, @id_usu, @est, @feRe)

Create Procedure ModificarVotacionReina

@id_reina int, @id_can int, @id_usu int, @est char, @feRe date

as

UPDATE votacionReina set id_candita=@id_can, id_usuario=@id_usu, estado=@est, fechaReg=@feRe WHERE id_reina=@id_reina;


CREATE PROCEDURE EliminarVotacionReina

@id_reina int

as

DELETE votacionReina WHERE id_reina=@id_reina;

CREATE PROCEDURE ObtenerVotacionReina
AS
BEGIN
    SELECT * FROM votacionReina; 
END


