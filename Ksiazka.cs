using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_consol_app
{
    public class Ksiazka
    {
        // właściwości == property  książki, poniżej są to property
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int DataPublikacji { get; set; }
        public bool CzyPrzeczytana { get; set; }

        //przykład konstruktora z parametrami
        public Ksiazka(int id, string tytul, string autor, int dataPublikacji, bool czyPrzeczytana)
        {
            Id = id;
            Tytul = tytul;
            Autor = autor;
            DataPublikacji = dataPublikacji;
            CzyPrzeczytana = czyPrzeczytana;
        }


        //metody czyli co ta książka (klasa) będzie robić, jak będzie działała, sposób działania, wyświetl informacje o książce
        public void WyswietlInformacjeOKsiazce()
        {
            //Console.WriteLine("Tytuł: " +Tytul +", Autor: " +Autor +", Data publikacji: " +DataPublikacji );
            //Console.WriteLine("Inny sposób kodowania");
            string przeczytana = CzyPrzeczytana ? "Przeczytana" : "Nieprzeczytana";
            Console.WriteLine($"Id = {Id}, Autor: {Autor}, Tytuł: {Tytul}, Data publikacji: {DataPublikacji}, Status: {przeczytana}");
        }

        // 00:15 filmu

    }
}
