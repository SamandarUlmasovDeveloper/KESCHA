string kod = "";
do{
   System.Console.WriteLine("Enter password!");
   kod = Console.ReadLine();
   }
while(kod != "123");

 System.Console.Write("Enter your name: ");
 string name = Console.ReadLine();
 string greeting =$"Hello, {name}";
 System.Console.WriteLine(greeting);

 System.Console.WriteLine("Enter your age: ");
 string ageAsString =Console.ReadLine();
 int age =Convert.ToInt32(ageAsString);
 System.Console.WriteLine("Converting...");
 System.Console.WriteLine($"successfully!{age}");

 
 

 int keschasAge  =3;
 int ageDiffrence=age- keschasAge;
 System.Console.WriteLine($"The diffrence between your and Kescha,s {ageDiffrence} ");


string message = 
     keschasAge >= 0
         ?"You are older"
         :"You are younger";     

 if(age > keschasAge)
 {
     System.Console.WriteLine("You are older");
}
else if (age == keschasAge)
{
  
  System.Console.WriteLine("You are equal");
}
else 
{
  System.Console.WriteLine("You are younger");
}

System.Console.WriteLine("Lett me tell you about my friends.");
string [] friendsName = { "Vasya", "Kasee", "Valya"};
System.Console.WriteLine(friendsName[2]);
int  [] friendsAge = {1, 2, 3,};

string[] friendName = new string[4];
friendsName[0] ="kasee";
friendsName[1] ="vasya";
friendsName[2] =name;
int[] friendAge ={1, 2, age};

System.Console.WriteLine($" {friendsName[0]} is {friendsAge[0]} year old!");
System.Console.WriteLine($" {friendsName[1]} is {friendsAge[1]} year old!");
System.Console.WriteLine($" {friendsName[2]} is {friendsAge[2]} year old!");

 for(int iteration = 0; iteration < friendsName.Length; iteration++)
 {
    System.Console.WriteLine($"{friendsName [iteration] } is {friendsAge[iteration]} year old");
 }










 







