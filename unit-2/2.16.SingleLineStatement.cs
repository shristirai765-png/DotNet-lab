// /*
// WAP in C# to demonstrate declaration of variables and expression statements using example of sum
// of two numbers and print out the result. It should cover object initialization, ternary operator,
// and null coalescing operator.
// */
// using System;

// class SingleLineStatement
// {
//     public string text;
//     static void expressionStmt(int var1, int var2)
//     {
//         int sum = var1 + var2; 
//         Console.WriteLine(sum);
//     }
//     static void objectInitialization()
//     {
//         // var pet = new Pet {name: "cat", Age = 20};
//         // Person p = new();
//         // p.Name= "Shristi"
//         SingleLineStatement stmt = new SingleLineStatement();
//         stmt.text = "This is an example of a single line statement.";
//         Console.WriteLine(stmt.text);

//     }
//     static void nullCoalescing()
//     {
//         string s2 = null;
//         string s1= s2 ?? "nothing";
//         Console.WriteLine(s1);
        
//     }
//     static void ternaryOperator(String text)
//     {
//         string result = text.Contains("Hello")?"Its a greeting":"Its not a greeting";
//         Console.WriteLine(result);
//     }
//     public static void invoke()
//     {
//         ternaryOperator("Hello, Shristi.");
//         expressionStmt(2,4);
//         nullCoalescing();
//         objectInitialization();
//     }
// }