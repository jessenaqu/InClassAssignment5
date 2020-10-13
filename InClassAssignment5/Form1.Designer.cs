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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inClassAssignment5));
            this.lblEnterTerm = new System.Windows.Forms.Label();
            this.txtEnterTerm = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblValueAfterPi = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterTerm
            // 
            this.lblEnterTerm.AutoSize = true;
            this.lblEnterTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblEnterTerm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTerm.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblEnterTerm.Location = new System.Drawing.Point(58, 113);
            this.lblEnterTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterTerm.Name = "lblEnterTerm";
            this.lblEnterTerm.Size = new System.Drawing.Size(160, 23);
            this.lblEnterTerm.TabIndex = 0;
            this.lblEnterTerm.Text = "Enter # of Term";
            this.lblEnterTerm.Click += new System.EventHandler(this.lblEnterTerm_Click);
            // 
            // txtEnterTerm
            // 
            this.txtEnterTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEnterTerm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterTerm.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEnterTerm.Location = new System.Drawing.Point(185, 192);
            this.txtEnterTerm.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterTerm.Name = "txtEnterTerm";
            this.txtEnterTerm.Size = new System.Drawing.Size(206, 31);
            this.txtEnterTerm.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCalculate.Location = new System.Drawing.Point(209, 328);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 38);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblValueAfterPi
            // 
            this.lblValueAfterPi.AutoSize = true;
            this.lblValueAfterPi.BackColor = System.Drawing.Color.Fuchsia;
            this.lblValueAfterPi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueAfterPi.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblValueAfterPi.Location = new System.Drawing.Point(420, 419);
            this.lblValueAfterPi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueAfterPi.Name = "lblValueAfterPi";
            this.lblValueAfterPi.Size = new System.Drawing.Size(0, 23);
            this.lblValueAfterPi.TabIndex = 3;
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.BackColor = System.Drawing.Color.Fuchsia;
            this.lblCalculation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblCalculation.Location = new System.Drawing.Point(420, 473);
            this.lblCalculation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(0, 23);
            this.lblCalculation.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblError.Location = new System.Drawing.Point(597, 67);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(69, 23);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "label1";
            // 
            // inClassAssignment5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InClassAssignment5.Properties.Resources.piBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCalculation);
            this.Controls.Add(this.lblValueAfterPi);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterTerm);
            this.Controls.Add(this.lblEnterTerm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblError;
    }
}

