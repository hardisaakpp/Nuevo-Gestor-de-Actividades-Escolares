/* const API = "https://localhost:7272";
const view = document.querySelector("#viewActivity")
const GetFetchApiPlanificador = async () => {
    const res = await fetch(`${API}/api/actividades`);
    const data = await res.json();
    data.forEach((activity) => {
        view.innerHTML = `activity.Id`
    });
} */

// GetFetchApiPlanificador();
// Datos primitivos

/**
 * string
 * numbers
 * booleanos
 * null
 * undefined*/

// const fruits = ["apple", "pear", "banana"];
// console.log(fruits[1]);

// let name = "Juan";
// let name1 = name;

/*if (name === name1) {
    console.log("Son iguales");
} */

// Manipulacion de arrays
/* const fruits = ["pear", "apple", "banana"];

for (let i = 0; i < fruits.length; i++) {
    if (fruits[i] === "pear") {
        console.log(fruits[i]);
        break;
    }
    //
}
const fruitsFilter = fruits.find(fruit => fruit === "pear"); */
// const fruitsFilter = fruits.filter(fruit => fruit === "pear");

// const  fruitsMoreOne = fruits.map(x => x + 1);

// const fruitsMoreOne = fruits.forEach(x => console.log(x + 1));

// console.log(fruitsMoreOne);
// console.log(fruitsFilter);
// console.log(fruits.length);

/*const fruits1 = fruits;

fruits1[0] = "apple";

console.log(fruits[0]);*/

// OBJETOS

/*const fruits = {
    name: 'pear',
    cost: 32.34
}

console.table(fruits.cost);*/
/*
const fruits = [
    { name: 'apple', cost: 1.2, color: 'red', quantity: 10 },
    { name: 'banana', cost: 0.5, color: 'yellow', quantity: 20 },
    { name: 'pear', cost: 1.0, color: 'green', quantity: 15 },
    { name: 'orange', cost: 0.8, color: 'orange', quantity: 12 },
    { name: 'grape', cost: 2.0, color: 'purple', quantity: 8 },
    { name: 'pineapple', cost: 3.0, color: 'brown', quantity: 5 },
    { name: 'mango', cost: 1.5, color: 'orange', quantity: 7 },
    { name: 'strawberry', cost: 2.5, color: 'red', quantity: 25 },
    { name: 'blueberry', cost: 3.5, color: 'blue', quantity: 30 },
    { name: 'kiwi', cost: 1.8, color: 'brown', quantity: 10 }
];

const newFruits = fruits.map(fruit => {
    if (fruit.name === "grape") {
        fruits[0].name = "kiwi";
    }
    return fruit.name.toUpperCase();
});

console.table(newFruits);

function GetDataFruits() {
    return fruits;
}
const data = GetDataFruits();
console.log(data[0].name);
//fruits.forEach(fruit => { console.table(fruit.name = "grape"); });

const GetData = () => {
    return data[0].name;
};
console.log(GetData());

 */

// CALLBACKS
/*
function suma(a, b) {
    return a + b;
}

function operaciones(callback, a, b) {
    return callback(a, b);
}

const res = operaciones(suma, 3, 4);
console.log(res);

fruits = ["apple"].map(x => x.toUpperCase());

 */

// ASINCRONISMO
// PROMESAS
const fruits = [
    { name: 'apple', cost: 1.2, color: 'red', quantity: 10 },
    { name: 'banana', cost: 0.5, color: 'yellow', quantity: 20 },
    { name: 'pear', cost: 1.0, color: 'green', quantity: 15 },
    { name: 'orange', cost: 0.8, color: 'orange', quantity: 12 },
    { name: 'grape', cost: 2.0, color: 'purple', quantity: 8 },
    { name: 'pineapple', cost: 3.0, color: 'brown', quantity: 5 },
    { name: 'mango', cost: 1.5, color: 'orange', quantity: 7 },
    { name: 'strawberry', cost: 2.5, color: 'red', quantity: 25 },
    { name: 'blueberry', cost: 3.5, color: 'blue', quantity: 30 },
    { name: 'kiwi', cost: 1.8, color: 'brown', quantity: 10 }
];

function GetData() {
    return new Promise((resolve, reject) => {
        setTimeout(x => {
            resolve(fruits);
        }, 4000);
    });
}
// Que es una promesa, que hace una promesa, como se usa una promesa: them, catch, finally