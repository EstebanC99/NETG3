using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public List<Usuario> GetAll()
        {
            return this.DbSet.ToList();
        }
    }
}
