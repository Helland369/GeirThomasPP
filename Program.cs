


class Program {


    void reverse()
    {

        Console.WriteLine("Sriv noe her!! Så blir den feil vei");

        string x = Console.ReadLine();

        for (int i = 0; i < x.Length; i++)
        {

            Console.Write(x[x.Length - i - 1]);
        }
    }

    void upCase() {

        Console.WriteLine("Skriv noe for å få det is store bokstaver!");

        string y = Console.ReadLine().ToUpper();

        Console.WriteLine(y);
    }
    
    static void Main() {

        int input = 10;

        do
        {
            Console.WriteLine("1. Trykke 1 for å reversere teksten");
            Console.WriteLine("2. Trykke 1 for å få store bokstaver");

            input = Console.ReadLine();

            switch (input) {
                case 1:
                    reverse();
                    break;
                case 2:
                    upCase();
                    break;
                default:

                    break;

            }

        } while (input < 10);

    }
}




// Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert. Gjør dette uten å bruke innebygde reverse metoder
// Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
// Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase
