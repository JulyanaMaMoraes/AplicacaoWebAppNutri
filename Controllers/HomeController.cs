using Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Paciente(Paciente pc)
        {
            return View(pc);
        }





        public IActionResult PacienteId(int id)
        {
            Contexto contexto = new Contexto();

            Paciente? pc = contexto.Paciente.Find(id);

            return View(pc);
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente pc)
        {
            Contexto contexto = new Contexto();

            contexto.Paciente.Add(pc);
            contexto.SaveChanges();

            return RedirectToAction("Index", "Home", pc.CPF);
        }



        public IActionResult Cadastrar()
        {
            return View();
        }



        [HttpPost]

        public IActionResult Login(Login model)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=AppNutri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();

                string query = "SELECT * FROM Paciente WHERE USERNAME = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", model.Username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["PASSWORD"].ToString();

                            if (VerifyPassword(storedPassword, model.Password))
                            {
                                // Autenticação bem-sucedida, redirecionar para a página principal
                                return RedirectToAction("Dieta", "Home");
                            }
                        }
                    }
                }
            }

            
            ModelState.AddModelError(string.Empty, "Usuário não encontrado ou senha incorreta");
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        private bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            
            return hashedPassword == providedPassword;

        }


        
        public IActionResult Caloria_v2(Caloria_v3 c)
        {
            return View(c);
        }

        public IActionResult Id(int id)
        {
            Contexto contexto = new Contexto();

            Caloria_v3? c = contexto.Caloria_v3.Find(id);

            return View(c);
        }


        [HttpPost]
        public IActionResult Dieta(Caloria_v3 c) 
        
        { 
           Contexto contexto = new Contexto();

            contexto.Caloria_v3.Add(c);
            contexto.SaveChanges();

            return RedirectToAction("Index", "Home", c.Caloria_ID);
        }

        public IActionResult Dieta()
        {
            return View();
        }





    }
}

    
    
    
    
    
    
       


    


