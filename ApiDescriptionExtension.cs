using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace System.Web.Http.Description
{
  /// <summary>
  /// API Descriptor Extension
  /// </summary>
  public static class ApiDescriptionExtension
  {
    /// <summary>
    /// Get the region name
    /// </summary>
    /// <param name="description"></param>
    /// <returns></returns>
    public static List<string> GetAreaName(this ApiDescription description)
    {
      string areaName = description.ActionDescriptor.RouteValues["path"];
      string controlName = description.ActionDescriptor.RouteValues["controller"];
      List<string> areaList = new List<string>();
      areaList.Add(controlName);
      if (!string.IsNullOrEmpty(areaName))
      {
        description.RelativePath = $"{areaName}/{controlName}/{description.RelativePath}";
      } 
      return areaList;
    }
  }
}