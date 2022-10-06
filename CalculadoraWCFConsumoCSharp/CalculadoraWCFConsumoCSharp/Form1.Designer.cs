namespace CalculadoraWCFConsumoCSharp
{
    partial class frmPrincipal
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
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(52, 44);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(128, 23);
            this.txbNumero1.TabIndex = 0;
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(52, 84);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(128, 23);
            this.txbNumero2.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(52, 132);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(51, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(129, 132);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(51, 23);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(129, 174);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(51, 23);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(52, 174);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(51, 23);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(52, 222);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 282);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.txbNumero1);
            this.Name = "frmPrincipal";
            this.Text = "Calcularora WCF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNumero1;
        private TextBox txbNumero2;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Label lblResultado;
    }
}