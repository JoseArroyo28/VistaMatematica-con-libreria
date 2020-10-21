namespace VistaMatematica
{
    partial class OperacionesAritmeticas
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxArreglo = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(152, 115);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 22);
            this.txtValor1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(152, 177);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(152, 225);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(90, 35);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbxArreglo
            // 
            this.cbxArreglo.AutoSize = true;
            this.cbxArreglo.Location = new System.Drawing.Point(539, 93);
            this.cbxArreglo.Name = "cbxArreglo";
            this.cbxArreglo.Size = new System.Drawing.Size(136, 21);
            this.cbxArreglo.TabIndex = 6;
            this.cbxArreglo.Text = "Lista De Numero";
            this.cbxArreglo.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(536, 161);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(48, 17);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "1 de 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor";
            // 
            // OperacionesAritmeticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cbxArreglo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "OperacionesAritmeticas";
            this.Text = "OperacionesAritmeticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbxArreglo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
    }
}