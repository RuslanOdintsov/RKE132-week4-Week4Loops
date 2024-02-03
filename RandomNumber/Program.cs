
using System.Security.Cryptography;

Random rnd = new Random();
//int randomNumber = rnd.Next(0,65);  //genereerib 0-64
//Console.WriteLine($"Your roulette number is:{randomNumber}");
//for (int i = 0; i < 10; i++)
//{
//    randomNumber = rnd.Next(0, 65);
//    Console.WriteLine($"Your lucky number is:{randomNumber}");
//}

int rndSum = 0;
int rndNum;
for (int i = 0;i < 10;i++)
{
    rndNum = rnd.Next(0,11);
    rndSum = rndSum + rndNum;
    Console.WriteLine($"Random number is:{rndNum}");
}
Console.WriteLine($"Random number sum is:{rndSum}");
