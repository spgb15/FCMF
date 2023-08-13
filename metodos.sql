USE DB_ReinaFacultad;

SELECT * FROM Candidata JOIN DatosPersonales ON Candidata.ID_DatosPersonales = DatosPersonales.id_datosPersonales;

SELECT * FROM Candidata JOIN DatosPersonales ON Candidata.ID_DatosPersonales = DatosPersonales.id_datosPersonales WHERE id_reinado = 2;

DELETE FROM datosPersonales;
SELECT * FROM candidata;
SELECT * FROM DATOSPERSONALES;
	
	INSERT INTO datosPersonales (nombres, fechaNac, direccion, teléfono, mail, url_foto, titulo)
VALUES
  ('Doménica Angulo', '1995-05-15','Guayaquil, Alborada 1era etapa', '0952253345', 'Dome_AT@gmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_DA\foto_DA.jpg', 'Bachillerato General Unificado'),
  ('Karina Rodríguez', '1996-08-20','Guayaquil, Floresta', '0952298765', 'Karina.rodriguez@gmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_KR\foto_KR.jpg', 'Bachillerato en Ciencias'),
  ('Ximena Castillo', '1993-11-25','Guayaquil, Mapasingue Oeste', '0952278901', 'Xime1993@gmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_XC\foto_XC.jpg', 'Bachillerato en Ciencias'),
  ('Carolina Ramírez', '1995-02-12','Guayaquil, Sauces 2', '0952251089', 'carolina_RS95@hotmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_CR\foto_CR.jpg', 'Bachillerato Técnico'),
  ('Paula Gordillo', '1998-06-30','Guayaquil, Alborada 3ra etapa', '0952289012', 'pau_mariana@gmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PG\foto_PG.jpg', 'Bachillerato Técnico'),
  ('Julia Sánchez', '1994-09-08', 'Guayaquil, Portete y la 36', '0952245678', 'juli_1994@gmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_JS\foto_JS.jpg', 'Bachillerato Técnico'),
  ('Elena Romero', '1996-12-18', 'Guayaquil, Av. Quito y Capitán Nájera', '0952267890', 'elenaromero@hotmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_ER\foto_ER.jpg', 'Bachillerato Técnico'),
  ('Patricia Vargas', '1999-04-22','Guayaquil, Guasmo Norte', '0952201294', 'patricia_vargas@gmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PV\foto_PV.jpg', 'Bachillerato General Unificado'),
  ('Isabel Solis', '1997-01-28', 'Guayaquil, 9 de Octubre y Esmeraldas', '0952223406', '97isabel@hotmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_IS\foto_IS.jpg', 'Bachillerato en Ciencias'),
  ('Fernanda Zamorano', '2000-01-12', 'Guayaquil, Alborada 5ta etapa', '0952294560', 'fer12zambrano@gmail.com', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_FZ\foto_FZ.jpg', 'Bachillerato Técnico');


  INSERT INTO candidata(id_datosPersonales, id_reinado, pasatiempos, habilidades, intereses, aspiraciones) values
  (11, 1, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (12, 1, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (13, 1, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (14, 1, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (15, 1, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),

  (16, 2, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (17, 2, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (18, 2, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (19, 2, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA'),
  (20, 2, 'CANTAR', 'BAILAR', 'SOCIALES','SER INGENIERA');

  SELECT * FROM ALBUM;
  SELECT * FROM FOTOS;

  INSERT INTO FOTOS(id_album,id_candidata, TITULO, descripcion, url_foto) VALUES
  (2, 1, 'DOMENICA ANGULO', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_DA\foto_DA.jpg'),
  (2, 1, 'DOMENICA ANGULO', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_DA\DA1.jpg'),
  (2, 1, 'DOMENICA ANGULO', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_DA\DA2.jpg'),
  (2, 1, 'DOMENICA ANGULO', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_DA\DA3.jpg'),

  (3, 2, 'KARINA RODRIGUEZ', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_KR\foto_KR.jpg'),
  (3, 2, 'KARINA RODRIGUEZ', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_KR\KR1.jpg'),
  (3, 2, 'KARINA RODRIGUEZ', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_KR\KR2.jpg'),
  (3, 2, 'KARINA RODRIGUEZ', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_KR\KR3.jpg'),

  (4, 3, 'XIMENA CASTILLO', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_XC\foto_XC.jpg'),
  (4, 3, 'XIMENA CASTILLO', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_XC\XC1.jpg'),
  (4, 3, 'XIMENA CASTILLO', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_XC\XC2.jpg'),
  (4, 3, 'XIMENA CASTILLO', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_XC\XC3.jpg'),

  (5, 4, 'CAROLINA RAMIREZ', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_KR\foto_CR.jpg'),
  (5, 4, 'CAROLINA RAMIREZ', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_CR\CR1.jpg'),
  (5, 4, 'CAROLINA RAMIREZ', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_CR\CR2.jpg'),
  (5, 4, 'CAROLINA RAMIREZ', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_CR\CR3.jpg'),

  (6, 5, 'PAULA GORDILLO', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PG\foto_PG.jpg'),
  (6, 5, 'PAULA GORDILLO', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PG\PG1.jpg'),
  (6, 5, 'PAULA GORDILLO', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PG\PG2.jpg'),
  (6, 5, 'PAULA GORDILLO', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PG\PG3.jpg'),

  (7, 6, 'JULIA SÁNCHEZ', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_JS\foto_JS.jpg'), 
  (7, 6, 'JULIA SÁNCHEZ', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\\JS1.jpg'), 
  (7, 6, 'JULIA SÁNCHEZ', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_JS\JS2.jpg'), 
  (7, 6, 'JULIA SÁNCHEZ', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_JS\JS3.jpg'),

  (8, 7, 'ELENA ROMERO', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_ER\foto_ER.jpg'), 
  (8, 7, 'ELENA ROMERO', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_ER\ER1.jpg'), 
  (8, 7, 'ELENA ROMERO', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_ER\ER2.jpg'), 
  (8, 7, 'ELENA ROMERO', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_ER\ER3.jpg'),

  (9, 8, 'PATRICIA VARGAS', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PV\foto_PV.jpg'), 
  (9, 8, 'PATRICIA VARGAS', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PV\PV1.jpg'), 
  (9, 8, 'PATRICIA VARGAS', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PV\PV2.jpg'), 
  (9, 8, 'PATRICIA VARGAS', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_PV\PV3.jpg'),

  (10, 9, 'ISABEL SOLIS', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_IS\foto_IS.jpg'), 
  (10, 9, 'ISABEL SOLIS', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_IS\IS1.jpg'), 
  (10, 9, 'ISABEL SOLIS', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_IS\IS2.jpg'), 
  (10, 9, 'ISABEL SOLIS', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_IS\IS3.jpg'),

  (11, 10, 'FERNANDA ZAMORANO', 'FOTO PRINCIPAL', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_KR\foto_FZ.jpg'), 
  (11, 10, 'FERNANDA ZAMORANO', 'FOTO 1', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_FZ\FZ1.jpg'), 
  (11, 10, 'FERNANDA ZAMORANO', 'FOTO 2', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_FZ\FZ2.jpg'), 
  (11, 10, 'FERNANDA ZAMORANO', 'FOTO 3', 'C:\Users\Paul Guerra\Documents\Proyecto\FCMF\Album de Candidatas\foto_FZ\FZ3.jpg');



  INSERT INTO ALBUM(id_candidata, nombreAlbum) VALUES
  (1, 'DOMENICA ANGULO'),
  (2, 'KARINA RODRIGUEZ'),
  (3, 'XIMENA CASTILLO'),
  (4, 'CAROLINA RAMIREZ'),
  (5, 'PAULA GORDILLO'),
  (6, 'JULIA SANCHEZ'),
  (7, 'ELENA ROMERO'),
  (8, 'PATRICIA VARGAS'),
  (9, 'ISABEL SOLIS'),
  (10, 'FERNANDA ZAMORANO');


 