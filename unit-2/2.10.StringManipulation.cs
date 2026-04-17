/*
WAP in cs to demonstrate the use of string manipulation functions, string interpolation, escape sequence, 
string concatenation, string length, string comparison, string case conversion, string trimming,
string splitting, string joining, string searching, string replacing, string formatting.
*/
class StringManipulation
{
    static void stringFormatting()
    {
        string result = string.Format("Item: {0}, Price: {1:C}", "Coffee", 2.50);

    }
    static void stringReplacing()
    {
        string greeting = "Good Morning";
        string newGreeting = greeting.Replace("Morning", "Evening");
        Console.WriteLine(newGreeting);
    }
    static void stringSearching()
    {
        string[] names = {"Shristi", "Khushi", "Salina", "Sapana"};
        Console.WriteLine(names.Contains("Shristi"));
    }
    static void stringJoining()
    {
        string[] fruits = {"Apple", "Banana", "Mango", "Orange"};
        Console.WriteLine(string.Join(",",fruits));
    }
    
    static void stringInterpolation()
    {
        string name = "Shristi";
        string course = "C#";
        Console.WriteLine($"Hi, My name is {name} and I am learning {course}");

    }
    static void escapeSequence()
    {
        string text = "This \n is a \t very \v good morning \\";
        Console.WriteLine(text);
    }
    static void stringConcatenation()
    {
        string str1 = "Hello";
        string str2 = "World";
        Console.WriteLine(str1 + "," + str2);
    }
    static void stringLength()
    {
        string name = "Shristi";
        Console.WriteLine(name.Length);
    }
    static void stringComparison()
    {
        string fName = "Shristi";
        string lName = "Rai";
        Console.WriteLine(string.Equals(fName,lName));
    }
    static void caseConversion()
    {
        string greeting = "good morning";
        Console.WriteLine(greeting.ToUpper());

    }
    static void stringTrimming()
    {
        Console.WriteLine("Enter any text:");
        string textInput = Console.ReadLine()!;
        Console.WriteLine(textInput.Trim());
    }
    static void stringSplitting()
    {
        string text = "HelloWorld";
        string[] words = text.Split(' ');
        Console.WriteLine(words);
    }

    public static void invoke()
    {
        stringInterpolation();
        stringConcatenation();
        escapeSequence();
        caseConversion();
        stringComparison();
        stringTrimming();
        stringFormatting();
        stringSearching();
        stringJoining();
        stringReplacing();
        stringSplitting();
    }
}