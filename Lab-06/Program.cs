using Lab_06;


Animal animal = new Dog();
Console.WriteLine(animal.Sound);
animal.Move();

Dog dog = new Dog();
Console.WriteLine(dog.Sound);
dog.Move();

Cat cat = new Cat();
Console.WriteLine(cat.Sound);
cat.Move();


Dog dog = new Dog();
dog.Walk();

IWalkable walkableDog = new Dog();
walkableDog.Walk();