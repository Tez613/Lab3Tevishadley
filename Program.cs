// While loop
int Counter = 0;
while (Counter < 10)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Welcome to my While loop, if you would like to exit type Exit");
    Console.WriteLine("Please pick a number between 10 and 99");
    string Userinput = Console.ReadLine();
    if (Userinput == "Exit")
    {
        Console.WriteLine("thanks for Playing");
        Console.Clear();
        Counter = 2;
        break;
    }
    float Usernumber = int.Parse(Userinput);
    if (Usernumber < 10 || Usernumber > 99)
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Out of permissable numbers please try again");
        continue;
    }
    else
    {
        if (Usernumber / 23 == 1 || Usernumber / 23 == 2 || Usernumber / 23 == 3 || Usernumber / 23 == 4)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("that number was divisible by 23");
            Counter++;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("that number was NOT divisible by 23");
            continue;
        }
    }
}

//Do while loop.

Counter = 0;

do
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Welcome to my  DO While loop, if you would like to exit type Exit");
    Console.WriteLine("Please pick a number between 10 and 99");
    string Userinput = Console.ReadLine();
    if (Userinput == "Exit")
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("thanks for Playing");
        Console.Clear();
        Counter = 3;
        
        break;
    }
    float Usernumber = int.Parse(Userinput);
    if (Usernumber < 10 || Usernumber > 99)
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Out of permissable numbers please try again");
        continue;
    }
    else
    {
        if (Usernumber / 34 == 1 || Usernumber / 34 == 2 || Usernumber / 34 == 3 || Usernumber / 34 == 4)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("that number was divisible by 34");
            Counter++;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("that number was NOT divisible by 34");
            continue;
        }
    }
}
while (Counter < 10);

//For loop

Counter = 0;
for (int Increment = 0; Increment < 1;)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Welcome to my For loop, if you would like to exit type Exit");
    Console.WriteLine("Please pick a number between 10 and 99");
    string Userinput = Console.ReadLine();
    if (Userinput == "Exit")
    {
        
        Console.WriteLine("thanks for Playing");
        Console.Clear();
        Counter = 2;
        break;
    }
    float Usernumber = int.Parse(Userinput);
    if (Usernumber < 10 || Usernumber > 99)
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Out of permissable numbers please try again");

        continue;
    }
    else
    {
        if (Usernumber / 33 == 1 || Usernumber / 33 == 2 || Usernumber / 33 == 3 || Usernumber / 33 == 4)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("that number was divisible by 33");
            Counter++;

        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("that number was NOT divisible by 33");
            continue;
        }
    }
}

int operation = 0;
while (operation == 0)
{
    float Choosennumber1 = 0;
    float Choosennumber2 = 0;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Hello! We are going to do some math");
    Console.WriteLine("Please choose and option and type in its assigned number");
    Console.WriteLine("exit = 1");
    Console.WriteLine("add = 2");
    Console.WriteLine("subtract = 3");
    Console.WriteLine("multiply = 4");
    Console.WriteLine("divide = 5");
    float userinput = int.Parse(Console.ReadLine());
    float Solution = 0;
    switch (userinput)
    {
        case 1:
        Console.WriteLine("Thanks for playing");
            Environment.Exit(0);
            break;
        case 2:
            Console.WriteLine("please choose a number and hit enter");
            Choosennumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please choose another number");
            Choosennumber2 = int.Parse(Console.ReadLine());
            Solution = Choosennumber1 + Choosennumber2;
            Console.WriteLine($"{Choosennumber1}+{Choosennumber2} = {Solution}");
            break;
        case 3:
            Console.WriteLine("please choose a number and hit enter");
            Choosennumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please choose another number");
            Choosennumber2 = int.Parse(Console.ReadLine());
            Solution = Choosennumber1 - Choosennumber2;
            Console.WriteLine($"{Choosennumber1}-{Choosennumber2} = {Solution}");
            break;
        case 4:
            Console.WriteLine("please choose a number and hit enter");
            Choosennumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please choose another number");
            Choosennumber2 = int.Parse(Console.ReadLine());
            Solution = Choosennumber1 * Choosennumber2;
            Console.WriteLine($"{Choosennumber1}*{Choosennumber2} = {Solution}");
            break;
        case 5:
            Console.WriteLine("please choose a number and hit enter");
            Choosennumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please choose another number");
            Choosennumber2 = int.Parse(Console.ReadLine());
            Solution = Choosennumber1 / Choosennumber2;
            Console.WriteLine($"{Choosennumber1}/{Choosennumber2} = {Solution}");
            break;

    }

}
