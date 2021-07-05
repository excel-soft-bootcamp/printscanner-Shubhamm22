using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class ScanManager
    {
      
        public void ScanDocument(IScanonly scan)
        {
            scan.Scan();
        }
        
    }
}
