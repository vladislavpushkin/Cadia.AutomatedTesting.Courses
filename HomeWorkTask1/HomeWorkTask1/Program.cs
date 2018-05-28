using System;

namespace HomeWorkTask1
{
    class Phrases
    {
        public static int count = 0;

        public string phrase1;
        public string phrase2;

        public Phrases(string _phrase1, string _phrase2)
        {
            phrase1 = _phrase1;
            phrase2 = _phrase2;

            count++;
            Print();
        }

        public void Print()
        {
            Console.WriteLine("phrase1:" + phrase1);
            Console.WriteLine("phrase2:" + phrase2);
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
                Phrases English = new Phrases("Good day!", "Anything new?");
                Console.WriteLine();

                Phrases French = new Phrases("Bonjour!", "Quoi de neuf?");
                Console.WriteLine();

                Phrases Deutsch = new Phrases("Guten Tag!", "Irgend was Neues?");
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }
}
