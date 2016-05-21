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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecondsProgress = new System.Windows.Forms.Label();
            this.lblPrimeNumbers = new System.Windows.Forms.Label();
            this.txtHighestPrimeNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeneratePrimeNumbers
            // 
            this.btnGeneratePrimeNumbers.Location = new System.Drawing.Point(210, 96);
            this.btnGeneratePrimeNumbers.Name = "btnGeneratePrimeNumbers";
            this.btnGeneratePrimeNumbers.Size = new System.Drawing.Size(188, 23);
            this.btnGeneratePrimeNumbers.TabIndex = 0;
            this.btnGeneratePrimeNumbers.Text = "GeneratePrimeNumbers";
            this.btnGeneratePrimeNumbers.UseVisualStyleBackColor = true;
            this.btnGeneratePrimeNumbers.Click += new System.EventHandler(this.GeneratePrime_Click);
            // 
            // SecondsTimer
            // 
            this.SecondsTimer.Tick += new System.EventHandler(this.Secondstimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seconds ";
            // 
            // lblSecondsProgress
            // 
            this.lblSecondsProgress.AutoSize = true;
            this.lblSecondsProgress.Location = new System.Drawing.Point(305, 57);
            this.lblSecondsProgress.Name = "lblSecondsProgress";
            this.lblSecondsProgress.Size = new System.Drawing.Size(93, 13);
            this.lblSecondsProgress.TabIndex = 3;
            this.lblSecondsProgress.Text = "Seconds Progress";
            // 
            // lblPrimeNumbers
            // 
            this.lblPrimeNumbers.AutoSize = true;
            this.lblPrimeNumbers.Location = new System.Drawing.Point(222, 32);
            this.lblPrimeNumbers.Name = "lblPrimeNumbers";
            this.lblPrimeNumbers.Size = new System.Drawing.Size(78, 13);
            this.lblPrimeNumbers.TabIndex = 4;
            this.lblPrimeNumbers.Text = "Prime Numbers";
            // 
            // txtHighestPrimeNumber
            // 
            this.txtHighestPrimeNumber.Location = new System.Drawing.Point(306, 24);
            this.txtHighestPrimeNumber.Name = "txtHighestPrimeNumber";
            this.txtHighestPrimeNumber.Size = new System.Drawing.Size(144, 20);
            this.txtHighestPrimeNumber.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.txtHighestPrimeNumber);
            this.Controls.Add(this.lblPrimeNumbers);
            this.Controls.Add(this.lblSecondsProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneratePrimeNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePrimeNumbers;
        private System.Windows.Forms.Timer SecondsTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecondsProgress;
        private System.Windows.Forms.Label lblPrimeNumbers;
        private System.Windows.Forms.TextBox txtHighestPrimeNumber;
    }
}

