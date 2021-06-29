using System;

namespace PrinterScannerProgramme
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer _printerRef = new Printer();
            _printerRef.Print();

            Scanner _scannerRef = new Scanner();
            _scannerRef.Scan();

            PrintManager _printmanager = new PrintManager(_printerRef);
            _printmanager.Print();
            ScanManager _scanmanager = new ScanManager(_scannerRef);
            _scanmanager.Scan();

            PrintScanner _printscanner = new PrintScanner(_printmanager);
            _printscanner.PrintDocument();

            PrintScanner _printscanner1 = new PrintScanner(_scanmanager);
            _printscanner1.ScanDocument();
           
        }
    }
}
