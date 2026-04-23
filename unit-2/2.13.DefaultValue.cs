using System.Runtime.InteropServices;
//  WAP in C# to print the default values of basic data types (int, double, bool, char, string)
class DefaultValue
{
    public static void invoke()
    {
        decimal defaultDecimal = default(decimal);
        char defaultChar = default(char);
        string defaultString = default(string);
        int defaultInt = default(int);
        bool defaultBool = default(bool);
        double defaultDouble = default(double);

        Console.WriteLine(defaultInt);
        Console.WriteLine(defaultBool);
        Console.WriteLine(defaultDouble);
        Console.WriteLine(defaultDecimal);
        Console.WriteLine(defaultChar);
        Console.WriteLine(defaultString);
    }
}