Console.WriteLine("Veuillez introduire un nombre :");
string userInput = Console.ReadLine();

Console.WriteLine($"Vous avez introduit {userInput} de type : {userInput.GetType()}");

//Convertion en Int32
//int userNumber = Convert.ToInt32(userInput);
//int userNumber = int.Parse(userInput);
int userNumber;
bool isConverted = int.TryParse(userInput, out userNumber);
Console.WriteLine($"Convertion effectuée ? {isConverted}");
Console.WriteLine($"Vous avez introduit {userNumber} de type : {userNumber.GetType()}");

//Convertion en Double
//double userDouble = Convert.ToDouble(userInput);
//double userDouble = double.Parse(userInput);
double userDouble;
isConverted = double.TryParse(userInput, out userDouble);
Console.WriteLine($"Convertion effectuée ? {isConverted}");
Console.WriteLine($"Vous avez introduit {userDouble} de type : {userDouble.GetType()}");

//Convertion en Boolean
//bool userBool = Convert.ToBoolean(userInput);
//bool userBool = bool.Parse(userInput);
bool userBool;
isConverted = bool.TryParse(userInput, out userBool);
Console.WriteLine($"Convertion effectuée ? {isConverted}");
Console.WriteLine($"Vous avez introduit {userBool} de type : {userBool.GetType()}");