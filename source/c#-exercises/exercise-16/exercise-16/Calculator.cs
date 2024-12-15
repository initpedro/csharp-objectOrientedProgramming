using System.Security.Cryptography;

namespace exercise_16 {
    internal class Calculator {
        // out, armazenou o dado de out int result, vai ser a cópia da variável referência "a" no programa principal
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
