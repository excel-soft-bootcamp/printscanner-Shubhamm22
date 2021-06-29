using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class PrintScanner : Iprintscan,Iprintonly,Iscanonly
    {
        Iprintonly _print;
        Iscanonly _scan;
        Iprintscan _printscan;
        public PrintScanner(Iprintscan printerscanner )
        {
            //this._print = print;
            //this._scan = scan;
            this._printscan = printerscanner;
           

        }
        public void PrintDocument()
        {
            PrintManager _printmanager = new PrintManager();
            _printmanager.PrintDocument(printer);

        }
        public void ScanDocument()
        {
         _scan.Scan();
        }
           
    }
}
