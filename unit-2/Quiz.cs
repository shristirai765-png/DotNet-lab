class Quiz
{
    static void guessAnswer()
    {
        Console.WriteLine("Are you ready to play? Y/N: ");
        string input = (Console.ReadLine()!).ToUpper();
        if (input == "YES")
        {
            Console.WriteLine("What is the largest planet in the solar system? ");
            string answer = Console.ReadLine()!;
            if(answer == "Jupiter")
            {
                Console.WriteLine("You have got the right answer.");
            }
            else
            {
                Console.WriteLine("Wrong Answer!");
            }
        }
    }
    public static void invoke()
    {
        guessAnswer();
    }
}