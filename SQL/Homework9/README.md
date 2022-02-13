#### 1.city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
```sql 
SELECT city,country FROM city INNER JOIN country on city.country_id = country.country_id
``` 

#### 2.customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
```sql 
SELECT payment_id, first_name, last_name FROM customer INNER JOIN payment on customer.customer_id = payment.customer_id;
``` 

#### 3.customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
```sql 
SELECT rental_id, first_name, last_name FROM rental INNER JOIN customer on rental.customer_id = customer.customer_id
``` 


