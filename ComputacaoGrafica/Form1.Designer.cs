namespace ComputacaoGrafica
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Metodo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.anguloText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.forceText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "P1 (             ,             )";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "P2 (             ,             )";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(35, 6);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(30, 20);
            this.x1.TabIndex = 2;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(77, 6);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(30, 20);
            this.y1.TabIndex = 3;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(77, 35);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(30, 20);
            this.y2.TabIndex = 5;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(35, 35);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(30, 20);
            this.x2.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(306, 64);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Metodo
            // 
            this.Metodo.FormattingEnabled = true;
            this.Metodo.Items.AddRange(new object[] {
            "Translação",
            "Escala",
            "Rotação",
            "Reflexão (Eixo X)",
            "Reflexão (Eixo Y)",
            "Reflexão (Origem)",
            "Cisalhamento Vertical",
            "Cisalhamento Horizontal"});
            this.Metodo.Location = new System.Drawing.Point(306, 30);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(121, 21);
            this.Metodo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ponto de Origem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ponto de Translação e Escala";
            // 
            // anguloText
            // 
            this.anguloText.Location = new System.Drawing.Point(35, 64);
            this.anguloText.Name = "anguloText";
            this.anguloText.Size = new System.Drawing.Size(72, 20);
            this.anguloText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ângulo da rotação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ɵ";
            // 
            // forceText
            // 
            this.forceText.Location = new System.Drawing.Point(35, 90);
            this.forceText.Name = "forceText";
            this.forceText.Size = new System.Drawing.Size(72, 20);
            this.forceText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "F";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Força aplicada ao Cisalhamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Operação";
            // 
            // labelResultado
            // 
            this.labelResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResultado.Location = new System.Drawing.Point(11, 147);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(482, 165);
            this.labelResultado.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Resultado";
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.White;
            this.imagem.Location = new System.Drawing.Point(11, 147);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(486, 170);
            this.imagem.TabIndex = 19;
            this.imagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 329);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.forceText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.anguloText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Transformações Geométricas em 2D";
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox Metodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox anguloText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox forceText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox imagem;
    }
}

