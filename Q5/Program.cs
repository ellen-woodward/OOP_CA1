/* Ellen Woodward (S00222321)
 * 17/10/22
 * CA1
 */

double salary = 50000, inflation = 0.1;

Console.WriteLine($"Original salary : {salary}");

IncreaseSalaryByInflation(ref salary, inflation); //pass salary by reference to method

Console.WriteLine($"Increased salary : {salary}");

void IncreaseSalaryByInflation(ref double salary, double inflation)
{
    salary += salary * (inflation); //calculates new salary, which changes varaible outside of method
}