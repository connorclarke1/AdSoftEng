using System;

namespace BMICalculatorSpace
{
    class BMICalculator
    {
        private static string userHeightStr, userWeightStr;
        static void Main()
        {
            GetUserInfo();
            CalculateBMI();
        }

        static void GetUserInfo(){
            Console.WriteLine("Please Enter Your Weight in Kg:");
            userWeightStr = Console.ReadLine();
            Console.WriteLine("Please Enter Your Height in CM:");
            userHeightStr = Console.ReadLine();
        }
        
        static void CalculateBMI(){
            float userWeightFloat = Single.Parse(userWeightStr);
            float userHeightFloat = Single.Parse(userHeightStr);
            float BMI = userWeightFloat/((userHeightFloat/100)*(userHeightFloat/100));
            string BMIStr = BMI.ToString();
            Console.WriteLine($"Your BMI is {BMIStr}");

        }
    }
}