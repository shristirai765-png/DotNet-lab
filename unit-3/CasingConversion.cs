/*wap to covert any given string into any of the following cases such as pascalcase, upper snakecase,lower snakecase, kebabcase, camelcase and
(switch cases)
print the available casing in the console and 
take string input from user to allow user to select casing of their choice 

*/
class CasingConversion
{
    static string conversion(string text)
    {
        Console.WriteLine("Available cases: ");
        Console.WriteLine("1. PascalCase");
        Console.WriteLine("2. Upper snakeCase");
        Console.WriteLine("3. Lower snakeCase");
        Console.WriteLine("4. KebabCase");
        Console.WriteLine("5. camelCase");
        Console.WriteLine("In which case do you want to convert the string into? ");
        string choice = Console.ReadLine()!.ToLower();
        string[] words = text.Split(' ');

        switch (choice)
        {
            case "pascal":
                string result="";
                foreach(string w in words){
                    result += char.ToUpper(w[0])+ w.Substring(1).ToLower();
                }
                return result;

            case "lower snake":
                return string.Join("_", words).ToUpper();

            case "upper snake":
                return string.Join("_", words).ToUpper();
            
            case "kebab":
                return string.Join("-", words).ToLower();
            
            case "camel":
                string camelCase= words[0].ToUpper();
                for(int i = 1; i<words.Length; i++)
                {
                    camelCase += char.ToUpper(words[i][0])+words[i].Substring(1).ToLower();
                }
                return camelCase;

            default:
                return "Invalid Choice! Please try again.";

        }
        

    }
    public static void invoke()
    {
        Console.WriteLine("Enter any string input: ");
        string input = Console.ReadLine()!;

        string result = conversion(input);
        Console.WriteLine("Result: " + result);
    }
}