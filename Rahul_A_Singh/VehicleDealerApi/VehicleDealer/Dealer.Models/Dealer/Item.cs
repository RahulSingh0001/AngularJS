using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer.Models.Dealer
{
    public class Item
    {
        public int id { get; set; }
        public List<object> message { get; set; }
        public int position_x { get; set; }
        public int position_y { get; set; }
        public int position_z { get; set; }
        public int rotation_x { get; set; }
        public int rotation_y { get; set; }
        public int rotation_z { get; set; }
        public string created { get; set; }
    }
}
