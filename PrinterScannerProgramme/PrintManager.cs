using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class PrintManager: Iprintonly
    {
        Iprintonly print1;
        public void PrintDocument(Iprintonly printer)

        {
            this.print1 = printer; }
        public void Print() {
            print1.Print();
           
        }
           
        }
    }
}
