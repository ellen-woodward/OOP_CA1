/* Ellen Woodward (S00222321)
 * 17/10/22
 * CA1
 */

Console.Write("Enter birth year: ");
int year = int.Parse(Console.ReadLine());

int age = 2022 - year; // calculate age

if (age >= 18)
    Console.WriteLine("You can vote!");
else
    Console.WriteLine("You cannot vote");
