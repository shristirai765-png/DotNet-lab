using System.Diagnostics.CodeAnalysis;
//automatic properties
class CSK
{
    int a { get ; set; }
    int b { get; set; }
    // public CSK(int a, int b)
    // {
    //     this.a = a;
    //     this.b = b;
    // }
    int sum
    {
        get{ return a + b;}
    }

    // public int sum()
    // {
    //     return this.a + this.b;
    // }
    public static void invoke()
    {
        CSK c = new CSK();
        c.a =10;
        c.b = 20;
        Console.WriteLine(c.sum);

    }
}
//this. ->inside class
//new chk ->out