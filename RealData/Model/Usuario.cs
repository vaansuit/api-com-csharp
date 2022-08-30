using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealData.Model
{
    public class Usuario : BaseModel
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }
    }
}
