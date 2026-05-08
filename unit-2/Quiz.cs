class Quiz
{
    public void guessAnswer()
    {
        Console.WriteLine("Are you ready to play? Y/N: ");
        string input = (Console.ReadLine()!).ToUpper();
        if (input == "YES")
        {
            Console.WriteLine("What is the largest planet in the solar system? ");
            string answer = Console.ReadLine()!;
            answer = char.ToUpper(answer[0])+ answer.Substring(1).ToLower();
            // Console.WriteLine(answer);
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
        Quiz ans= new Quiz();
        ans.guessAnswer();
    }
}