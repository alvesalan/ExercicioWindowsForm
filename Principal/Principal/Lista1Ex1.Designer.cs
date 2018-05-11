namespace Principal
{
    partial class Lista1Ex1
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
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_Sucessor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Antecessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diga um numero:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(147, 27);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(63, 20);
            this.txt_numero.TabIndex = 1;
            this.txt_numero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Sucessor
            // 
            this.btn_Sucessor.Location = new System.Drawing.Point(118, 75);
            this.btn_Sucessor.Name = "btn_Sucessor";
            this.btn_Sucessor.Size = new System.Drawing.Size(69, 33);
            this.btn_Sucessor.TabIndex = 2;
            this.btn_Sucessor.Text = "Go Go";
            this.btn_Sucessor.UseVisualStyleBackColor = true;
            this.btn_Sucessor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sucessor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Antecessor :";
            // 
            // btn_Antecessor
            // 
            this.btn_Antecessor.Location = new System.Drawing.Point(121, 142);
            this.btn_Antecessor.Name = "btn_Antecessor";
            this.btn_Antecessor.Size = new System.Drawing.Size(69, 33);
            this.btn_Antecessor.TabIndex = 5;
            this.btn_Antecessor.Text = "Go Go";
            this.btn_Antecessor.UseVisualStyleBackColor = true;
            this.btn_Antecessor.Click += new System.EventHandler(this.btn_Antecessor_Click);
            // 
            // Lista1Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(304, 420);
            this.Controls.Add(this.btn_Antecessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Sucessor);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Name = "Lista1Ex1";
            this.Text = "Lista1Ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_Sucessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Antecessor;
    }
}