//Ви отримали рядок, який містить декілька слів, розділених комами. 
//Ваша мета - видалити всі пробіли з цього рядка та вивести результат.

Console.Write("Enter string: ");
string userInput = Console.ReadLine();

Console.WriteLine(userInput./*Trim().*/Replace(" ", ""));