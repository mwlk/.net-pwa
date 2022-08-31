using FirstPWA.Class;
using FirstPWA.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstPWA.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<PersonaCls> ListarPersonas()
        {
            List<PersonaCls> result = new List<PersonaCls>();

            using (BDBibliotecaContext _db = new BDBibliotecaContext())
            {
                result = (from p in _db.Personas
                          where p.Bhabilitado == 1
                          select new PersonaCls
                          {
                              iidpersona = p.Iidpersona,
                              nombreCompleto = p.Nombre + ", " + p.Appaterno + " " + p.Apmaterno,
                              correo = p.Correo
                          }).ToList();

                return result;
            }
        }
    }
}
