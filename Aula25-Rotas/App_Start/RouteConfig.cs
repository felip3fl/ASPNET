﻿using System;
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
