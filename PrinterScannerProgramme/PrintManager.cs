using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class PrintManager
    {
        
        
        public void PrintDocument(IPrintonly print )
        {
            print.Print();
        }


    }
}
