using Compilador.Helpers;
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
            throw new ExcepcionCompiler(ExceptionMessage.FileNotFound);
        }
    
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

