using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class DataSorting
    {
        private List<string> storage;        
        private string[] data;

        public List<string> Storage { get => storage; set => storage = value; }
        public string[] Data { get => data; set => data = value; }

        public DataSorting() { this.storage = new List<string>(); }
        public DataSorting(List<string> storage) {  this.storage = storage; }

        public void SortSmallFirst()
        {
            this.storage.Sort();
            this.data = new string[this.storage.Count];

            for (int i = 0; i < this.Storage.Count; i++)
            {
                this.data[i] = this.storage[i];
            }
        }

        public void SortCapitalFirst()
        {

            InvertFirstLetter();
            this.storage.Sort();
            InvertFirstLetter();
            this.data = new string[this.storage.Count];
            for (int i = 0; i < this.Storage.Count; i++)
            {
                this.data[i] = this.storage[i];
            }
            
        }

        public void InvertFirstLetter()
        {
            for (int i = 0; i < storage.Count; i++)
            {
                storage[i] = (storage[i][0] <= 90 && storage[i][0]>=65) ? storage[i].ToUpper() : storage[i].ToLower();
            }
        }
    }
}
