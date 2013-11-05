using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ioservice.Models
{
    public class ScriptModel
    {
        public string Name { get; set; }
        public string Src { get; set; }

        public ScriptModel(string name, string src)
        {
            this.Name=name;
            this.Src = src;
        }
    }

    
}