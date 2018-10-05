using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPS_Barcode_System.Enums
{
    /// <summary>
    /// All possible error types in the system.
    /// </summary>
    public enum EnumErrorType
    {
        InvalidZipCodeInput,
        InvalidBarCodeInput,
        IncorrectBarCode,
        IncorrectCheckDigit,
        OutputBoxIsEmpty
    }
}
