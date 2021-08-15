// ** Ilk Fonksiyon Tanımlamak:

function helloWorld(){
    console.log("Merhaba")
}

// function hello(){
//     console.log("Hello")
//     helloWorld()
// } 
helloWorld() //Çalıştırnayı sağlar


// ********** Fonksiyonlara Parametreler Atamak ve Fonksiyondan Dönüş Almak **********

// Temel Kurallar:
// 1: Bir Fonksiyon Bir veya Birden Fazla Parametre Alabilir veya Hiç Parametre Almayabilir.
// 2: Bir Fonksiyon Dışarı Bilgi Gönderebilir(return) veya Göndermeyebilir
// 3: Mümkün oldukça Fonksiyonun Bağımlılıklarını Azaltmak Gerekir.

let firstName = "Lorem";

function greetings(firstName="", lastName="") { // default parametre aliyor..
    // console.log(`Merhaba ${firstName ? firstName : ""}`)
    // console.log(`Merhaba ${firstName}`)
    console.log(`Merhaba ${firstName} ${lastName}`);
} 

console.log(firstName) // degisken;
greetings() // fonksiyona parametre gondermedik ??;
greetings("Parametre");

function greetings2(firstName, lastName) {
    let info = `Merhaba ${firstName} ${lastName}`;
    return info;
}

let greetingsInfo = greetings2("Ad", "Soyad");
// let info = "deneme" // ?????
console.log(greetingsInfo);

/* function domIdWriteInfo(id, info) {
    let domObject = document.querySelector(`#${id}`);
    domObject.innerHTML = info;
}

let htmlInfo = `<span style="color:red">Color REDDDD</span>`;

domIdWriteInfo('greeting', htmlInfo);
domIdWriteInfo('info', greetings2("Lorem", "Ipsum"));
 */

// Arrow function Kullanimi
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Arrow_functions

const helloFuncV1 = (firstName) => { console.log(`Merhaba ${firstName}`) }; 
helloFuncV1("helloFuncV1");


const helloFuncV2 = firstName => console.log(`Merhaba ${firstName}`); // bir parametre, bir dönüş işlemi
helloFuncV2("helloFuncV2");


const helloFuncV3 = (firstName, lastName) => console.log(
    `Merhaba ${firstName} ${lastName}`
) // console.log parantezi

helloFuncV3("helloFuncV3", "Last Name info");

const helloFuncV4 = (firstName, lastName) => {
    let info = `Merhaba ${firstName} ${lastName}`;
    console.log(info);
    return info;
}



// Functions Bolum Sonu Egzersizi

let counter = 0
let counterDOM = document.querySelector('#counter')
let increaseDOM = document.querySelector('#increase')
let decreaseDOM = document.querySelector('#decrease')

counterDOM.innerHTML = counter

increaseDOM.addEventListener("click", clickEvent)
decreaseDOM.addEventListener("click", clickEvent)

function clickEvent() {
    console.log(this.id)
    this.id == "increase" ?  counter += 1 : counter -= 1
    counterDOM.innerHTML = counter
}

helloFuncV4("helloFuncV4", "Other Info");

// DOM Etkinlikleriyle Calismak
// https://www.w3schools.com/jsref/dom_obj_event.asp
// https://developer.mozilla.org/en-US/docs/Web/Events

let greet = document.querySelector("#greeting");
greeting.addEventListener("click", domClick);
function domClick(){
    console.log("etkinlik denetlendi")
    this.style.color == "red" ? this.style.color = "black" : this.style.color = "red"
}