using Nancy;
using System.Collections.Generic;
using Date.Objects;


namespace Date
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
        }
    }
}
