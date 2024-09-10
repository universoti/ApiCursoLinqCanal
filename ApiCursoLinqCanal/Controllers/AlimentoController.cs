using ApiCursoLinqCanal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ApiCursoLinqCanal.Controllers
{
    public class AlimentoController : Controller
    {

        [HttpGet]
        [Route("/ObterAlimentos")]    
        public object ObterAlimentos()
        {
            //jeito 1 
            //Alimentos alimentos = new();
            //return alimentos.PopularDados();

            //jeito 2
            return new Alimentos().PopularDados();
        }



        [HttpGet]
        [Route("/ObterAlimentos/{kcal}")]
        public object ObterAlimentos(int kcal)
        {
            //para filtrar informaçoes vamos utilizar o where 
            //lambda sao expressoes para darmos nomes aos nosso atributos - exemplo -> letra => e traz o campo exemplo s=>s.calorias

            //jeito 1 
            Alimentos alimentos = new();
            return alimentos.PopularDados().Where(s=>s.Calorias==kcal).ToList();

        }


    }
}
