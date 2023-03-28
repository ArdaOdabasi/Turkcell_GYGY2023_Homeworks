// <--- It is a project with examples on Abstract, Constructor, Encapsulation, Inheritance, Interface and Polymorphism --->


//<--- Abstract --->

//using _3_thirdAssignment_GYGY2023.Abstract;

//Vehicle car = new Car
//{
//    Brand = "Hyundai",
//    Model = "i20",
//    Year = 2015
//};

//car.Drive();


//<--- Constructor --->

//using _3_thirdAssignment_GYGY2023.Constructor;

//Vehicle car = new Car("Hyundai", "i20", 2015);
//car.Drive();


//<--- Encapsulation --->

//using _3_thirdAssignment_GYGY2023.Encapsulation;

//Car Car = new Car("Hyundai - i20", 2015, 0);
//Car.Accelerate(30);
//Car.Brake(10);
//Car.PrintDetails();

// Model, yıl ve hız özelliklerini private erişim belirteciyle gizledim.
// Bunların yerine, hızlanma ve frenleme metotlarını kullanarak bu özelliklerle etkileşime geçtim.
// Böylece araba sınıfının iç yapısını gizledim ve sadece istenilen işlevselliğin kullanılmasını sağladım. 


//<--- Interface --->

//using _3_thirdAssignment_GYGY2023.Interface;

//IDrivable araba = new Car();
//araba.Start();
//araba.Accelerate();
//araba.Brake();

//IDrivable bisiklet = new Bicycle();
//bisiklet.Start();
//bisiklet.Accelerate();
//bisiklet.Brake();


//<--- Inheritance - Polymorphism --->

using _3_thirdAssignment_GYGY2023.Inheritance___Polymorphism;

Animal animal = new Animal("Hayvan");
animal.MakeSound();

Dog dog = new Dog("Foks");
dog.MakeSound();

Cat cat = new Cat("Balım");
cat.MakeSound();