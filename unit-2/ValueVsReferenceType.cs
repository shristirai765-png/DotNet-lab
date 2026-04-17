// /*Make a method that takes a value type and a reference type as parameters, and modifies them inside the method.
//  Then, call this method 
//  */ 
// class ValueVsReferenceType
// {
//     /*
//     pass args
//     print args
//     give new value to a variable
//     print the new value
//     change the original value and the new value
//     print the origial value and the new value
//      */
//     public static void demonstrateValueType(int value)
//     {
//         Console.WriteLine(value);
//         int newValue = value;
//         Console.WriteLine(newValue);
//         value = value -100;
//         newValue = 400;
//         Console.WriteLine(value);
//         Console.WriteLine(newValue);
        
//     }

//     public static void demonstrateReferenceType(ref int value)
//     {
//         Console.WriteLine(value);
//     }
//     public static void invoke()
//     {
//         int number = 10;
//         demonstrateValueType(100);
//         demonstrateReferenceType(ref number);
//     }
// }