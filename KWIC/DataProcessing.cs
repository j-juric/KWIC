using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class DataProcessing
    {
        private List<string> storage;
        private List<CircuralList> lines;
        private string[] data;

        public List<string> Storage { get => storage; set => storage = value; }
        public string[] Data { get => data; set => data = value; }

        public DataProcessing() { this.lines = new List<CircuralList>(); this.storage = new List<string>(); }
        public DataProcessing(string[] data) { this.data = data; this.lines = new List<CircuralList>(); this.storage = new List<string>(); }

        public void FillLines()
        {
            foreach(var l in this.data)
            {
                string[] words = l.Split(new[] { " " }, StringSplitOptions.None);
                var clist = new CircuralList();
                foreach(var w in words)
                {
                    clist.AddToTail(new Node(w));
                }
                lines.Add(clist);
            }
        }

        public void FillStorage()
        {
            foreach(var l in lines)
            {
                var cnt = l.Count;
                do
                {
                    StringBuilder builder = new StringBuilder();
                    var n = l.Head;
                    do
                    {
                        builder.Append(n.Value);
                        builder.Append(' ');
                        n = n.Next;
                    } while (n.Next != l.Head.Next);

                    this.storage.Add(builder.ToString());

                    l.Shift();
                    cnt--;

                } while (cnt > 0);
            }
        }

     
    }
}
