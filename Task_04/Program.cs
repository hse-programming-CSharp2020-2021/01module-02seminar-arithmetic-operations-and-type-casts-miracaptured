﻿/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;

namespace Task_4 {
	class Program {
		static void Main(string[] args) {
			int x;
			// TODO : Считать целочисленное значение.
			// TODO : Вычислить значение и вывести.

			int.TryParse(Console.ReadLine(), out x);
			Console.WriteLine(ReverseNumber(x));
			
		}

		static string ReverseNumber(int x) {
			// Предлагается 2 решения данной задачи : 
			// 1) Выделить каждую цифру в отдельную переменную и собрать их в обратном порядке.
			// 2) Преобразовать переменную в строку использовать метод Reverse и выполнить обратное преобразование.
			// Выбор метода остаётся за вами.
			char[] IntReversed= x.ToString().ToCharArray();
			Array.Reverse(IntReversed);
			return new string(IntReversed);
		}
	}
}
