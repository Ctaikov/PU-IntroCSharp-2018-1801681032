using System;
using System.IO;
using System.Text;

namespace StudentNameList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] lines = File.ReadAllLines(@"C:\Users\Staikov\Desktop\STD2018\PU-IntroCSharp-2018-1801681032\PUIntroHomeworks\StudentNameList\files\Students.txt");
            Console.WriteLine("Contents of Students.txt :");
            int sum = 0;
            char smileyFace = '\u263a';
            foreach (string line in lines)
            {
                string[] currentElements = line.Split(' ');
                string firstName = currentElements[1];
                string surName = currentElements[2];
                string lastName = currentElements[3];
                string fullName = $"{firstName} {surName} {lastName}";
                for (int i = 0; i < fullName.Length; i++)
                {
                    sum = sum + (int)fullName[i];
                }
                if(sum>=15000)
                {

                    Console.WriteLine($"{fullName} {smileyFace} => {sum}");
                }
                else
                {
                    Console.WriteLine($"{fullName} => {sum}");
                }
            }
        }
    }
}
