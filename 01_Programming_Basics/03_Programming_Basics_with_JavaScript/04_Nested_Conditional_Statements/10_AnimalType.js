function AnimalType(args) {
  let input = args[0].toLowerCase();

  switch (input) {
    case "dog":
      console.log('mammal');
      break;
    case "crocodile":
    case "tortoise":
    case "snake":
      console.log('reptile');
      break;
    default:
      console.log('unknown');
  }

}