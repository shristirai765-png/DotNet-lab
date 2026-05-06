class TemperatureConversion
{
    static double convertToCelsius(double temp)
    {
        double C = (temp - 32)* 5/9;
        return C;
    }
    static double convertToFahrenheit(double temp)
    {
        double F = (temp * 9/5)+ 32;
        return F;
    }
    public static void invoke()
    {
        double celsius = convertToCelsius(62);
        Console.WriteLine("Converting Fahrenheit to Celsius: " + celsius);
        double fahrenheit = convertToFahrenheit(18.5);
        Console.WriteLine("Converting Celsius to Fahrenheit: " + fahrenheit);
    }
}