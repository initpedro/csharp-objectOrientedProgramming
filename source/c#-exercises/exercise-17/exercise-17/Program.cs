using System;

namespace exercise17 {
    internal class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-------------------");

            // Lê-se: para cada string "apelido" contido no "vetor"
            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
