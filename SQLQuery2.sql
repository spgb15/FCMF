USE DB_ReinaFacultad;

INSERT INTO datosPersonales (nombres, fechaNac, direccion, tel�fono, mail, url_foto, titulo)
VALUES
  ('Dom�nica Angulo', '1995-05-15','Guayaquil, Alborada 1era etapa', '0952253345', 'Dome_AT@gmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_DA\foto_DA.jpg', 'Bachillerato General Unificado'),
  ('Karina Rodr�guez', '1996-08-20','Guayaquil, Floresta', '0952298765', 'Karina.rodriguez@gmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_KR\foto_KR.jpg', 'Bachillerato en Ciencias'),
  ('Ximena Castillo', '1993-11-25','Guayaquil, Mapasingue Oeste', '0952278901', 'Xime1993@gmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_XC\foto_XC.jpg', 'Bachillerato en Ciencias'),
  ('Carolina Ram�rez', '1995-02-12','Guayaquil, Sauces 2', '0952251089', 'carolina_RS95@hotmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_CR\foto_CR.jpg', 'Bachillerato T�cnico'),
  ('Paula Gordillo', '1998-06-30','Guayaquil, Alborada 3ra etapa', '0952289012', 'pau_mariana@gmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_PG\foto_PG.jpg', 'Bachillerato T�cnico'),
  ('Julia S�nchez', '1994-09-08', 'Guayaquil, Portete y la 36', '0952245678', 'juli_1994@gmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_JS\foto_JS.jpg', 'Bachillerato T�cnico'),
  ('Elena Romero', '1996-12-18', 'Guayaquil, Av. Quito y Capit�n N�jera', '0952267890', 'elenaromero@hotmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_ER\foto_ER.jpg', 'Bachillerato T�cnico'),
  ('Patricia Vargas', '1999-04-22','Guayaquil, Guasmo Norte', '0952201294', 'patricia_vargas@gmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_PV\foto_PV.jpg', 'Bachillerato General Unificado'),
  ('Isabel Solis', '1997-01-28', 'Guayaquil, 9 de Octubre y Esmeraldas', '0952223406', '97isabel@hotmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_IS\foto_IS.jpg', 'Bachillerato en Ciencias'),
  ('Fernanda Zamorano', '2000-01-12', 'Guayaquil, Alborada 5ta etapa', '0952294560', 'fer12zambrano@gmail.com', 'C:\Users\spaul\Documents\GitHub\FCMF\Album de Candidatas\foto_FZ\foto_FZ.jpg', 'Bachillerato T�cnico');

  SELECT * FROM usuario;

  INSERT INTO usuario(nombres, username, contrasenia, mail, id_perfil) VALUES
  ('SERGIO', 'SPGB15', 'prueba', 'GUERRAPAUL22@GMAIL.COM', 1),
  ('SERGIO', 'SPGB16', 'prueba', 'GUERRAPAUL22@GMAIL.COM', 2),
  ('SERGIO', 'SPGB17', 'prueba', 'GUERRAPAUL22@GMAIL.COM', 3);