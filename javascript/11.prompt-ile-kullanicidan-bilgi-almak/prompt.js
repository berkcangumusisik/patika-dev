// ********** prompt ile Kullanicidan Bilgi Almak **********
// https://developer.mozilla.org/en-US/docs/Web/API/Window/prompt

let fullName = prompt("Adınızı ve soyadınızı yazınız")
let greeting = document.querySelector("#greeting")
greeting.innerHTML = `${greeting.innerHTML} <small style="color:red">${fullName}</small>`
