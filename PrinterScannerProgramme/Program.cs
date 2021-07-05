using System;

namespace PrinterScannerProgramme
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer _printerRef = new Printer();
           

            Scanner _scannerRef = new Scanner();
            

            PrintManager _printmanager = new PrintManager();
            _printmanager.PrintDocument(_printerRef);
            
            ScanManager _scanmanager = new  ScanManager();
            _scanmanager.ScanDocument(_scannerRef);

            PrintScanner _printScanner = new PrintScanner();
            _printScanner.SetPrinter(_printerRef);
            _printScanner.SetScanner(_scannerRef);

            _printmanager.PrintDocument(_printScanner);
            _scanmanager.ScanDocument(_printScanner);
           
        }
    }
}
