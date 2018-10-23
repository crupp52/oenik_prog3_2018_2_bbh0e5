/*
DROP TABLE Uploads;
DROP TABLE Videos;
DROP TABLE Categories;
DROP TABLE Creators;
*/

/*Create tables*/
CREATE TABLE Creators(
	creator_id numeric(20) not null,
	creator_name varchar(30),
	creator_email varchar(70),
	creator_birth_date date,
	creator_premium numeric(1),
	CONSTRAINT creators_pk PRIMARY KEY(creator_id)
);

CREATE TABLE Categories(
	category_id numeric(20) not null,
	category_name varchar(30),
	category_adult numeric(1),
	CONSTRAINT categories_pk PRIMARY KEY(category_id)
);

CREATE TABLE Videos(
	video_id numeric(20) not null,
	video_title varchar(255) not null,
	video_description varchar(255),
	creator_id numeric(20) not null,
	category_id numeric(20) not null,
	CONSTRAINT videos_pk PRIMARY KEY(video_id),
	CONSTRAINT creator_vid_fk FOREIGN KEY(creator_id) REFERENCES Creators(creator_id),
	CONSTRAINT category_vid_fk FOREIGN KEY(category_id) REFERENCES Categories(category_id)
);

CREATE TABLE Uploads(
	upload_id numeric(20) not null,
	upload_date date,
	video_id numeric(20) not null,
	creator_id numeric(20) not null,
	CONSTRAINT uploads_pk PRIMARY KEY(upload_id),
	CONSTRAINT video_upl_fk FOREIGN KEY(video_id) REFERENCES Videos(video_id),
	CONSTRAINT creator_upl_fk FOREIGN KEY(creator_id) REFERENCES Creators(creator_id)
);

/*Cretors table*/
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (1, 'Ava Jackson', 'ava.jackson18@example.com', '1980-10-06' , 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (2, 'Ben Kuhn', 'ben.kuhn39@example.com', '1970-10-27', 1);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (3, 'Bella Gordon', 'bella.gordon33@example.com', '1971-09-01', 1);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (4, 'Isobel Hansen', 'isobel.hansen75@example.com', '1975-03-13', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (5, 'Jose Chapman', 'jose.chapman13@example.com', '1977-01-11', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (6, 'Laurie George', 'laurie.george14@example.com', '1977-07-13', 1);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (7, 'Frances Alexander', 'frances.alexander96@example.com', '1979-05-22', 1);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (8, 'Ann Cox', 'ann.cox66@example.com', '1981-02-10', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (9, 'Alvin Martinez', 'alvin.martinez54@example.com', '1981-09-09', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (10, 'Terrance Robertson', 'terrance.robertson11@example.com', '1981-10-01', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (11, 'Constance Obrien', 'constance.obrien89@example.com', '1982-02-24', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (12, 'Eva Montgomery', 'eva.montgomery85@example.com', '1984-09-14', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (13, 'Jack Silva', 'jack.silva33@example.com', '1986-05-22', 1);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (14, 'Marcus Franklin', 'Marcus Franklin', '1986-10-27', 0);
INSERT INTO Creators (creator_id, creator_name, creator_email, creator_birth_date, creator_premium)
VALUES (15, 'Sofia Bishop', 'sofia.bishop21@example.com', '1987-07-16', 0);

/*Categories table*/
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (31, 'Film and Animation', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (32, 'Comedy', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (33, 'Education', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (34, 'Entertainment', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (35, 'Cars and Vehicles', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (36, 'Gaming', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (37, 'Thriller', 1);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (38, 'Horror', 1);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (39, 'Foreign', 1);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (310, 'Videoblogging', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (311, 'Howto and Style', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (312, 'Movies', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (313, 'Nonprofits and Activism', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (314, 'Family', 0);
INSERT INTO Categories (category_id, category_name, category_adult)
VALUES (315, 'Drama', 0);

/*Videos table*/
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (61, 'Lecsapolt óceán - 1. rész', 'natgeo TV - Eredeti sorozat', 9, 33);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (62, 'Lecsapolt óceán - 2. rész', 'natgeo TV - Eredeti sorozat', 9, 33);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (63, 'Lecsapolt óceán - 3. rész', 'natgeo TV - Eredeti sorozat', 9, 33);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (64, 'Lecsapolt óceán - 4. rész', 'natgeo TV - Eredeti sorozat', 9, 33);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (65, 'Lecsapolt óceán - 5. rész', 'natgeo TV - Eredeti sorozat', 9, 33);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (66, 'Venom - Előzetes 2018', 'Venom - Előzetes 2018', 3, 31);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (67, 'GET OUT (2017)', 'Egész estés horror film', 1, 38);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (68, 'PSYCHO (1960)', 'Klasszikus horror, a legjobbak között van!', 2, 37);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (69, 'KING KONG (1933)', 'Klasszikus horror, a legjobbak között van!', 2, 38);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (610, 'Ultimate Crash Test', 'Series 3 (2003)', 15, 35);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (611, 'Cars 1', 'Egész estés családi animációsfilm', 13, 314);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (612, 'Cars 2', 'Egész estés családi animációsfilm', 12, 314);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (613, 'Cars 3', 'Egész estés családi animációsfilm', 11, 314);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (614, 'Showder Klub s09e01', 'A TV adás rögzített másolata.', 10, 34);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (615, 'Showder Klub s09e02', 'A TV adás rögzített másolata.', 10, 34);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (616, 'Showder Klub s09e03', 'A TV adás rögzített másolata.', 10, 34);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (617, 'ROAD TO FORTNITE PRO', 'I KNOW I AM BAD...', 6, 36);
INSERT INTO Videos (video_id, video_title, video_description, creator_id, category_id)
VALUES (618, 'Fortnite All Dances Season 1 to 4', 'Fortnite All Dances Season 1 to 4', 6, 36);

/*Uploads table*/
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (1, '2009-02-27', 61, 9);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (2, '2009-03-31', 62, 9);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (3, '2009-07-31', 63, 9);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (4, '2009-11-15', 64, 9);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (5, '2010-02-27', 65, 9);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (6, '2011-05-08', 66, 3);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (7, '2011-06-27', 67, 1);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (8, '2012-01-12', 68, 2);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (9, '2012-04-05', 69, 2);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (10, '2012-12-08', 610, 15);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (11, '2013-07-09', 611, 13);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (12, '2014-01-31', 612, 12);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (13, '2014-10-25', 613, 11);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (14, '2016-07-27', 614, 10);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (15, '2016-10-12', 615, 10);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (16, '2017-02-19', 616, 10);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (17, '2018-03-17', 617, 6);
INSERT INTO Uploads (upload_id, upload_date, video_id, creator_id)
VALUES (18, '2018-09-09', 618, 6);

/*Select tables*/
SELECT * FROM Videos;
SELECT * FROM Creators;
SELECT * FROM Categories;
SELECT * FROM Uploads;