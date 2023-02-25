namespace KESCHA.classes
{
   class Animal
    {
     //field yani bu malumotni saqlash uchun ozgaruvchi
     public string Name { get; set; }
     public int Age { get; set; }
     public int AgeDiffrence{get; set;}

     public Animal( string name, int age)
      {
         Name = name;
         Age = age;

      }
     public Animal(
      string name,
      int userAge,
      int animalAge)
     {
        Name = name;
        Age = 0;
        CalculateAgeDiffranceWithNoReturn(userAge, animalAge);
     }

     public void printAgeDiffrance()
     {
      Console.WriteLine($"The diffrence between your and {Name},s  age  is {AgeDiffrence}");
     }

     public void compareAges(int userAge)
     {
      
            if(userAge > Age)
            {
               System.Console.WriteLine("You are older");
            }
            else if (userAge == Age)
            {
            
            System.Console.WriteLine("You are equal");
            }
            else 
            {
            System.Console.WriteLine("You are younger");
            }
     }

     public void TellAboutFriends(string userName, int userAge)
     {
            Console.WriteLine("Lett me tell you about my friends.");

            string [] friendsName = { "Vasya", "Kasee", "Valya"};
            Console.WriteLine(friendsName[2]);
            int  [] friendsAge = {1, 2, 3,};
            string[] friendName = new string[4];
            friendsName[0] ="kasee";
            friendsName[1] ="vasya";
            friendsName[2] =userName;
            int[] friendAge ={1, 2, userAge};

      for(int iteration = 0; iteration < friendsName.Length; iteration++)
          {
             Console.WriteLine($"{friendsName [iteration] } is {friendsAge[iteration]} year old");
          }
      }
    
     
   public void CalculateAgeDiffraceWithNoReturn(int userAge, int animalAge)
     {
       
        AgeDiffrence = userAge -Age;
        
     }
      public int CalculateAgeDiffrance(int userAge, int animalAge)
      {
         return userAge - animalAge;
      }
      public void Greet(string userName)
      
      {
          if(userName == "")
         {
         userName = "Unknown Person";
         }
         Console.WriteLine($"Hello, {userName}");
     
      }
      
      private void CalculateAgeDiffranceWithNoReturn(int userAge, int animalAge)
      {
         AgeDiffrence = userAge - animalAge;
      }
     
    }
}
