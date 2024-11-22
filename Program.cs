namespace PP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool visMeny = true;
            while (visMeny)
            {
                visMeny = MainMenu();
            }
        }
        static void visPåSkjermen(string y)
        {
            Console.Clear();
            Console.WriteLine($"Dette er den modifiserte teksten: {y}");
            Console.WriteLine("Trykk en tast for å gå tilbake til menyen");
            Console.ReadKey();
        }
        static void reverse()
        {
            Console.WriteLine("Skriv noe her!! Så blir den feil vei");
            string x = Console.ReadLine();
            string letters = "";
            for (int i = 0; i < x.Length; i++)
            {

                letters += (x[x.Length - i - 1]);
            }
            visPåSkjermen(letters);
        }

        static void upCase()
        {
            Console.WriteLine("Skriv noe for å få det is store bokstaver!");
            string y = Console.ReadLine().ToUpper();
            visPåSkjermen(y);
        }

        static void removeSpaces()
        {
            Console.WriteLine("Skriv inn en setning hvor mellomrom fjernes:");
            var sentence = Console.ReadLine();
            sentence = sentence.Replace(" ", "");
            visPåSkjermen(sentence);
        }
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Velg her: ");
            Console.WriteLine("1) Trykk 1 for å reversere teksten");
            Console.WriteLine("2) Trykk 2 for å få store bokstaver");
            Console.WriteLine("3) Trykk 3 for å ta vekk mellomrom");
            Console.WriteLine("4) Trykk 4 for å avslutte");
            switch (Console.ReadLine())
            {
                case "1":
                    reverse();
                    return true;
                case "2":
                    upCase();
                    return true;
                case "3":
                    removeSpaces();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
                            } 
        }

      
    }


}

// Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert. Gjør dette uten å bruke innebygde reverse metoder
// Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
// Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase
