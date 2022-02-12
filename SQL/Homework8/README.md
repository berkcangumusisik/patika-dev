#### 1.test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
```sql 
CREATE TABLE employee 
      (
	id INTEGER,
	name VARCHAR(50),
	birthday DATE,
	email VARCHAR(100)
	
       )
``` 

#### 2.Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
```sql 
INSERT INTO employee (id, name, birthday, email) VALUES (1, 'Jens', '3/31/2021', 'jnicklinson0@about.com');
INSERT INTO employee (id, name, birthday, email) VALUES (2, 'Herta', '6/24/2021', 'hzini1@sitemeter.com');
INSERT INTO employee (id, name, birthday, email) VALUES (3, 'Alica', '6/8/2021', 'aruppelin2@google.nl');
INSERT INTO employee (id, name, birthday, email) VALUES (4, 'Latrina', '9/17/2021', 'lbruyett3@oracle.com');
INSERT INTO employee (id, name, birthday, email) VALUES (5, 'Robinetta', '6/22/2021', 'rknipe4@yelp.com');
INSERT INTO employee (id, name, birthday, email) VALUES (6, 'Innis', '11/20/2021', 'ifenna5@hostgator.com');
INSERT INTO employee (id, name, birthday, email) VALUES (7, 'Daryl', '11/10/2021', 'dmerlin6@webeden.co.uk');
INSERT INTO employee (id, name, birthday, email) VALUES (8, 'Janos', '9/23/2021', 'jbadham7@ask.com');
INSERT INTO employee (id, name, birthday, email) VALUES (9, 'Corabelle', '12/27/2021', 'cstrangwood8@dot.gov');
INSERT INTO employee (id, name, birthday, email) VALUES (10, 'Quincey', '8/28/2021', 'qdeboo9@ning.com');
INSERT INTO employee (id, name, birthday, email) VALUES (11, 'Arliene', '11/28/2021', 'ageistbecka@ed.gov');
INSERT INTO employee (id, name, birthday, email) VALUES (12, 'Kizzee', '12/21/2021', 'kmacgaughyb@techcrunch.com');
INSERT INTO employee (id, name, birthday, email) VALUES (13, 'Byrann', '4/5/2021', 'bantoniouc@fda.gov');
INSERT INTO employee (id, name, birthday, email) VALUES (14, 'Teodora', '8/6/2021', 'tbezantsd@skype.com');
INSERT INTO employee (id, name, birthday, email) VALUES (15, 'Hilary', '10/20/2021', 'hstuttmane@state.gov');
INSERT INTO employee (id, name, birthday, email) VALUES (16, 'Shanon', '6/19/2021', 'smiddlewickf@sitemeter.com');
INSERT INTO employee (id, name, birthday, email) VALUES (17, 'Devin', '10/10/2021', 'dosgarg@linkedin.com');
INSERT INTO employee (id, name, birthday, email) VALUES (18, 'Marcus', '7/16/2021', 'mporkerh@princeton.edu');
INSERT INTO employee (id, name, birthday, email) VALUES (19, 'Karolina', '8/18/2021', 'ksadleri@jalbum.net');
INSERT INTO employee (id, name, birthday, email) VALUES (20, 'Thorsten', '9/20/2021', 'tprosekj@ow.ly');
INSERT INTO employee (id, name, birthday, email) VALUES (21, 'Harri', '4/5/2021', 'hravenhillk@japanpost.jp');
INSERT INTO employee (id, name, birthday, email) VALUES (22, 'Vally', '5/29/2021', 'vyurinovl@storify.com');
INSERT INTO employee (id, name, birthday, email) VALUES (23, 'Emanuele', '7/24/2021', 'edrainm@issuu.com');
INSERT INTO employee (id, name, birthday, email) VALUES (24, 'Roddie', '8/22/2021', 'rogersn@merriam-webster.com');
INSERT INTO employee (id, name, birthday, email) VALUES (25, 'Row', '2/2/2022', 'rfortyo@latimes.com');
INSERT INTO employee (id, name, birthday, email) VALUES (26, 'Niki', '9/22/2021', 'nkalinskyp@digg.com');
INSERT INTO employee (id, name, birthday, email) VALUES (27, 'Tobe', '6/22/2021', 'tdenslowq@nasa.gov');
INSERT INTO employee (id, name, birthday, email) VALUES (28, 'Zarah', '2/2/2022', 'zmitskevichr@sbwire.com');
INSERT INTO employee (id, name, birthday, email) VALUES (29, 'Ferdinanda', '4/20/2021', 'fschruyers@macromedia.com');
INSERT INTO employee (id, name, birthday, email) VALUES (30, 'Silvanus', '11/12/2021', 'shigginbottamt@shareasale.com');
INSERT INTO employee (id, name, birthday, email) VALUES (31, 'Frederick', '10/20/2021', 'faustonu@booking.com');
INSERT INTO employee (id, name, birthday, email) VALUES (32, 'Francis', '5/3/2021', 'fpearmainv@i2i.jp');
INSERT INTO employee (id, name, birthday, email) VALUES (33, 'Eula', '1/9/2022', 'etadloww@dmoz.org');
INSERT INTO employee (id, name, birthday, email) VALUES (34, 'Sean', '7/9/2021', 'ssweedx@ehow.com');
INSERT INTO employee (id, name, birthday, email) VALUES (35, 'Vivianne', '8/27/2021', 'valdgatey@domainmarket.com');
INSERT INTO employee (id, name, birthday, email) VALUES (36, 'Yves', '2/8/2022', 'ysongerz@ycombinator.com');
INSERT INTO employee (id, name, birthday, email) VALUES (37, 'Byran', '11/12/2021', 'bhebbron10@hexun.com');
INSERT INTO employee (id, name, birthday, email) VALUES (38, 'Chev', '4/8/2021', 'chaliburton11@spotify.com');
INSERT INTO employee (id, name, birthday, email) VALUES (39, 'Layne', '8/7/2021', 'lfontes12@topsy.com');
INSERT INTO employee (id, name, birthday, email) VALUES (40, 'Heddi', '8/18/2021', 'hskittrell13@kickstarter.com');
INSERT INTO employee (id, name, birthday, email) VALUES (41, 'Say', '9/12/2021', 'smcdougle14@elegantthemes.com');
INSERT INTO employee (id, name, birthday, email) VALUES (42, 'Gabi', '11/8/2021', 'glaflin15@abc.net.au');
INSERT INTO employee (id, name, birthday, email) VALUES (43, 'Flossy', '11/5/2021', 'fdeave16@icio.us');
INSERT INTO employee (id, name, birthday, email) VALUES (44, 'Catherine', '9/14/2021', 'chugill17@nytimes.com');
INSERT INTO employee (id, name, birthday, email) VALUES (45, 'Virgil', '6/26/2021', 'vupward18@vk.com');
INSERT INTO employee (id, name, birthday, email) VALUES (46, 'Maybelle', '4/15/2021', 'mcrotty19@mlb.com');
INSERT INTO employee (id, name, birthday, email) VALUES (47, 'Craig', '4/3/2021', 'cacklands1a@acquirethisname.com');
INSERT INTO employee (id, name, birthday, email) VALUES (48, 'Deb', '2/27/2021', 'drichards1b@webeden.co.uk');
INSERT INTO employee (id, name, birthday, email) VALUES (49, 'Traci', '10/8/2021', 'tcurgenuer1c@wired.com');
INSERT INTO employee (id, name, birthday, email) VALUES (50, 'De witt', '9/3/2021', 'ddare1d@themeforest.net');

``` 
#### 3.Sütunların her birine göre diğer sütunları güncelleyecek 5 adet update işlemi yapalım.
```sql 
UPDATE employee SET name = 'Berkcan' WHERE id = 8;
UPDATE employee SET birthday = '1999-12-04' WHERE id = 8;
UPDATE employee SET email = 'example@email.com' WHERE name = 'Berkcan';
UPDATE employee SET birthday = '1998-11-14' WHERE name = 'De witt';
UPDATE employee SET name = 'Ahmet' WHERE email = 'tcurgenuer1c@wired.com';
``` 

#### 4.Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
```sql 
DELETE FROM employee WHERE id = 7;
DELETE FROM employee WHERE name = 'Berkcan';
DELETE FROM employee WHERE birthday = '9-3-2021';
DELETE FROM employee WHERE email = 'chugill17@nytimes.com';
DELETE FROM employee WHERE birthday = '2-27-2021';
``` 