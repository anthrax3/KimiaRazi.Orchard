﻿using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;

namespace Diaco.KimiaRazi {
    public class Routes : IRouteProvider {

        public Routes() {
            // constructor
        }

        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes() {
            return new[] {
                             new RouteDescriptor {
                                                     Priority = 81,
                                                     Route = new Route(
                                                         "{culture}/{controller}/{action}/{id}",
                                                         new RouteValueDictionary {
                                                                                      {"culture", "en-US"},
                                                                                      {"controller", "Home"},
                                                                                      {"action", "Index"},
                                                                                      {"id", UrlParameter.Optional}
                                                                                  },
                                                         new RouteValueDictionary {
                                                                                      {"culture", @"(\w{2})|(\w{2}-\w{2})"},
                                                                                      {"controller", @"(Home)"}
                                                                                  },
                                                         new RouteValueDictionary {
                                                                                      {"area", "Diaco.Helloworld"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 }
                         };
        }
    }
}