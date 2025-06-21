# PruebaTecnicaPodcast

Consultas generdas en SQL

CREATE DATABASE Podcast

USE Podcast

CREATE TABLE Episodio(
IdEpisodio INT IDENTITY(1,1) PRIMARY KEY,
NumeroEpisodio VARCHAR(10) NOT NULL
)

CREATE TABLE Idioma(
IdIdioma INT IDENTITY(1,1) PRIMARY KEY,
Idioma VARCHAR(20) NOT NULL
)

CREATE TABLE Categoria(
IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
Categoria VARCHAR(20) NOT NULL
)

CREATE TABLE Imagen(
IdImagen INT IDENTITY(1,1) PRIMARY KEY,
Imagen VARBINARY(MAX) NULL
)

CREATE TABLE Podcast(
IdPodcast INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(100) NOT NULL,
IdEpisodio INT FOREIGN KEY REFERENCES Episodio(IdEpisodio) NOT NULL,
Descripcion VARCHAR(500) NULL,
FechaDePublicacion DATE NOT NULL,
FechaDeCaducidad DATE NOT NULL,
AudioURL VARCHAR(500) NOT NULL,
IdCategoria INT FOREIGN KEY REFERENCES Categoria(IdCategoria) NOT NULL,
IdImagen INT FOREIGN KEY REFERENCES Imagen(IdImagen) NULL,
Duracion INT NOT NULL,
IdIdioma INT FOREIGN KEY REFERENCES Idioma(IdIdioma) NOT NULL
)



INSERT INTO Episodio (NumeroEpisodio) 
VALUES ('EP-1'),
('EP-2'),
('EP-3'),
('EP-4'),
('EP-5'),
('EP-6'),
('EP-7'),
('EP-8'),
('EP-9'),
('EP-10')

INSERT INTO Idioma(Idioma)
VALUES('Español'),
('Ingles'),
('Portugues'),
('Frances'),
('Aleman'),
('Chino Mandarin'),
('Japones'),
('Ruso')

INSERT INTO Categoria(Categoria)
VALUES
('Terror'),
('entretenimiento'),
('ficción'),
('Comedia'),
('Música'),
('Cine y TV'),
('Ciencia'),
('Educación'),
('Tecnología'),
('Deportes')

INSERT INTO Imagen(Imagen)
VALUES
(0),
(0),
(0),
(0),
(0),
(0),

SELECT * FROM Imagen
SELECT * FROM Podcast
UPDATE Podcast SET IdImagen = 6
WHERE IdPodcast = 22
INSERT INTO Podcast(Nombre, IdEpisodio, Descripcion, FechaDePublicacion, FechaDeCaducidad, 
AudioURL, IdCategoria, IdImagen, Duracion, IdIdioma)
VALUES
('Fantasmas y Demonios en la Morgue | Relatos Siniestros de la Morgue', 1, '¿Qué secretos aterradores esconden las morgues? En este episodio de Extra Anormal Podcast, Paco Arias conversa con 
Jorge Riverón, quien comparte relatos espeluznantes de fantasmas y demonios que acechan en la soledad fría de las morgues.', '2024-06-10', '2025-07-15', 'https://youtu.be/PB_GFlBJ4fg?si=smzEHuoZraC6BnAm', 10, 1, 81, 1),
('Fantasmas y Demonios en la Morgue | Relatos Siniestros de la Morgue', 2, '¿Qué secretos aterradores esconden las morgues? En este episodio de Extra Anormal Podcast, Paco Arias conversa con 
Jorge Riverón, quien comparte relatos espeluznantes de fantasmas y demonios que acechan en la soledad fría de las morgues.', '2024-06-11', '2025-07-16', 'https://youtu.be/PB_GFlBJ4fg?si=smzEHuoZraC6BnAm', 10, 1, 65, 1),
('Fantasmas y Demonios en la Morgue | Relatos Siniestros de la Morgue', 3, '¿Qué secretos aterradores esconden las morgues? En este episodio de Extra Anormal Podcast, Paco Arias conversa con 
Jorge Riverón, quien comparte relatos espeluznantes de fantasmas y demonios que acechan en la soledad fría de las morgues.', '2024-06-12', '2025-07-17', 'https://youtu.be/PB_GFlBJ4fg?si=smzEHuoZraC6BnAm', 10, 1, 96, 1),
('Fantasmas y Demonios en la Morgue | Relatos Siniestros de la Morgue', 4, '¿Qué secretos aterradores esconden las morgues? En este episodio de Extra Anormal Podcast, Paco Arias conversa con 
Jorge Riverón, quien comparte relatos espeluznantes de fantasmas y demonios que acechan en la soledad fría de las morgues.', '2024-06-13', '2025-07-18', 'https://youtu.be/PB_GFlBJ4fg?si=smzEHuoZraC6BnAm', 10, 1, 105, 1),

('Historias Siniestras en Centros Comerciales y Tiendas de Autoservicio', 1, 'En este episodio de Extra Anormal Podcast, Paco Arias junto a Mariana Corcas exploran los pasillos más sinistros de 
centros comerciales y tiendas de autoservicio donde empleados y clientes han vivido encuentros sobrenaturales.', '2024-10-22', '2025-08-20', 'https://youtu.be/WARSTmaIlh0?si=VErxBTmf8xkaXUMW', 10, 1, 96, 1),
('Historias Siniestras en Centros Comerciales y Tiendas de Autoservicio', 2, 'En este episodio de Extra Anormal Podcast, Paco Arias junto a Mariana Corcas exploran los pasillos más sinistros de 
centros comerciales y tiendas de autoservicio donde empleados y clientes han vivido encuentros sobrenaturales.', '2024-10-23', '2025-08-21', 'https://youtu.be/WARSTmaIlh0?si=VErxBTmf8xkaXUMW', 10, 1, 76, 1),
('Historias Siniestras en Centros Comerciales y Tiendas de Autoservicio', 3, 'En este episodio de Extra Anormal Podcast, Paco Arias junto a Mariana Corcas exploran los pasillos más sinistros de 
centros comerciales y tiendas de autoservicio donde empleados y clientes han vivido encuentros sobrenaturales.', '2024-10-24', '2025-08-21', 'https://youtu.be/WARSTmaIlh0?si=VErxBTmf8xkaXUMW', 10, 1, 87, 1),
('Historias Siniestras en Centros Comerciales y Tiendas de Autoservicio', 4, 'En este episodio de Extra Anormal Podcast, Paco Arias junto a Mariana Corcas exploran los pasillos más sinistros de 
centros comerciales y tiendas de autoservicio donde empleados y clientes han vivido encuentros sobrenaturales.', '2024-10-25', '2025-08-23', 'https://youtu.be/WARSTmaIlh0?si=VErxBTmf8xkaXUMW', 10, 1, 112, 1),
('Historias Siniestras en Centros Comerciales y Tiendas de Autoservicio', 5, 'En este episodio de Extra Anormal Podcast, Paco Arias junto a Mariana Corcas exploran los pasillos más sinistros de 
centros comerciales y tiendas de autoservicio donde empleados y clientes han vivido encuentros sobrenaturales.', '2024-10-26', '2025-08-24', 'https://youtu.be/WARSTmaIlh0?si=VErxBTmf8xkaXUMW', 10, 1, 120, 1),

('La Cotorrisa - Franco Escamilla', 1, 'Feliz navidad cotorros, les dejamos este episodio adelantado para que lo reciban de regalo en su arbolito, tuvimos el inmenso placer de grabar con Franco Escamilla y 
resultó ser un episodio inolvidable. Disfruten que todo es para ustedes.', '2024-10-13', '2025-05-15', 'https://youtu.be/qxDNGjdgyx4?si=NPrdZRCLPYezLwoK', 3, 1, 102, 2),
('La Cotorrisa - Franco Escamilla', 2, 'Feliz navidad cotorros, les dejamos este episodio adelantado para que lo reciban de regalo en su arbolito, tuvimos el inmenso placer de grabar con Franco Escamilla y 
resultó ser un episodio inolvidable. Disfruten que todo es para ustedes.', '2024-10-15', '2025-05-20', 'https://youtu.be/qxDNGjdgyx4?si=NPrdZRCLPYezLwoK', 3, 1, 112, 2),
('La Cotorrisa - Franco Escamilla', 3, 'Feliz navidad cotorros, les dejamos este episodio adelantado para que lo reciban de regalo en su arbolito, tuvimos el inmenso placer de grabar con Franco Escamilla y 
resultó ser un episodio inolvidable. Disfruten que todo es para ustedes.', '2024-10-17', '2025-10-29', 'https://youtu.be/qxDNGjdgyx4?si=NPrdZRCLPYezLwoK', 3, 1, 98, 2),

('La Cotorrisa - Asalté a mi mamá en el camión', 1, 'Les dejamos este episodio tan embarazoso en el que un juven asalta a su propria mama en el camion', '2025-02-12', '2025-11-1', 'https://youtu.be/AVtckEWxAus?si=vkwo55N2S7xUZ9ZD', 4, 1, 67, 2),
('La Cotorrisa - Asalté a mi mamá en el camión', 2, 'Les dejamos este episodio tan embarazoso en el que un juven asalta a su propria mama en el camion', '2025-02-13', '2025-11-2', 'https://youtu.be/AVtckEWxAus?si=vkwo55N2S7xUZ9ZD', 4, 1, 98, 2),
('La Cotorrisa - Asalté a mi mamá en el camión', 3, 'Les dejamos este episodio tan embarazoso en el que un juven asalta a su propria mama en el camion', '2025-02-14', '2025-11-3', 'https://youtu.be/AVtckEWxAus?si=vkwo55N2S7xUZ9ZD', 4, 1, 62, 2),
('La Cotorrisa - Asalté a mi mamá en el camión', 4, 'Les dejamos este episodio tan embarazoso en el que un juven asalta a su propria mama en el camion', '2025-02-15', '2025-11-4', 'https://youtu.be/AVtckEWxAus?si=vkwo55N2S7xUZ9ZD', 4, 1, 72, 2),

('Guía COMPLETA de INTELIGENCIA Artificial | JUAN LOMBANA en Cracks Podcast', 1, 'Este episodio es presentado por LegaLario la empresa de tecnología legal que ayuda a reducir costos y tiempos de 
gestión hasta un 80% y por Hospital Angeles Health System que cuenta con  el programa de cirugía robótica más robusto en el sector privado en México.', '2025-09-3', '2025-11-10', 'https://youtu.be/514L9I3yFN4?si=uDHCRAbWOrWcdCHQ', 10, 1, 80, 3),
('Guía COMPLETA de INTELIGENCIA Artificial | JUAN LOMBANA en Cracks Podcast', 2, 'Este episodio es presentado por LegaLario la empresa de tecnología legal que ayuda a reducir costos y tiempos de 
gestión hasta un 80% y por Hospital Angeles Health System que cuenta con  el programa de cirugía robótica más robusto en el sector privado en México.', '2025-09-4', '2025-11-15', 'https://youtu.be/514L9I3yFN4?si=uDHCRAbWOrWcdCHQ', 10, 1, 85, 3),


('Inmortalidad Tecnológica: Meta-Humanos, GPT5 y el Futuro de la IA (Dot CSV) #LFDE', 1, '¿Cuales son los verdaderos límites de la inteligencia artificial? ¿Donde acaban los humanos, y empiezan los robots? 
Estas son algunas de las preguntas que intentamos responder en este podcast con Carlos, ingeniero informático y experto en IA.', '2025-08-19', '2025-12-14', 'https://youtu.be/rbQ8_YvF-ko?si=76zwEqC-78ugZwqZ', 10, 1, 80, 4),
('Inmortalidad Tecnológica: Meta-Humanos, GPT5 y el Futuro de la IA (Dot CSV) #LFDE', 2, '¿Cuales son los verdaderos límites de la inteligencia artificial? ¿Donde acaban los humanos, y empiezan los robots? 
Estas son algunas de las preguntas que intentamos responder en este podcast con Carlos, ingeniero informático y experto en IA.', '2025-08-19', '2025-12-14', 'https://youtu.be/rbQ8_YvF-ko?si=76zwEqC-78ugZwqZ', 10, 1, 88, 4),
('Inmortalidad Tecnológica: Meta-Humanos, GPT5 y el Futuro de la IA (Dot CSV) #LFDE', 3, '¿Cuales son los verdaderos límites de la inteligencia artificial? ¿Donde acaban los humanos, y empiezan los robots? 
Estas son algunas de las preguntas que intentamos responder en este podcast con Carlos, ingeniero informático y experto en IA.', '2025-08-19', '2025-12-14', 'https://youtu.be/rbQ8_YvF-ko?si=76zwEqC-78ugZwqZ', 10, 1, 83, 4)

--Escribe la consulta SQL que recupere todos los podcasts vigentes que tengan más de un episodio
SELECT Podcast.Nombre, Podcast.FechaDeCaducidad FROM Podcast
WHERE GETDATE() < Podcast.FechaDeCaducidad

ESTE PROYECO HA SIDO CREADO CON .NET CORE CON ANGULAR DESDE VISUAL STUDIO POR LO QUE SOLO SE TENDRA QUE DESACARGAR EL PROYECTO Y EJECUTARLO PARA SU FUCNCIONAMIENTO

HACER UN NPM INSTALL PARA INSTALAR LAS DEPENDENCIAS
