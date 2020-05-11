using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba2ApiMaipo.Models;
using prueba2ApiMaipo.Repositories;

namespace prueba2ApiMaipo.Controllers
{
    [Produces("application/json")]
    public class RolController : ControllerBase
    {
        IRolRepository rolRepository;

        public RolController(IRolRepository _rolRepository)
        {
            rolRepository = _rolRepository;
        }

        [Route("api/rol/GetRol")]
        [HttpGet]
        public ActionResult GetRol()
        {
            var result = rolRepository.GetRol();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [Route("api/rol/InsertRol")]
        [HttpPost]
        public ActionResult InsertRol([FromBody] Rol rol)
        {
            var result = rolRepository.InsertRol(rol);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }


        [Route("api/rol/EditRol/{id}")]
        [HttpPut]
        public ActionResult EditRol([FromBody] Rol rol, int id)
        {
            var result = rolRepository.EditRol(rol, id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }


        [Route("api/rol/DeleteRol/{id}")]
        [HttpDelete]
        public ActionResult DeleteRol( int id)
        {
            var result = rolRepository.DeleteRol( id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}