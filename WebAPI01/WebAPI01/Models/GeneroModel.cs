using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI01.Models
{
    public class GeneroModel
    {

        public String Name { get; set; }
        public String MaleRegex { get; set; }
        public String FemaleRegex { get; set; }
        public String Result { get; set; }

    }
}