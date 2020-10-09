using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите метод, который будет определять: Ряд всех простых и составных чисел в заданном диапазоне чисел!


namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = new int[100];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = i;
                if ((masiv[i] / 2) % 2 == 0)
                {
                    Console.WriteLine($"Output {masiv[i]} ");
                }
                else
                {
                    Console.WriteLine($"Output {masiv[i]}");
                }

            }

        }
       
        
    }
}
