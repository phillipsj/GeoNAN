using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoNAN.Models
{
   public class FeatureServer
   {
      public string serviceDescription { get; set; }
      public List<FeatureServerLayerInfo> layers { get; set; }
      public List<FeatureServerTableInfo> tables { get; set; }

      public FeatureServer()
      {
         layers = new List<FeatureServerLayerInfo>();
         tables = new List<FeatureServerTableInfo>();
      }

      public FeatureServer(string serviceDesc)
      {
         serviceDescription = serviceDesc;
         layers = new List<FeatureServerLayerInfo>();
         tables = new List<FeatureServerTableInfo>();
      }
   }

   public class FeatureServerLayerInfo
   {
      public int id { get; set; }
      public string name { get; set; }
   }

   public class FeatureServerTableInfo
   {
      public int id { get; set; }
      public string name { get; set; }
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