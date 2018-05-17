using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            LabList LabEighteen = new LabList();
            LabEighteen.Add("James");
            LabEighteen.Add("Martin");
            LabEighteen.Add("Luke");
            LabEighteen.Add("James");
            LabEighteen.Add("Susan");
            LabEighteen.Add("James");
            LabEighteen.Add("Sarah");
            LabEighteen.Add("Jane");

            LabEighteen.PrintInfo();

            LabEighteen.removeAll("James");

            LabEighteen.PrintInfo();



            int[] numbers = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };

            int largest = Validation.FindLargestInt(numbers);
            int[] frequency = new int[largest];

            Validation.CompareMethod(numbers, frequency);

            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine($"[{i}]: {frequency[i]}");
            }
        }
    }
}
