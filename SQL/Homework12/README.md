#### 1.film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
```sql 
SELECT COUNT(*) FROM Film WHERE length > (SELECT AVG(length) FROM Film);

``` 

#### 2.film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?
```sql 
SELECT COUNT(*) FROM Film WHERE rental_rate = any (SELECT max(rental_rate) FROM Film);
``` 

#### 3.film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.
```sql 
SELECT COUNT(*) FROM Film WHERE rental_rate = all (SELECT min(rental_rate) FROM Film) and replacement_cost = any (SELECT min(replacement_cost) FROM Film);
``` 


#### 4.Payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.
```sql 
SELECT customer_id, count(payment_id) "Alışveriş Toplamı" FROM payment GROUP BY customer_id ORDER BY "Alışveriş Toplamı" DESC
``` 

