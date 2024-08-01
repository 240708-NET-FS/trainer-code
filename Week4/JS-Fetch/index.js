function getAllPoke() {
    fetch('http://localhost:5074/api/Pokemon')
        .then(res => res.json())
        .then(resBody => console.log(resBody))
}

function postPoke() {
    const poke = {        
        "dexId": 100,
        "name": "Geodude22222222",
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