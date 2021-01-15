
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
            this.arraymuaso = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ketqua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.jackbot2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.textquayso1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quay số";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arraymuaso
            // 
            this.arraymuaso.Location = new System.Drawing.Point(213, 267);
            this.arraymuaso.Name = "arraymuaso";
            this.arraymuaso.Size = new System.Drawing.Size(289, 34);
            this.arraymuaso.TabIndex = 2;
            this.arraymuaso.Text = " ";
            this.arraymuaso.TextChanged += new System.EventHandler(this.arraymuaso_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 37);
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
            this.ketqua.Location = new System.Drawing.Point(144, 82);
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
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kết Qủa Xổ Số Ngày";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Quay Số Đặt Biệt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // jackbot2
            // 
            this.jackbot2.Location = new System.Drawing.Point(602, 349);
            this.jackbot2.Name = "jackbot2";
            this.jackbot2.Size = new System.Drawing.Size(81, 44);
            this.jackbot2.TabIndex = 7;
            this.jackbot2.Text = "Kiểm Tra Jackbot2";
            this.jackbot2.UseVisualStyleBackColor = true;
            this.jackbot2.Visible = false;
            this.jackbot2.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 36);
            this.button4.TabIndex = 17;
            this.button4.Text = "Lưu kết Quả";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textquayso1
            // 
            this.textquayso1.Location = new System.Drawing.Point(213, 181);
            this.textquayso1.Name = "textquayso1";
            this.textquayso1.Size = new System.Drawing.Size(289, 35);
            this.textquayso1.TabIndex = 1;
            this.textquayso1.Text = " ";
            this.textquayso1.TextChanged += new System.EventHandler(this.textquayso_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 393);
            this.Controls.Add(this.textquayso1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.jackbot2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.arraymuaso);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hoang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox arraymuaso;
        private System.Windows.Forms.Button button2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button jackbot2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox textquayso1;
    }
}

