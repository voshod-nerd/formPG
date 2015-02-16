using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Novacode;
using System.IO;


namespace WpfApplication1
{
    class ExportToDocx
    {
       public void InputDataMek(Dictionary<string,string> data,string filename) 
        {   
            //string fileDir= Directory.GetCurrentDirectory()+"/report/MEK.docx";


            using (DocX document = DocX.Load(filename))
            {
                /*
                 * Replace each instance of the string pear with the string banana.
                 * Specifying true as the third argument informs DocX to track the
                 * changes made by this replace. The fourth argument tells DocX to
                 * ignore case when matching the string pear.
                 */


                document.ReplaceText("#A1", "Мы все умрем", true, RegexOptions.IgnoreCase);
                document.ReplaceText("#A2", "Но не все сразу", true, RegexOptions.IgnoreCase);

               // document.ReplaceText( "#A1", data["#A1"], true, RegexOptions.IgnoreCase);
               // document.ReplaceText("#A2", data["#A2"], true, RegexOptions.IgnoreCase);
                // Save changes made to this document
                document.Save();
            }
            // Release this document from memory.

        
        }

    }
}
