using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WardrobeSolution.Models
{
    public class Outfit
    {

        public int OutfitID { get; set; }
        public string OutfitName { get; set; }
        public string AccessoryID { get; set; }
        public string ShoeID { get; set; }
        public string BottomID { get; set; }
        public string TopID { get; set; }

        public virtual Shoe Shoe { get; set; }
        public virtual Top Top { get; set; }
        public virtual Bottom Bottom { get; set; }
        public virtual Accessory Accessory { get; set; }

    }
}