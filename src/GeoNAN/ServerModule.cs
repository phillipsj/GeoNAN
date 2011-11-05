using System.Collections.Generic;
using GeoNAN.Models;
using Nancy;

namespace GeoNAN
{
   public class ServerModule:NancyModule
   {
      public ServerModule()
      {
         Get["/"] = x =>
         {
            return View["home"];
         };

         Get["/services/test"] = x =>
         {            
            return View["test"];
         };

         Get["/services/"] = x =>
         {
            return View["services", new List<string>{ "locations", "events", "stations"}];
         };         

         Get["/services/{resourceName}/featureserver"] = x =>
         {
            var fs = new FeatureServer(x.resourceName);
            fs.layers = new List<FeatureServerLayer> { 
               new FeatureServerLayer { id = 0, name = "woot"},
               new FeatureServerLayer { id = 1, name = "wootacious"}
            };
            fs.tables = new List<FeatureServerTable> { 
               new FeatureServerTable { id = 0, name = "negative"},
               new FeatureServerTable { id = 1, name = "supernegative"}
            };

            if (Request.Query["f"] == "json")
               return Response.AsJson(fs);
            else
               return View["featureServer", fs];
         };

         Get["/services/{resourceName}/featureserver/{tableName}"] = x =>
         {
            var s = "Endpoint definition";
            if (Request.Query["f"] == "json")
               return Response.AsJson(s);
            else
               return View["featureServer", s];
         };
      }
   }
}