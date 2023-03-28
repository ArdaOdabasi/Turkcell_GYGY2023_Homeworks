// <--- Finding the largest element, smallest element, sum and average of a sequence of numbers. (For, foreach, while and do-while loops used) --->

int[] numbers = new int[6];
Console.WriteLine("\n6 Elemandan Oluşan Bir Sayı Dizisi Oluşturacaksınız");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"\nDizinin {i + 1}.Elemanının Değerini Giriniz:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"\n\nOluşturduğunuz Sayı Dizisinin Elemanları Şu Şekildedir:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"\nDizinin {i + 1}.Elemanı: {numbers[i]}");
}

// For döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma

Console.WriteLine("\n\nFor döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma");

int minNumber = numbers[0]; // Dizideki en küçük elemanın değeri için geçici olarak dizinin 1.elemanının değerini atadım.
int maxNumber = numbers[0]; // Dizideki en büyük elemanın değeri için geçici olarak dizinin 1.elemanının değerini atadım.
int sum = 0; // Dizinin toplam değeri için geçici olarak 0 değerini atadım.
double average = 0; // Dizinin ortalama değeri için geçici olarak 0 değerini atadım.

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }

    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }

    sum += numbers[i];

    average = (Convert.ToDouble(sum) / (i + 1));
}

Console.WriteLine($"\nSayı Dizisinin En Küçük Elemanı: {minNumber}");
Console.WriteLine($"\nSayı Dizisinin En Büyük Elemanı: {maxNumber}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Toplam Değeri: {sum}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Ortalama Değeri: {average}");

// While döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma

Console.WriteLine("\n\nWhile döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma");

minNumber = numbers[0]; // While döngüsünde kullanmak için dizinin en küçük elemanının değerine geçici olarak dizinin 1.elemanının değerini atadım.
maxNumber = numbers[0]; // While döngüsünde kullanmak için dizinin en büyük elemanının değerine geçici olarak dizinin 1.elemanının değerini atadım.
sum = 0; // While döngüsünde kullanmak için dizinin toplam değerine geçici olarak 0 değerini atadım.
average = 0; // While döngüsünde kullanmak için dizinin ortalama değerine geçici olarak 0 değerini atadım.
int j = 0; // While döngüsünde kullanmak için bir değişken oluşturdum.

while (j < numbers.Length)
{
    if (numbers[j] < minNumber)
    {
        minNumber = numbers[j];
    }

    if (numbers[j] > maxNumber)
    {
        maxNumber = numbers[j];
    }

    sum += numbers[j];

    average = (Convert.ToDouble(sum) / (j + 1));

    j++;
}

Console.WriteLine($"\nSayı Dizisinin En Küçük Elemanı: {minNumber}");
Console.WriteLine($"\nSayı Dizisinin En Büyük Elemanı: {maxNumber}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Toplam Değeri: {sum}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Ortalama Değeri: {average}");

// Do-While döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma

Console.WriteLine("\n\nDo-While döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma");

minNumber = numbers[0]; // Do-While döngüsünde kullanmak için dizinin en küçük elemanının değerine geçici olarak dizinin 1.elemanının değerini atadım.
maxNumber = numbers[0]; // Do-While döngüsünde kullanmak için dizinin en büyük elemanının değerine geçici olarak dizinin 1.elemanının değerini atadım.
sum = 0; // Do-While döngüsünde kullanmak için dizinin toplam değerine geçici olarak 0 değerini atadım.
average = 0; // Do-While döngüsünde kullanmak için dizinin ortalama değerine geçici olarak 0 değerini atadım.
int k = 0; // Do-While döngüsünde kullanmak için bir değişken oluşturdum.

do
{
    if (numbers[k] < minNumber)
    {
        minNumber = numbers[k];
    }

    if (numbers[k] > maxNumber)
    {
        maxNumber = numbers[k];
    }

    sum += numbers[k];

    average = (Convert.ToDouble(sum) / (k + 1));

    k++;

} while (k < numbers.Length);

Console.WriteLine($"\nSayı Dizisinin En Küçük Elemanı: {minNumber}");
Console.WriteLine($"\nSayı Dizisinin En Büyük Elemanı: {maxNumber}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Toplam Değeri: {sum}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Ortalama Değeri: {average}");

// Foreach döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma

Console.WriteLine("\n\nForeach döngüsü kullanarak sayı dizisinin toplamını, ortalamasını, dizinin en büyük elemanını ve dizinin en küçük elemanını bulma");

minNumber = numbers[0]; // Foreach döngüsünde kullanmak için dizinin en küçük elemanının değerine geçici olarak dizinin 1.elemanının değerini atadım.
maxNumber = numbers[0]; // Foreach döngüsünde kullanmak için dizinin en büyük elemanının değerine geçici olarak dizinin 1.elemanının değerini atadım.
sum = 0; // Foreach döngüsünde kullanmak için dizinin toplam değerine geçici olarak 0 değerini atadım.
average = 0; // Foreach döngüsünde kullanmak için dizinin ortalama değerine geçici olarak 0 değerini atadım.
int l = 0; // Foreach döngüsünde kullanmak için bir değişken oluşturdum.

foreach (int number in numbers)
{
    if (numbers[l] < minNumber)
    {
        minNumber = numbers[l];
    }

    if (numbers[l] > maxNumber)
    {
        maxNumber = numbers[l];
    }

    sum += numbers[l];

    average = (Convert.ToDouble(sum) / (l + 1));

    l++;
}

Console.WriteLine($"\nSayı Dizisinin En Küçük Elemanı: {minNumber}");
Console.WriteLine($"\nSayı Dizisinin En Büyük Elemanı: {maxNumber}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Toplam Değeri: {sum}");
Console.WriteLine($"\nSayı Dizisinin Elemanlarının Ortalama Değeri: {average}");