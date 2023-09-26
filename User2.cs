using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;


namespace OOPSPROJECT_TQ.Delegates
{
    internal class User2

    {
        public delegate string MyDelegate1(string Name);
        

        
            public static string UpperCase(string Name)

            {
                return Name.ToUpper();

            }
            
         
           
            
        

      
    }
}
