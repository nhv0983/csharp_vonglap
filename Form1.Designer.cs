namespace csharp_vonglap
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
            this.btntinh = new System.Windows.Forms.Button();
            this.lblnhapso = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblgiaithua = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(178, 142);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 0;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lblnhapso
            // 
            this.lblnhapso.AutoSize = true;
            this.lblnhapso.Location = new System.Drawing.Point(64, 35);
            this.lblnhapso.Name = "lblnhapso";
            this.lblnhapso.Size = new System.Drawing.Size(45, 13);
            this.lblnhapso.TabIndex = 1;
            this.lblnhapso.Text = "nhập số";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(153, 35);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // lblgiaithua
            // 
            this.lblgiaithua.AutoSize = true;
            this.lblgiaithua.Location = new System.Drawing.Point(64, 89);
            this.lblgiaithua.Name = "lblgiaithua";
            this.lblgiaithua.Size = new System.Drawing.Size(47, 13);
            this.lblgiaithua.TabIndex = 3;
            this.lblgiaithua.Text = "giai thừa";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(153, 86);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 4;
            this.txtketqua.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.lblgiaithua);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblnhapso);
            this.Controls.Add(this.btntinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label lblnhapso;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblgiaithua;
        private System.Windows.Forms.TextBox txtketqua;
    }
}

