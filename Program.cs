using Library_consol_app;

namespace Library_consol_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // stworzyliśmy obiekt class Ksiazka panTadeusz i użyliśmy właściwości/ property tytuł, autor, data publikacji
            // poniżej przykład konstruktora bezparametrowego - konstruktor czyli coś co konstrułuje obiekt

            //Ksiazka panTadeusz = new Ksiazka("Pan Tadeusz", "Adam Mickiewicz", 1834);
            //Ksiazka halka = new Ksiazka("Balladyna", "Juliusz Słowacki", 1839);
            //Ksiazka malyKsiaze = new Ksiazka("Mały Książe", "Antoine de Saint-Exupery", 1943);
            //Ksiazka kodDaVinci = new Ksiazka("Kod DaVinci", "Dan Brown", 2004);

            //poniżej tworzona jest biblioteka
            Biblioteka biblio = new Biblioteka();

            //biblio.DodajKsiazke(panTadeusz);
            //biblio.DodajKsiazke(halka);
            //biblio.DodajKsiazke(malyKsiaze);
            //biblio.DodajKsiazke(kodDaVinci);
            Console.WriteLine();

            bool czyKontynuowac = true;

            while (czyKontynuowac)
            {
                Console.WriteLine("Witaj w systemie zarządzania biblioteką");
                Console.WriteLine("Wybierz dostępną operację:");
                Console.WriteLine("1. Dodaj książkę");
                Console.WriteLine("2. Wyświetl książki");
                Console.WriteLine("3. Wyjdż z aplikacji");
                Console.WriteLine("Wpisz numer operacji i zatwierdż Enterem");

                string operacja = Console.ReadLine();
                Console.WriteLine();

                switch (operacja)
                {
                    case "1":
                        Console.WriteLine("Wpisz tytuł i zatwierdz enterem: ");
                        string tytul = Console.ReadLine();

                        Console.WriteLine("Wpisz autora i zatwierdz enterem: ");
                        string autor = Console.ReadLine();

                        Console.WriteLine("Wpisz datę publikacji i zatwierdz enterem: ");
                        //int dataPublikacjiString = Int32.Parse(Console.ReadLine());
                        string dataPublikacjiTekst = Console.ReadLine();
                        int dataPublikacji;
                        int.TryParse(dataPublikacjiTekst, out dataPublikacji);
                        // ciekawy sposób pokazujący użycie TryParse !!!

                        //Tworzenie nowego obiektu i dodanie do biblioteki
                        Ksiazka ksiazka = new Ksiazka(tytul, autor, dataPublikacji);
                        biblio.DodajKsiazke(ksiazka);

                        break;
                    case "2":
                        biblio.WyswietlKsiazki();
                        break;
                    case "3":
                        czyKontynuowac = false;
                        Console.WriteLine("Zamykam aplikację ...");
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej operacji. Spróbuj ponownie... ");
                        break;
                }
            }

            // jeżeli używamy konstruktora !!! konstruktora z parametrem to nie przypisujemy poniższych wartości w ten sposób. Ten sposób  jest tylko w przypadku konstruktora bezparametrowego
            //panTadeusz.Tytul = "Pan Tadeusz";
            //panTadeusz.Autor = "Adam Mickiewicz";
            //panTadeusz.DataPublikacji = 1834;

            //poniżej wyświetliliśmy info o tej książce
            //w nawiasach można przekazywać parametry, poniżej jednak w () nie przekazano parametrrów
            //panTadeusz.WyswietlInformacjeOKsiazce();
            //halka.WyswietlInformacjeOKsiazce();
            //malyKsiaze.WyswietlInformacjeOKsiazce();
            //kodDaVinci.WyswietlInformacjeOKsiazce();

            biblio.WyswietlKsiazki();


            // live 1:30"
        }
    }
}
