using Business.Entities;
using ResourceAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class UsuarioLogic : LogicBase<Usuario, IUsuarioRepository>, IUsuarioLogic
    {
        public UsuarioLogic(Usuario usuario,
                            IUsuarioRepository repository)
            : base(usuario, repository)
        {
            
        }

        public Usuario GetByID(int ID)
        {
            using (var context = new AcademiaDbContext())
            {
                return this.Repository.GetByID(ID);
            }
        }

        public List<Usuario> GetAll()
        {
            using (var context = new AcademiaDbContext())
            {
                return this.Repository.GetAll();
            }
        }
    }
}
