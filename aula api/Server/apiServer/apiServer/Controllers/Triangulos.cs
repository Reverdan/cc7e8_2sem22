using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Triangulos : ControllerBase
    {
        [HttpGet]
        public String triangulo(String l1, String l2, String l3)
        {
            String mensagem = "";
            try
            {
                int n1 = Convert.ToInt32(l1);
                int n2 = Convert.ToInt32(l2);
                int n3 = Convert.ToInt32(l3);
                if (n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1)
                {
                    if (n1 == n2 && n2 == n3) 
                        mensagem = "Triângulo equilátero";
                    else
                        if (n1 != n2 && n2 != n3 && n1 != n3) 
                            mensagem = "Triângulo Escaleno";
                        else 
                            mensagem = "Triângulo Isósceles";
                }
                else
                {
                    mensagem = "Não é um triângulo";
                }
            }
            catch (Exception)
            {
                mensagem = "Erro de conversão";
            }
            return mensagem;
        }
    }
}
