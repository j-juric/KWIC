using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class InputMedia
    {
        private string inputFile;

        public string InputFile { get => inputFile; set => inputFile = value; }

        public InputMedia() { }
        public InputMedia(string file) { this.inputFile = file; }

        public string[] GetData()
        {
            string text = File.ReadAllText(this.inputFile);
            string[] lines = text.Split(
            new[] { "\r\n", "\r", "\n" }
            , StringSplitOptions.None);            
            return lines;
        }       
    }
}
