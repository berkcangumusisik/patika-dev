// Local Storage:
// https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage


// localStorage içerisine bilgi kaydetmek:
let email = "gumusisikberkcan@gmail.com";
localStorage.setItem('userEmail', email); // -> anahtar, değer yapısı kullanılır(key, value)

// localStorage içerisindeki bilgiyi bir değişkene atamak ve çağırmak:
let localStorageEMailInfo = localStorage.getItem('userEmail'); // daha önce atadigimiz anahtar bilgisi

console.log(localStorageEMailInfo);

// localStorage içerisinden istenilen Key bilgisinin silinmesi:
localStorage.removeItem('userEmail') ;// key bilgisini yazarak silebiliriz..

// Local Storage Islemleri:
// Eger tutacagimiz bilgi object ise JSON.stringify ile objeyi string yapıya çevirebiliriz.

let user = {userName: "berkcanGümüşışık", isActive: true};
console.log(user);
localStorage.setItem('userInfo', JSON.stringify(user) );


let userInfo = localStorage.getItem('userInfo'); // bilgiyi al
userInfo = JSON.parse(userInfo);
console.log(userInfo);


// 2. egzersiz:
let items = [1,2,3, user];
// localStorage.setItem('newItems', items) // hatali :(
localStorage.setItem('newItems', JSON.stringify(items));

let newItems = JSON.parse( localStorage.getItem('newItem') ); //JSON Parse ile localStorage icindeki bilginin cekilip kullanilmasi..

// localStorage Bolum Sonu Egzersizi

let counter = localStorage.getItem('counter') ? Number(localStorage.getItem('counter')) : 0;
let counterDOM = document.querySelector('#counter');
let increaseDOM = document.querySelector('#increase');
let decreaseDOM = document.querySelector('#decrease');

counterDOM.innerHTML = counter

increaseDOM.addEventListener("click", clickEvent);
decreaseDOM.addEventListener("click", clickEvent);

function clickEvent() {
    this.id == "increase" ?  counter += 1 : counter -= 1;
    localStorage.setItem('counter', counter);
    counterDOM.innerHTML = counter;
}