// array - dizilerle calismak

// Dizi Oluşturmak 
let domain = "kodluyoruz";
let isActive = false;
let items = [15, 25, 35, isActive, domain];
console.log(items);

let emptyArray  = []; // boş liste

// Array içerisindeki öge sayısını öğrenme
console.log(items.length // array içindeki öge sayısına ulaşma 
);

// Array icindeki ilk elemana ulaşmak için dizi[] kullanılır.
console.log( items[0] );
// Array içindeki son elemanını çapırmak için -1 eksiğini alırız. Yazılımda sayma sıfırdan başlar.
console.log( items[items.length - 1] );

// Array içindeki ortadaki elemanı çağırma
console.log(
    "ortadaki :",
    items[ Math.floor(items.length / 2) ]
);

// degisken içindeki bilginin Array olup olmadığını kontrol etme
console.log(
    typeof(items) // object olarak çıktı veriyor
)

console.log(
    Array.isArray(items)
)

// hangileri isArray -> True verir ? 

console.log("[] : ", Array.isArray( [] ) )
console.log("1 : ", Array.isArray( 1 ) )
console.log("true : ", Array.isArray( true ) )




let items = [10, 20, 30, 40, ]
console.log("items - ilk hali : ", items)

// Array: sona öğe /eleman eklemek -> push
items.push(50)
console.log("50 : ", items)

// Array: başa öğe eklemek -> unshift 
items.unshift(5)
console.log("5 : ", items)

// Array: sondaki öğeyi çıkarmak-> pop
let lastItem = items.pop() // son elemani lastItem içerisine ekledik
console.log("lastItem: ", lastItem, ", items: ", items)

// Array: bastaki öğeyi çıkarmak -> shift
let firstItem = items.shift() // ilk elemani firstItem içerisine ekledik
console.log("firstItem: ", firstItem, ", items: ", items)

// Array icindeki bir ogenin bilgisinin degistirilmesi:

// ilk öğenin değiştirilmesi
items[0] = 5;
console.log(items)

// sonuncu öğenin değiştirilmesi:
items[items.length - 1] = 1000
console.log(items)

items[2] = 10000
console.log(items)


// Cok Kullanilan Array(Dizi) Metotlari ve Array icinde Array
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array
// https://www.w3schools.com/js/js_array_methods.asp

let items = [1, 2, 3, 4, 5] 

// Array icinde Array:
let femaleUsers = ["Ayse", "Hulya", "Merve"]
let maleUsers = ["Ahmet", "Hasan", "Mehmet"]

items.unshift(femaleUsers)

items.push(maleUsers)

console.log(items)

console.log(items.length)
console.log(items[0].length) // Array icindeki istedigimiz Array'in length bilgisini aldik
console.log(items[0][0]) // Ayse bilgisine ulastik :)

// Array icerisinden oge ayirmak -> splice(pos, item?)
let newItems = items.splice(1, 5)

console.log("newItems: ", newItems)
console.log("items: ", items)
// Array icerisindeki ogenin index bilgisini bulmak -> indexOf('value')
items.unshift("lorem")
items.push("ipsum")

console.log( items.indexOf("ipsum") )

// Array Kopyalamak -> slice, [...ES6]
let copyItems = items
console.log(items)

copyItems.pop() // son ogeyi cikarttik
console.log("copyItems", copyItems)
console.log("items", items)

console.log("kopyalandiktan sonraki hali:")
copyItems = items.slice() // kopyalama yapti
copyItems.pop() // son ogeyi cikarttik
console.log("copyItems", copyItems)
console.log("items", items)

let es6Items = [...items] // es6 ve sonrasinda gelen kopyalama islemi
console.log(es6Items)

// Iki Array Bilgisini Birlestirmek -> [...ES6, ...ES6]
let allUsers = [...femaleUsers, ...maleUsers] // es6 birden fazla array yapisini birlestirmek
console.log(allUsers)

// Array icerisindeki bilgiyi String'e cevirmek -> toString, join
console.log(allUsers.toString())
console.log(allUsers.join(" --- "))


// Istedigimiz Index Bilgisine Oge Eklemek -> splice(index, 0, value)
allUsers.splice(allUsers.length -1, 0, "Melissa")
allUsers.splice(Math.floor( allUsers.length / 2 ), 0, "Lorem")
console.log(allUsers)