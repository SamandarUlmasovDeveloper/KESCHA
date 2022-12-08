 System.Console.Write("Enter your name: ");
 string name = Console.ReadLine();
 string greeting =$"Hello, {name}";
 System.Console.WriteLine(greeting);

 System.Console.WriteLine("Enter your age: ");
 string ageAsString =Console.ReadLine();
 int age =Convert.ToInt32(ageAsString);
 System.Console.WriteLine("Converting...");
 System.Console.WriteLine($"successfully!{age}");

 int keschaAge  =3;
 int ageDiffrence=age- keschaAge;
 System.Console.WriteLine($"The diffrence between your and Kescha,s {ageDiffrence} ");
 // >>= <<=  ==  !=
 System.Console.WriteLine($"You are older than or equal to KESCHA: {age >= keschaAge}");
 System.Console.WriteLine($"You are older to than KESCHA: {age > keschaAge}");
 System.Console.WriteLine($"You are younger than  or equal to KESCHA: {age < keschaAge}");
 System.Console.WriteLine($"You are younger than KESCHA: {age <= keschaAge}");
 System.Console.WriteLine($"You age is equal to KESCHA: {age == keschaAge}");
 System.Console.WriteLine($"You age is not equal to KESCHA: {age != keschaAge}");







