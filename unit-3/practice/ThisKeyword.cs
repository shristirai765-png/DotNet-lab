//wap in c# to demonstrate the difference between class fields and method parameters
//scenario - prepare a class named student and use setname with string as an argument and getname methods for field name 
class ThisKeyword
{
    public string name = "Rai";
    public void setName(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return this.name;
    }
    public static void invoke()
    {
        ThisKeyword thisKeyword = new ThisKeyword();
        Console.WriteLine(thisKeyword.name);//" "
        thisKeyword.setName("Shristi");
        Console.WriteLine(thisKeyword.name);//Shristi
        string getName = thisKeyword.getName();
        Console.WriteLine(getName); //shristi


    }
}
