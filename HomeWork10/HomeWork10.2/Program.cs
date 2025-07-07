//Ви розробляєте програму для генерації текстового звіту. Ваше завдання - створити текстовий звіт, 
//який містить заголовок, дату та список подій. Використайте StringBuilder, 
//щоб зберегти пам’ять та оптимізувати об’єднання рядків. 
//Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder.

using System.Text;

string title = "\0";
string date  = "\0";
StringBuilder listOfEvents  = new StringBuilder();
string exit = "O";

Console.Write("Enter title: ");
title = Console.ReadLine();

Console.Write("Enter date (dd/mm/yy): ");
date  = Console.ReadLine();

int i = 0;
while (exit.ToUpper() == "O")
{
    Console.Write($"Enter #{i + 1} event: ");
    listOfEvents.Append(Console.ReadLine());
	listOfEvents.Append(", ");
	i++;

    Console.Write("If you want to add another event enter 'O', if not 'X': ");
    exit = Console.ReadLine();

    while (exit.ToUpper() != "O" && exit.ToUpper() != "X")
    {
        Console.Write("Please, enter only 'O' or 'X': ");
        exit = Console.ReadLine();
    }
}

int lastIndexOfComa = listOfEvents.Length - 2;
listOfEvents.Replace(',', '\0', lastIndexOfComa, 1);

Console.WriteLine($"\nYour title: {title}");
Console.WriteLine($"Date: {date}");
Console.WriteLine($"Events: {listOfEvents.ToString()}");