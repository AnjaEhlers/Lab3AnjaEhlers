// while loop
while (true)
{
     Console.Write("Enter a number between 10 and 99: ");
     string userResponse = Console.ReadLine();
     if (userResponse =="exit"){
     Console.WriteLine("Thanks for playing.");
     Environment.Exit(1);
     }
     int userNumber = Convert.ToInt32(userResponse);
     if (userNumber%23==0){
         Console.BackgroundColor=ConsoleColor.Green;
        Console.Clear();
     break;
     }
     else
     {
          Console.BackgroundColor=ConsoleColor.Red;
          Console.Clear();
      break;
     }

}
// do while
do 
{
     Console.Write("Enter a number between 10 and 99");
     string userResponse = Console.ReadLine();
     if (userResponse =="exit"){
     Console.WriteLine("Thanks for playing.");
     Environment.Exit(1);
     }
     int userNumber = Convert.ToInt32(userResponse);
     if (userNumber%34==0){
         Console.BackgroundColor=ConsoleColor.Green;
        Console.Clear();
     break;
     }
     else
     {
          Console.BackgroundColor=ConsoleColor.Red;
          Console.Clear();
     break;
     }
     
}
while (true);
// for loop
for(;;) {
Console.Write("Enter a number between 10 and 99");
     string userResponse = Console.ReadLine();
     if (userResponse =="exit"){
     Console.WriteLine("Thanks for playing.");
     Environment.Exit(1);
     }
     int userNumber = Convert.ToInt32(userResponse);
     if (userNumber%33==0){
         Console.BackgroundColor=ConsoleColor.Green;
        Console.Clear();
     break;
     }
     else
     {
          Console.BackgroundColor=ConsoleColor.Red;
          Console.Clear();
     break;
     }
}

while (true)
{
Console.Write("Which operator would you like to use?");
string userResponse = Console.ReadLine();

switch(userResponse)
{
      case "add":
      Console.Write("Choose a number.");
      int userNumberOneAddition=int.Parse(Console.ReadLine());
      Console.Write("Choose another number.");
      int userNumberTwoAddition=int.Parse(Console.ReadLine());
      int additionResult=userNumberOneAddition + userNumberTwoAddition;
      Console.WriteLine(additionResult);
      break;

      case "subtract":
      Console.Write("Choose a number.");
      int userNumberOneSubtraction=int.Parse(Console.ReadLine());
      Console.Write("Choose another number.");
      int userNumberTwoSubtraction=int.Parse(Console.ReadLine());
      int subtractionResult=userNumberOneSubtraction - userNumberTwoSubtraction;
      Console.WriteLine(subtractionResult);
      break;

      case "multiply":
        Console.Write("Choose a number.");
      int userNumberOneMultiplication=int.Parse(Console.ReadLine());
      Console.Write("Choose another number.");
      int userNumberTwoMultiplication=int.Parse(Console.ReadLine());
      int multiplicationResult=userNumberOneMultiplication * userNumberTwoMultiplication;
      Console.WriteLine(multiplicationResult);
      break;

      case "divide":
       Console.Write("Choose a number.");
      int userNumberOneDivision=int.Parse(Console.ReadLine());
      Console.Write("Choose another number.");
      int userNumberTwoDivision=int.Parse(Console.ReadLine());
      int divisionResult=userNumberOneDivision / userNumberTwoDivision;
      Console.WriteLine(divisionResult);
      break;

      case "exit":
     Console.WriteLine("Thanks for playing.");
     Environment.Exit(1);
      break;
}
}