using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing; 

namespace RestaurantKuLibrary.Models
{
   public class RestaurantMenuModel
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte ImageToByteArray { get; set; }

    }

}
