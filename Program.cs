using Library_consol_app;

namespace Library_consol_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stworzyliśmy obiekt class Ksiazka panTadeusz i użyliśmy właściwości/ property tytuł, autor, data publikacji
            // poniżej przykład konstruktora bezparametrowego - konstruktor czyli coś co konstrułuje obiekt

            Ksiazka panTadeusz = new Ksiazka("Pan Tadeusz", "Adam Mickiewicz", 1834);
            Ksiazka halka = new Ksiazka("Balladyna", "Juliusz Słowacki", 1839);
            Ksiazka malyKsiaze = new Ksiazka("Mały Książe", "Antoine de Saint-Exupery", 1943);
            

            // jeżeli używamy konstruktora !!! konstruktora z parametrem to nie przypisujemy poniższych wartości w ten sposób. Ten sposób  jest tylko w przypadku konstruktora bezparametrowego
            //panTadeusz.Tytul = "Pan Tadeusz";
            //panTadeusz.Autor = "Adam Mickiewicz";
            //panTadeusz.DataPublikacji = 1834;

            //poniżej wyświetliliśmy info o tej książce
            //w nawiasach można przekazywać parametry, poniżej jednak w () nie przekazano parametrrów
            panTadeusz.WyswietlInformacjeOKsiazce();
            halka.WyswietlInformacjeOKsiazce();
            malyKsiaze.WyswietlInformacjeOKsiazce();


            // live 43"
        }
    }
}
