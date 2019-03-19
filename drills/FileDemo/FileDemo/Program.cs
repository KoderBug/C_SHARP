using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* To read data from a text file use StreamReader class.  Define the path in a string variable like below, 
 * you must use double slashes when defining a path.  Single slash indicates the beginning of an escape sequence.
 * Pass the path to the StreamReader file.  If you do not have a file you can write to a text file using
 * StreamWriter.  If you do not define you file path as below the file will be written in the same directory
 * as the exe file which is in the bin directory.
 * 
 * The using keyword before the StreamWriter and StreamReader instance is to ensure that the Dispose() method
 * is always called.  This is a prewritten method that closes or release any unmanaged resources such as files
 * and streams once they are no longer needed.
 * 
 * EndOfStream is a property of the StreamReader class that returns true when the end of the file is reached.
 * 
 * sr.ReadLine() reads a line from the text file and returns it as a string.  This string is then printed
 * onto the screen using the Console.WriteLine() method.
 * 
 * Finally, after we finish reading the file, we close the file so that other programs may use it.
 * You should always close your file once you no longer need it.
 * 
 * The Exists() method checks if a file exists, this is the preferred method to handle the "file not found" 
 * scenario rather than a try catch block.  The File class is a pre-written class in the System.IO 
 * namespace that provides static methods for the creation, copying, deletion, moving and opening of a single file.
 * 
 * To use the Exists() method, we use an if statemtn to check if the file exists before using a StreamReader to open
 * and read the file.  In the else block, we can write code to create the file if it is not found.
 * 
 * Use the StreamWriter class to write to a text file.  You can append to an existing file or overwrite an exisiting file.
 * When the StreamWriter instance is created, the constructor looks for the file at the given path.
 * If the file is not found, it creates the file.
 */ 

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring the path to the file
            string path = "myfile.txt";

            //Writing to the file
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }

            //Reading from the file
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            Console.Read();
        }
    }
}
