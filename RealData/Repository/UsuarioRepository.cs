using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealData.Model;
using RealData.NewFolder;
using RealData.Utils;

namespace RealData.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override string Create(Usuario model)
        {
            model.Senha = Criptografia.Criptografar(model.Senha);
            return base.Create(model);
        }
    }
}
