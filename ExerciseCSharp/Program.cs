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


            //float numFloat = 1.2F; //initialized variable (variabile di tipo Numeri con virgola) //F is a suffix
            //double numDouble = 4.5684; //initialized variable (variabile di tipo Numeri con virgola ma puo' avere piu' cifre dopo la virgola)
            //bool trueBool = true; //initialized variable (variabile di tipo booleana true)
            //bool falseBool = false; //initialized variable (variabile di tipo booleana false)
            //char sentChar = 'Hello World!'; //initialized variable (variabile di tipo booleana false)
            //string textString = "Hello World!"; //initialized variable (variabile di tipo booleana false)

            //Console.WriteLine(numInt); //print hello, World!

            Console.Read(); // used to make sure it doesn't close by himself, it doesn't close until you press a key
        }

        //static bool trueResponse(int numInt) // bool ritorna un valore booleano // (int numInt) -> valore di ingresso
        //{
        //    Console.WriteLine(numInt);

        //}

    }
}