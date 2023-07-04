using Teste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;


namespace Teste.Controllers
{
    public class LoginNutriController : Controller

    {
        [HttpPost]

        public IActionResult NutriLogin(NUTRICIONISTA model)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=AppNutri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();

                string query = "SELECT * FROM NUTRICIONISTA WHERE USERNAME = @Username";
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
                                return RedirectToAction("Paciente", "Dados");
                            }
                        }
                    }
                }
            }

            // Credenciais inválidas, exibir mensagem de erro
            ModelState.AddModelError(string.Empty, "Usuário não encontrado ou senha incorreta");
            return View(model);
        }

        public IActionResult NutriLogin()
        {
            return View();
        }

        private bool VerifyPassword(string hashedPassword, string providedPassword)
        {


            //Comparação direta de senha (não recomendado para produção)
            return hashedPassword == providedPassword;

        }
    }
}