let inputDOM = document.querySelector('#task')
let ulDOM = document.querySelector('#list');
let list = document.querySelector("ul");

EventListeners();

function EventListeners() {
    ulDOM.addEventListener("click", function (ev) {
            if (ev.target.tagName == "LI") {
                ev.target.classList.toggle();
            }
        },
        false
    );
    document.addEventListener("DOMContentLoaded", loadAllTodosLi);
    ulDOM.addEventListener("click", deleteTodo)
}

//todoları silme
function deleteTodo(e) {

    if (e.target.className === "close") {

        e.target.parentElement.parentElement.remove();

        deleteTodoFromStorage(e.target.parentElement.previousSibling.textContent)

    }
}
 // Todoları storage dan silme
 function deleteTodoFromStorage(deletetodo){
     
    let todos = getTodosFromStorage(); // todoları localden array olarak aldım
    let index = todos.indexOf(deletetodo)
    
     //arrayden silme
     todos.splice(index,1);
      
     //silinen veriyi storage a kaydet
     localStorage.setItem("todos", JSON.stringify(todos)); 
}

// span onclick fonksiyonu(Tıklandıgında ne olacagı)
function newElement(){
addTodo()  
}

//Sayfa yenielndıkten sonra verilerin sayfada gorunmesı(localStorage'dan verılerın cekilmesi)
function loadAllTodosLi(){
 let todos = getTodosFromStorage();

 todos.forEach(function(todo){
   addTodoToLi(todo);
 });  
}

function addTodo(){

const newTodo = inputDOM.value.trim(); // trim ile sondaki ve bastaki bosluklar sılındı

// Boşluk kontrolü ve toast show
if(newTodo === ""){
 $(".error").toast("show");
}else{
 $(".success").toast("show");
 addTodoToLi(newTodo)
 addTodoToStorage(newTodo)
}

}

// String degerini list item olarak ekleyecek
function addTodoToLi(newTodo){ 
const listItem = document.createElement("li"); // list item olusturma
const deleteBtn = document.createElement("a")
deleteBtn.className = "close"
deleteBtn.innerHTML = `<span class = "close">X</span>`

// textNode
listItem.appendChild(document.createTextNode(newTodo))
listItem.appendChild(deleteBtn) 
//ulDOM 'a list item ı ekleme
ulDOM.appendChild(listItem)

//input alanını bosaltma
inputDOM.value = "";

}


// Storage'dan tum Todoları cekme
function getTodosFromStorage(){
let todos;

if(localStorage.getItem("todos") === null){
 todos = [];
}else{
 todos = JSON.parse(localStorage.getItem("todos"));
}
return todos;
}
//Storage 'dan Verileri alma
function addTodoToStorage(newTodo){
 
let todos = getTodosFromStorage();
todos.push(newTodo);
localStorage.setItem("todos", JSON.stringify(todos));
}