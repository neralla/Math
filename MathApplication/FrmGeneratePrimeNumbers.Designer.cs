namespace MathApplication
{
    partial class FrmGeneratePrimeNumbers
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
            this.btnGeneratePrimeNumbers = new System.Windows.Forms.Button();
            this.SecondsTimer = new System.Windows.Forms.Timer(this.components);
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblSecondsProgress = new System.Windows.Forms.Label();
            this.lblPrimeNumbers = new System.Windows.Forms.Label();
            this.txtHighestPrimeNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeneratePrimeNumbers
            // 
            this.btnGeneratePrimeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePrimeNumbers.Location = new System.Drawing.Point(124, 99);
            this.btnGeneratePrimeNumbers.Name = "btnGeneratePrimeNumbers";
            this.btnGeneratePrimeNumbers.Size = new System.Drawing.Size(188, 23);
            this.btnGeneratePrimeNumbers.TabIndex = 0;
            this.btnGeneratePrimeNumbers.Text = "GeneratePrimeNumbers";
            this.btnGeneratePrimeNumbers.UseVisualStyleBackColor = true;
            this.btnGeneratePrimeNumbers.Click += new System.EventHandler(this.btnGeneratePrime_Click);
            // 
            // SecondsTimer
            // 
            this.SecondsTimer.Tick += new System.EventHandler(this.Secondstimer_Tick);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(84, 57);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(60, 13);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "Seconds ";
            this.lblSeconds.Visible = false;
            // 
            // lblSecondsProgress
            // 
            this.lblSecondsProgress.AutoSize = true;
            this.lblSecondsProgress.Location = new System.Drawing.Point(231, 57);
            this.lblSecondsProgress.Name = "lblSecondsProgress";
            this.lblSecondsProgress.Size = new System.Drawing.Size(0, 13);
            this.lblSecondsProgress.TabIndex = 3;
            // 
            // lblPrimeNumbers
            // 
            this.lblPrimeNumbers.AutoSize = true;
            this.lblPrimeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeNumbers.Location = new System.Drawing.Point(84, 27);
            this.lblPrimeNumbers.Name = "lblPrimeNumbers";
            this.lblPrimeNumbers.Size = new System.Drawing.Size(91, 13);
            this.lblPrimeNumbers.TabIndex = 4;
            this.lblPrimeNumbers.Text = "Prime Numbers";
            // 
            // txtHighestPrimeNumber
            // 
            this.txtHighestPrimeNumber.Location = new System.Drawing.Point(225, 24);
            this.txtHighestPrimeNumber.Name = "txtHighestPrimeNumber";
            this.txtHighestPrimeNumber.Size = new System.Drawing.Size(144, 20);
            this.txtHighestPrimeNumber.TabIndex = 5;
            // 
            // FrmGeneratePrimeNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.txtHighestPrimeNumber);
            this.Controls.Add(this.lblPrimeNumbers);
            this.Controls.Add(this.lblSecondsProgress);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.btnGeneratePrimeNumbers);
            this.Name = "FrmGeneratePrimeNumbers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePrimeNumbers;
        private System.Windows.Forms.Timer SecondsTimer;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblSecondsProgress;
        private System.Windows.Forms.Label lblPrimeNumbers;
        private System.Windows.Forms.TextBox txtHighestPrimeNumber;
    }
}

