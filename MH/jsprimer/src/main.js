import {asyncAdd} from "./maths"

let values = [10,20,30,40,50];

async function doTask(){
    let total = await asyncAdd(values);
    console.log(`Suma łączna:${total}`)
}
doTask();


