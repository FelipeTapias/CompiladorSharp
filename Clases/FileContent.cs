using Compilador.Helpers;
using System;
using System.IO;

namespace Compilador.Clases;
public class FileContent
{
    public string path { get; private set; }
    public FileContent(string path)
    {
        if(path is null)
            throw new ArgumentNullException("path");
        
        this.path = path;      
    }

    public string OrderFile()
    {
        try
        {
            using (StreamReader streamReader = new StreamReader(path))
            {

                string allLines = "";
                string? line;
                line = streamReader.ReadLine();
                while (line != null)
                {
                    allLines += line.Trim();
                    line = streamReader.ReadLine();
                }
                return allLines;
            }
        }
        catch (Exception ex)
        {

            throw new ExcepcionCompiler(ExceptionMessage.FileNotFound);
        }
    }
}

