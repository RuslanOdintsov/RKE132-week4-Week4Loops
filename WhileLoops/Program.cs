Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool - true/false
while (loopActive)
{
    cpuRandom = rnd.Next(0, 6);
    //Console.WriteLine($"CPU has generated {cpuRandom}");
    Console.WriteLine("Make your guess");
    int userGuess = Int32.Parse(Console.ReadLine()); //Konsool loeb string formaadis, meie Parsime numbriks
    if (userGuess == cpuRandom)
    {
        Console.WriteLine("True");
        //break;
        //loopActive = false;
    }
    else
    {
        Console.WriteLine("False");
    }
}
Console.WriteLine("Game over");