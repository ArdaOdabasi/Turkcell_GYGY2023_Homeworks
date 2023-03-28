// <--- The concept of a variant in a Generic Interface --->

/* Generic Interface bir arayüzü tanımlarken parametreli tip kullanımına olanak tanıyan bir özelliktir. Bu, tanımlanan arayüzün farklı tipleri desteklemesine olanak sağlar.
 * Varyant kavramı ise, bu parametreli tiplerin arayüzdeki kullanım şekillerini belirler. Varyant, bir türün alt veya üst sınıfının yerine kullanılabildiği durumlarda kullanılır. 
 * Bu durumlarda, alt sınıf yerine üst sınıf kullanıldığında veya üst sınıf yerine alt sınıf kullanıldığında, tür uyumsuzluklarından kaçınmak için varyant kullanılır.
 * 
 * Örneğin, C# programlama dilinde, "in" ve "out" anahtar kelimeleri kullanılarak varyant kullanımı sağlanır. 
 * "in" anahtar kelimesi, parametreli bir tipte "out" anahtar kelimesi ise geri dönüş değeri olan bir tipte kullanılabilir. 
 * Bu şekilde, bir alt sınıfın üst sınıf yerine kullanılması veya üst sınıfın alt sınıf yerine kullanılması durumlarında, tür uyumsuzluklarından kaçınılabilir. */

// "out" anahtar kelimelerinin kullanımı:

public interface IAnimal<out T>
{
    T GetAnimal();
}

public class Animal<T> : IAnimal<T>
{
    private T animal;

    public Animal(T animal)
    {
        this.animal = animal;
    }

    public T GetAnimal()
    {
        return animal;
    }
}

public class Dog
{
    public string Name { get; set; }
}

public class Example
{
    public static void Main()
    {
        IAnimal<Dog> animal = new Animal<Dog>(new Dog { Name = "Fido" });
        // Using "out" keyword allows assigning IAnimal<Dog> to IAnimal<object>
        IAnimal<object> objAnimal = animal;

        Console.WriteLine(objAnimal.GetAnimal().GetType()); // Output: Dog
        Console.WriteLine(((Dog)objAnimal.GetAnimal()).Name); // Output: Fido
    }
}

/* Yukarıdaki örnekte, "IAnimal" generic interface'i "out" anahtar kelimesiyle tanımlanmıştır, bu nedenle "Dog" tipi, "object" tipi yerine kullanılabilir. 
 * Bu, "IAnimal<Dog>" tipinde bir nesnenin "IAnimal<object>" tipinde bir değişkene atanmasına izin verir. Bu, generic bir interface kullanırken tür güvenliğini koruyarak daha fazla esneklik sağlar.*/

// "in" anahtar kelimelerinin kullanımı:

//public interface IContainer<in T>
//{
//    void Add(T item);
//}

//public class AnimalContainer : IContainer<Animal>
//{
//    private List<Animal> animals = new List<Animal>();

//    public void Add(Animal item)
//    {
//        animals.Add(item);
//    }
//}

//public class Example
//{
//    public static void Main()
//    {
//        var animalContainer = new AnimalContainer();
//        IContainer<Dog> dogContainer = animalContainer;
//        // The DogContainer instance can add a Dog or an Animal

//        var dog = new Dog { Name = "Fido" };
//        dogContainer.Add(dog);
//    }
//}

/* Bu örnekte, "IContainer" generic interface'i "in" anahtar kelimesiyle tanımlanmıştır, bu nedenle "Animal" tipi, "Dog" tipi yerine kullanılabilir. 
 * Bu, "IContainer<Animal>" tipinde bir nesnenin "IContainer<Dog>" tipinde bir değişkene atanmasına izin verir.

"AnimalContainer" sınıfı, "IContainer<Animal>" arayüzünü uygular ve bir "Animal" öğesini eklemek için bir yöntem sağlar. 
"Example" sınıfında, bir "AnimalContainer" nesnesi oluşturulur ve "IContainer<Dog>" tipinde bir değişkene atanır. 
Ardından, bir "Dog" nesnesi oluşturulur ve "dogContainer" değişkenindeki "Add" yöntemi kullanılarak eklenebilir.*/
