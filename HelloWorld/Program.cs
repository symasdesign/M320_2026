using System.ComponentModel.DataAnnotations;

namespace HelloWorld {
    internal class Program {
        static void PrintNumber(int k) {
            k = k + 3;
            Console.WriteLine($"Zahl: {k}");
        }

        static void PrintMessage(string s) {
            s = s + "abc";
            Console.WriteLine($"Message: {s}");

        }

        static void PrintPerson(Person pers) {
            pers.Age += 3;
            Console.WriteLine($"Person Name: {pers.Name}, Age: {pers.Age}");
        }

        static void Main(string[] args) {

            //var res = Add(5, 7);

            int[] values = new int[20];
            values[3] = 7;

            int[] values2 = new int[25];
            Console.WriteLine(values2[3]);

            // for-Schleife(init schleifenvariable; schleifen-bedingung; aktion nach jeder itration)
            for (int i = 0; i < 20; i++) {
                values2[i] = values[i];
            }
            Console.WriteLine(values2[3]);

            Person p2 = new Person();
            Person[] persList = new Person[20];

            return;
            //values[23] = 6;

            //int a = 5;
            //PrintNumber(a);
            //Console.WriteLine($"Main: {a}");

            //var message = "Hallo";
            //PrintMessage(message);
            //Console.WriteLine($"Main: {message}");

            var p = new Person();
            p.Name = "Thomas";
            p.Age = 48;
            PrintPerson(p);
            Console.WriteLine($"Main Name: {p.Name}, Age: {p.Age}");

            var q = new Person();
            q.Name = "Ben";
            q.Age = 5;
            PrintPerson(q);
            Console.WriteLine($"Main Name: {q.Name}, Age: {q.Age}");

        }


        static int Add(int a, int b) {
            int c = a + b;

            return c;
        }

    }

    public class Person {
        //public string Name;   // Attribut
        public string Name { get; set; }   // Property
        public int Age { get; set; }
    }
}
