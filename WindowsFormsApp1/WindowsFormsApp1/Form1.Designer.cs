namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_urgente = new System.Windows.Forms.RadioButton();
            this.radioButton_ordinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(147, 322);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(112, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(110, 57);
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(307, 206);
            this.txtTelegrama.TabIndex = 4;
            this.txtTelegrama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coste";
            // 
            // radioButton_urgente
            // 
            this.radioButton_urgente.AutoSize = true;
            this.radioButton_urgente.Location = new System.Drawing.Point(110, 282);
            this.radioButton_urgente.Name = "radioButton_urgente";
            this.radioButton_urgente.Size = new System.Drawing.Size(63, 17);
            this.radioButton_urgente.TabIndex = 6;
            this.radioButton_urgente.TabStop = true;
            this.radioButton_urgente.Text = "Urgente";
            this.radioButton_urgente.UseVisualStyleBackColor = true;
            // 
            // radioButton_ordinario
            // 
            this.radioButton_ordinario.AutoSize = true;
            this.radioButton_ordinario.Location = new System.Drawing.Point(179, 282);
            this.radioButton_ordinario.Name = "radioButton_ordinario";
            this.radioButton_ordinario.Size = new System.Drawing.Size(67, 17);
            this.radioButton_ordinario.TabIndex = 7;
            this.radioButton_ordinario.TabStop = true;
            this.radioButton_ordinario.Text = "Ordinario";
            this.radioButton_ordinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 423);
            this.Controls.Add(this.radioButton_ordinario);
            this.Controls.Add(this.radioButton_urgente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RichTextBox txtTelegrama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_urgente;
        private System.Windows.Forms.RadioButton radioButton_ordinario;
    }
}

