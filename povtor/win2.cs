using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace povtor
{
    public class win2
    {
        public double testWin(double b1, double b2)
        {
            double b = ((b1 * 100) / b2);
            return b;
        }
        public void testWin2(double b1, double b2)//
        {
            Trace.Listeners.Add(new TextWriterTraceListener("Debug123.txt"));// дебаг
            Debug.Indent();
            Trace.Indent();//
            Debug.WriteLine("Debugged " + b1);// трейс и дебаг 
            Trace.WriteLine("Traced " + b2);///
            Debug.WriteLine("");
            Trace.Flush();
        }
    }
}
