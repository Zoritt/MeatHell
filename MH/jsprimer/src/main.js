import {addition as add, multiply, subtract, mean as average} from "./maths"

let values = [10,20,30,40,50];

console.log(`Suma:${add(values)}`);
console.log(`Iloczyn:${multiply(values)}`);
console.log(`Różnica:${subtract(1000,values)}`);
console.log(`Średnia:${average(values)}`);
