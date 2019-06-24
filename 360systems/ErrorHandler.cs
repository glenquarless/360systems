using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace _360systems
{
    public static class ErrorHandler
    {
        public static string DefaultHandler(Exception _ex)
        {
            string output = "";

            try
            {
                output = "Error occurred: " + _ex.Message.ToString();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message.ToString());
            }
            return output;
        }
    }
}