let name = "Adam"
let myData = {
    name,
    weather: "słonecznie",
    printMessage() {
        console.log(`Cześć, ${myData.name}!`);
        console.log(`Dziś jest ${myData.weather}.`);
    }
};
myData.printMessage();
let secondObject = {};
Object.assign(secondObject, myData);
secondObject.printMessage();
