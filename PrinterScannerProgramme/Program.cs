using System;

namespace PrinterScannerProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer _printerRef = new Printer();
            Scanner _scannerRef = new Scanner();

            PrintManager _printManager = new PrintManager();
            _printManager.Print();

            ScanManager _scanManager = new ScanManager();
            _scanManager.ScanDo(_scannerRef);

            PrintScanner _printScanner = new PrintScanner();
            _printManager.PrintDocument(_printScanner);
            _scanManager.ScanDocument(_printScanner);
        }
    }
}
