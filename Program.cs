
Console.WriteLine("Hello and welcome to a guess a number game!");

var random = new Random();
var number = random.Next(1, 100);
var guessCount = 0;

while (true)
{
    Console.Write("Guess a number ");
    var guess = int.Parse(Console.ReadLine());
    guessCount++;

    if (guess < number)
    {
        Console.WriteLine("You guessed to low, try again!");
    }
    else if (guess > number)
    {
        Console.WriteLine("You guessed to high, try again!");
    }
    else
    {
        Console.WriteLine($"You guessed correct ,you managed to guess in {guessCount} times");
        break;
    }
}
   
