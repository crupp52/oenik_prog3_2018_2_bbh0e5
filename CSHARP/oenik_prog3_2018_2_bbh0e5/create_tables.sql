/*Create tables*/
CREATE TABLE Creators(
	creator_id NUMERIC(20) not null,
	creator_name varchar(30),
	creator_email varchar(70),
	creator_birth_date DATETIME,
	creator_premium NUMERIC(1),
	CONSTRAINT creators_pk PRIMARY KEY(creator_id)
);

CREATE TABLE Categories(
	category_id NUMERIC(20) not null,
	category_name varchar(30),
	category_adult NUMERIC(1),
	CONSTRAINT categories_pk PRIMARY KEY(category_id)
);

CREATE TABLE Videos(
	video_id NUMERIC(20) not null,
	video_title varchar(255) not null,
	video_description varchar(255),
	creator_id NUMERIC(20) not null,
	category_id NUMERIC(20) not null,
	CONSTRAINT videos_pk PRIMARY KEY(video_id),
	CONSTRAINT creator_vid_fk FOREIGN KEY(creator_id) REFERENCES Creators(creator_id),
	CONSTRAINT category_vid_fk FOREIGN KEY(category_id) REFERENCES Categories(category_id)
);

CREATE TABLE Uploads(
	upload_id NUMERIC(20) not null,
	upload_date DATETIME,
	video_id NUMERIC(20) not null,
	creator_id NUMERIC(20) not null,
	CONSTRAINT uploads_pk PRIMARY KEY(upload_id),
	CONSTRAINT video_upl_fk FOREIGN KEY(video_id) REFERENCES Videos(video_id),
	CONSTRAINT creator_upl_fk FOREIGN KEY(creator_id) REFERENCES Creators(creator_id)
);