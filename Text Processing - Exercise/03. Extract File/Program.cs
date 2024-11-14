namespace Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathern = Console.ReadLine();

            string fileName = "";
            string extension = "";

            int lastSeparatorIndex = pathern.LastIndexOf('\\');
            int extensionIndex = pathern.LastIndexOf('.');

            if (lastSeparatorIndex != -1 && extensionIndex != -1 && extensionIndex > lastSeparatorIndex)
            {
                fileName = pathern.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);
                extension = pathern.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}