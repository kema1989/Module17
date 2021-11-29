using System;

namespace M17U2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Singleton
    {
        private static Singleton Connection { get; set; }
        private Singleton() { }

        public static Singleton ConnectTo(string configuration)
        {
            if (Connection == null)
                Connection = new Singleton();
            return Connection;
        }
    }
}
