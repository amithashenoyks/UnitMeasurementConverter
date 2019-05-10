namespace UnitMeasurementConverter
{
    partial class UnitConverter
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
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.outputTxtBox = new System.Windows.Forms.TextBox();
            this.fromUnitList = new System.Windows.Forms.ComboBox();
            this.toUnitList = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(12, 42);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.inputTxtBox.TabIndex = 0;
            this.inputTxtBox.Text = "1";
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Location = new System.Drawing.Point(298, 42);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.Size = new System.Drawing.Size(100, 20);
            this.outputTxtBox.TabIndex = 1;
            // 
            // fromUnitList
            // 
            this.fromUnitList.FormattingEnabled = true;
            this.fromUnitList.Location = new System.Drawing.Point(13, 82);
            this.fromUnitList.Name = "fromUnitList";
            this.fromUnitList.Size = new System.Drawing.Size(99, 21);
            this.fromUnitList.TabIndex = 2;
            // 
            // toUnitList
            // 
            this.toUnitList.FormattingEnabled = true;
            this.toUnitList.Location = new System.Drawing.Point(298, 82);
            this.toUnitList.Name = "toUnitList";
            this.toUnitList.Size = new System.Drawing.Size(100, 21);
            this.toUnitList.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(168, 64);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(98, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert To";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 145);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.toUnitList);
            this.Controls.Add(this.fromUnitList);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.inputTxtBox);
            this.Name = "UnitConverter";
            this.Text = "UnitConverter";
            this.Load += new System.EventHandler(this.UnitConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.TextBox outputTxtBox;
        private System.Windows.Forms.ComboBox fromUnitList;
        private System.Windows.Forms.ComboBox toUnitList;
        private System.Windows.Forms.Button btnConvert;
    }
}