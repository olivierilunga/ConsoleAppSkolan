namespace ConsoleAppSkolan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine($"Hello, World! {TimeOfThisDay()}");
            WorkingOnLoops();
        }
        private static DateTime CurrentTime()
        {
            DateTime tidens = DateTime.Now;
            while (DateTime.Now != tidens.ToUniversalTime())
            {
                Console.WriteLine($"Dagens tid är: {DateTime.UtcNow}");
            }
            return tidens;
        }

        private static void WorkingOnLoops()
        {
            int guess = 0;
            int num = new Random().Next(1, 10);

            int iterration = 3;
            do
            {
                int result = iterration - guess;

                Console.Write($"Guess which number im thinking about,");
                Console.WriteLine($"You only get {result} guess now: ");

                int user = Convert.ToInt32(Console.ReadLine());

                if (user == num)
                {
                    Console.WriteLine(String.Format("WOOHOO, YOU GUESSED RIGHT! {0}", num));
                    Console.WriteLine("And it took you" + " " + guess + " SHOOT!!");
                    break;
                }

                else if (guess >= 2)
                {
                    Console.WriteLine("GAME OVER FOUR YOU!");
                    break;
                }

                else
                {
                    Console.WriteLine("Wrong, guess again!");
                    guess++;
                    Console.WriteLine($"You have {iterration - guess} guesses left");
                }
            } while (guess < 3);


        }
    }
}