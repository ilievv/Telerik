﻿/* 
Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

You might need to learn how to use loops in C# (search in Internet).
*/

using System;

class LongSequence
{
    static void Main()
    {
        int number;

        for (int i = 2; i <= 1002; i++)
        {
            if (i % 2 == 0)
            {
                number = i;
            }
            else
            {
                number = i * (-1);
            }
            Console.WriteLine(number);
        }
    }
}