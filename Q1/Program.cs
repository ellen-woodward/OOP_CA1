Console.Write("Enter birth year: ");
int year = int.Parse(Console.ReadLine());

int age = 2022 - year;

if (age >= 18)
    Console.WriteLine("You can vote!");
else
    Console.WriteLine("You cannot vote");
