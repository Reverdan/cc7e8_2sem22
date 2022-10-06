namespace ConsumoWSDLForm
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
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(59, 34);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(100, 23);
            this.txbN1.TabIndex = 0;
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(59, 63);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(100, 23);
            this.txbN2.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(59, 92);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(100, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(59, 129);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 181);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbN1;
        private TextBox txbN2;
        private Button btnSomar;
        private Label lblResultado;
    }
}