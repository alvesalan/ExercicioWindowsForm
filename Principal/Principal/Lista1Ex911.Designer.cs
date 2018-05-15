namespace Principal
{
    partial class Lista1Ex911
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
            this.mtb_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lb_AnosVivos = new System.Windows.Forms.Label();
            this.lb_MesesVivos = new System.Windows.Forms.Label();
            this.lb_HorasVivas = new System.Windows.Forms.Label();
            this.lb_MinutosVivos = new System.Windows.Forms.Label();
            this.lb_SegundosVivos = new System.Windows.Forms.Label();
            this.lb_DiasVivos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtb_DataNascimento
            // 
            this.mtb_DataNascimento.Location = new System.Drawing.Point(47, 10);
            this.mtb_DataNascimento.Mask = "99/99/9999";
            this.mtb_DataNascimento.Name = "mtb_DataNascimento";
            this.mtb_DataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mtb_DataNascimento.TabIndex = 0;
            this.mtb_DataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_DataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mtb_DataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_DataNascimento_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(177, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dias Vivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anos Vivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meses vivos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horas Vivas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Minutos Vivos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Segundos Vivos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtb_DataNascimento);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 40);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(20, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 261);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_DiasVivos);
            this.groupBox4.Location = new System.Drawing.Point(112, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(48, 29);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lb_AnosVivos);
            this.groupBox5.Location = new System.Drawing.Point(112, 54);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(48, 29);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lb_MesesVivos);
            this.groupBox6.Location = new System.Drawing.Point(112, 93);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(48, 29);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lb_HorasVivas);
            this.groupBox7.Location = new System.Drawing.Point(112, 128);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(48, 29);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lb_MinutosVivos);
            this.groupBox8.Location = new System.Drawing.Point(112, 163);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(48, 29);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lb_SegundosVivos);
            this.groupBox9.Location = new System.Drawing.Point(112, 198);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(48, 29);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            // 
            // lb_AnosVivos
            // 
            this.lb_AnosVivos.AutoSize = true;
            this.lb_AnosVivos.Location = new System.Drawing.Point(15, 8);
            this.lb_AnosVivos.Name = "lb_AnosVivos";
            this.lb_AnosVivos.Size = new System.Drawing.Size(19, 13);
            this.lb_AnosVivos.TabIndex = 1;
            this.lb_AnosVivos.Text = "00";
            // 
            // lb_MesesVivos
            // 
            this.lb_MesesVivos.AutoSize = true;
            this.lb_MesesVivos.Location = new System.Drawing.Point(15, 8);
            this.lb_MesesVivos.Name = "lb_MesesVivos";
            this.lb_MesesVivos.Size = new System.Drawing.Size(19, 13);
            this.lb_MesesVivos.TabIndex = 1;
            this.lb_MesesVivos.Text = "00";
            // 
            // lb_HorasVivas
            // 
            this.lb_HorasVivas.AutoSize = true;
            this.lb_HorasVivas.Location = new System.Drawing.Point(15, 8);
            this.lb_HorasVivas.Name = "lb_HorasVivas";
            this.lb_HorasVivas.Size = new System.Drawing.Size(19, 13);
            this.lb_HorasVivas.TabIndex = 1;
            this.lb_HorasVivas.Text = "00";
            // 
            // lb_MinutosVivos
            // 
            this.lb_MinutosVivos.AutoSize = true;
            this.lb_MinutosVivos.Location = new System.Drawing.Point(15, 8);
            this.lb_MinutosVivos.Name = "lb_MinutosVivos";
            this.lb_MinutosVivos.Size = new System.Drawing.Size(19, 13);
            this.lb_MinutosVivos.TabIndex = 1;
            this.lb_MinutosVivos.Text = "00";
            // 
            // lb_SegundosVivos
            // 
            this.lb_SegundosVivos.AutoSize = true;
            this.lb_SegundosVivos.Location = new System.Drawing.Point(15, 8);
            this.lb_SegundosVivos.Name = "lb_SegundosVivos";
            this.lb_SegundosVivos.Size = new System.Drawing.Size(19, 13);
            this.lb_SegundosVivos.TabIndex = 1;
            this.lb_SegundosVivos.Text = "00";
            // 
            // lb_DiasVivos
            // 
            this.lb_DiasVivos.AutoSize = true;
            this.lb_DiasVivos.Location = new System.Drawing.Point(15, 8);
            this.lb_DiasVivos.Name = "lb_DiasVivos";
            this.lb_DiasVivos.Size = new System.Drawing.Size(19, 13);
            this.lb_DiasVivos.TabIndex = 1;
            this.lb_DiasVivos.Text = "00";
            // 
            // Lista1Ex911
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(609, 482);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lista1Ex911";
            this.Text = "Lista1Ex911";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_DataNascimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lb_SegundosVivos;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lb_MinutosVivos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lb_HorasVivas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lb_MesesVivos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lb_AnosVivos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_DiasVivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}