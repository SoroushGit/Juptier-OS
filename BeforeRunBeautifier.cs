using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jupiter
{
    public class BeforeRunBeautifier
    {
        public static void Runner()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine(Variables._Banner + "\n\n");
            DelayerWriter("Welcome to Jupiter!");
            Console.WriteLine("\n\n");
        }
        public static void DelayerWriter(string text) 
        {
            for(int i = 0; i < text.Length; i++) 
            {
                Console.Write(text[i]);
                Thread.Sleep(1); 
            }
            return;
        }
    }
}
