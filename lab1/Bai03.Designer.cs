namespace lab1
{
    partial class Bai03
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
            sodoc = new Label();
            ketqua = new Label();
            kq = new TextBox();
            textBox2 = new TextBox();
            doc = new Button();
            Xoa = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // sodoc
            // 
            sodoc.AutoSize = true;
            sodoc.Location = new Point(185, 68);
            sodoc.Name = "sodoc";
            sodoc.Size = new Size(65, 15);
            sodoc.TabIndex = 0;
            sodoc.Text = "Số cần đọc";
            // 
            // ketqua
            // 
            ketqua.AutoSize = true;
            ketqua.Location = new Point(185, 142);
            ketqua.Name = "ketqua";
            ketqua.Size = new Size(47, 15);
            ketqua.TabIndex = 1;
            ketqua.Text = "Kết quả";
            // 
            // kq
            // 
            kq.Location = new Point(304, 139);
            kq.Name = "kq";
            kq.Size = new Size(100, 23);
            kq.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // doc
            // 
            doc.Location = new Point(471, 64);
            doc.Name = "doc";
            doc.Size = new Size(75, 23);
            doc.TabIndex = 4;
            doc.Text = "Đọc";
            doc.UseVisualStyleBackColor = true;
            doc.Click += doc_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(471, 139);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(75, 23);
            Xoa.TabIndex = 5;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(471, 206);
            thoat.Name = "thoat";
            thoat.Size = new Size(75, 23);
            thoat.TabIndex = 6;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(Xoa);
            Controls.Add(doc);
            Controls.Add(textBox2);
            Controls.Add(kq);
            Controls.Add(ketqua);
            Controls.Add(sodoc);
            Name = "Bai03";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sodoc;
        private Label ketqua;
        private TextBox kq;
        private TextBox textBox2;
        private Button doc;
        private Button Xoa;
        private Button thoat;
    }
}