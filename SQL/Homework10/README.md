#### 1.city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
```sql 
SELECT city.city, country.country FROM city LEFT JOIN country on city.country_id = country.country_id
``` 

#### 2.customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
```sql 
SELECT payment.payment_id, customer.first_name, customer.last_name FROM customer RIGHT JOIN payment on customer.customer_id = payment.customer_id;
``` 

#### 3.customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
```sql 
SELECT rental.rental_id, customer.first_name, customer.last_name FROM rental FULL JOIN customer on rental.customer_id = customer.customer_id
``` 


