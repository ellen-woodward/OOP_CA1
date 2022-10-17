/* Ellen Woodward (S00222321)
 * 17/10/22
 * CA1
 */

string[] data = new string[11];
string[] titles = new string[3];
double[] averages = new double[3];
int count = 0;

string filePath = "reviews.txt";

string[] fileContents = File.ReadAllLines(filePath);

foreach (string line in fileContents)
{
    data = line.Split(','); //split data from file into array
    titles[count] = data[0]; //take title into new array

    int total = 0;
    for(int i = 1; i < data.Length; i++) //calculate averages from rest of data array
    {
        total += int.Parse(data[i]);
    }
    averages[count] = (double)total / 10; // add averages to new averages array
    count++;
}

for (int i = 0; i < titles.Length; i++)
{
    Console.WriteLine($"{titles[i]} : {averages[i]}");
}
