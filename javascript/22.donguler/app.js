// For Dongusu
// https://developer.mozilla.org/tr/docs/Web/JavaScript/Guide/Loops_and_iteration

// for ([başlangıçAtaması]; [koşulİfadesi]; [arttırımİfadesi]) {
// yapilacak islem
// }

let users = ["Lorem", "Ipsum", "Dolor", ]

// for (let index = 0; index < 10; index++) {
//   console.log(index)
// }

// let index = 0

// for (; index < 10; index++) {
//   console.log(index)
// }

const userListDOM = document.querySelector('#userList')

for (index = 0; index < users.length; index++) {
    const liDOM = document.createElement('li')
    liDOM.innerHTML = users[index]
    userListDOM.appendChild(liDOM)
}

//Break & Continue
// https://www.w3schools.com/js/js_break.asp

const LOREM_LIST = [
    'lorem', 'ipsum', 'dolor', 'amet', 'consectetur,', 'adipisicing', 'elit'
]

let counter = 0

// for (; counter < 10; counter++) {
//   console.log(counter)
//   if (counter === 5) {break}
// }

// for (; counter < 10; counter++) {
//   if (counter === 5) {continue}
//   console.log(counter)
// }

const UL_DOM = document.querySelector('#userList')

let index = 0

// for (; index < LOREM_LIST.length; index++) {
//   if (LOREM_LIST[index] == "dolor") {break}
//   let LI_DOM = document.createElement('li')
//   LI_DOM.innerHTML = LOREM_LIST[index]
//   UL_DOM.append(LI_DOM)
// }

for (; index < LOREM_LIST.length; index++) {
    if (LOREM_LIST[index] == "dolor") {
        continue
    }
    let LI_DOM = document.createElement('li')
    LI_DOM.innerHTML = LOREM_LIST[index]
    UL_DOM.append(LI_DOM)
}


// While Dongusu
// https://www.w3schools.com/js/js_loop_while.asp

// let counter = 0;

// while ( counter < 10 ) {
//   console.log(counter)
//   counter ++
// }

let userName = ""

while (!userName) {
    userName = prompt("Kullanici Adini Giriniz: ")
    console.log(userName)
}

// Array forEach Metotu
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/TypedArray/forEach
// https://www.w3schools.com/jsref/jsref_foreach.asp

const PRODUCTS = ["Laptop", "Phone", "Speaker", "Desktop PC", "Server", "Mouse", "Keyboard"]

// PRODUCTS.forEach((product, index, array) => array[index] = product + " 111" )
PRODUCTS.forEach((product, index, array) => array[index] = `${product.toUpperCase()}`) // toUpperCase

console.log(PRODUCTS)

/*****
const userListDOM = document.querySelector('#userList')
for (index = 0; index < users.length; index++) {
  const liDOM = document.createElement('li')
  liDOM.innerHTML = users[index]
  userListDOM.appendChild(liDOM)
}
*/

const userListDOM = document.querySelector('#userList')

PRODUCTS.forEach(item => {
    const liDOM = document.createElement('li')
    liDOM.innerHTML = item
    userListDOM.append(liDOM)
})

// array filter kullanimi
// https://developer.mozilla.org/tr/docs/Web/JavaScript/Reference/Global_Objects/Array/filter

// 5 harften fazla olanlar (6) ??
const PRODUCTS = ["Mic", "Cable", "Speaker", "Desktop PC", "Server", "Mouse", "Keyboard"]

const NEW_PRODUCTS = PRODUCTS.filter(item => item.length > 5)
console.log(NEW_PRODUCTS)


// aktif kullanicilar ??
const USERS = [{
        fullName: "Ayse Sumer",
        isActive: false
    },
    {
        fullName: "Ahmet Urgan",
        isActive: true
    },
    {
        fullName: "Asya Basar",
        isActive: true
    },
    {
        fullName: "Aksel Durmaz",
        isActive: false
    },
]

// const ACTIVE_USERS = USERS.filter(user => user.isActive === true)
const ACTIVE_USERS = USERS.filter(user => user.isActive)
console.log(ACTIVE_USERS)

// array map kullanimi
// https://developer.mozilla.org/tr/docs/Web/JavaScript/Reference/Global_Objects/Array/map

const USERS = ["AYSE", "MehMet", "TugCE", "AkSEL"]

// userName icinde orjinal isim kalsin, 
// shortName icinde ilk harf buyuk . (A.)
// newName icinde ilk harf buyuk olsun
// {userName: "AYSE", shortName: "A.", newName: "Ayse"}

const NEW_USERS = USERS.map(user => user.toLowerCase())
console.log(NEW_USERS)

// const USERS_OBJ = USERS.map( item =>
//   {
//     return {
//       userName: item, shortName: `${item[0]}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`
//     }
//   } 
// )

const USERS_OBJ = USERS.map(item => ({
    userName: item,
    shortName: `${item[0]}.`,
    newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`
}))

console.log(USERS_OBJ)