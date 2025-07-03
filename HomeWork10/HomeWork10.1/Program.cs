//Ви отримали рядок, який містить ім’я та прізвище користувача.
//Ваша мета - перевірити, чи починається прізвище на ту ж літеру, що й ім’я.
//Якщо так, вивести повідомлення “Прізвище починається на ту ж літеру, що і ім’я”,
//інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.

string userInput = "";

while (string.IsNullOrEmpty(userInput))
{
	Console.Write("Enter your firstname and lastname: ");
	userInput = Console.ReadLine();
}

string[] fullName = userInput.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string firstName = fullName[0];
string lastName = fullName[1];

if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
    Console.WriteLine("Last name starts with the same letter as first name");
else Console.WriteLine("Last name does not start with the same letter as first name");