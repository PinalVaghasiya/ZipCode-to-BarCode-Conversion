using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPS_Barcode_System.Entities
{
    class BarCodeSystem
    {
        /// <summary>
        /// Dictionary to store the rules given in the requirement representing the bar value for each number from 0 to 9 and Start/Stop bar value.
        /// </summary>
        public static Dictionary<String, String> rules = new Dictionary<String, String>();

        /// <summary>
        /// Static Constructor to initialize the rules.
        /// </summary>
        static BarCodeSystem()
        {
            rules.Add("0", "||:::");
            rules.Add("1", ":::||");
            rules.Add("2", "::|:|");
            rules.Add("3", "::||:");
            rules.Add("4", ":|::|");
            rules.Add("5", ":|:|:");
            rules.Add("6", ":||::");
            rules.Add("7", "|:::|");
            rules.Add("8", "|::|:");
            rules.Add("9", "|:|::");
            rules.Add("Start/Stop", "|");
        }
    }
}
