using System;
//use System.IO using for file read and write.
using  System.IO;
namespace Read_and_Write_files_using_system.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the path of file.
            const string path = @"C:\Users\vicky\Desktop\WordsDocument\test.txt";
            //check file is exist or not.
            if (File.Exists(path))
            {
                //read the file.
                var content = File.ReadAllText(path);

                //print the file content.
                Console.WriteLine("Current content of file :" + content);
            }
            
            Console.WriteLine("Write new content for file.");

            //read the new content for file which you will put in the variable.
            var newContent = Console.ReadLine();

            //write the file.
            File.WriteAllText(path,newContent);

            //agin check file is exist or not.
            if (File.Exists(path))
            {
                //read the file.
                var updateContent = File.ReadAllText(path);

                //print the updated content of file.
                Console.WriteLine("Current content of file :" + updateContent);
            }
           
            Console.ReadLine();
            

        }
    }


  
}
