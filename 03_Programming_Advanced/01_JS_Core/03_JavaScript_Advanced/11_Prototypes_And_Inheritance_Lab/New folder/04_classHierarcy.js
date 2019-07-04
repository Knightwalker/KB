function solve() {

  class Figure {
    constructor() {
        if (this.constructor === Figure) {
            throw new TypeError('Abstract class "Figure" cannot be instantiated directly.'); 
        }
    }
  }

  class Circle extends Figure {
    constructor(radius) {
      super();
      this.radius = radius;
    }

    get area() {
      return Math.PI * this.radius * this.radius;
    }

    toString(){
        return `${this.constructor.name} - radius: ${this.radius}`;
    }

  }

  class Rectangle extends Figure {
    constructor(width, height) {
      super();
      this.width = width;
      this.height = height;
    }

    get area() {
      return this.width * this.height;
    }

    toString() {
      return `${this.constructor.name} - width: ${this.width}, height: ${this.height}`;
    }

  }

  return {
    Figure,
    Circle,
    Rectangle
  }

}