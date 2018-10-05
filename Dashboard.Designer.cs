namespace USPS_Barcode_System
{
    partial class USPSBarcodeSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USPSBarcodeSystem));
            this.pictureBoxBg = new System.Windows.Forms.PictureBox();
            this.btnPostalToBar = new System.Windows.Forms.Button();
            this.btnFontStyle = new System.Windows.Forms.Button();
            this.btnBarToPostal = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.panelMenubar = new System.Windows.Forms.Panel();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.panelConversion = new System.Windows.Forms.Panel();
            this.picBoxHelp = new System.Windows.Forms.PictureBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).BeginInit();
            this.panelMenubar.SuspendLayout();
            this.panelConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBg
            // 
            this.pictureBoxBg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBg.Image")));
            this.pictureBoxBg.Location = new System.Drawing.Point(129, 120);
            this.pictureBoxBg.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBg.Name = "pictureBoxBg";
            this.pictureBoxBg.Size = new System.Drawing.Size(465, 329);
            this.pictureBoxBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBg.TabIndex = 0;
            this.pictureBoxBg.TabStop = false;
            // 
            // btnPostalToBar
            // 
            this.btnPostalToBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostalToBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostalToBar.ForeColor = System.Drawing.Color.Red;
            this.btnPostalToBar.Location = new System.Drawing.Point(3, 6);
            this.btnPostalToBar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostalToBar.Name = "btnPostalToBar";
            this.btnPostalToBar.Size = new System.Drawing.Size(165, 42);
            this.btnPostalToBar.TabIndex = 1;
            this.btnPostalToBar.Text = "Encode Zip Code";
            this.btnPostalToBar.UseVisualStyleBackColor = true;
            this.btnPostalToBar.Click += new System.EventHandler(this.encodeZipCode_Click);
            // 
            // btnFontStyle
            // 
            this.btnFontStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFontStyle.ForeColor = System.Drawing.Color.Black;
            this.btnFontStyle.Location = new System.Drawing.Point(129, 257);
            this.btnFontStyle.Margin = new System.Windows.Forms.Padding(2);
            this.btnFontStyle.Name = "btnFontStyle";
            this.btnFontStyle.Size = new System.Drawing.Size(214, 42);
            this.btnFontStyle.TabIndex = 6;
            this.btnFontStyle.Text = "Change Font Syle";
            this.btnFontStyle.UseVisualStyleBackColor = true;
            this.btnFontStyle.Visible = false;
            this.btnFontStyle.Click += new System.EventHandler(this.btnFontStyle_Click);
            // 
            // btnBarToPostal
            // 
            this.btnBarToPostal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarToPostal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBarToPostal.ForeColor = System.Drawing.Color.Red;
            this.btnBarToPostal.Location = new System.Drawing.Point(172, 6);
            this.btnBarToPostal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBarToPostal.Name = "btnBarToPostal";
            this.btnBarToPostal.Size = new System.Drawing.Size(165, 42);
            this.btnBarToPostal.TabIndex = 2;
            this.btnBarToPostal.Text = "Decode Bar Code";
            this.btnBarToPostal.UseVisualStyleBackColor = true;
            this.btnBarToPostal.Click += new System.EventHandler(this.decodeBarCode_Click);
            // 
            // panelMenubar
            // 
            this.panelMenubar.Controls.Add(this.btnPostalToBar);
            this.panelMenubar.Controls.Add(this.btnBarToPostal);
            this.panelMenubar.Location = new System.Drawing.Point(39, 57);
            this.panelMenubar.Name = "panelMenubar";
            this.panelMenubar.Size = new System.Drawing.Size(516, 52);
            this.panelMenubar.TabIndex = 8;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblInput.Location = new System.Drawing.Point(11, 20);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(103, 16);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Enter Zip Code";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInput.Visible = false;
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(129, 56);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(214, 42);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Bar Code";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(366, 56);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(214, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.clear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOutput.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblOutput.Location = new System.Drawing.Point(44, 117);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(69, 16);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Bar Code";
            this.lblOutput.Visible = false;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtBoxOutput.BackColor = System.Drawing.Color.White;
            this.txtBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxOutput.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOutput.Location = new System.Drawing.Point(129, 111);
            this.txtBoxOutput.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.Size = new System.Drawing.Size(453, 133);
            this.txtBoxOutput.TabIndex = 6;
            this.txtBoxOutput.TabStop = false;
            this.txtBoxOutput.Visible = false;
            this.txtBoxOutput.FontChanged += new System.EventHandler(this.txtBoxOutput_FontChanged);
            this.txtBoxOutput.TextChanged += new System.EventHandler(this.txtBoxOutput_TextChanged);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxInput.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.Location = new System.Drawing.Point(129, 17);
            this.txtBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(451, 27);
            this.txtBoxInput.TabIndex = 3;
            this.txtBoxInput.Visible = false;
            this.txtBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxInput_KeyDown);
            this.txtBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxInput_KeyPress);
            // 
            // panelConversion
            // 
            this.panelConversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConversion.Controls.Add(this.picBoxHelp);
            this.panelConversion.Controls.Add(this.btnFontStyle);
            this.panelConversion.Controls.Add(this.lblInput);
            this.panelConversion.Controls.Add(this.txtBoxInput);
            this.panelConversion.Controls.Add(this.btnConvert);
            this.panelConversion.Controls.Add(this.btnClear);
            this.panelConversion.Controls.Add(this.txtBoxOutput);
            this.panelConversion.Controls.Add(this.lblOutput);
            this.panelConversion.Location = new System.Drawing.Point(39, 115);
            this.panelConversion.Name = "panelConversion";
            this.panelConversion.Size = new System.Drawing.Size(626, 322);
            this.panelConversion.TabIndex = 9;
            this.panelConversion.Visible = false;
            // 
            // picBoxHelp
            // 
            this.picBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("picBoxHelp.Image")));
            this.picBoxHelp.Location = new System.Drawing.Point(587, 17);
            this.picBoxHelp.Name = "picBoxHelp";
            this.picBoxHelp.Size = new System.Drawing.Size(22, 23);
            this.picBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHelp.TabIndex = 7;
            this.picBoxHelp.TabStop = false;
            this.picBoxHelp.Click += new System.EventHandler(this.picBoxHelp_Click);
            this.picBoxHelp.MouseHover += new System.EventHandler(this.picBoxHelp_MouseHover);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.ShowAlways = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(40, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(406, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Welcome to USPS Barcode System";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(113, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 48);
            this.panel1.TabIndex = 7;
            // 
            // USPSBarcodeSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelConversion);
            this.Controls.Add(this.panelMenubar);
            this.Controls.Add(this.pictureBoxBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "USPSBarcodeSystem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USPS Barcode System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).EndInit();
            this.panelMenubar.ResumeLayout(false);
            this.panelConversion.ResumeLayout(false);
            this.panelConversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBg;
        private System.Windows.Forms.Button btnPostalToBar;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button btnFontStyle;
        private System.Windows.Forms.Button btnBarToPostal;
        private System.Windows.Forms.Panel panelMenubar;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Panel panelConversion;
        private System.Windows.Forms.PictureBox picBoxHelp;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
    }
}

