using ApiCursoLinqCanal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCursoLinqCanal.Controllers
{
    public class AlimentoController : Controller
    {

        [HttpGet]
        [Route("/ObterAlimentos")]    
        public object ObterAlimentos()
        {
            //jeito 1 
            Alimentos alimentos = new();
            return alimentos.PopularDados();

            //jeito 2
            //return new Alimentos().PopularDados();
        }
    }
}
