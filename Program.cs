namespace ENUM
{
    class Program {

        enum newEnum {
            One = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Direct Access : " + newEnum.One);

            Console.WriteLine("Enum Value : " + (int)newEnum.One);

            // Creating Instance;
            newEnum newenum = newEnum.Five;

            Console.WriteLine("Instance : " + newenum);

            Console.WriteLine("Instance Enum Value : " + (int)newenum);

            int x = 7;

            newEnum nenum = (newEnum)x;

            Console.WriteLine("Converted : " + nenum);

            Console.WriteLine("Converted Enum Value : " + (int)nenum);
            


        }
    }
}