namespace Principal
{
    partial class Lista1Ex4
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
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Final = new System.Windows.Forms.TextBox();
            this.btn_Tabuada = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(101, 29);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(44, 20);
            this.txt_Numero.TabIndex = 1;
            this.txt_Numero.TextChanged += new System.EventHandler(this.txt_Numero_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Final);
            this.groupBox1.Controls.Add(this.btn_Tabuada);
            this.groupBox1.Location = new System.Drawing.Point(38, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabuada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_Final
            // 
            this.txt_Final.Location = new System.Drawing.Point(7, 48);
            this.txt_Final.Multiline = true;
            this.txt_Final.Name = "txt_Final";
            this.txt_Final.Size = new System.Drawing.Size(254, 311);
            this.txt_Final.TabIndex = 1;
            this.txt_Final.TextChanged += new System.EventHandler(this.txt_Final_TextChanged);
            // 
            // btn_Tabuada
            // 
            this.btn_Tabuada.Location = new System.Drawing.Point(92, 19);
            this.btn_Tabuada.Name = "btn_Tabuada";
            this.btn_Tabuada.Size = new System.Drawing.Size(75, 23);
            this.btn_Tabuada.TabIndex = 0;
            this.btn_Tabuada.Text = "Tabuada";
            this.btn_Tabuada.UseVisualStyleBackColor = true;
            this.btn_Tabuada.Click += new System.EventHandler(this.btn_Tabuada_Click);
            // 
            // Lista1Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(472, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label1);
            this.Name = "Lista1Ex4";
            this.Text = "Lista1Ex4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Tabuada;
        private System.Windows.Forms.TextBox txt_Final;
    }
}