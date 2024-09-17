namespace ApiCursoLinqCanal.Models
{
    public class Alimentos
    {
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public string Unidade { get; set; }
        public double Calorias { get; set; }

        public List<Alimentos> PopularDados()
        {
            List<Alimentos> alimento = new List<Alimentos>()
            {

             #region Grupo 1 - 20 calorias
              new Alimentos(){Nome="Aface",Unidade="Porcao Pires",Quantidade=1,Calorias=20},             
              new Alimentos(){Nome="Acelga",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="Aipo",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="Almeirão",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="Aspargo",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="cebola",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="erva doce",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="mostarda",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="nabo",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="pepino",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="rabanete",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="repolho",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="rucula",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="salsão",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new Alimentos(){Nome="tomate",Unidade="Porcao Pires",Quantidade=1,Calorias=20},

	         #endregion
             #region grupo 2 - 35 calorias
		
              new Alimentos(){Nome="Abóbora",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Abóbrinha",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Acelga",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Alcachofra",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Aspargo",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Almeirão",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Beringela",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Beterraba",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Brócolis",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Broto de bambú",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Broto de feijão",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Cebola",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Cebolinha",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Cenoura",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Chuchu",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Couve",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Couve-flor",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Cogumelo",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Escarola",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Espinafre",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Ervilha fresca",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Palmito",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Pimentão",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Quiabo",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Vagem",Unidade="colheres",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Milho",Unidade="colheres",Quantidade=4,Calorias=35},

	           #endregion
             #region grupo 3 - 50 calorias
		      new Alimentos(){Nome="Abacate 1/4",Unidade="colheres",Quantidade=0.25,Calorias=50},
              new Alimentos(){Nome="Abacaxi",Unidade="fatia",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Albran",Unidade="colher sopa",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Ameixa",Unidade="unidade",Quantidade=2,Calorias=50},
              new Alimentos(){Nome="Amora",Unidade="unidade",Quantidade=10,Calorias=50},
              new Alimentos(){Nome="Aveia",Unidade="colher",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Banana nanica 1/2",Unidade="unidade",Quantidade=0.5,Calorias=50},
              new Alimentos(){Nome="Banana Maçã",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Banana ouro",Unidade="unidade",Quantidade=2,Calorias=50},
              new Alimentos(){Nome="Banana prata",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Barra de Cereais diet",Unidade="gramas",Quantidade=20,Calorias=50},
              new Alimentos(){Nome="Barra de cereais light",Unidade="gramas",Quantidade=20,Calorias=50},
              new Alimentos(){Nome="Barra de cereais 1/2",Unidade="unidade",Quantidade=0.5,Calorias=50},
              new Alimentos(){Nome="Caju",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Caqui",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Carambola",Unidade="unidade",Quantidade=2,Calorias=50},
              new Alimentos(){Nome="Cereja",Unidade="unidades",Quantidade=10,Calorias=50},
              new Alimentos(){Nome="Damasco",Unidade="unidades",Quantidade=2,Calorias=50},
              new Alimentos(){Nome="Figo",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Framboesa",Unidade="unidade",Quantidade=10,Calorias=50},
              new Alimentos(){Nome="fruto do conde 1/2",Unidade="unidade",Quantidade=0.5,Calorias=50},
              new Alimentos(){Nome="Goiaba",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Granola",Unidade="colher",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Jaboticaba",Unidade="unidades",Quantidade=10,Calorias=50},
              new Alimentos(){Nome="Kiwi",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Laranja",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Maçã",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Mamão",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Mamão papaia",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Manga pequena",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Maracujá",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Melancia",Unidade="fatia",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Melão",Unidade="fatias",Quantidade=2,Calorias=50},
              new Alimentos(){Nome="Musle",Unidade="colher",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Morango",Unidade="pires",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Pera",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Pêssego",Unidade="unidade",Quantidade=1,Calorias=50},
              new Alimentos(){Nome="Sucrilhos",Unidade="colher",Quantidade=1,Calorias=50},              
	#endregion
             #region grupo 4 - 80 calorias
		       new Alimentos(){Nome="Arroz cozido",Unidade="colheres",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Arroz a grega",Unidade="colheres",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Arroz integral",Unidade="colheres",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Batata",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Batata-doce",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Biscoito doce sem recheio",Unidade="unidade",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Biscoito doce com recheio",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Biscoito ClubSocial 1/2",Unidade="pacote",Quantidade=0.5,Calorias=80},
               new Alimentos(){Nome="Biscoito maizena",Unidade="unidades",Quantidade=3,Calorias=80},
               new Alimentos(){Nome="Biscoito povilho",Unidade="rosca",Quantidade=5,Calorias=80},
               new Alimentos(){Nome="Biscoito Wafer",Unidade="unidades",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Bolacha Agua",Unidade="unidades",Quantidade=3,Calorias=80},
               new Alimentos(){Nome="Bolcha Salgada",Unidade="unidades",Quantidade=3,Calorias=80},
               new Alimentos(){Nome="Canelone",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Capeletti ou ravioli 1/2",Unidade="xicara",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Creme de milho",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Cucuz",Unidade="fatia média",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Farelo de Aveia",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Farela de trigo",Unidade="colheres",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Farinhas geral",Unidade="colheres",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Farofa",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Feijão,Ervilha,Lentilha",Unidade="colheres",Quantidade=4,Calorias=80},
               new Alimentos(){Nome="Feijão branco",Unidade="colheres",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Floco de arroz",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Floco de milho",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Fubá",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Gergilim",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Germe de trigo",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Grão de bico",Unidade="colheres",Quantidade=3,Calorias=80},
               new Alimentos(){Nome="Macarrao cozido",Unidade="xicara",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Maizena",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Mandioca",Unidade="pedaço",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Mandioquinha",Unidade="pedaço",Quantidade=3,Calorias=80},
               new Alimentos(){Nome="Milho verde",Unidade="colher sopa",Quantidade=3,Calorias=80},
               new Alimentos(){Nome="Pão frances 1/2",Unidade="unidade sem miolo",Quantidade=0.5,Calorias=80},
               new Alimentos(){Nome="Pão de forma",Unidade="fatia",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Pão integral",Unidade="fatia",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Pão de centeio",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Pão de gluten",Unidade="unidades",Quantidade=2,Calorias=80},
               new Alimentos(){Nome="Pão de queijo",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Pão de hamburguer ou hotdog",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Pão italiano",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Pão de leite",Unidade="fatia",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Pão sírio",Unidade="unidade",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Polenta Assada",Unidade="fatia",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="pure de batata",Unidade="colher",Quantidade=1,Calorias=80},
               new Alimentos(){Nome="Risoto 1 1/2 ",Unidade="colher",Quantidade=1.5,Calorias=80},
               new Alimentos(){Nome="Suflede queijo 1 1/2",Unidade="colher",Quantidade=1.5,Calorias=80},

	           #endregion
             #region grupo 5 - 100 calorias
		       new Alimentos(){Nome="Queijo Camebert",Unidade="Fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Queijo Gorgozola",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Queijo Minas",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Mussarela de bufala",Unidade="unidade",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Mussarela",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Parmesão",Unidade="colher",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Polenguinho",Unidade="unidade",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Queijo prato",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Provolone",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Queijo de sopa",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Queijo Roquefort",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Requeijão Light",Unidade="colher",Quantidade=3,Calorias=100},
	           #endregion
             #region grupo 6 - 100 calorias
		       new Alimentos(){Nome="Almondega(carne ou frango)",Unidade="unidades",Quantidade=2,Calorias=100},
               new Alimentos(){Nome="Aves sem pele",Unidade="porcao",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Carne gorda de vaca",Unidade="porcao",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Carne magra de vaca",Unidade="unidade",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Camarão",Unidade="pires",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Dobradinha",Unidade="pires",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Figado de boi",Unidade="bife",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Hambuguer",Unidade="unidade",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Linguiça",Unidade="unidade",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Lombo defumado",Unidade="porção",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Lula",Unidade="pires",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Marisco",Unidade="pires",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Miolo",Unidade="porção",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Miúdos",Unidade="porcão",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Omelete",Unidade="ovo",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Ostra e mexiloes",Unidade="unidade",Quantidade=5,Calorias=100},
               new Alimentos(){Nome="Ovo",Unidade="unidade",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Ovo de cordona",Unidade="unidades",Quantidade=4,Calorias=100},
               new Alimentos(){Nome="Peito de peru",Unidade="fatias",Quantidade=2,Calorias=100},
               new Alimentos(){Nome="Peixe fresco",Unidade="porção",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Peixe salgado ou hadock",Unidade="porção",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Polvo",Unidade="porção",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Presunto ou frios",Unidade="fatia fina",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Quibe assado",Unidade="fatia",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Quibe Cru",Unidade="porção",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Rosbife",Unidade="fatias",Quantidade=2,Calorias=100},
               new Alimentos(){Nome="Salsicha",Unidade="unidade",Quantidade=1,Calorias=100},
               new Alimentos(){Nome="Sardinha fresca",Unidade="unidades",Quantidade=5,Calorias=100},
               new Alimentos(){Nome="Sardinha em olho",Unidade="unidade",Quantidade=1,Calorias=100},
	           #endregion             
             #region grupo 7 - 120 calores
		
              new Alimentos(){Nome="Margarina",Unidade="colheres",Quantidade=2,Calorias=120},
              new Alimentos(){Nome="Coalhada seca 1 1/2",Unidade="colheres",Quantidade=1.5,Calorias=120},
              new Alimentos(){Nome="leite integral",Unidade="copo",Quantidade=4,Calorias=35},
              new Alimentos(){Nome="Leite integral em pó",Unidade="colheres",Quantidade=4,Calorias=120},
              new Alimentos(){Nome="Leite ou iorgute em pó 1 1/2",Unidade="colheres",Quantidade=1.5,Calorias=120},
              new Alimentos(){Nome="Leite ou iorgute desnatado 1 1/2",Unidade="copo",Quantidade=1.5,Calorias=120},
              new Alimentos(){Nome="Iorgute Natural 3/4",Unidade="copo",Quantidade=0.75,Calorias=120},
              new Alimentos(){Nome="Leite de sopa",Unidade="copo",Quantidade=1,Calorias=120},
              

	#endregion
             #region grupo 8 - 120 calores
		
              new Alimentos(){Nome="Creme de palmito",Unidade="conchas",Quantidade=2,Calorias=120},
              new Alimentos(){Nome="Canja sem pele",Unidade="concha",Quantidade=1,Calorias=120},
              new Alimentos(){Nome="Creme de aspargo",Unidade="concha",Quantidade=1,Calorias=35},
              new Alimentos(){Nome="Creme de cebola",Unidade="conhca",Quantidade=2,Calorias=120},
              new Alimentos(){Nome="Creme de cogumelo",Unidade="concha",Quantidade=1,Calorias=120},
              new Alimentos(){Nome="Creme de ervilhas",Unidade="concha",Quantidade=1,Calorias=120},
              new Alimentos(){Nome="Caldo verde",Unidade="conchas",Quantidade=2,Calorias=120},
              new Alimentos(){Nome="Sopa de legumes",Unidade="conchas",Quantidade=2,Calorias=120},
              

	#endregion
            };


            return alimento;

        }




    }
}
