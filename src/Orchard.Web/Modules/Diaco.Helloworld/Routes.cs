using System.Collections.Generic;
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
                                                     Priority = 12,
                                                     Route = new Route(
                                                         "Diaco",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Diaco.Helloworld"},
                                                                                      {"controller", "Home"},
                                                                                      {"action", "Index"}
                                                                                  },
                                                         new RouteValueDictionary(),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Diaco.Helloworld"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Priority = 12,
                                                     Route = new Route(
                                                         "{culture}/Diaco",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Diaco.Helloworld"},
                                                                                      {"controller", "Home"},
                                                                                      {"action", "Index"},
                                                                                      {"culture", "en-US"}
                                                                                  },
                                                         new RouteValueDictionary(),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Diaco.Helloworld"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/Create",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogAdmin"},
                                                                                      {"action", "Create"}
                                                                                  },
                                                         new RouteValueDictionary(),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}/Edit",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogAdmin"},
                                                                                      {"action", "Edit"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}/Remove",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogAdmin"},
                                                                                      {"action", "Remove"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogAdmin"},
                                                                                      {"action", "Item"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}/Posts/Create",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogPostAdmin"},
                                                                                      {"action", "Create"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}/Posts/{postId}/Edit",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogPostAdmin"},
                                                                                      {"action", "Edit"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}/Posts/{postId}/Delete",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogPostAdmin"},
                                                                                      {"action", "Delete"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}/Posts/{postId}/Publish",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogPostAdmin"},
                                                                                      {"action", "Publish"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs/{blogId}/Posts/{postId}/Unpublish",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogPostAdmin"},
                                                                                      {"action", "Unpublish"}
                                                                                  },
                                                         new RouteValueDictionary (),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Blogs",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogAdmin"},
                                                                                      {"action", "List"}
                                                                                  },
                                                         new RouteValueDictionary(),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Blogs",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "Blog"},
                                                                                      {"action", "List"}
                                                                                  },
                                                         new RouteValueDictionary(),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "{*path}",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "BlogPost"},
                                                                                      {"action", "ListByArchive"}
                                                                                  },
                                                         new RouteValueDictionary {
                                                                                      {"path", "_archiveConstraint"},
                                                                                  },
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                             new RouteDescriptor {
                                                     Priority = 11,
                                                     Route = new Route(
                                                         "{*path}",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"},
                                                                                      {"controller", "RemoteBlogPublishing"},
                                                                                      {"action", "Rsd"}
                                                                                  },
                                                         new RouteValueDictionary {
                                                                                      {"path", "_rsdConstraint"}
                                                                                  },
                                                         new RouteValueDictionary {
                                                                                      {"area", "Orchard.Blogs"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 }
                         };
        }
    }
}