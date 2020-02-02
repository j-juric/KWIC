using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                throw new Exception("Execution must have 2 arguments!");
            }

            var input = args[0];
            var output = args[1];
            var im = new InputMedia(input);

            var data = im.GetData();

            var dp = new DataProcessing(data);

            dp.FillLines();
            dp.FillStorage();

            var ds = new DataSorting(dp.Storage);
            ds.SortCapitalFirst();

            var om = new OutputMedia(output, ds.Data);
        
            om.OutputData();

        }
    }
}
