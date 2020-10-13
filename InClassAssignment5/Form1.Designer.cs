namespace InClassAssignment5
{
    partial class inClassAssignment5
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
            this.lblEnterTerm = new System.Windows.Forms.Label();
            this.txtEnterTerm = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblValueAfterPi = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterTerm
            // 
            this.lblEnterTerm.AutoSize = true;
            this.lblEnterTerm.Location = new System.Drawing.Point(128, 60);
            this.lblEnterTerm.Name = "lblEnterTerm";
            this.lblEnterTerm.Size = new System.Drawing.Size(81, 13);
            this.lblEnterTerm.TabIndex = 0;
            this.lblEnterTerm.Text = "Enter # of Term";
            // 
            // txtEnterTerm
            // 
            this.txtEnterTerm.Location = new System.Drawing.Point(215, 57);
            this.txtEnterTerm.Name = "txtEnterTerm";
            this.txtEnterTerm.Size = new System.Drawing.Size(100, 20);
            this.txtEnterTerm.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(215, 113);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblValueAfterPi
            // 
            this.lblValueAfterPi.AutoSize = true;
            this.lblValueAfterPi.Location = new System.Drawing.Point(128, 163);
            this.lblValueAfterPi.Name = "lblValueAfterPi";
            this.lblValueAfterPi.Size = new System.Drawing.Size(35, 13);
            this.lblValueAfterPi.TabIndex = 3;
            this.lblValueAfterPi.Text = "label1";
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Location = new System.Drawing.Point(128, 199);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(35, 13);
            this.lblCalculation.TabIndex = 4;
            this.lblCalculation.Text = "label2";
            // 
            // inClassAssignment5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalculation);
            this.Controls.Add(this.lblValueAfterPi);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterTerm);
            this.Controls.Add(this.lblEnterTerm);
            this.Name = "inClassAssignment5";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTerm;
        private System.Windows.Forms.TextBox txtEnterTerm;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblValueAfterPi;
        private System.Windows.Forms.Label lblCalculation;
    }
}

