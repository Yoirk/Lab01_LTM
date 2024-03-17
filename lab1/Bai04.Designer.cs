namespace lab1
{
    partial class Bai04
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
            label1 = new Label();
            label4 = new Label();
            Thuchien = new Button();
            label2 = new Label();
            label3 = new Label();
            Nhap = new TextBox();
            KQ = new TextBox();
            Thoat = new Button();
            Xoa = new Button();
            Pick1 = new ComboBox();
            Pick2 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập một số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 290);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Kết quả:";
            // 
            // Thuchien
            // 
            Thuchien.BackColor = SystemColors.Desktop;
            Thuchien.ForeColor = SystemColors.ButtonFace;
            Thuchien.Location = new Point(116, 130);
            Thuchien.Name = "Thuchien";
            Thuchien.Size = new Size(114, 23);
            Thuchien.TabIndex = 4;
            Thuchien.Text = "Thực hiện";
            Thuchien.UseVisualStyleBackColor = false;
            Thuchien.Click += Thuchien_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 86);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Chọn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 86);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Sang:";
            // 
            // Nhap
            // 
            Nhap.Location = new Point(116, 41);
            Nhap.Name = "Nhap";
            Nhap.Size = new Size(332, 23);
            Nhap.TabIndex = 8;
            // 
            // KQ
            // 
            KQ.Location = new Point(230, 287);
            KQ.Name = "KQ";
            KQ.ReadOnly = true;
            KQ.Size = new Size(332, 23);
            KQ.TabIndex = 9;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(373, 130);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(75, 23);
            Thoat.TabIndex = 10;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(267, 130);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(75, 23);
            Xoa.TabIndex = 11;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Pick1
            // 
            Pick1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Pick1.AutoCompleteSource = AutoCompleteSource.ListItems;
            Pick1.FormattingEnabled = true;
            Pick1.Items.AddRange(new object[] { "Binary", "Demical", "Hexademical" });
            Pick1.Location = new Point(116, 83);
            Pick1.Name = "Pick1";
            Pick1.Size = new Size(121, 23);
            Pick1.TabIndex = 12;
            // 
            // Pick2
            // 
            Pick2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Pick2.AutoCompleteSource = AutoCompleteSource.ListItems;
            Pick2.FormattingEnabled = true;
            Pick2.Items.AddRange(new object[] { "Binary", "Demical", "Hexademical" });
            Pick2.Location = new Point(327, 83);
            Pick2.Name = "Pick2";
            Pick2.Size = new Size(121, 23);
            Pick2.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Nhap);
            groupBox1.Controls.Add(Xoa);
            groupBox1.Controls.Add(Thuchien);
            groupBox1.Controls.Add(Pick2);
            groupBox1.Controls.Add(Thoat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Pick1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(114, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 197);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin:";
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(KQ);
            Controls.Add(label4);
            Name = "Bai04";
            Text = "Bài 4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Button Thuchien;
        private Label label2;
        private Label label3;
        private TextBox Nhap;
        private TextBox KQ;
        private Button Thoat;
        private Button Xoa;
        private ComboBox Pick1;
        private ComboBox Pick2;
        private GroupBox groupBox1;
    }
}