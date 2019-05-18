using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aula25_Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Criando uma nova rota
            routes.MapRoute(
                name:"Produtos",
                url: "Produtos/",
                defaults: new { controller = "Produto", action = "Index" }
           );

            routes.MapRoute(
              "Detalhes",
              "Produtos/{produtoid}",
              new { controller = "Produto", action = "Detalhes" },
              new { produtoid = @"\d+" } //Aqui restrige que só digito seja aceito
            );

            //A posição aqui é importante, pq se estivese de baixo do Categorias,
            //ele vai endenter como uma categoria
            routes.MapRoute(
              "Cadastro",
              "Produtos/Cadastrar",
              new { controller = "Produto", action = "Cadastrar" }
            );

            routes.MapRoute(
              "Categorias",
              "Produtos/{categoria}",
              new { controller = "Produto", action = "Categorias" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produto", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
