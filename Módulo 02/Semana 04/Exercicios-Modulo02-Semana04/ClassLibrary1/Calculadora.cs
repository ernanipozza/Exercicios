using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public static class Calculadora {

        public static int somar (int a, int b) {
            return a + b;
        }
        public static int somar (int a, int b, int c) {
            return a + b + c;
        }
        public static int subtrair (int a, int b) {
            return a - b;
        }
        public static int subtrair(int a, int b, int c) {
            return a - b - c;
        }
        public static int multiplicar (int a, int b) {
            return a * b;
        }
        public static int multiplicar(int a, int b, int c) {
            return a * b * c;
        }

        public static int dividir (int a, int b) {
            return a / b;
        }
        public static int dividir(int a, int b, int c) {
            return a / b / c;
        }


    }
}
