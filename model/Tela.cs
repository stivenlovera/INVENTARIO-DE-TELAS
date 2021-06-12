using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventario_telas.model
{
    public class Tela
    {
        public int id { get; set; }
        public string marca { get; set; }
        public int largo { get; set; }
        public int tipo { get; set; }
        public string color { get; set; }
        public string procedencia { get; set; }
        public bool estado { get; set; }
    }
}
