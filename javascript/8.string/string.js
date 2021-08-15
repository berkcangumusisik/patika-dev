// ********** String Veri Turu Islemleri ********** 
// https://www.w3schools.com/jsref/jsref_obj_string.asp

let email = "gumusisikberkcan@gmail.com"
let firstName = "berkcan"
let lastName = "GÜMÜŞIŞIK"

// string karakter sayisi -> length
console.log( email.length )

// Ilk Karakteri Bulmak -> [0]:
console.log(firstName[0])
console.log(firstName.charAt(0))

// buyuk harf / kucuk harf :
firstName = firstName.toUpperCase()
console.log(firstName)

firstName = firstName.toLowerCase()
console.log(firstName)

// String Icinde Istedigimiz Bilgiyi Aramak ve Yerini Bulmak -> search:
console.log(email.search("@"))
console.log( email[15] )

email.search('olmayan') // -1

// belli bir yere kadar al -> slice :  (domain bilgisi)
let DOMAIN = email.slice( email.search("@") + 1)
console.log(DOMAIN)

console.log(
    DOMAIN.slice(0, DOMAIN.indexOf('.') )  // sadece gmail kismini aldik
)

// bilgiyi değiştirme -> replace :
email = email.replace('gmail.com', 'kodluyoruz.org')
console.log(email)

// istedigim bilgi var mi ? -> includes :
email.includes('dkfhsd') // false
email.includes('@') // true

// istedigim bilgiyle basladığını ve bittiğini alma -> startsWidth, endsWidth :
console.log(
    email.endsWith('kodluyoruz.org')
)

// Ilk Harflerini Buyuk Yaoma
firstName = "FIRST"
lastName = "LAST"
let fullName = `${firstName[0].toUpperCase()}${firstName.slice(1).toLowerCase()} ${lastName[0].toUpperCase()}${lastName.slice(1).toLowerCase()}`