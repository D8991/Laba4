using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Sale
    {
        public string Good_Name { get; set; }
        public Sale(string Good_Name)
        {
            this.Good_Name = Good_Name;
        }
        public override string ToString()
        {
            return Good_Name;
        }
    }
}
