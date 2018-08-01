using System;
using System.IO;
using System.Reflection;

namespace HogwartsTheGameCA
{
    public static class Game
    {
        static void Main()
        {
            //Initial Title
            Console.Title = "Welcome To Hogwarts!";
            
            //Declare Encoding for unicoded ASCII graphics
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Get the file we want
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HogwartsTheGameCA.HMenuResources.WelcomeToHogwarts.txt"))
            {
                //Read file contents
                using (StreamReader reader = new StreamReader(stream))
                {
                    //Write out contents
                    string contents = reader.ReadToEnd();

                    //Console.SetCursorPosition((Console.WindowWidth - contents.Length) / 2, Console.CursorTop);

                    //Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (contents.Length / 2)) + "}", contents));

                    //Console.Write(new string(' ', (Console.WindowWidth - contents.Length) / 2));

                    Console.WriteLine(contents);

                }

            }

            Console.ReadKey();

        }
    }           
}