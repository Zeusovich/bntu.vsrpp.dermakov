
using System;

namespace bntu.vsrpp.dermakov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxNumbers = new System.Windows.Forms.GroupBox();
            this.buttonListNumbers = new System.Windows.Forms.Button();
            this.checkBoxMinNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxMaxNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxAverageNumber = new System.Windows.Forms.CheckBox();
            this.textBoxAverageNumber = new System.Windows.Forms.TextBox();
            this.textBoxMinNumber = new System.Windows.Forms.TextBox();
            this.textBoxMaxNumber = new System.Windows.Forms.TextBox();
            this.groupBoxStrings = new System.Windows.Forms.GroupBox();
            this.buttonListStrings = new System.Windows.Forms.Button();
            this.textBoxAverageLength = new System.Windows.Forms.TextBox();
            this.textBoxMinLength = new System.Windows.Forms.TextBox();
            this.checkBoxAverageLength = new System.Windows.Forms.CheckBox();
            this.textBoxMaxLength = new System.Windows.Forms.TextBox();
            this.checkBoxMaxLength = new System.Windows.Forms.CheckBox();
            this.checkBoxMinLength = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfElements = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxNumbers.SuspendLayout();
            this.groupBoxStrings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOpen.Location = new System.Drawing.Point(387, 236);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(90, 39);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open file";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSave.Location = new System.Drawing.Point(609, 236);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 39);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save file";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxNumbers
            // 
            this.groupBoxNumbers.Controls.Add(this.buttonListNumbers);
            this.groupBoxNumbers.Controls.Add(this.checkBoxMinNumber);
            this.groupBoxNumbers.Controls.Add(this.checkBoxMaxNumber);
            this.groupBoxNumbers.Controls.Add(this.checkBoxAverageNumber);
            this.groupBoxNumbers.Controls.Add(this.textBoxAverageNumber);
            this.groupBoxNumbers.Controls.Add(this.textBoxMinNumber);
            this.groupBoxNumbers.Controls.Add(this.textBoxMaxNumber);
            this.groupBoxNumbers.Location = new System.Drawing.Point(51, 12);
            this.groupBoxNumbers.Name = "groupBoxNumbers";
            this.groupBoxNumbers.Size = new System.Drawing.Size(294, 196);
            this.groupBoxNumbers.TabIndex = 2;
            this.groupBoxNumbers.TabStop = false;
            this.groupBoxNumbers.Text = "Numbers";
            // 
            // buttonListNumbers
            // 
            this.buttonListNumbers.Location = new System.Drawing.Point(40, 170);
            this.buttonListNumbers.Name = "buttonListNumbers";
            this.buttonListNumbers.Size = new System.Drawing.Size(204, 25);
            this.buttonListNumbers.TabIndex = 11;
            this.buttonListNumbers.Text = "List of numbers";
            this.buttonListNumbers.UseVisualStyleBackColor = true;
            this.buttonListNumbers.Click += new System.EventHandler(this.buttonListNumbers_Click);
            // 
            // checkBoxMinNumber
            // 
            this.checkBoxMinNumber.AutoSize = true;
            this.checkBoxMinNumber.Location = new System.Drawing.Point(15, 84);
            this.checkBoxMinNumber.Name = "checkBoxMinNumber";
            this.checkBoxMinNumber.Size = new System.Drawing.Size(56, 24);
            this.checkBoxMinNumber.TabIndex = 7;
            this.checkBoxMinNumber.Text = "min";
            this.checkBoxMinNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaxNumber
            // 
            this.checkBoxMaxNumber.AutoSize = true;
            this.checkBoxMaxNumber.Location = new System.Drawing.Point(15, 37);
            this.checkBoxMaxNumber.Name = "checkBoxMaxNumber";
            this.checkBoxMaxNumber.Size = new System.Drawing.Size(59, 24);
            this.checkBoxMaxNumber.TabIndex = 6;
            this.checkBoxMaxNumber.Text = "max";
            this.checkBoxMaxNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxAverageNumber
            // 
            this.checkBoxAverageNumber.AutoSize = true;
            this.checkBoxAverageNumber.Location = new System.Drawing.Point(15, 134);
            this.checkBoxAverageNumber.Name = "checkBoxAverageNumber";
            this.checkBoxAverageNumber.Size = new System.Drawing.Size(84, 24);
            this.checkBoxAverageNumber.TabIndex = 4;
            this.checkBoxAverageNumber.Text = "average";
            this.checkBoxAverageNumber.UseVisualStyleBackColor = true;
            // 
            // textBoxAverageNumber
            // 
            this.textBoxAverageNumber.Location = new System.Drawing.Point(141, 132);
            this.textBoxAverageNumber.Name = "textBoxAverageNumber";
            this.textBoxAverageNumber.Size = new System.Drawing.Size(116, 27);
            this.textBoxAverageNumber.TabIndex = 5;
            // 
            // textBoxMinNumber
            // 
            this.textBoxMinNumber.Location = new System.Drawing.Point(141, 84);
            this.textBoxMinNumber.Name = "textBoxMinNumber";
            this.textBoxMinNumber.Size = new System.Drawing.Size(116, 27);
            this.textBoxMinNumber.TabIndex = 6;
            // 
            // textBoxMaxNumber
            // 
            this.textBoxMaxNumber.Location = new System.Drawing.Point(141, 37);
            this.textBoxMaxNumber.Name = "textBoxMaxNumber";
            this.textBoxMaxNumber.Size = new System.Drawing.Size(116, 27);
            this.textBoxMaxNumber.TabIndex = 4;
            // 
            // groupBoxStrings
            // 
            this.groupBoxStrings.Controls.Add(this.buttonListStrings);
            this.groupBoxStrings.Controls.Add(this.textBoxAverageLength);
            this.groupBoxStrings.Controls.Add(this.textBoxMinLength);
            this.groupBoxStrings.Controls.Add(this.checkBoxAverageLength);
            this.groupBoxStrings.Controls.Add(this.textBoxMaxLength);
            this.groupBoxStrings.Controls.Add(this.checkBoxMaxLength);
            this.groupBoxStrings.Controls.Add(this.checkBoxMinLength);
            this.groupBoxStrings.Location = new System.Drawing.Point(422, 12);
            this.groupBoxStrings.Name = "groupBoxStrings";
            this.groupBoxStrings.Size = new System.Drawing.Size(294, 196);
            this.groupBoxStrings.TabIndex = 3;
            this.groupBoxStrings.TabStop = false;
            this.groupBoxStrings.Text = "Strings";
            // 
            // buttonListStrings
            // 
            this.buttonListStrings.Location = new System.Drawing.Point(47, 170);
            this.buttonListStrings.Name = "buttonListStrings";
            this.buttonListStrings.Size = new System.Drawing.Size(204, 25);
            this.buttonListStrings.TabIndex = 10;
            this.buttonListStrings.Text = "List of strings";
            this.buttonListStrings.UseVisualStyleBackColor = true;
            this.buttonListStrings.Click += new System.EventHandler(this.buttonListStrings_Click);
            // 
            // textBoxAverageLength
            // 
            this.textBoxAverageLength.Location = new System.Drawing.Point(151, 135);
            this.textBoxAverageLength.Name = "textBoxAverageLength";
            this.textBoxAverageLength.Size = new System.Drawing.Size(116, 27);
            this.textBoxAverageLength.TabIndex = 7;
            // 
            // textBoxMinLength
            // 
            this.textBoxMinLength.Location = new System.Drawing.Point(151, 87);
            this.textBoxMinLength.Name = "textBoxMinLength";
            this.textBoxMinLength.Size = new System.Drawing.Size(116, 27);
            this.textBoxMinLength.TabIndex = 9;
            // 
            // checkBoxAverageLength
            // 
            this.checkBoxAverageLength.AutoSize = true;
            this.checkBoxAverageLength.Location = new System.Drawing.Point(15, 135);
            this.checkBoxAverageLength.Name = "checkBoxAverageLength";
            this.checkBoxAverageLength.Size = new System.Drawing.Size(130, 24);
            this.checkBoxAverageLength.TabIndex = 7;
            this.checkBoxAverageLength.Text = "average length";
            this.checkBoxAverageLength.UseVisualStyleBackColor = true;
            // 
            // textBoxMaxLength
            // 
            this.textBoxMaxLength.Location = new System.Drawing.Point(151, 40);
            this.textBoxMaxLength.Name = "textBoxMaxLength";
            this.textBoxMaxLength.Size = new System.Drawing.Size(116, 27);
            this.textBoxMaxLength.TabIndex = 8;
            // 
            // checkBoxMaxLength
            // 
            this.checkBoxMaxLength.AutoSize = true;
            this.checkBoxMaxLength.Location = new System.Drawing.Point(15, 40);
            this.checkBoxMaxLength.Name = "checkBoxMaxLength";
            this.checkBoxMaxLength.Size = new System.Drawing.Size(105, 24);
            this.checkBoxMaxLength.TabIndex = 5;
            this.checkBoxMaxLength.Text = "max length";
            this.checkBoxMaxLength.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinLength
            // 
            this.checkBoxMinLength.AutoSize = true;
            this.checkBoxMinLength.Location = new System.Drawing.Point(15, 87);
            this.checkBoxMinLength.Name = "checkBoxMinLength";
            this.checkBoxMinLength.Size = new System.Drawing.Size(102, 24);
            this.checkBoxMinLength.TabIndex = 6;
            this.checkBoxMinLength.Text = "min length";
            this.checkBoxMinLength.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCalculate.Location = new System.Drawing.Point(498, 236);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(90, 39);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of elements:";
            // 
            // textBoxNumberOfElements
            // 
            this.textBoxNumberOfElements.Location = new System.Drawing.Point(194, 242);
            this.textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            this.textBoxNumberOfElements.Size = new System.Drawing.Size(58, 27);
            this.textBoxNumberOfElements.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(755, 299);
            this.Controls.Add(this.textBoxNumberOfElements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxStrings);
            this.Controls.Add(this.groupBoxNumbers);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxNumbers.ResumeLayout(false);
            this.groupBoxNumbers.PerformLayout();
            this.groupBoxStrings.ResumeLayout(false);
            this.groupBoxStrings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxNumbers;
        private System.Windows.Forms.GroupBox groupBoxStrings;
        private System.Windows.Forms.CheckBox checkBoxMaxNumber;
        private System.Windows.Forms.CheckBox checkBoxMinNumber;
        private System.Windows.Forms.CheckBox checkBoxAverageNumber;
        private System.Windows.Forms.CheckBox checkBoxAverageLength;
        private System.Windows.Forms.CheckBox checkBoxMaxLength;
        private System.Windows.Forms.CheckBox checkBoxMinLength;
        private System.Windows.Forms.TextBox textBoxAverageNumber;
        private System.Windows.Forms.TextBox textBoxMinNumber;
        private System.Windows.Forms.TextBox textBoxMaxNumber;
        private System.Windows.Forms.TextBox textBoxAverageLength;
        private System.Windows.Forms.TextBox textBoxMinLength;
        private System.Windows.Forms.TextBox textBoxMaxLength;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfElements;
        private System.Windows.Forms.Button buttonListNumbers;
        private System.Windows.Forms.Button buttonListStrings;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

