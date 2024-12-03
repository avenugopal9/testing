using System;
using System.IO;

public class FilePathHandler
{
    public void HandleFile(string filePath)
    {
        // BAD: Unvalidated input used directly in file access
        string fullPath = Path.Combine("C:\\Files", filePath);
        string content = File.ReadAllText(fullPath);
        Console.WriteLine(content);
    }
}
