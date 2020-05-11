using prueba2ApiMaipo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Repositories
{
    public interface IRolRepository
    {
        object GetRol();
        object InsertRol(Rol rol);
        object EditRol(Rol rol, int id);
        object DeleteRol(int id);
    }
}
