namespace ConstructorNs
{
    class ConstructorTypes
    {
        static ConstructorTypes()
        {
            Console.WriteLine("This is static constructor");
        }
        public ConstructorTypes()
        {
            Console.WriteLine("This is default constructor");
        }
    }
    class ConstructorTypesDemo
    {
        public static void invoke()
        {
            ConstructorTypes ct = new ConstructorTypes();
            ConstructorTypes ct1 = new ConstructorTypes();
        }
    }
}
