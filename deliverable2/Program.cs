using System;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string headsOrTailsGuess = "";
            float numberOfFlips = 0;
            float correctCount = 0;
            Random rand = new Random();

            Console.Write("Guess which will have more: heads or tails? ");
            headsOrTailsGuess = Console.ReadLine().ToLower();

            Console.Write("How many flips? ");
            numberOfFlips = float.Parse(Console.ReadLine());

            runCoinFlips(numberOfFlips);

            void runCoinFlips(float numOfFlips) {
                for (int count = 0; count < numOfFlips; count++)
                {
                    string flipResult = flipCoin();
                    if (flipResult == headsOrTailsGuess) {
                        correctCount++;
                    }
                }
            }

            string flipCoin() {
                float flip = rand.Next(0, 2);
                string result = "";

                if (flip % 2 == 0) {
                    result = "heads";
                }
                else {
                    result = "tails";
                }

                Console.WriteLine(result);
                return result;
            }

            float calculateGuessAccuracy(float correctGueses, float chances) {
                return correctGueses / chances * 100;
            }

            Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctCount} time(s)");
            Console.WriteLine($"That's {calculateGuessAccuracy(correctCount, numberOfFlips):0.0}%");
        }
    }
}
