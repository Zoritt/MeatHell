function myFunc(name, weather, ...extraArgs){
  console.log("Cześć, " + name + "!");
  console.log("Dziś jest " + weather + ".");
  for (let i = 0; i < extraArgs.length; i++){
    console.log("Dodatkowy argument:"+extraArgs[i]);
  }
}
myFunc("Adam", "słonecznie","raz","dwa","trzy");