﻿/*CRETORS TABLE*/
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (1, 'AVA JACKSON', 'AVA.JACKSON18@EXAMPLE.COM', '1980-10-06' , 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (2, 'BEN KUHN', 'BEN.KUHN39@EXAMPLE.COM', '1970-10-27', 1);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (3, 'BELLA GORDON', 'BELLA.GORDON33@EXAMPLE.COM', '1971-09-01', 1);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (4, 'ISOBEL HANSEN', 'ISOBEL.HANSEN75@EXAMPLE.COM', '1975-03-13', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (5, 'JOSE CHAPMAN', 'JOSE.CHAPMAN13@EXAMPLE.COM', '1977-01-11', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (6, 'LAURIE GEORGE', 'LAURIE.GEORGE14@EXAMPLE.COM', '1977-07-13', 1);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (7, 'FRANCES ALEXANDER', 'FRANCES.ALEXANDER96@EXAMPLE.COM', '1979-05-22', 1);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (8, 'ANN COX', 'ANN.COX66@EXAMPLE.COM', '1981-02-10', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (9, 'ALVIN MARTINEZ', 'ALVIN.MARTINEZ54@EXAMPLE.COM', '1981-09-09', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (10, 'TERRANCE ROBERTSON', 'TERRANCE.ROBERTSON11@EXAMPLE.COM', '1981-10-01', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (11, 'CONSTANCE OBRIEN', 'CONSTANCE.OBRIEN89@EXAMPLE.COM', '1982-02-24', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (12, 'EVA MONTGOMERY', 'EVA.MONTGOMERY85@EXAMPLE.COM', '1984-09-14', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (13, 'JACK SILVA', 'JACK.SILVA33@EXAMPLE.COM', '1986-05-22', 1);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (14, 'MARCUS FRANKLIN', 'MARCUS FRANKLIN', '1986-10-27', 0);
INSERT INTO CREATORS (CREATOR_ID, CREATOR_NAME, CREATOR_EMAIL, CREATOR_BIRTH_DATE, CREATOR_PREMIUM)
VALUES (15, 'SOFIA BISHOP', 'SOFIA.BISHOP21@EXAMPLE.COM', '1987-07-16', 0);

/*CATEGORIES TABLE*/
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (31, 'FILM AND ANIMATION', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (32, 'COMEDY', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (33, 'EDUCATION', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (34, 'ENTERTAINMENT', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (35, 'CARS AND VEHICLES', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (36, 'GAMING', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (37, 'THRILLER', 1);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (38, 'HORROR', 1);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (39, 'FOREIGN', 1);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (310, 'VIDEOBLOGGING', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (311, 'HOWTO AND STYLE', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (312, 'MOVIES', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (313, 'NONPROFITS AND ACTIVISM', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (314, 'FAMILY', 0);
INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME, CATEGORY_ADULT)
VALUES (315, 'DRAMA', 0);

/*VIDEOS TABLE*/
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (61, 'LECSAPOLT ÓCEÁN - 1. RÉSZ', 'NATGEO TV - EREDETI SOROZAT', 18321, 33);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (62, 'LECSAPOLT ÓCEÁN - 2. RÉSZ', 'NATGEO TV - EREDETI SOROZAT', 41423, 33);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (63, 'LECSAPOLT ÓCEÁN - 3. RÉSZ', 'NATGEO TV - EREDETI SOROZAT', 42431, 33);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (64, 'LECSAPOLT ÓCEÁN - 4. RÉSZ', 'NATGEO TV - EREDETI SOROZAT', 7432, 33);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (65, 'LECSAPOLT ÓCEÁN - 5. RÉSZ', 'NATGEO TV - EREDETI SOROZAT', 31231, 33);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (66, 'VENOM - ELŐZETES 2018', 'VENOM - ELŐZETES 2018', 57843, 31);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (67, 'GET OUT (2017)', 'EGÉSZ ESTÉS HORROR FILM', 73273, 38);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (68, 'PSYCHO (1960)', 'KLASSZIKUS HORROR, A LEGJOBBAK KÖZÖTT VAN!', 63260, 37);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (69, 'KING KONG (1933)', 'KLASSZIKUS HORROR, A LEGJOBBAK KÖZÖTT VAN!', 547834, 38);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (610, 'ULTIMATE CRASH TEST', 'SERIES 3 (2003)', 32100, 35);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (611, 'CARS 1', 'EGÉSZ ESTÉS CSALÁDI ANIMÁCIÓSFILM', 323688, 314);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (612, 'CARS 2', 'EGÉSZ ESTÉS CSALÁDI ANIMÁCIÓSFILM', 976042, 314);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (613, 'CARS 3', 'EGÉSZ ESTÉS CSALÁDI ANIMÁCIÓSFILM', 1000334, 314);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (614, 'SHOWDER KLUB S09E01', 'A TV ADÁS RÖGZÍTETT MÁSOLATA.', 432100, 34);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (615, 'SHOWDER KLUB S09E02', 'A TV ADÁS RÖGZÍTETT MÁSOLATA.', 300021, 34);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (616, 'SHOWDER KLUB S09E03', 'A TV ADÁS RÖGZÍTETT MÁSOLATA.', 435010, 34);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (617, 'ROAD TO FORTNITE PRO', 'I KNOW I AM BAD...', 10523986, 36);
INSERT INTO VIDEOS (VIDEO_ID, VIDEO_TITLE, VIDEO_DESCRIPTION, VIDEO_VIEWS, CATEGORY_ID)
VALUES (618, 'FORTNITE ALL DANCES SEASON 1 TO 4', 'FORTNITE ALL DANCES SEASON 1 TO 4', 36234701, 36);

/*UPLOADS TABLE*/
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (1, '2009-02-27', 61, 9);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (2, '2009-03-31', 62, 9);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (3, '2009-07-31', 63, 9);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (4, '2009-11-15', 64, 9);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (5, '2010-02-27', 65, 9);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (6, '2011-05-08', 66, 3);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (7, '2011-06-27', 67, 1);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (8, '2012-01-12', 68, 2);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (9, '2012-04-05', 69, 2);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (10, '2012-12-08', 610, 15);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (11, '2013-07-09', 611, 13);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (12, '2014-01-31', 612, 12);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (13, '2014-10-25', 613, 11);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (14, '2016-07-27', 614, 10);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (15, '2016-10-12', 615, 10);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (16, '2017-02-19', 616, 10);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (17, '2018-03-17', 617, 6);
INSERT INTO UPLOADS (UPLOAD_ID, UPLOAD_DATE, VIDEO_ID, CREATOR_ID)
VALUES (18, '2018-09-09', 618, 6);