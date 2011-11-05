using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoNAN.Models
{
   public class FeatureServer
   {
      public string serviceDescription { get; set; }
      public List<FsLayer> layers { get; set; }
      public List<FsTable> tables { get; set; }
      public FeatureServer(string serviceDesc)
      {
         serviceDescription = serviceDesc;
         layers = new List<FsLayer>();
         tables = new List<FsTable>();
      }
   }

   public class FsLayer
   {
      public int id { get; set; }
      public string name { get; set; }
   }

   public class FsTable
   {
      public int id { get; set; }
      public string name { get; set; }
   }
}