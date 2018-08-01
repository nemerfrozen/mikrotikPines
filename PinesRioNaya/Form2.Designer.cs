namespace PinesRioNaya
{
    partial class Form2
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
            this.lbl_pin = new System.Windows.Forms.Label();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pin.Location = new System.Drawing.Point(82, 40);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(179, 63);
            this.lbl_pin.TabIndex = 0;
            this.lbl_pin.Text = "label1";
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo.Location = new System.Drawing.Point(85, 148);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(126, 46);
            this.lbl_tiempo.TabIndex = 1;
            this.lbl_tiempo.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.lbl_pin);
            this.Name = "Form2";
            this.Text = "Pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}