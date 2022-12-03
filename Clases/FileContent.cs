using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Compilador.Clases;
public class FileContent
{
    StreamReader streamReader;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="path"></param>
    public FileContent(string path)
    {
        try
        {
            streamReader = new StreamReader(path);
        }
        catch (Exception error)
        {
            throw new Exception(
            "File couldn't find, verify the path", error);
        }
    
    }

    /// <summary>
    /// Function to read the selected file
    /// </summary>
    public void ReadFile()
    { 
        string line;
        Console.WriteLine("Lectura de archivo");
        line = streamReader.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = streamReader.ReadLine();
        }
        Console.ReadLine();
    }

    /// <summary>
    /// Function to order and remove the space the selected file
    /// </summary>
    public string OrderFile()
    {
        string allLines = "";
        string line;

        Console.WriteLine("Ordenamiento del archivo");
        line = streamReader.ReadLine();
        while (line != null)
        {
            allLines += line.Trim();
            line = streamReader.ReadLine();
        }
        return allLines;
    }
}

