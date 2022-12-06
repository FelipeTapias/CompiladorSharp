using System;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Compilador.Clases;
public class FileContent
{
    StreamReader streamReader;

    public FileContent(string path)
    {
        try
        {
            streamReader = new StreamReader(path);
        }
        catch (Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            throw new Exception("File couldn't find, verify the path", error);
        }
    
    }

    public void ReadFile()
    { 
        string line;
        line = streamReader.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);    
            line = streamReader.ReadLine();
        }
        Console.ReadLine();
    }

    public string OrderFile()
    {
        string allLines = "";
        string line;
        line = streamReader.ReadLine();
        while (line != null)
        {
            allLines += line.Trim();
            line = streamReader.ReadLine();
        }
        return allLines;
    }
}

