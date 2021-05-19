using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception is unforseen error when your program is executing.
            //your users get to see the error messages which is not intuitivw
            //the error messages contain valuable informations that may be useful to hackers
            //some lines of code will be skipped

            StreamReader streamReader = new StreamReader(@"c:\sample.txt");
            try
            {
                System.Console.WriteLine(streamReader.ReadToEnd());
                
            }
            catch(FileNotFoundException ex)
            {
                System.Console.WriteLine(ex.FileName + "Please confirm the file name");
            }
            catch (Exception ex)
            {
                
                System.Console.WriteLine(ex.Message);

                //stack trace will give more infrmation or full details about the exception and the line the error is occuring
                System.Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                streamReader.Close();
            }
        }
    }
}
