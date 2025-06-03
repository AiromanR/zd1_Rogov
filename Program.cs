using zd1_Rogov;

Console.WriteLine("Введите имя первого кота");
Cat cat1 = new Cat(Console.ReadLine());
Console.WriteLine("Введите вес первого кота");
cat1.Weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите имя второго кота");
Cat cat2 = new Cat(Console.ReadLine());
Console.WriteLine("Введите вес второго кота");
cat2.Weight = Convert.ToDouble(Console.ReadLine());

cat1.Meow();
cat2.Meow();

Console.WriteLine("Измените имя первого кота");
cat1.Name = Console.ReadLine();
cat1.Meow();

Console.WriteLine("Измените вес второго кота");
cat2.Weight = Convert.ToDouble(Console.ReadLine());
cat2.Meow();

