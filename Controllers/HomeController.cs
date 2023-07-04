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

        //public IActionResult Cadastro()
        //{
        //Contexto contexto = new Contexto();

        //List<Paciente> cadastro = (from Paciente pc in contexto.Cadastro
        //select pc).Include(e => e.Emails).ToList<Pessoa>();
        //return View(cadastro);
        //}

        [HttpPost]
        public IActionResult Cadastrar(Paciente pc)
        {
            Contexto contexto = new Contexto();

            contexto.Paciente.Add(pc);
            contexto.SaveChanges();


            //int pessoaId = p.Id;
            //List<Email> emails = (from Email e in contexto.Emails
            // select e).Include(e => e.pessoa).Where(e => e.pessoa.Id == pessoaId).ToList<Email>();

            //ViewData["Emails"] = emails;

            //ViewBag.pessoaId = p.Id;

            // return RedirectToAction("CadastroEmail", new { id = p.Id });
            return RedirectToAction("Index", "Home", pc.CPF);
        }



        public IActionResult Cadastrar()
        {
            return View();
        }




        //[HttpGet]
        //public IActionResult Login (int id)
        //{
        //    //int pessoaId = ViewBag.CaloriaId;
        //    Contexto contexto = new Contexto();
        //    //    //List<Email> emails = (from Email p in contexto.Emails
        //    //    //                      select p).Include(e => e.pessoa).Where(p => p.pessoa.Id == id).ToList<Email>();

        //    ViewData["Caloria"] = caloria;
        //    ViewData["Cpf"] = id;

        //    return View();
        //}

        //public IActionResult CadastroEmail(Email email, int? id)
        //[HttpPost]
        //public IActionResult CadastroEmail(string emailTexto, int? id)
        //{
        //    Email email = new Email();
        //    email.email = emailTexto;

        //    Contexto contexto = new Contexto();

        //    Pessoa? pessoa = new Pessoa();
        //    pessoa = (from Pessoa p in contexto.Pessoas
        //              select p).Include(e => e.Emails).Where(p => p.Id == id).FirstOrDefault<Pessoa>();

        //    email.pessoa = pessoa;

        //    contexto.Emails.Add(email);
        //    contexto.SaveChanges();

        //    return RedirectToAction("PessoaId", new { id = id });
        //}

        //[HttpPost]
        //public IActionResult Cadastrar(Pessoa p)
        //{
        //    Contexto contexto = new Contexto();

        //    contexto.Pessoas.Add(p);
        //    contexto.SaveChanges();

        //    return View("Pessoa", p);
        //}



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

            // Credenciais inválidas, exibir mensagem de erro
            ModelState.AddModelError(string.Empty, "Usuário não encontrado ou senha incorreta");
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        private bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            // Implemente a lógica de verificação da senha aqui
            // Você pode usar bibliotecas de hashing de senha, como BCrypt ou PBKDF2

            // Exemplo simples de comparação direta de senha (não recomendado para produção)
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

    
    
    
    
    
    
       


    


