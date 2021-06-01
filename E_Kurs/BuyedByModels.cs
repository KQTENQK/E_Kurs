using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Kurs
{
    public class BuyedByModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int ByuedId { get; set; }
        public int BuyedById { get; set; }
    }
}
