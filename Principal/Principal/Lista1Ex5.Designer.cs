namespace Principal
{
    partial class Lista1Ex5
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NomeCarro = new System.Windows.Forms.TextBox();
            this.txt_ValorCarro = new System.Windows.Forms.TextBox();
            this.txt_ValorCadaParcela = new System.Windows.Forms.TextBox();
            this.txt_QTD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btn_Resultado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de cada parcela do carro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidades de meses de prestação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_QTD);
            this.groupBox1.Controls.Add(this.txt_ValorCadaParcela);
            this.groupBox1.Controls.Add(this.txt_ValorCarro);
            this.groupBox1.Controls.Add(this.txt_NomeCarro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(62, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txt_NomeCarro
            // 
            this.txt_NomeCarro.Location = new System.Drawing.Point(123, 29);
            this.txt_NomeCarro.Name = "txt_NomeCarro";
            this.txt_NomeCarro.Size = new System.Drawing.Size(315, 20);
            this.txt_NomeCarro.TabIndex = 4;
            this.txt_NomeCarro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_ValorCarro
            // 
            this.txt_ValorCarro.Location = new System.Drawing.Point(325, 65);
            this.txt_ValorCarro.Name = "txt_ValorCarro";
            this.txt_ValorCarro.Size = new System.Drawing.Size(113, 20);
            this.txt_ValorCarro.TabIndex = 5;
            this.txt_ValorCarro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_ValorCadaParcela
            // 
            this.txt_ValorCadaParcela.Location = new System.Drawing.Point(325, 95);
            this.txt_ValorCadaParcela.Name = "txt_ValorCadaParcela";
            this.txt_ValorCadaParcela.Size = new System.Drawing.Size(113, 20);
            this.txt_ValorCadaParcela.TabIndex = 6;
            // 
            // txt_QTD
            // 
            this.txt_QTD.Location = new System.Drawing.Point(325, 124);
            this.txt_QTD.Name = "txt_QTD";
            this.txt_QTD.Size = new System.Drawing.Size(113, 20);
            this.txt_QTD.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(62, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 315);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do carro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor do carro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor de cada parcela";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantidade de prestação";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor total do financiamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(356, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Diferença entre o valor do financiamento e o valor do carro";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(213, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(225, 20);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(213, 120);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(225, 20);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(213, 152);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(225, 20);
            this.textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(65, 225);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(326, 73);
            this.textBox10.TabIndex = 19;
            // 
            // btn_Resultado
            // 
            this.btn_Resultado.Location = new System.Drawing.Point(215, 231);
            this.btn_Resultado.Name = "btn_Resultado";
            this.btn_Resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_Resultado.TabIndex = 6;
            this.btn_Resultado.Text = "Resultado";
            this.btn_Resultado.UseVisualStyleBackColor = true;
            this.btn_Resultado.Click += new System.EventHandler(this.btn_Resultado_Click);
            // 
            // Lista1Ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(608, 594);
            this.Controls.Add(this.btn_Resultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lista1Ex5";
            this.Text = "Lista1Ex5";
            this.Load += new System.EventHandler(this.Lista1Ex5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_QTD;
        private System.Windows.Forms.TextBox txt_ValorCadaParcela;
        private System.Windows.Forms.TextBox txt_ValorCarro;
        private System.Windows.Forms.TextBox txt_NomeCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Resultado;
    }
}