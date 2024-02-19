using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_consol_app
{
    public class Biblioteka
    // jest to class, która będzie przechowywać wszystkie posiadane książki, będzie obiekt biblioteka
    //tutaj również będziemy wyświetlać wszystkie posiadane książki, w tej klasie będzie biblioteka z piękną podświetlanym regałem
    {
        //chcąc wiedzieć co mamy w bibliotece musimy mieć listę ksiązek!!!

        public List<Ksiazka> ksiazki = new List<Ksiazka>();

        public void DodajKsiazke(Ksiazka nowaKsiazka)
        {
            //chcąc dodać książkę do listy należy tą książkę wprowadzić !!!
            ksiazki.Add(nowaKsiazka);
            Console.WriteLine($"Dodano książkę: {nowaKsiazka.Tytul}");
            //powyżej informacja, że dodano książkę do listy
        }

        public void WyswietlKsiazki()
        {
            if (ksiazki.Count == 0)
            {
                Console.WriteLine("Przepraszamy, nie masz dodanych książek w bibliotece");
                return;
            }
            else
            {
                 Console.WriteLine("Ksiażki dostępne w bibliotece: ");
                foreach (var Ksiazka in ksiazki)
                {
                    Ksiazka.WyswietlInformacjeOKsiazce();
                }
            }


        }
    }
}
