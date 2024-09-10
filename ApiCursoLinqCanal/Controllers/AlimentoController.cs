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


        [HttpGet]
        [Route("/ObterAlimentosPorDescricao/{kcal}")]
        public object ObterAlimentosPorDescricao(int kcal)
        {
            //para filtrar informaçoes vamos utilizar o where 
            //lambda sao expressoes para darmos nomes aos nosso atributos - exemplo -> letra => e traz o campo exemplo s=>s.calorias

            //jeito 1 
            Alimentos alimentos = new();
            return alimentos.PopularDados().Where(s => s.Calorias == kcal).Select(s=>s.Nome).ToList();

        }


        [HttpGet]
        [Route("/SomaKakAlimento/{kcal}")]
        public object SomaKakAlimento(int kcal)
        {
            //para filtrar informaçoes vamos utilizar o where 
            //lambda sao expressoes para darmos nomes aos nosso atributos - exemplo -> letra => e traz o campo exemplo s=>s.calorias

            //jeito 1 
            Alimentos alimentos = new();
            return alimentos.PopularDados().Where(s => s.Calorias == kcal).Sum(s=>s.Calorias);    

        }

        [HttpGet]
        [Route("/AgruparKakAlimento")]
        public object AgruparKakAlimento()
        {
            //para filtrar informaçoes vamos utilizar o where 
            //lambda sao expressoes para darmos nomes aos nosso atributos - exemplo -> letra => e traz o campo exemplo s=>s.calorias

            //jeito 1 
            Alimentos alimentos = new();
            return alimentos.PopularDados().GroupBy(s => s.Calorias);
            

        }

        [HttpGet]
        [Route("/AgruparUnidadeAlimento")]
        public object AgruparUnidadeAlimento()
        {
            //para filtrar informaçoes vamos utilizar o where 
            //lambda sao expressoes para darmos nomes aos nosso atributos - exemplo -> letra => e traz o campo exemplo s=>s.calorias

            //jeito 1 
            Alimentos alimentos = new();
            //return alimentos.PopularDados().GroupBy(s => s.Calorias);
            return alimentos.PopularDados().GroupBy(s => s.Unidade);

        }


        [HttpGet]
        [Route("/AlimentoMenosCalorico2")]
        public object AlimentoMenosCalorico2()
        {
            //para filtrar informaçoes vamos utilizar o where 
            //lambda sao expressoes para darmos nomes aos nosso atributos - exemplo -> letra => e traz o campo exemplo s=>s.calorias

            //jeito 1 
            Alimentos alimentos = new();
            //return alimentos.PopularDados().GroupBy(s => s.Calorias);
            return alimentos.PopularDados().Min(s => s.Calorias);

        }


        [HttpGet]
        [Route("/AlimentoMaisCalorico2")]
        public object AlimentoMaisCalorico2()
        {
            //para filtrar informaçoes vamos utilizar o where 
            //lambda sao expressoes para darmos nomes aos nosso atributos - exemplo -> letra => e traz o campo exemplo s=>s.calorias

            //jeito 1 
            Alimentos alimentos = new();
            //return alimentos.PopularDados().GroupBy(s => s.Calorias);
            return alimentos.PopularDados().Max(s => s.Calorias);

        }

    }
}
