using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _360systems
{
    /// <summary>
    /// Summary description for Main
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Main : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

       

        [WebMethod]
        public string Test()
        {
            string output = "";
            int values = 0;


            try
            {
                values = Worker.InitialDefaultArray()[1];
                output = values.ToString();
            }
            catch (Exception ex)
            {
                ErrorHandler.DefaultHandler(ex);
            }
            return output;
        }

        [WebMethod]
        public string GetDuplicates()
        {
            string output = "";
            int[] ints = new int[1000000];

            try
            {
                ints = Worker.InitialDefaultArray();
                output = GetDuplicatesFromInput(ints);
            }
            catch (Exception ex)
            {
                ErrorHandler.DefaultHandler(ex);
            }
            return output;
        }

        [WebMethod]
        public string GetDuplicatesFromInput(int[] _input)
        {
            string output = "";

            try
            {
                output = Worker.GetDuplicates(_input);
            }
            catch (Exception ex)
            {
                ErrorHandler.DefaultHandler(ex);
            }
            return output;
        }       
    }
}
