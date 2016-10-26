using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AlumnoCE
    {
        public int AluId { get; set; }
        public string ALuNom { get; set; } //varchar(40),
        public string AluApe { get; set; }// varchar(40),
        public string AluDni { get; set; } //char(8),
        public int AluEdad { get; set; }//
    }
}
