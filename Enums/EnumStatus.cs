using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPS_Barcode_System.Enums
{
    //All possible statuses for methods in Business layer.
    public enum EnumStatus
    {
        Success,
        IncorrectBarCode,
        IncorrectCheckDigit
    }
}
