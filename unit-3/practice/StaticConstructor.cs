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
        public static
    }
    class ConstructorTypesDemo
    {
        public static void invoke()
        {
            ConstructorTypes ConstructorTypes = new ConstructorTypes();
            ConstructorTypes();
            ConstructorTypes ConstructorTypes1 = new ConstructorTypes();
            ConstructorTypes1();
        }
    }
}
