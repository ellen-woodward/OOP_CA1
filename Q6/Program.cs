/* Ellen Woodward (S00222321)
 * 17/10/22
 * CA1
 */
using Q6; //links classes and program.cs

Worker worker1 = new Worker("Tom", "Plumber", 15); //instantiate new object Worker 
Worker worker2 = new Worker("Jo", "Electrician", 20); //pass in info on new Worker

List<Worker> workers = new List<Worker>(); //create list of type Worker
workers.Add(worker1);
workers.Add(worker2);

DisplayInformation(workers);

void DisplayInformation(List<Worker> workers)
{
    for (int i = 0; i < workers.Count; i++)
    {
        Console.WriteLine($"Worker {i+1}\nName : {workers[i].Name}\nType : {workers[i].Type}\nHourly rate : {workers[i].HourlyRate}\n");
    }
}