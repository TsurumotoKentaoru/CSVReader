using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader
{
    public static string[][] getCSV(string filePath)
    {
        TextAsset csvFile = Resources.Load(filePath) as TextAsset;
        if (csvFile == null)
        {
            return null;
        }
        StringReader reader = new StringReader(csvFile.text);
        List<string[]> csvDatas = new List<string[]>();
        if (reader != null)
        {
            while (reader.Peek() > -1)
            {
                string line = reader.ReadLine();
                csvDatas.Add(line.Split(','));
            }
            return csvDatas.ToArray();
        }
        else
        {
            return null;
        }
    }
}