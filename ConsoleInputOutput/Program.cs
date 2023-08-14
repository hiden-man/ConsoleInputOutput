using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            ConsoleInputOutput();
        }
        static void ConsoleInputOutput()
        {
        RightAnswer:
            int firstNum = random.Next(1, 101),
                SecondNum = random.Next(1, 101);
            string symbolOperators = "";
            byte RandomOperator = Convert.ToByte(random.Next(1, 5));
            if (RandomOperator == 1)
                symbolOperators = "+";
            if (RandomOperator == 2)
                symbolOperators = "-";
            if(RandomOperator == 3)
                symbolOperators = "/";
            if(RandomOperator == 4)
                symbolOperators = "*";
            Incorrect:
            Console.WriteLine($"{firstNum} {symbolOperators} {SecondNum} = ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (firstNum + SecondNum) ||
                answer == (firstNum - SecondNum) ||
                answer == (firstNum * SecondNum) ||
                answer == (firstNum / SecondNum))
            {
                Console.WriteLine("Right");
                goto RightAnswer;
            }
            if (answer != (firstNum + SecondNum) ||
                answer != (firstNum - SecondNum) ||
                answer != (firstNum * SecondNum) ||
                answer != (firstNum / SecondNum))
                goto Incorrect;
        }
    }
}
