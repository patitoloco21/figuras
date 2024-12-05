namespace figuras2funcionando
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cubo = new System.Windows.Forms.TabPage();
            this.Piramide = new System.Windows.Forms.TabPage();
            this.Cilindro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.LadoCubo = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LadoP = new System.Windows.Forms.TextBox();
            this.AlturaP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioC = new System.Windows.Forms.TextBox();
            this.AlturaC = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Cubo.SuspendLayout();
            this.Piramide.SuspendLayout();
            this.Cilindro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cubo);
            this.tabControl1.Controls.Add(this.Piramide);
            this.tabControl1.Controls.Add(this.Cilindro);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 250);
            this.tabControl1.TabIndex = 0;
            // 
            // Cubo
            // 
            this.Cubo.Controls.Add(this.LadoCubo);
            this.Cubo.Controls.Add(this.label1);
            this.Cubo.Location = new System.Drawing.Point(4, 25);
            this.Cubo.Name = "Cubo";
            this.Cubo.Padding = new System.Windows.Forms.Padding(3);
            this.Cubo.Size = new System.Drawing.Size(355, 221);
            this.Cubo.TabIndex = 0;
            this.Cubo.Text = "Cubo";
            this.Cubo.UseVisualStyleBackColor = true;
            // 
            // Piramide
            // 
            this.Piramide.Controls.Add(this.AlturaP);
            this.Piramide.Controls.Add(this.LadoP);
            this.Piramide.Controls.Add(this.label3);
            this.Piramide.Controls.Add(this.label2);
            this.Piramide.Location = new System.Drawing.Point(4, 25);
            this.Piramide.Name = "Piramide";
            this.Piramide.Padding = new System.Windows.Forms.Padding(3);
            this.Piramide.Size = new System.Drawing.Size(355, 221);
            this.Piramide.TabIndex = 1;
            this.Piramide.Text = "Piramide";
            this.Piramide.UseVisualStyleBackColor = true;
            // 
            // Cilindro
            // 
            this.Cilindro.Controls.Add(this.AlturaC);
            this.Cilindro.Controls.Add(this.RadioC);
            this.Cilindro.Controls.Add(this.label5);
            this.Cilindro.Controls.Add(this.label4);
            this.Cilindro.Location = new System.Drawing.Point(4, 25);
            this.Cilindro.Name = "Cilindro";
            this.Cilindro.Padding = new System.Windows.Forms.Padding(3);
            this.Cilindro.Size = new System.Drawing.Size(355, 221);
            this.Cilindro.TabIndex = 2;
            this.Cilindro.Text = "Cilindro";
            this.Cilindro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado";
            // 
            // LadoCubo
            // 
            this.LadoCubo.Location = new System.Drawing.Point(153, 33);
            this.LadoCubo.Multiline = true;
            this.LadoCubo.Name = "LadoCubo";
            this.LadoCubo.Size = new System.Drawing.Size(176, 22);
            this.LadoCubo.TabIndex = 1;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(284, 270);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Altura";
            // 
            // LadoP
            // 
            this.LadoP.Location = new System.Drawing.Point(106, 44);
            this.LadoP.Name = "LadoP";
            this.LadoP.Size = new System.Drawing.Size(100, 22);
            this.LadoP.TabIndex = 2;
            // 
            // AlturaP
            // 
            this.AlturaP.Location = new System.Drawing.Point(106, 104);
            this.AlturaP.Name = "AlturaP";
            this.AlturaP.Size = new System.Drawing.Size(100, 22);
            this.AlturaP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Altura";
            // 
            // RadioC
            // 
            this.RadioC.Location = new System.Drawing.Point(101, 28);
            this.RadioC.Name = "RadioC";
            this.RadioC.Size = new System.Drawing.Size(100, 22);
            this.RadioC.TabIndex = 2;
            // 
            // AlturaC
            // 
            this.AlturaC.Location = new System.Drawing.Point(101, 87);
            this.AlturaC.Name = "AlturaC";
            this.AlturaC.Size = new System.Drawing.Size(100, 22);
            this.AlturaC.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Cubo.ResumeLayout(false);
            this.Cubo.PerformLayout();
            this.Piramide.ResumeLayout(false);
            this.Piramide.PerformLayout();
            this.Cilindro.ResumeLayout(false);
            this.Cilindro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cubo;
        private System.Windows.Forms.TabPage Piramide;
        private System.Windows.Forms.TabPage Cilindro;
        private System.Windows.Forms.TextBox LadoCubo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AlturaP;
        private System.Windows.Forms.TextBox LadoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AlturaC;
        private System.Windows.Forms.TextBox RadioC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calcular;
    }
}

