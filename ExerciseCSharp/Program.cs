using System; //using this mainspace

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args) // everything inside main will be executed // args = arguments
        {

            int numInt = 5; //initialized variable (variabile di tipo intero)
            //float numFloat = 1.2F; //initialized variable (variabile di tipo Numeri con virgola) //F is a suffix
            //double numDouble = 4.5684; //initialized variable (variabile di tipo Numeri con virgola ma puo' avere piu' cifre dopo la virgola)
            //bool trueBool = true; //initialized variable (variabile di tipo booleana true)
            //bool falseBool = false; //initialized variable (variabile di tipo booleana false)
            //char sentChar = 'Hello World!'; //initialized variable (variabile di tipo booleana false)
            //string textString = "Hello World!"; //initialized variable (variabile di tipo booleana false)

            Console.WriteLine(numInt); //print hello, World!

            Console.Read(); // used to make sure it doesn't close by himself, it doesn't close until you press a key
        }

        //static bool trueResponse(int numInt) // bool ritorna un valore booleano // (int numInt) -> valore di ingresso
        //{
        //    Console.WriteLine(numInt);

        //}

    }
}