﻿using System;
using System.Linq;
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Требуется:
//1.Создать метод MyReverse(int[] array),
//который принимает в качестве аргумента массив целочисленных элементов
//и возвращает инвертированный массив (элементы массива в обратном порядке).

//2.Создайте метод int[] SubArray(int[] array, int index, int count).
//Метод возвращает часть полученного в качестве аргумента массива,
//начиная с позиции указанной в аргументе index,
//размерностью, которая соответствует значению аргумента count.
//Если аргумент count содержит значение больше чем количество элементов,
//которые входят в выбираемую часть исходного массива (от указанного индекса index, до индекса последнего элемента),
//то при формировании нового массива размерностью в count, заполните единицами те элементы,
//которые не были скопированы из исходного массива.
//```

namespace TeachMeSkills.DotNet.Task25
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        static int MyReverse(int[]array1)
        {
            Array.Reverse(array1) ;
            return array1[1];
        }
    }
}
