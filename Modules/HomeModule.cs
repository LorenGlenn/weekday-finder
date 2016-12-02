using Nancy;
using System.Collections.Generic;
using Finder.Object;

namespace Finder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      //Insert your GETs and POSTs here
      Post["/find-weekday"] =_=>
      {
        string date = Request.Form["date"];
        DayFinder newDayFinder = new DayFinder(date);
        newDayFinder.Counter();
        return View["index.cshtml", newDayFinder.GetDayOfWeek()];
      };
    }
  }
}
