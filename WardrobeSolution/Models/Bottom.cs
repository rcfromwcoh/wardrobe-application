using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WardrobeSolution.Models
{
    public class Bottom
    {

        public int ID { get; set; }
        public string BottomName { get; set; }
        public string Photo { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }

        public virtual ICollection<Outfit> Outfits { get; set; }
    }
}