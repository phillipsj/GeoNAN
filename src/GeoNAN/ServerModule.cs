using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using GeoNAN.Models;

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
            var p = Request.Query;
            //return "This is just a test, your server is running as expected";\
            return View["test"];
         };

         Get["/services/"] = x =>
         {
            return View["services", new List<string>{ "locations", "events", "stations"}];
         };

         //Get["/services/{resourceName}"] = x =>
         //{
         //   return string.Format("This is a list of data endpoints for {0} resource!", x.resourceName);
         //};

         //Get["/services/{resourceName}/{tableName}"] = x =>
         //{
         //   return "Endpoint definition";
         //};

         Get["/services/{resourceName}/featureserver"] = x =>
         {
            var fs = new FeatureServer(x.resourceName);
            fs.layers = new List<FsLayer> { 
               new FsLayer { id = 0, name = "woot"},
               new FsLayer { id = 1, name = "wootacious"}
            };
            fs.tables = new List<FsTable> { 
               new FsTable { id = 0, name = "negative"},
               new FsTable { id = 1, name = "supernegative"}
            };

            if (Request.Query["f"] == "json")
               return Response.AsJson(fs);
            else
               return View["featureServer", fs];
         };

         Get["/services/{resourceName}/featureserver/{tableName}"] = x =>
         {
            return "Endpoint definition";
         };

         Get["/services/{resourceName}/featureserver/{tableName}/{primaryKey}"] = x =>
         {
            return "Endpoint definition";
         };
      }
   }
}