let produkts = [
    {name:"Kapelusz", price: 24.5, stock: 10},
    {name:"Kajak", price: 289.99, stock: 1},
    {name:"Piłka", price: 10, stock: 0},
    {name:"Buty do biegania", price: 116.50, stock: 20},
];
let totalValue = produkts.filter(item => item.stock>0)
.reduce((prev, item) => prev + (item.price*item.stock),0);
console.log(`Wartość łączna: ${totalValue.toFixed(2)} PLN`)