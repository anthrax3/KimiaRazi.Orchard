using Orchard.UI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diaco.KimiaRazi.Original
{
    public class ResourceManifest:IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineStyle("kimiarazi-rtl").SetUrl("kimiarazi-rtl.css");
            // manifest.DefineScript("MyScript").SetUrl("myscript.js").SetDependencies("jQuery");
        }
    }
}