using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabeSynchronizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookPath = @"c:\prj\SabeData\Atlantis Gene.epub";
            var recognizedPath = @"c:\prj\SabeData\ch1recognized.txt";

            var book = new Reader().ReadEpub(bookPath);
            var recognizedlines = File.ReadAllLines(recognizedPath);

            foreach (var recognizedLine in recognizedlines)
            {
                CompareRecognizedLineWithOriginal(recognizedLine);
            }
        }

        static int bookLinesIndex;

        private static void CompareRecognizedLineWithOriginal(string recognizedLine)
        {
            //var bookline = bookLines[bookLinesIndex];


            bookLinesIndex++;
        }
    }
}
