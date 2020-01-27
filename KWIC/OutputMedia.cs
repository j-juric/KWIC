using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class OutputMedia
    {
        private string outputFile;
        private string[] data;

        public string OutputFile { get => outputFile; set => outputFile = value; }
        public string[] Data { get => data; set => data = value; }

        public OutputMedia() { }
        public OutputMedia(string outputFile, string[] data) { this.outputFile = outputFile; this.data = data; }

        public void OutputData()
        {
            File.AppendAllLines("output.txt", this.data);
        }
    }
}
