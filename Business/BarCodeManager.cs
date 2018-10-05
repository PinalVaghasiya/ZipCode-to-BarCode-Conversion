using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USPS_Barcode_System.Entities;
using USPS_Barcode_System.Enums;

namespace USPS_Barcode_System.Business
{
    class BarCodeManager
    {
        /// <summary>
        /// Encodes the given Zip Code into Bar Code using the given rules for translating digits to bar code value.
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns>Encoded Bar Code in String format to display in UI.</returns>
        public static String encodeZipCode(String zipCode)
        {
            zipCode = zipCode.Replace("-", "");
            
            //Single Bar for Start of Bar Code output.
            String barCode = BarCodeSystem.rules["Start/Stop"];
            
            char[] arr = zipCode.ToCharArray();
            foreach (char c in arr)
            {
                //Fetches the Bar Code value for each digit in the given Zip Code.
                barCode += BarCodeSystem.rules[c.ToString()];
            }
            
            //Fetches the Bar Code value for the Check Digit returned from below function.
            barCode += BarCodeSystem.rules[getCheckDigit(zipCode)];

            //Single Bar for Stop of Bar Code output
            barCode += BarCodeSystem.rules["Start/Stop"];
            
            return barCode;
        }
        
        /// <summary>
        /// Computes the check digit using the formula given in the requirement.
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns>The Check Digit computed.</returns>
        public static String getCheckDigit(String zipCode)
        {
            int sum = 0, mod = 0;
            foreach (char c in zipCode.ToCharArray())
            {
                sum += int.Parse(c.ToString());
            }
            mod = sum % 10;
            if (mod == 0)
                return mod.ToString();
            else
                return (10 - mod).ToString();
        }

        /// <summary>
        /// Decodes the given Bar Code into Zip Code.
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="zipCode"></param>
        /// <returns>Status of the Decoding of Bar Code and updates the value of out parameter zipCode.</returns>
        public static EnumStatus decodeBarCode(String barCode, out String zipCode)
        {
            //Get rid of the Start and Stop Bars.
            barCode = barCode.Substring(1, barCode.Length - 2);
            
            zipCode = "";

            //Get the value of last 5 Bars which represent the Check Digit.
            String check = barCode.Substring(barCode.Length - 5, 5);
            
            //Get the numeric value of Check Digit using the given rules table.
            int checkDigit = int.Parse(BarCodeSystem.rules.FirstOrDefault(x => x.Value == check).Key);
            
            int sum = 0;

            //Loop through given input to fetch 5 bars each representing a digit each of zipCode.
            for (int i = 0; i <= (barCode.Length - 10); i = i + 5)
            {
                String val = BarCodeSystem.rules.FirstOrDefault(x => x.Value == barCode.Substring(i, 5)).Key;

                //These 5 bars do not represent any numeric value in given rule hence raise exception.
                if (val == null)
                    return EnumStatus.IncorrectBarCode;

                zipCode += val;
                sum += int.Parse(val);
            }

            if (verifyCheckDigit(sum, checkDigit))
                return EnumStatus.Success;
            else
                return EnumStatus.IncorrectCheckDigit;
        }

        /// <summary>
        /// Verifies if the Check Digit fetch from Bar Code is valid for given Zip Code.
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="checkDigit"></param>
        /// <returns>Return true if this Check Digit is valid. Otherwise, return false.</returns>
        public static bool verifyCheckDigit(int sum, int checkDigit)
        {
            if ((sum + checkDigit) % 10 == 0)
                return true;
            else
                return false;
        }
    }
}
