CREATE DATABASE filmek;
USE filmek;

CREATE TABLE film(
filmid INT PRIMARY KEY IDENTITY,
cim VARCHAR(100) NOT NULL,
megjeve INT NOT NULL,
korhatar  INT NOT NULL,
hossz INT NOT NULL,
borito VARCHAR(100) NOT NULL
);

CREATE TABLE mufajok(
mufaj VARCHAR(100) NOT NULL,
filmid INT FOREIGN KEY REFERENCES film
);
-- A filmeket valamiért csak egyesével tudtam feltölteni.
INSERT INTO film VALUES 
('Star Wars IV. rész – Egy új remény', 1977, 12, 121, 'ANEWHOPE.PNG');
('Star Wars V. rész – A Birodalom visszavág', 1980, 12, 124, 'THEEMPIRESTRIKESBACK.PNG');
('Star Wars VI. rész – A Jedi visszatér', 1983, 12, 131, 'RETURNOFTHEJEDI.PNG');
('Star Wars I. rész - Baljós árnyak', 1999, 0, 136, 'THEPHANTOMMENACE');
('Star Wars II. rész - A klónok támadása' ,2002 ,0, 142, 'ATTACKOFTHECLONES.PNG');
('Star Wars III. rész - A Sith-ek bosszúja', 2005, 0, 140, 'REVENGEOFTHESITH.PNG');
('Star Wars: Az utolsó Jedik', 2017, 12, 152, 'THELASTJEDI.PNG');
('Star Wars: Az ébredő Erő', 2015, 12, 138, 'THEFORCEAWAKENS.PNG');
('Star Wars: Skywalker kora', 2019, 12, 141, 'THERISEOFSKYWALKER.PNG');
('Zsivány Egyes: Egy Star Wars-történet', 2016, 12, 133, 'ROUGEONE.PNG');
('Solo: Egy Star Wars-történet', 2018, 12, 135, 'SOLO.PNG');
('Star Wars: A klónok háborúja', 2008, 12, 98, 'CLONEWARS.PNG');

INSERT INTO mufajok VALUES
('akció',1),
('akció',2),
('akció',3),
('akció',4),
('akció',5),
('akció',6),
('akció',7),
('akció',8),
('akció',9),
('akció',10),
('akció',11),
('akció',12),
('kaland',1),
('kaland',2),
('kaland',3),
('kaland',4),
('kaland',5),
('kaland',6),
('kaland',7),
('kaland',8),
('kaland',9),
('kaland',10),
('kaland',11),
('kaland',12),
('sci-fi',1),
('sci-fi',2),
('sci-fi',3),
('sci-fi',4),
('sci-fi',5),
('sci-fi',6),
('sci-fi',7),
('sci-fi',8),
('sci-fi',9),
('sci-fi',10),
('sci-fi',11),
('animációs',12);