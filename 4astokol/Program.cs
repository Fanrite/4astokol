using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4astokol
{
    class Program
    {
        static void encrypt(ref string msg, ref int key, ref string result)
        {
            char[] charArr = msg.ToCharArray();
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; i + j < charArr.Length; j += key)
                {
                    result += charArr[i + j];
                }
            }
        }

        static void decrypt(ref string msg, ref int key, ref string result)
        {
            char[] charArr = msg.ToCharArray();
            char[] resultchar = msg.ToCharArray();
            int k = 0;
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; i + j < charArr.Length; j += key)
                {
                    resultchar[i + j] = msg[k++];
                }
            }
            result += resultchar;
        }


        static void Main(string[] args)
        {
            string msg = "", result = "", decry = "";
            int key = 2;

            Console.Write("Введіть що зашифрувати:");
            msg = Console.ReadLine();

            Console.Write("Введіть ключ:");
            key = Convert.ToInt32(Console.ReadLine());

            encrypt(ref msg, ref key, ref result);
            decrypt(ref result, ref key, ref decry);

            Console.WriteLine($"Зашифроване повідомлення:{result}");
            Console.WriteLine($"Розштфроване повідомлення:{msg}");

            Console.ReadKey();

        }
    }
}
