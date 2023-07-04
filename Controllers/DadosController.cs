using Microsoft.AspNetCore.Mvc;
using Teste.Models;


namespace Teste.Controllers
{
    public class DadosController : Controller
    {

        public IActionResult Paciente(string cpf)
        {
            List<Paciente> pacientes = ObterPaciente(cpf);
            List<Caloria_v3> calorias = ObterCaloria();

            ViewBag.Caloria_v3 = calorias;

            var model = new ListModel<Paciente>(pacientes);

            return View(model);
        }




        private List<Paciente> ObterPaciente(string cpf)
        {
            using (var contexto = new Contexto())
            {
                List<Paciente> pacientes = new List<Paciente>();

                if (!string.IsNullOrEmpty(cpf))
                {
                    pacientes = contexto.Paciente.Where(p => p.CPF == cpf).ToList();
                }
                else
                {
                    pacientes = contexto.Paciente.ToList();
                }

                return pacientes;
            }
        }






        private List<Caloria_v3> ObterCaloria()
        {
            using (var contexto = new Contexto()) 
            {
                List<Caloria_v3> calorias = contexto.Caloria_v3.ToList();

                return calorias;
            }
        }
    }
}
