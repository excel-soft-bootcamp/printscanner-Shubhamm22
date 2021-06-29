using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class PrintManager:Iprintonly
    {
        Iprintonly print1;
        public PrintManager(Iprintonly printer)

        {
            this.print1 = printer;
           
        }
        public void Print() {
            print1.Print();

        }
        public void PrintDocument( )
        {
            print1.Print();
        }


    }
}
