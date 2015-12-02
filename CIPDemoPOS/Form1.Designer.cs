namespace CIPDemoPOS
{
    partial class form_DemoPOS
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
            this.btn_CreditSale = new System.Windows.Forms.Button();
            this.txtBox_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txtBox_ResultMessage = new System.Windows.Forms.TextBox();
            this.lbl_ResultMessage = new System.Windows.Forms.Label();
            this.txtBox_ResultStatus = new System.Windows.Forms.TextBox();
            this.lbl_ResultStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CreditSale
            // 
            this.btn_CreditSale.Location = new System.Drawing.Point(191, 27);
            this.btn_CreditSale.Name = "btn_CreditSale";
            this.btn_CreditSale.Size = new System.Drawing.Size(75, 23);
            this.btn_CreditSale.TabIndex = 0;
            this.btn_CreditSale.Text = "Credit Sale";
            this.btn_CreditSale.UseVisualStyleBackColor = true;
            this.btn_CreditSale.Click += new System.EventHandler(this.btn_CreditSale_Click);
            // 
            // txtBox_Amount
            // 
            this.txtBox_Amount.Location = new System.Drawing.Point(6, 29);
            this.txtBox_Amount.Name = "txtBox_Amount";
            this.txtBox_Amount.Size = new System.Drawing.Size(179, 20);
            this.txtBox_Amount.TabIndex = 1;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(76, 9);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 2;
            this.lbl_Amount.Text = "Amount";
            // 
            // txtBox_ResultMessage
            // 
            this.txtBox_ResultMessage.Location = new System.Drawing.Point(95, 79);
            this.txtBox_ResultMessage.Multiline = true;
            this.txtBox_ResultMessage.Name = "txtBox_ResultMessage";
            this.txtBox_ResultMessage.Size = new System.Drawing.Size(181, 23);
            this.txtBox_ResultMessage.TabIndex = 3;
            // 
            // lbl_ResultMessage
            // 
            this.lbl_ResultMessage.AutoSize = true;
            this.lbl_ResultMessage.Location = new System.Drawing.Point(6, 82);
            this.lbl_ResultMessage.Name = "lbl_ResultMessage";
            this.lbl_ResultMessage.Size = new System.Drawing.Size(83, 13);
            this.lbl_ResultMessage.TabIndex = 4;
            this.lbl_ResultMessage.Text = "Result Message";
            // 
            // txtBox_ResultStatus
            // 
            this.txtBox_ResultStatus.Location = new System.Drawing.Point(95, 108);
            this.txtBox_ResultStatus.Name = "txtBox_ResultStatus";
            this.txtBox_ResultStatus.Size = new System.Drawing.Size(181, 20);
            this.txtBox_ResultStatus.TabIndex = 5;
            // 
            // lbl_ResultStatus
            // 
            this.lbl_ResultStatus.AutoSize = true;
            this.lbl_ResultStatus.Location = new System.Drawing.Point(12, 111);
            this.lbl_ResultStatus.Name = "lbl_ResultStatus";
            this.lbl_ResultStatus.Size = new System.Drawing.Size(70, 13);
            this.lbl_ResultStatus.TabIndex = 6;
            this.lbl_ResultStatus.Text = "Result Status";
            // 
            // form_DemoPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.lbl_ResultStatus);
            this.Controls.Add(this.txtBox_ResultStatus);
            this.Controls.Add(this.lbl_ResultMessage);
            this.Controls.Add(this.txtBox_ResultMessage);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.txtBox_Amount);
            this.Controls.Add(this.btn_CreditSale);
            this.Name = "form_DemoPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIP Demo POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreditSale;
        private System.Windows.Forms.TextBox txtBox_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox txtBox_ResultMessage;
        private System.Windows.Forms.Label lbl_ResultMessage;
        private System.Windows.Forms.TextBox txtBox_ResultStatus;
        private System.Windows.Forms.Label lbl_ResultStatus;
    }
}

