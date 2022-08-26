using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealData.Model
{
    public class Animal : BaseModel
    {
        public string Especie { get; set; }
        public double Peso { get; set; }
        public string Sexo { get; set; }
    }
}
