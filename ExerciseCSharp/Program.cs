using System; //using this mainspace

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args) // everything inside main will be executed // args = arguments
        {

            int numInt = 5; //initialized variable (variabile di tipo intero) (variabile dichiarata,variabile assegnata,variabile inizzializzata )

            string name = "Jon"; //variabile inizzializzata
            string surname;//variabile dichiarata
            surname = "Smith"; //variabile assegnata

            string apici = "20"; // un numero dentro "" e' una stringa

            // variabile riassegnata
            name = "Luke";
            surname = "Jonson";

            Console.WriteLine(name + " " + surname); // la variabile sara' riassegnata con successo e apparira' Luke Jonson


            // Fizz buzz problem

            //for (int i = 1; i <= 100; i++)
            //{
            //if (i % 3 == 0 && i % 5 == 0)
            //{
            //Console.WriteLine("FizzBuzz");
            //}
            //else if (i % 3 == 0)
            //{
            //Console.WriteLine("Fizz");
            //}
            //else if (i % 5 == 0)
            //{
            //Console.WriteLine("Buzz");
            //}
            //else
            //{
            //Console.WriteLine(i);
            //}
            //}







            //    public class Fibonacci
            //{
            //    public static int Calculate(int n)
            //    {
            //        if (n < 2)
            //            return n;
            //        else
            //            return Calculate(n - 1) + Calculate(n - 2);
            //    }
            //}






            //float numFloat = 1.2F; //initialized variable (variabile di tipo Numeri con virgola) //F is a suffix
            //double numDouble = 4.5684; //initialized variable (variabile di tipo Numeri con virgola ma puo' avere piu' cifre dopo la virgola)
            //bool trueBool = true; //initialized variable (variabile di tipo booleana true)
            //bool falseBool = false; //initialized variable (variabile di tipo booleana false)
            //char sentChar = 'Hello World!'; //initialized variable (variabile di tipo booleana false)
            //string textString = "Hello World!"; //initialized variable (variabile di tipo booleana false)

            //Console.WriteLine(numInt); //print hello, World!




            //Tipi di Dati



            string testo = "Lorem ipsum"; // string = "testo" 
            string add = "dolor";
            string combinazione = testo + " " + add;
            char carattere = 'c';  // char = 'singolo carattere'
            int intero = 10; // int = numero intero fino a 10 mld, puo' essere negativo "-10"
            long varlong = 2050000520550; //Long = Valore lungo

            float virgola = 5.5f; // float conserva tra le 6 e le 9 cifre dopo la virgola 
            double doppi = 5.5f; //double permette di andare di due cifre dopo la virgola
            decimal decimale = 5.5m; // decimale permette un numero piu' preciso

            bool trueFalse = true; // bool = valore che puo' essere True o False


            string upper = testo.ToUpper();

            //Console.WriteLine(combinazione);
            //Console.WriteLine("Avvio testo: {0} {1}", testo, add); // poter scrivere una variabile all'interno delle "" utilizzando {}   
            //Console.WriteLine($"Avvio testo: {testo} {add}"); //mettendo $ all'inizio permette di richiamare le variabili all'interno delle ""
            //Console.WriteLine(upper); // apparira' "LOREM IPSUM"
            //Console.WriteLine(testo.Length); // conta la lunghezza del testo
            //Console.WriteLine(testo.IndexOf('e')); // indica dove si trova la lettera "e" in oridne di numeri a pertire da 0
            //Console.WriteLine(testo.Substring(6)); // fa partire il testo dal carattere 6, quindi -> "ipsum"



            // Calcolatrice addizionale 

            Console.WriteLine("Inserisci numero 1");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Inserisci numero 2");
            string numero2 = Console.ReadLine();

            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);

            int risultato = num1 + num2;
            string result = $"La somma tra {num1} e {num2} e': {risultato}";

            Console.WriteLine(result);





            Console.Read(); // used to make sure it doesn't close by himself, it doesn't close until you press a key
        }

        //static bool trueResponse(int numInt) // bool ritorna un valore booleano // (int numInt) -> valore di ingresso
        //{
        //    Console.WriteLine(numInt);

        //}

    }
}