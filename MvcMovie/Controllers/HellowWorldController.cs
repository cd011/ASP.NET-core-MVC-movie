using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    //
    //GET: /HelloWorld/
    //don't have to add Index as an action because it is called as default
    public string Index()
    {
        return "This is my default action...";
    }
    //
    //GET: /HelloWorld/Welcome/
    //Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int ID = 1)
    {
        //return "This is the Welcome action method...";

        //called by localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        
        //called by localhost:{PORT}/HelloWorld/Welcome/3?name=Rick
        //third URL segment is considered as the route parameter id
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}
