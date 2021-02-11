namespace Cash_Register__Library_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vileSecrets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotal = new System.Windows.Forms.Label();
            this.taxField = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.outputLabelSub = new System.Windows.Forms.Label();
            this.outputLabelTax = new System.Windows.Forms.Label();
            this.outputLabelTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tenderField = new System.Windows.Forms.Label();
            this.input4 = new System.Windows.Forms.TextBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.calculateChange = new System.Windows.Forms.Button();
            this.changeField = new System.Windows.Forms.Label();
            this.outputLabelChange = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vileSecrets
            // 
            this.vileSecrets.AutoSize = true;
            this.vileSecrets.BackColor = System.Drawing.Color.Blue;
            this.vileSecrets.ForeColor = System.Drawing.Color.White;
            this.vileSecrets.Location = new System.Drawing.Point(5, 9);
            this.vileSecrets.Name = "vileSecrets";
            this.vileSecrets.Size = new System.Drawing.Size(117, 13);
            this.vileSecrets.TabIndex = 0;
            this.vileSecrets.Text = "Books of Vile Darkness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tool of Dark Summoning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accursed Artifact of Doom";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(135, 6);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(113, 20);
            this.input1.TabIndex = 5;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(135, 30);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(113, 20);
            this.input2.TabIndex = 6;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(135, 54);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(113, 20);
            this.input3.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(15, 91);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(233, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.BackColor = System.Drawing.Color.Blue;
            this.subTotal.ForeColor = System.Drawing.Color.White;
            this.subTotal.Location = new System.Drawing.Point(19, 128);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(52, 13);
            this.subTotal.TabIndex = 9;
            this.subTotal.Text = "Sub-total:";
            // 
            // taxField
            // 
            this.taxField.AutoSize = true;
            this.taxField.BackColor = System.Drawing.Color.Blue;
            this.taxField.ForeColor = System.Drawing.Color.White;
            this.taxField.Location = new System.Drawing.Point(19, 161);
            this.taxField.Name = "taxField";
            this.taxField.Size = new System.Drawing.Size(28, 13);
            this.taxField.TabIndex = 10;
            this.taxField.Text = "Tax:";
            // 
            // totalField
            // 
            this.totalField.AutoSize = true;
            this.totalField.BackColor = System.Drawing.Color.Blue;
            this.totalField.ForeColor = System.Drawing.Color.White;
            this.totalField.Location = new System.Drawing.Point(19, 194);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(34, 13);
            this.totalField.TabIndex = 11;
            this.totalField.Text = "Total:";
            // 
            // outputLabelSub
            // 
            this.outputLabelSub.BackColor = System.Drawing.Color.Blue;
            this.outputLabelSub.ForeColor = System.Drawing.Color.White;
            this.outputLabelSub.Location = new System.Drawing.Point(201, 128);
            this.outputLabelSub.Name = "outputLabelSub";
            this.outputLabelSub.Size = new System.Drawing.Size(47, 13);
            this.outputLabelSub.TabIndex = 12;
            this.outputLabelSub.Text = "$0.00";
            // 
            // outputLabelTax
            // 
            this.outputLabelTax.BackColor = System.Drawing.Color.Blue;
            this.outputLabelTax.ForeColor = System.Drawing.Color.White;
            this.outputLabelTax.Location = new System.Drawing.Point(201, 161);
            this.outputLabelTax.Name = "outputLabelTax";
            this.outputLabelTax.Size = new System.Drawing.Size(47, 13);
            this.outputLabelTax.TabIndex = 13;
            this.outputLabelTax.Text = "$0.00";
            // 
            // outputLabelTotal
            // 
            this.outputLabelTotal.BackColor = System.Drawing.Color.Blue;
            this.outputLabelTotal.ForeColor = System.Drawing.Color.White;
            this.outputLabelTotal.Location = new System.Drawing.Point(201, 194);
            this.outputLabelTotal.Name = "outputLabelTotal";
            this.outputLabelTotal.Size = new System.Drawing.Size(47, 13);
            this.outputLabelTotal.TabIndex = 14;
            this.outputLabelTotal.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // tenderField
            // 
            this.tenderField.AutoSize = true;
            this.tenderField.BackColor = System.Drawing.Color.Blue;
            this.tenderField.ForeColor = System.Drawing.Color.White;
            this.tenderField.Location = new System.Drawing.Point(19, 277);
            this.tenderField.Name = "tenderField";
            this.tenderField.Size = new System.Drawing.Size(53, 13);
            this.tenderField.TabIndex = 16;
            this.tenderField.Text = "Tendered";
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(135, 274);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(113, 20);
            this.input4.TabIndex = 17;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(18, 415);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(230, 23);
            this.receiptButton.TabIndex = 18;
            this.receiptButton.Text = "PRINT RECEIPT";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // calculateChange
            // 
            this.calculateChange.Location = new System.Drawing.Point(18, 324);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(230, 23);
            this.calculateChange.TabIndex = 19;
            this.calculateChange.Text = "CALCULATE CHANGE";
            this.calculateChange.UseVisualStyleBackColor = true;
            this.calculateChange.Click += new System.EventHandler(this.CalculateChange_Click);
            // 
            // changeField
            // 
            this.changeField.AutoSize = true;
            this.changeField.BackColor = System.Drawing.Color.Blue;
            this.changeField.ForeColor = System.Drawing.Color.White;
            this.changeField.Location = new System.Drawing.Point(19, 377);
            this.changeField.Name = "changeField";
            this.changeField.Size = new System.Drawing.Size(47, 13);
            this.changeField.TabIndex = 20;
            this.changeField.Text = "Change:";
            // 
            // outputLabelChange
            // 
            this.outputLabelChange.BackColor = System.Drawing.Color.Blue;
            this.outputLabelChange.ForeColor = System.Drawing.Color.White;
            this.outputLabelChange.Location = new System.Drawing.Point(204, 377);
            this.outputLabelChange.Name = "outputLabelChange";
            this.outputLabelChange.Size = new System.Drawing.Size(44, 13);
            this.outputLabelChange.TabIndex = 21;
            this.outputLabelChange.Text = "$0.00";
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(312, 15);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(437, 375);
            this.receiptOutput.TabIndex = 22;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(316, 393);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(433, 45);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "FOR A NEW ORDER";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.outputLabelChange);
            this.Controls.Add(this.changeField);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.tenderField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputLabelTotal);
            this.Controls.Add(this.outputLabelTax);
            this.Controls.Add(this.outputLabelSub);
            this.Controls.Add(this.totalField);
            this.Controls.Add(this.taxField);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vileSecrets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Xykons Shop of Mysticism";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vileSecrets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label taxField;
        private System.Windows.Forms.Label totalField;
        private System.Windows.Forms.Label outputLabelSub;
        private System.Windows.Forms.Label outputLabelTax;
        private System.Windows.Forms.Label outputLabelTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tenderField;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label changeField;
        private System.Windows.Forms.Label outputLabelChange;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button resetButton;
    }
}

