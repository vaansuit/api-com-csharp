using RealData.Model;
using RealData.Repository;

namespace WebApi.Controllers
{
    public class UsuarioController : GenerciController<Usuario, UsuarioRepository>
    {
        public UsuarioController() : base(new UsuarioRepository())
        {

        }
    }
}
