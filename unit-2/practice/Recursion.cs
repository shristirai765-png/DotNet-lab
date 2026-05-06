using System.Reflection.PortableExecutable;

class Recursion
{
   
    static void charToString(char[] words, int n)
    {
        // Console.WriteLine()
        // string result = new string(words);
        // string[] stringArray = words.Select(c => c.ToString()).ToArray();

        if (n < 0)
            return;
        Console.WriteLine(words[n]);
        charToString(words, n - 1);
        
    }
    public static void invoke()
    {
        char[] names = {'S', 'A', 'P'};
        charToString(names, names.Length - 1);
    }
}