using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace povtor
{
    /// <summary>
    /// Эта программа позволяет общитывать погрешность 
    /// </summary>
    internal class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Dialogwin class1 = new Dialogwin(); // основная програма 
            class1.DialogWindows();

              
 
        }
    }
}
