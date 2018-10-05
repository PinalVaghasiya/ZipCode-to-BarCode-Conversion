using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using USPS_Barcode_System.Enums;
using USPS_Barcode_System.Business;

namespace USPS_Barcode_System
{
    public partial class USPSBarcodeSystem : Form
    {
        public EnumActionType actionType;
        
        public USPSBarcodeSystem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear all the fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "";
            txtBoxOutput.Text = "";
        }

        /// <summary>
        /// Change the font appearance of the output Bar Code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFontStyle_Click(object sender, EventArgs e)
        {
            if (txtBoxOutput.Text != "")
            {
                DialogResult result = fontDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Get Font.
                    Font font = fontDialog.Font;
                    // Set TextBox Font.
                    this.txtBoxOutput.Font = fontDialog.Font;
                }
            }
            else
                showErrorMessage(EnumErrorType.OutputBoxIsEmpty);
        }

        /// <summary>
        /// Entry point for Encoding Zip Code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encodeZipCode_Click(object sender, EventArgs e)
        {
            panelConversion.Visible = true;
            lblInput.Visible = true;
            lblOutput.Visible = true;

            txtBoxInput.Visible = true;
            this.txtBoxInput.Focus();
            txtBoxInput.Text = "";
            txtBoxInput.MaxLength = 10;
            
            txtBoxOutput.Visible = true;
            txtBoxOutput.Text = "";
            
            btnFontStyle.Visible = true;
            btnClear.Visible = true;

            btnConvert.Visible = true;
            btnConvert.Text = "Encode";
            
            pictureBoxBg.Visible = false;
            lblTitle.Text = "Encode Zip Code to Bar Code";
            lblInput.Text = "Enter Zip Code";

            actionType = EnumActionType.EncodeZipCode;
        }

        /// <summary>
        /// Entry point for Decoding Bar Code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decodeBarCode_Click(object sender, EventArgs e)
        {
            panelConversion.Visible = true;
            lblInput.Visible = true;
            lblOutput.Visible = true;

            txtBoxInput.Visible = true;
            txtBoxInput.Text = "";
            this.txtBoxInput.Focus();
            txtBoxInput.MaxLength = 52;
            
            txtBoxOutput.Visible = true;
            txtBoxOutput.Text = "";
            
            txtBoxOutput.Font = new Font("Century Gothic, 21.75pt", 21.75f);
            
            btnFontStyle.Visible = false;
            btnClear.Visible = true;
            
            btnConvert.Visible = true;
            btnConvert.Text = "Decode";
            
            pictureBoxBg.Visible = false;
            lblTitle.Text = "Decode Bar Code to Zip Code";
            lblInput.Text = "Enter Bar Code";

            actionType = EnumActionType.DecodeBarCode;
        }

        /// <summary>
        /// To adjust output textbox according to changes in the font appearance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxOutput_FontChanged(object sender, EventArgs e)
        {
            Size textBoxRect = TextRenderer.MeasureText(this.txtBoxOutput.Text, this.txtBoxOutput.Font,
                new Size(this.txtBoxOutput.Width, int.MaxValue),
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl);
            
            //Adding scrollbar.
            this.txtBoxOutput.ScrollBars = textBoxRect.Height > this.txtBoxOutput.Height ?
                ScrollBars.Vertical :
                ScrollBars.None;
        }

        /// <summary>
        /// Entry point for Decoding Bar Code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch(actionType)
            {
                //Encode Zip Code to Bar Code
                case EnumActionType.EncodeZipCode:
                    if (txtBoxInput.Text.Length != 10)
                        showErrorMessage(EnumErrorType.InvalidZipCodeInput);
                    else
                    {
                        String barCode = BarCodeManager.encodeZipCode(txtBoxInput.Text);
                        txtBoxOutput.Text = barCode;
                    }
                    break;
                //Decode Bar Code to Zip Code
                case EnumActionType.DecodeBarCode:
                    if (txtBoxInput.Text.Length != 52)
                        showErrorMessage(EnumErrorType.InvalidBarCodeInput);
                    else
                    {
                        String zipCode = "";
                        EnumStatus status = BarCodeManager.decodeBarCode(txtBoxInput.Text, out zipCode);
                        if (status == EnumStatus.Success)
                        {
                            string sVal = zipCode;
                            string newst = Regex.Replace(sVal, ".{5}", "$0-");
                            txtBoxOutput.Text = newst;
                            txtBoxOutput.SelectionStart = txtBoxOutput.Text.Length;
                        }
                        else
                            showErrorMessage((EnumErrorType) Enum.Parse(typeof(EnumErrorType), status.ToString()));
                    }
                    break;
            }
        }

        /// <summary>
        /// To limit the user for entering specfic inputs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(actionType)
            {
                case EnumActionType.EncodeZipCode:
                    e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
                    break;
                case EnumActionType.DecodeBarCode:
                    if (!char.IsControl(e.KeyChar) && (e.KeyChar != ':') && (e.KeyChar != '|'))
                        e.Handled = true;
                    break;
            }
        }

        /// <summary>
        /// To guide the user for input on mouse hover.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxHelp_MouseHover(object sender, EventArgs e)
        {
            PictureBox PB = null;
            switch (actionType)
            {
                case EnumActionType.EncodeZipCode:
                    PB = (PictureBox) sender;
                    toolTipHelp.Show("Hint: Zip code must be of ZIP+4 digits", PB, -20, 30, 2000);
                    break;
                case EnumActionType.DecodeBarCode:
                    PB = (PictureBox) sender;
                    toolTipHelp.Show("Hint: \nFull bar = '|' \nHalf bar = ':'", PB, -20, 30, 2000);
                    break;
            }
        }

        /// <summary>
        /// To guide the user for input on click of hint.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxHelp_Click(object sender, EventArgs e)
        {
            switch (actionType)
            {
                case EnumActionType.EncodeZipCode:
                    MessageBox.Show("Zip code must be of ZIP+4 digits", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case EnumActionType.DecodeBarCode:
                    MessageBox.Show("\nFull bar = '|' \nHalf bar = ':'", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }

        /// <summary>
        /// To dynamically seperate 5 digit zip code and 4 digit area code by adding a hyphen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            string sVal = txtBoxInput.Text;
            if (actionType == EnumActionType.EncodeZipCode && !string.IsNullOrEmpty(sVal) && e.KeyCode != Keys.Back)
            {
                sVal = sVal.Replace("-", "");
                string newst = Regex.Replace(sVal, ".{5}", "$0-");
                txtBoxInput.Text = newst;
                txtBoxInput.SelectionStart = txtBoxInput.Text.Length;
            }
        }

        /// <summary>
        /// Display apppropriate error messages for each exception scenarios.
        /// </summary>
        /// <param name="errorType"></param>
        public static void showErrorMessage(EnumErrorType errorType)
        {
            switch (errorType)
            {
                case EnumErrorType.InvalidZipCodeInput:
                    MessageBox.Show("The Zip code input should be ZIP+4 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case EnumErrorType.InvalidBarCodeInput:
                    MessageBox.Show("The Bar code input should have 52 half/full bars!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case EnumErrorType.IncorrectBarCode:
                    MessageBox.Show("The given Bar Code is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case EnumErrorType.IncorrectCheckDigit:
                    MessageBox.Show("The given Bar Code does not compute correctly against the check digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case EnumErrorType.OutputBoxIsEmpty:
                    MessageBox.Show("Output box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void txtBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
