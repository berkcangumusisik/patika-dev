// ********** let ve const ile Degisken Tanimlama **********
//LET daha kapsamlı bir kullanıma sahip bu yüzden var yerine let kullanmak daha iyi
// var ile degisken tanımlamak:
// var serverName = "api.kodluyoruz.org";
// console.log(serverName);
// let ile degiskeni bos tanimlamak:
let serverName;
console.log(serverName);
// let ile degiskene bilgi atamak:
serverName = "http://kodluyoruz.org"
console.log(serverName);

// let ile degiskene bilgi atayarak çalıştırmak:
let serverPassword = "1234";
console.log(serverPassword);
// degisken atamasi yapmadan once kullanmaya calismak:(let ile kullanıldığı zaman hata verir var ile kulllanılırsa undefined çıktısı verir)
console.log(fullName);
// let fullName = "Berkcan Gümüşışık"
var fullName = "Berkcan Gümüşışık"
//Birleştirme işlemi yapma
let firstName = "Berkcan"
let lastName = "Gümüşışık"
console.log(firstName + " "+ lastName)

console.log(fullName + " Yeni kişi sisteme eklendi.")

result = fullName + " Yeni kişi"
console.log(result)
//const ile boş değişken tanımlamak. Boş tanımlanamaz çünkü const ile eklenen bilgiler değiştirilemez. Bir kez tanımlanır ve kalır.
// const password;
// password = "12345";
// console.log(password)

//const ile değişken tanımlamak
const password = "1234";
console.log(password);

// password = "12345";
// console.log(password)