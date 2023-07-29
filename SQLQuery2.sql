USE DB_ReinaFacultad;

INSERT INTO datosPersonales (nombres, fechaNac, direccion, teléfono, mail, url_foto, titulo)
VALUES
  ('Doménica Angulo', '1995-05-15','Guayaquil, Alborada 1era etapa', '0952253345', 'Dome_AT@gmail.com', 'foto_DA.jpg', 'Bachillerato General Unificado'),
  ('Karina Rodríguez', '1996-08-20','Guayaquil, Floresta', '0952298765', 'Karina.rodriguez@gmail.com', 'foto_KR.jpg', 'Bachillerato en Ciencias'),
  ('Ximena Castillo', '1993-11-25','Guayaquil, Mapasingue Oeste', '0952278901', 'Xime1993@gmail.com', 'foto_XC.jpg', 'Bachillerato en Ciencias'),
  ('Carolina Ramírez', '1995-02-12','Guayaquil, Sauces 2', '0952251089', 'carolina_RS95@hotmail.com', 'foto_CR.jpg', 'Bachillerato Técnico'),
  ('Paula Gordillo', '1998-06-30','Guayaquil, Alborada 3ra etapa', '0952289012', 'pau_mariana@gmail.com', 'foto_PG.jpg', 'Bachillerato Técnico'),
  ('Julia Sánchez', '1994-09-08', 'Guayaquil, Portete y la 36', '0952245678', 'juli_1994@gmail.com', 'foto_JS.jpg', 'Bachillerato Técnico'),
  ('Elena Romero', '1996-12-18', 'Guayaquil, Av. Quito y Capitán Nájera', '0952267890', 'elenaromero@hotmail.com', 'foto_ER.jpg', 'Bachillerato Técnico'),
  ('Patricia Vargas', '1999-04-22','Guayaquil, Guasmo Norte', '0952201294', 'patricia_vargas@gmail.com', 'foto_PV.jpg', 'Bachillerato General Unificado'),
  ('Isabel Solis', '1997-01-28', 'Guayaquil, 9 de Octubre y Esmeraldas', '0952223406', '97isabel@hotmail.com', 'foto_IS.jpg', 'Bachillerato en Ciencias'),
  ('Fernanda Zamorano', '2000-01-12', 'Guayaquil, Alborada 5ta etapa', '0952294560', 'fer12zambrano@gmail.com', 'foto_FZ.jpg', 'Bachillerato Técnico');

  SELECT * FROM datosPersonales;