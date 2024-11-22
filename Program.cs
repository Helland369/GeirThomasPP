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
        static void reverse()
        {

            Console.WriteLine("Skriv noe her!! Så blir den feil vei");

            string x = Console.ReadLine();

            for (int i = 0; i < x.Length; i++)
            {

                Console.Write(x[x.Length - i - 1]);
            }
        }

        static void upCase()
        {

            Console.WriteLine("Skriv noe for å få det is store bokstaver!");

            string y = Console.ReadLine().ToUpper();

            Console.WriteLine(y);
        }
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Velg her: ");
            Console.WriteLine("1) Trykk 1 for å reversere teksten");
            Console.WriteLine("2) Trykk 2 for å få store bokstaver");
            Console.WriteLine("3) Trykk 3 for å avslutte");
            switch (Console.ReadLine())
            {
                case "1":
                    reverse();
                    return true;
                case "2":
                    upCase();
                    return true;
                case "3":
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
