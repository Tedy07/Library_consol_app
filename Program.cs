namespace Library_consol_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! wprowadz swoje imię: ");

            string imie = Console.ReadLine();
            string imie2 = "Adam";
            int liczbaCalkowita = 4;
            bool prawdaFalsz = false;

            if (string.IsNullOrEmpty(imie) == true)
            {
                Console.WriteLine("Nie podałeś imienia");
            } else
            {
                Console.WriteLine($"Podałeś stringa: {imie}");
            }

            for (int i = 0; i < 10; i++)
            {

            }
            
        }
    }
}
