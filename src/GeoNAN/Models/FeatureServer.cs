using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoNAN.Models
{
   public class FeatureServer
   {
      public string serviceDescription { get; set; }
      public List<FeatureServerLayer> layers { get; set; }
      public List<FeatureServerTable> tables { get; set; }
      public FeatureServer(string serviceDesc)
      {
         serviceDescription = serviceDesc;
         layers = new List<FeatureServerLayer>();
         tables = new List<FeatureServerTable>();
      }
   }

   public class FeatureServerLayer
   {
      public int id { get; set; }
      public string name { get; set; }
   }

   public class FeatureServerTable
   {
      public int id { get; set; }
      public string name { get; set; }
   }
}