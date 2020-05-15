using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Car_shop_Library
{
    public class GeneralUtils
    {
        public GeneralUtils() { }

        public string OutputFileName(string OutputFileDirectory, string fileExtension)
        {

            string fileFullname = Path.Combine(OutputFileDirectory, $"Output.{fileExtension}");

            return fileFullname;
        }
    }

    public class ErrorProviderUtilities
    {
        public ErrorProviderUtilities() { }

        public void setError(ErrorProvider error, Control control, string msg) { error.SetError(control, msg); }
   
        public void resetError(ErrorProvider error, Control control) { error.SetError(control, string.Empty); }
    }
}