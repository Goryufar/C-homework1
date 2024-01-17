using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        private static int j;

        static void Main(string[] args)
        {
            Console.WriteLine("input ex 1-7");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Weather();
                    break;
                case 2:
                    edgeGroup();
                    break;
                case 3:
                    tempConvertor();
                    break;
                case 4:
                    maxMinInArray();
                    break;
                case 5:
                    swap();
                    break;
                case 6:
                    secondLargest();
                    break;
                case 7:
                    arraySum();
                    break;
                default:
                    Console.WriteLine("your input doesnt satisfy to requierments !!!");
                    break;

            }

            Console.Read();
        }


        public static void Weather()
        {
            Console.WriteLine("Please input wheather temprature");

            int _input = Convert.ToInt32(Console.ReadLine());

           

            if (_input> 30)
            {
                Console.WriteLine("It is too hot ");
            }
            else if (_input > 10 && _input < 30)
            {
                Console.WriteLine("It is cool ");
            }
            else
            {
                Console.WriteLine("Freezing weather");
            }

            
        }

        public static void edgeGroup()
        {
            Console.WriteLine("Please input age ");

            int _input = Convert.ToInt32(Console.ReadLine());

            if (_input < 13 && _input>=0)
                Console.WriteLine("Child");
            else if (_input >= 13 && _input < 19)
                Console.WriteLine("Teenager");
            else if(_input >= 19 && _input <= 120)
                Console.WriteLine("Adult");
            else
                Console.WriteLine("are you sure about that???");
        }

        public static void tempConvertor()
        {
            Console.WriteLine("Farenhate to Celcius");
            Console.WriteLine("please input 1 if you want to swich");
            int _swich = Convert.ToInt32(Console.ReadLine());

            if (_swich == 1)
            {

                Console.WriteLine("Please input Celcius ");
                float Celsius = Convert.ToInt32(Console.ReadLine());

                float Fahrenheit = Celsius * 9 / 5 + 32;
                Console.WriteLine("Celcius to farehhate :" + Fahrenheit);


            }
            else
            {
                
                Console.WriteLine("Please input Farenhate ");
                float Fahrenheit = Convert.ToInt32(Console.ReadLine());

                float Celsius = (Fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Farenthait to Celcius :" + Celsius);
            }


        }

        public static void maxMinInArray()
        {
            int[] arr = { 120, 3232, 432, -100, 120 };

            int min = arr[0];
            int max = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
               
                    min = arr[i];
                

                if (arr[i] > max)
                    max = arr[i];
            }

            Console.WriteLine("min is "+ min );

            Console.WriteLine("min is " + max);
        }


        public static void swap()
        {
            Console.WriteLine("----------- " );
            int[] arr = { 120, 3232, 432, -100, 120 };
            int i = 0;
            int j = arr.Length-1;
            for (; i < j ; i++, j--)
            {
              
                    int temp = 0;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                        
                    
                    
            }

            for (int k = 0; k < arr.Length; k++)
                Console.WriteLine(arr[k]);
        }

        public static void secondLargest()
        {
            int[] arr = { 120, 3232, 432, -100, 120,231312,32,23,2,32,21,1,3 };

         

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {

                        int temp = 0;
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }


                }
            }

            for (int k = 0; k < arr.Length; k++)
                Console.WriteLine(arr[k]);


            Console.WriteLine("second largest is " + arr[arr.Length-2]);
        }

        public static void arraySum()
        {
            Console.WriteLine("----------- ");
            int[] arr1 = { 120, 3232, 432, -100, 120 };
            int[] arr2 = { 20, 332, 4232, 100, -120 };

            int[] sum = new int[(arr1.Length + arr2.Length)/2];

            for(int i = 0; i < arr1.Length; i++)
            {
                sum[i] = arr1[i] + arr2[i];
            }


            for (int k = 0; k < sum.Length; k++)
                Console.WriteLine(sum[k]);
        }
    }
}
