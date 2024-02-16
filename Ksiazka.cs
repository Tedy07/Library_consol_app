﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_consol_app
{
    public class Ksiazka
    {
        // właściwości == property książki, poniżej są to property
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int DataPublikacji { get; set; }

        
        //metody czyli co ta książka (klasa) będzie robić, jak będzie działała, sposób działania, wyświetl informacje o książce
        public void WyswietlInformacjeOKsiazce()
        {
            Console.WriteLine("Tytuł: " +Tytul +", Autor: " +Autor +" Data publikacji: " +DataPublikacji );
            Console.WriteLine("Inny sposób kodowania");
            Console.WriteLine($"Tytuł: {Tytul}, Autor: {Autor}, Data publikacji: {DataPublikacji}");

        }


    }
}