using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dataStructuresAndAlgorithmsPlayground
{
    public class In
    {
        public static IEnumerable<int> ReadInts(string filePath)
        {
            using (TextReader reader = File.OpenText(filePath))
            {
                string lastLine;
                while((lastLine = reader.ReadLine()) != null)
                {
                    yield return int.Parse(lastLine);
                }
            }
        }
    }
}
