﻿using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            try
            {
                Divide(5, 2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            static int CheckFileExtension(string fileName)
            {
                if (fileName == null || fileName == "")
                {
                    throw new ArgumentNullException("fileName", "Student did not submit any work!");
                }
                else
                {
                    if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


        }
    }
}
