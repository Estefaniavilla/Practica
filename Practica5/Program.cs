namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {

            int num, aux, dec, uni, cen;
            string linea;
            Console.WriteLine("Enter a number:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            cen = num / 100;
            num = num % 100;
            dec = num / 10;
            uni = num % 10;
            aux = (uni * 100) + (dec * 10) + cen;
            Console.WriteLine("The inverted number will be: " + aux);
            Console.WriteLine("Press any key to exit:"); 
            Console.ReadLine();
        }
    }
}
