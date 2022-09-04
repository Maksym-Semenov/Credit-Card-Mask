using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Credit_Card_Mask
{
    public static class Kata
    {
        // return masked string
        public static string Maskify(string cc)
        {
            string pattern = "\w\s";
            string replacement = "#";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(cc, replacement);

            return result;
            //string[] chars = cc.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //if (chars.Length < 4)
            //{
            //    return cc;
            //}
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string chars1 = Kata.Maskify("4556364607935616");
                Console.WriteLine(chars1);
            string chars2 = Kata.Maskify("1");
            Console.WriteLine(chars2);
            string chars3 = Kata.Maskify("11111");
                Console.WriteLine(chars3);
        }
    }
}
