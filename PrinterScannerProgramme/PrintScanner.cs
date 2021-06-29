using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class PrintScanner
    {
        Iprintonly _print;
        Iscanonly _scan;
      
        public PrintScanner(Iprintonly print1)
        {
             this._print = print1;
            

        }
        public PrintScanner(Iscanonly scan1) { this._scan = scan1; }
        public void PrintDocument()
        {

            _print.Print();
        }
      
        public void ScanDocument()
        {
          
            _scan.Scan();

        }
        
           
    }
}
