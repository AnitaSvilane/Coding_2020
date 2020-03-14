using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day14_IO_Sample
{
    class Example
    {

        public static void Write()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\anita\\Desktop\\Test.txt");

                //Write a line of text
                sw.WriteLine("Hello World!!");

                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");

                sw.WriteLine("Mans teksts");
                sw.Write("teksta turpinājums");
                sw.Write(" asdfg");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void Read()
        {           

            try
            {
                String line;
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\anita\\Desktop\\Test.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
