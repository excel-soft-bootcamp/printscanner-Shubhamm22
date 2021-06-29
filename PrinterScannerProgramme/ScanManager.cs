using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProgramme
{
    class ScanManager: Iscanonly
    {
        Iscanonly iscan1;
        public ScanManager(Iscanonly scanner)
        {
            this.iscan1 = scanner;
           
        }
        public void Scan()
        {
            iscan1.Scan();
        }
        public void ScanDocument()
        {
            iscan1.Scan();
        }
        
    }
}
