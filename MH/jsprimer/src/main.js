import additionalFunction from "./maths/sum";
//import {multiply, subtract as minus} from "./maths/operations"
import * as ops from "./maths/operations"

let values = [10,20,30,40,50];
console.log(`Suma:${additionalFunction(values)}`);
console.log(`Iloczyn:${ops.multiply(values)}`);
console.log(`Różnica:${ops.subtract(1000,values)}`);
