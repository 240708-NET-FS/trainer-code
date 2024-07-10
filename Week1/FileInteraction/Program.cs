using System;
using System.IO;
using System.Xml.Serialization;

namespace FileInteraction
{
    class Program
    {
        //fields
    

        //methods
        static void Main()
        {
            Console.WriteLine("Application Running...");

            string[] text  = {"Hello Everyone!", "use commas to separate items", "in your array", "as you declare them", "and this will show if the file overwrote"};

            string path = @".\TextFile.txt";

            
          

            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1: Read from file.");
                Console.WriteLine("2: Write to file.");
                Console.WriteLine("3: Create Xml Record");
                Console.WriteLine("4: Read from Xml Record");
                Console.WriteLine("0: Exit.");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                switch(choice)
                {
                    case "1": // if (choice == "1")
                        Console.WriteLine("Reading from file...");
                        if(!File.Exists(path))
                        {
                            Console.WriteLine("File does not exist.");
                        }
                        else
                        {
                            string[] readText = File.ReadAllLines(path); // Read all lines from the file, and store in string array
                            foreach (string s in readText) // loop through the string array
                            {
                                Console.WriteLine(s); // print each line
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Writing to file...");
                        if (! File.Exists(path)) // if the file does NOT exist
                        {
                            File.WriteAllLines(path, text); // write all lines to the file,
                            //  if the file exists it will overwrite it, 
                            // if the file doesn't exist it will create it
                        }
                        else
                        {
                            File.AppendAllLines(path, text); // append all lines to the file,
                        }                
                        break;

                    case "3":
                        Person P = new Person("James", 12.34, 56.78);
                        if (! File.Exists(path)) // if the file does NOT exist
                        {
                            File.WriteAllText(path, P.SerializeXml()); // write all lines to the file,
                            //  if the file exists it will overwrite it, 
                            // if the file doesn't exist it will create it
                        }
                        else
                        {
                            File.AppendAllText(path, P.SerializeXml()); // append all lines to the file,
                        } 
                       
                        break;

                    case "4":
                        Person Q = DeserializeXML();
                        Console.WriteLine(Q.name);
                        Console.WriteLine(Q.height);
                        Console.WriteLine(Q.weight);
                        break;

                    case "0":
                        loop = false;
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            Console.WriteLine("Application closing...");
        }





        private static Person DeserializeXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string path = @".\TextFile.txt";
            Person P = new Person();
            if(!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
                return null;
            }
            else
            {
                using StreamReader reader = new StreamReader(path);
                var record = (Person)serializer.Deserialize(reader);
                if (record is null)
                {
                    throw new InvalidDataException();
                    return null;
                }
                else
                {
                    P = record;
                }
            }
            return P;
        }


    }
}
