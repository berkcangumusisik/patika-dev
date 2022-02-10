#### 1.film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.
```sql 
SELECT DISTINCT replacement_cost FROM film;
``` 

#### 2.film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
```sql 
SELECT COUNT(DISTINCT replacement_cost) FROM film;
``` 

#### 3.film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
```sql 
SELECT COUNT(title) FROM film WHERE LIKE 'T%' AND rating = 'G';
``` 

#### 4.country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
```sql 
SELECT COUNT(country) FROM country LENGTH(country) = 5;
``` 

#### 5.city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
```sql 
SELECT COUNT(city) FROM city WHERE city ILIKE 'r%';
``` 