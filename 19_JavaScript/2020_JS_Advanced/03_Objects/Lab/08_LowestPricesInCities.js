function main(args) {
  let obj = {};
  for (let i = 0; i < args.length; i++) {
    let data = args[i].split(" | ");
    let town = data[0];
    let product = data[1];
    let price = Number(data[2]);

    if(!obj.hasOwnProperty(product)) {
      obj[product] = {};
    }
    
    obj[product][town] = price;   
  }

  for (const key in obj) {
    let minPrice = Number.MAX_VALUE;
    let town = "";
    for (const key2 in obj[key]) {
      if(obj[key][key2] < minPrice){
        minPrice = obj[key][key2];
        town = key2;
      }
    }
    console.log(`${key} -> ${minPrice} (${town})`);
  }
}

main(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
);