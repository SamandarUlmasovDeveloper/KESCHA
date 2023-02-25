
 using KESCHA.classes;
 namespace KESCHA
 {
    class Program
    {
      static void Main(string[] args)
      {
        Animal kescha = new Animal(name: "kescha", age: 3);

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        kescha.Greet(userName);
       

        Console.WriteLine("Enter your age: ");
        string ageAsString = Console.ReadLine();
        int userAge = Convert.ToInt32(ageAsString);
        Console.WriteLine("Converting...");
        Console.WriteLine($"successfully converted!{userAge}");


        // kescha.CalculateAgeDiffranceWithNoReturn(userAge);
        kescha.printAgeDiffrance();
        kescha.compareAges(userAge);
        kescha.TellAboutFriends(userName, userAge);
      }
    }
}
 

