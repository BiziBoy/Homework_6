using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
  class Program
  {
    static void Main(string[] args)
    {
      //заполнить массив с клавиатуры
      Console.Write("Введите количество элементов в массиве: ");
      int length = int.Parse(Console.ReadLine());
      int[] array = new int[length];
      for (int i = 0; i < length; i++)
      {
        Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Введенный массив.");
      for (int i = 0; i < length; i++)
      {
        Console.WriteLine((i + 1) + "-й элемент массива: " + array[i]);
      }
      Console.ReadLine();
    }
  }
}
