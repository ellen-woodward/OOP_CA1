/* Ellen Woodward (S00222321)
 * 17/10/22
 * CA1
 */

string results = "WDDLWWDLWW";

int winCount = 0, drawCount = 0, lossCount = 0;

for (int i = 0; i < results.Length; i++) //treat string as array
{
    if (results[i] == 'W')
        winCount++;
    else if (results[i] == 'D')
        drawCount++;
    else
        lossCount++;
}

int totalPoints = (winCount * 3) + (drawCount);

Console.WriteLine($"{winCount} wins\n{drawCount} draws\n{lossCount} losses\nTotal points: {totalPoints}");