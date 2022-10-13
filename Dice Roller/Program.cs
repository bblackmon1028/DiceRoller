bool rollAgain = false;
int dice1 = RandomNumber();
int dice2 = RandomNumber();
int diceTotal = dice1 + dice2;

do
{
    Console.WriteLine("How many sides does each dice have?");
    string userDiceAnswer = Console.ReadLine();
    int diceSides;

    if (int.TryParse(userDiceAnswer, out diceSides))
    {
        Console.WriteLine("Roll the dice!");
    }
    else
    {
        Console.WriteLine("That's not a valid number.");
        Environment.Exit(0);
    }
    Console.WriteLine($"You rolled a {dice1} and a {dice2}. Total: {diceTotal}");

    if (diceSides == 6)
    {
        Console.WriteLine(SixSidedDice(dice1, dice2));
    }
    else
    {
        Console.WriteLine(DiceComboMessages(dice1, dice2));
    }

    Console.WriteLine("Would you like to roll again? (y/n)?");
    string userAnswer = Console.ReadLine().ToLower();

    if (userAnswer == "y")
    {
        rollAgain = true;
        dice1 = RandomNumber();
        dice2 = RandomNumber();
        diceTotal = dice1 + dice2;
    }
    else
    {
        rollAgain = false;
    }
}
while (rollAgain);

Console.WriteLine("Thanks for playing!");


int RandomNumber()
{
    int randomNumber = 0;
    Random rnd = new Random();
    return randomNumber = rnd.Next(1, 7);
}


string SixSidedDice(int dice1, int dice2)
{
    string message = "";

    if (diceTotal == 7 || diceTotal == 11)
    {
        return message = "Win!";
    }
    if (diceTotal == 2 || diceTotal == 3 || diceTotal == 12)
    {
        if (dice1 == 1 && dice2 == 1)
        {
            return message = "Snake Eyes!\nCraps!";
        }
        if (dice1 == 1 && dice2 == 2 || dice1 == 2 && dice2 == 1)
        {
            return message = "Ace Deuce!\nCraps!";
        }
        if (dice1 == 6 && dice2 == 6)
        {
            return message = "Box Cars!\nCraps!";
        }
        return message = "Craps!";
    }
    else
    {
        return message = "";
    }
}

string DiceComboMessages(int dice1, int dice2)
{
    string message;

    if (dice1 == 2 && dice2 == 2)
    {
        return message = "Ballerina!";
    }
    else
    {
        return message = "Nice roll!";
    }
}
