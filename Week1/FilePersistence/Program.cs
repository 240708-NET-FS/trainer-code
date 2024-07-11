using System.Drawing;

namespace FilePersistence;

public class Program {

    public static String filePath = "./cat_base64.txt";

    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, what is your name?");

        // String name = Console.ReadLine();

        // Console.WriteLine("Hello, " + name);

        // // Save Data
        // using (StreamWriter writer = new StreamWriter(filePath))
        // {
        //     writer.WriteLine(name);
        // }

        String base64Txt = "";

        // // Read Data
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    String[] parts = line.Split(',');
                    base64Txt = parts[1];
                } 
            }
        }

        byte[] imageBytes = Convert.FromBase64String(base64Txt);

        using (MemoryStream ms = new MemoryStream(imageBytes))
        {
            // Create image from memory stream
            Image image = Image.FromStream(ms);

            // Output the image
            image.Save("output_image.png");
        }

    }
}