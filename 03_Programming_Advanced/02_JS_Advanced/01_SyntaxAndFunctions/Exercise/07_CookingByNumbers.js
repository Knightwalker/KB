function main(args) {

  let number = Number(args[0]);
  for (let i = 1; i < args.length; i++) {
    if (args[i] == "chop") {
      number = number / 2;
    } else if (args[i] == "dice") {
      number = Math.sqrt(number);
    } else if (args[i] == "spice") {
      number = number += 1;
    } else if (args[i] == "bake") {
      number *= 3;
    } else if (args[i] == "fillet") {
      number -= number * 0.20;
    }

    console.log(number);

  }

}

main(['32', 'chop', 'chop', 'chop', 'chop', 'chop']);