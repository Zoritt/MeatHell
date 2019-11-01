function myFunc(nameFunction){
  return ("Cześć, " + nameFunction() + "!")
  }
  
  function printName(nameFunction, printFunction){
    printFunction(myFunc(nameFunction));
  }

  printName(function(){return "Adam"},console.log)
