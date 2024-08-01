function getAllPoke() {
    fetch('http://localhost:5074/api/Pokemon')
        .then(res => res.json())
        .then(resBody => console.log(resBody))
}

function postPoke() {
    const poke = {        
        "dexId": 100,
        "name": "Geodude222222223",
        "type1": "ground",
        "type2": "string"          
    }
    
    fetch('http://localhost:5074/api/Pokemon', {
        method: 'POST',
        body: JSON.stringify(poke),
        headers: {
            'Content-Type' : 'application/json'
        }
    })
    .then(res => res.json())
    .then(resBody => console.log(resBody));
}

function addPoke(e) {
    e.preventDefault();
    console.log("Adding a pokemon");
}

const pokeForm = document.getElementById('addPokeForm');

pokeForm.addEventListener('submit', function(e) {
    e.preventDefault();

    let type2 = e.target.elements['type2'].value

    if(!type2) type2 = "";

    const poke = {        
        "dexId": Number(e.target.elements['dexId'].value),
        "name": e.target.elements['pokeName'].value,
        "type1": e.target.elements['type1'].value,
        "type2": e.target.elements['type2'].value          
    }
    
    fetch('http://localhost:5074/api/Pokemon', {
        method: 'POST',
        body: JSON.stringify(poke),
        headers: {
            'Content-Type' : 'application/json'
        }
    })
    .then(res => res.json())
    .then(resBody => console.log(resBody));
});

// pokeForm.addEventListener('submit', random);

// function random(e){
//     e.preventDefault();
//     console.log("random function");
// }

function changeCars(e) {
    const cars = document.getElementById('cars');
    const index = cars.selectedIndex;
    const option = cars.options[index].text;   
    console.log(option);
}
