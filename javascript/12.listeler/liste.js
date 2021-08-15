// ********** liste icerisindeki son elemana ulasmak veya eleman eklemek **********
let lastChild = document.querySelector("ul#list>li:last-child")
lastChild.innerHTML = "Son Öğe Değiştirildi"

let firstChild = document.querySelector("ul#list>li:first-child")
firstChild.innerHTML = "İlk Öğe Değiştirildi"

let ulDOM = document.querySelector("ul#list")
let liDOM = document.createElement('li')

liDOM.innerHTML = "Kendi Olusturdugumuz Oge"

// ulDOM.append(liDOM) // en sona ekler
ulDOM.prepend(liDOM)