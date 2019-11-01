let myArray = [100, "Adam", true];
for(let i=0; i < myArray.length; i++)
{
    console.log(myArray[i])
}

myArray.forEach((value, index) => console.log(`Indeks ${index}: ${value}`))