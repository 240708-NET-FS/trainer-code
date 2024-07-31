// function foobar() {
//     for(var i = 0; i < 1000; i++){
//         //do something
//     }
//     console.log(i);
// }

let dogCounter = 0;

function clickHandler(e) {
    console.log("You clicked!");
    console.log(e);
}

function leaveHandler() {
    alert("HOLD ON!!!")
}

function dogHandler() {
    let newImg = document.createElement('img');
    newImg.src = "dog.jpg";
    document.body.appendChild(newImg);
    let counter = document.getElementById('dogCount');
    counter.innerText = dogCount();
}

function dogListHandler() {
    let newImg = document.createElement('img');
    let listItem = document.createElement('li');
    newImg.src = "dog.jpg";
    let list = document.getElementById("myList");
    listItem.appendChild(newImg);
    list.appendChild(listItem);
}

function dogCount() {
    dogCounter++;    
    return dogCounter;
}

function bubble(e, name) {
    console.log(e, name);
    e.stopPropagation();
}