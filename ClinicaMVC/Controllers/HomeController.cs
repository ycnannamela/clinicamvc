using Microsoft.AspNetCore.Mvc;
using Actividad;
using Entidad;
namespace ClinicaMVC.Controllers
{
    public class HomeController : Controller
    {
        Actividad_Medico actividad_medico = new Actividad_Medico();

        public IActionResult Index()
        {
            return RedirectToAction(nameof(MostrarMedicos));
        }
        public IActionResult MostrarMedicos()
        {
            List<Medico> medicosActuales = actividad_medico.ReadAll(); 
            ViewBag.info = "LISTADO";
            return View("MostrarMedicos", medicosActuales);
        }
    
    }

    
}
