using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDF_Splitter
{
    internal static class Helpers
    {
        internal static string ShowFolderSelectDialog(string title)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = title;
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    return fbd.SelectedPath;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
