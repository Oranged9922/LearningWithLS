using System.Threading.Channels;

namespace LearningWithLS.FirstSteps
{
    class Program
    {

        public static void Main(string[] args)
        {
            //task_0_1();
            //task_0_2();

            task_1_1();
            task_1_2();
            task_1_3();
            task_1_4();
            task_1_5();

            task_2_1();
            task_2_2();
            task_2_3();
            task_2_4();
            task_2_5();
            task_2_6();
            task_2_7();
            task_2_8();
            task_2_9();
            task_2_10();
            task_2_11();
            task_2_12();

            task_3_1();
            task_3_2();

            task_4_1();

        }

        // Implement these :)

        /// 0 parsing input to int, basic (integer) math
        /// _0_1
        /// <summary>
        /// Read values of 2 integer numbers and save them as variables a1, a2. Calculate and display their sum.
        /// </summary>
        static void task_0_1()
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine(a1 + a2);
        }

        //
        // _0_2
        /// <summary>
        /// Read values of 3 integer numbers and save them as variables a1, a2, a3. Calculate and display their product.
        /// </summary>
        static void task_0_2()
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine(a1 * a2 * a3);
        }

        // 1 If
        // _1_1
        /// <summary>
        /// Read values of 3 integer numbers, save values as variables a1, a2, a3. Calculate and display the number of
        /// values that are equal to 0.
        /// </summary>
        static void task_1_1()
        {

            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int total = 0;
            if (a1 == 0) total++;
            if (a2 == 0) total++;
            if (a3 == 0) total++;
            Console.WriteLine(total);
        }
        // _1_2. 
        /// <summary>
        /// Read values of 4 integer values and save them as variables a1, a2, a3, a4. Using MODULO operation, find the
        /// even ones and calculate and display their sum.
        ///</summary>
        static void task_1_2()
        {

            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());

            int sum = 0;
            if (a1 % 2 == 0) sum += a1;
            if (a2 % 2 == 0) sum += a2;
            if (a3 % 2 == 0) sum += a3;
            if (a4 % 2 == 0) sum += a4;
            Console.WriteLine(sum);
        }
        // _1_3. 
        /// <summary>
        /// Read values of 2 integer numbers. Find and display the one which is lower.
        /// </summary>
        static void task_1_3()
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine(a1 < a2 ? a1 : a2);
            // basically equals to this
            //
            // if (a1 < a2) Console.WriteLine(a1);
            // else Console.WriteLine(a2);
        }


        // _1_4. 
        /// <summary>
        /// Read values of 4 integer numbers. Find and display the one with the highest value.
        /// </summary>
        static void task_1_4()
        {

            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());

            int max = a1;
            if (max < a2) max = a2;
            if (max < a3) max = a3;
            if (max < a4) max = a4;
            Console.WriteLine(max);

        }
        // _1_5. 
        /// <summary>
        /// Read value of an integer number X. If X is odd number, then read values of another 5 integer numbers. If X
        /// is the middle one, then calculate and display the sum and the product of the sequence (each on its own line).
        /// </summary>
        static void task_1_5()
        {
            int X = int.Parse(Console.ReadLine());

            if (X % 2 != 1) return;
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            int a5 = int.Parse(Console.ReadLine());

            if(X != a3) return;
            int sum = 0, product = 1;
            sum += a1;
            product *= a1;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            sum += a2;
            product *= a2;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            sum += a3;
            product *= a3;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            sum += a4;
            product *= a4;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            sum += a5;
            product *= a5;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
        }
        // 2 For
        // _2_1. 
        /// Display all odd numbers between 0 and 100.
        /// </summary>
        static void task_2_1()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 == 1) Console.WriteLine(i);
            }

        }
        // _2_2. 
        /// <summary>
        /// Display the sum of all even numbers between 0 and 100.
        /// </summary>
        static void task_2_2()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0) sum += i;
            }

            Console.WriteLine(sum);
        }
        // _2_3. 
        /// <summary>
        /// Read value of an integer number N. Calculate and display the sum of odd numbers from interval (1;N>.
        /// </summary>
        static void task_2_3()
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 1) sum += i;
            }

            Console.WriteLine(sum);
        }
        // _2_4. 
        /// <summary>
        /// Read values of 100 integer numbers. Calculate and display their sum.
        /// </summary>
        static void task_2_4()
        {
            int[] values = new int[100];
            for (int i = 0; i < 100; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }

            // using LINQ
            //Console.WriteLine(values.Sum());

            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            Console.WriteLine(sum);
        }
        // _2_5. 
        /// <summary>
        /// Read values of 100 integer numbers. Find and display the one with the highest value.
        /// </summary>
        static void task_2_5()
        {
            int[] values = new int[100];
            for (int i = 0; i < 100; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }

            // using LINQ
            //Console.WriteLine(values.Sum());

            int max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (max < values[i]) max = values[i];
            }
            Console.WriteLine(max);
        }
        // _2_6. 
        /// <summary>
        /// Read values of a real number X and an integer number N. Calculate and display the N-th power of X.
        /// </summary>
        static void task_2_6()
        {

        }
        // _2_7. 
        /// <summary>
        /// Read value of integer number N. Then read values of N integer numbers. Calculate and display how many
        /// numbers greater than 50 you have read.
        /// </summary>
        static void task_2_7()
        {

        }
        // _2_8. 
        /// <summary>
        /// Read values of integer numbers A and B. Calculate and display the sum and the products of integers laying
        /// between the given interval (A; B> (including interval boundaries).
        /// </summary>
        static void task_2_8()
        {

        }
        // _2_9. 
        /// <summary>
        /// Read integer number N. Calculate and display the product of the first N natural numbers that can be divided by 3.
        /// </summary>
        static void task_2_9()
        {

        }
        // _2_10. 
        /// <summary>
        /// Read integer number N. Then read a sequence of N integer numbers. Find the maximal and minimal value
        /// from that sequence and display them. Real numbers, Advanced math
        /// </summary>
        static void task_2_10()
        {

        }
        // _2_11. 
        /// <summary>
        /// Read value of a real number A. Calculate and display the value of an edge, volume and surface of a
        /// cube that has a length of its body diagonal A.
        /// </summary>
        static void task_2_11()
        {

        }
        // _2_12. 
        /// <summary>
        /// Read value of an integer number N. Then read values of N real numbers. Calculate and display the
        /// average of real numbers.
        /// </summary>
        static void task_2_12()
        {

        }
        // 3 Nested for loops
        // _3_1
        /// <summary>
        /// Read value of an integer number A. Find out and display whether number A is a prime.
        /// </summary>
        static void task_3_1()
        {

        }
        // _3_2
        /// <summary>
        /// Read value of an integer number N. Find and display all prime numbers from interval (1; N>.
        /// </summary>
        static void task_3_2()
        {

        }
        // 4 While
        // _4_1
        /// <summary>
        /// Read integer values until you encounter number 42. Calculate and display the sum of all numbers you
        /// have read.
        /// </summary>
        static void task_4_1()
        {

        }
    }
}