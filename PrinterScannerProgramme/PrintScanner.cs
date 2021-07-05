using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class PrintScanner:IPrintonly,IScanonly
    {
        IPrintonly _printerref;
        IScanonly _scanerref;
     
        public void SetPrinter(IPrintonly printeref) 
        {
            

             this._printerref = printeref;
            

        }
        public void  SetScanner(IScanonly scanerref) { this._scanerref = scanerref; }
        public void Print()
        {
            

            this._printerref.Print();
        }
      
        public void Scan()
        {
          
            this._scanerref.Scan();

        }
        
           
    }
}
