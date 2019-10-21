function solve(name, area, population, country, postCode) {

  let city = {
    name: name,
    area: area,
    population: population,
    country: country,
    postCode: postCode
  };

  let entries = Object.entries(city)
  for (let [ key, value ] of entries) {
    console.log(`${key} -> ${value}`);
  }

}