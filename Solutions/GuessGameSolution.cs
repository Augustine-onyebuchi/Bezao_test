namespace Test.Solutions;

public class GuessGameSolution
{
    public static void GuessNumber()
    {
        var secretNum = 14;
        var allowedTryCount = 3;
        var lastTryNum = 0;
        var tryCount = 0;
        Console.WriteLine("===== GUESS GAME =====");
        while (tryCount < allowedTryCount)
        {
            Console.Write("Guess a number within the range of 1 - 20: ");
            var strNum = Console.ReadLine();
            Console.WriteLine();

           
            bool isValid = false;
            var message = "";
            if (!int.TryParse(strNum, out int num) || num < 1 || num > 20)
            {
                message = $"Invalid number!";
            }
            else
            {
                if(num != lastTryNum){
                    tryCount += 1;
                }
                lastTryNum = num;

                if (num != secretNum)
                {
                    message = $"Wrong number! The number you entered is too {(num < secretNum ? "small" : "large")} You have {allowedTryCount - tryCount} try(s) left";
                }
                else
                {
                    message = $"Correct! You win!!!";
                    isValid = true;
                }
            }

            if (!isValid)
            {
                if (tryCount == allowedTryCount)
                {
                    Console.WriteLine("Sorry! You have no trys left");
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine(message);
                break;
            }
        }
    }
}