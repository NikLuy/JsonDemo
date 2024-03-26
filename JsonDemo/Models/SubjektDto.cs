using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo.Models
{

    public record SubjektDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Vorname { get; set; }
        public string? Adresse { get; set; }        	
    }
}
