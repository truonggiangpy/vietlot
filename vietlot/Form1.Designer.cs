
namespace vietlot
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
            this.button1 = new System.Windows.Forms.Button();
            this.textquayso = new System.Windows.Forms.RichTextBox();
            this.arraymuaso = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ketqua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.jackbot2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quay số";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textquayso
            // 
            this.textquayso.Location = new System.Drawing.Point(229, 32);
            this.textquayso.Name = "textquayso";
            this.textquayso.Size = new System.Drawing.Size(261, 44);
            this.textquayso.TabIndex = 1;
            this.textquayso.Text = " ";
            // 
            // arraymuaso
            // 
            this.arraymuaso.Location = new System.Drawing.Point(229, 105);
            this.arraymuaso.Name = "arraymuaso";
            this.arraymuaso.Size = new System.Drawing.Size(261, 44);
            this.arraymuaso.TabIndex = 2;
            this.arraymuaso.Text = " ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kiểm Tra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Enabled = false;
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.ForeColor = System.Drawing.Color.Red;
            this.ketqua.Location = new System.Drawing.Point(138, 215);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(34, 29);
            this.ketqua.TabIndex = 4;
            this.ketqua.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(283, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "kết quả xổ số";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Quay Số Đặt Biệt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // jackbot2
            // 
            this.jackbot2.Location = new System.Drawing.Point(514, 105);
            this.jackbot2.Name = "jackbot2";
            this.jackbot2.Size = new System.Drawing.Size(73, 44);
            this.jackbot2.TabIndex = 7;
            this.jackbot2.Text = "Kiểm Tra Jackbot2";
            this.jackbot2.UseVisualStyleBackColor = true;
            this.jackbot2.Visible = false;
            this.jackbot2.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 368);
            this.Controls.Add(this.jackbot2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.arraymuaso);
            this.Controls.Add(this.textquayso);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hoang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textquayso;
        private System.Windows.Forms.RichTextBox arraymuaso;
        private System.Windows.Forms.Button button2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button jackbot2;
    }
}

