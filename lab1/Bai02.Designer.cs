namespace lab1
{
    partial class Bai02
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
            sothunhat = new Label();
            sothuhai = new Label();
            sothuba = new Label();
            solonnhat = new Label();
            sonhonhat = new Label();
            textBox1 = new TextBox();
            thu3 = new TextBox();
            thu2 = new TextBox();
            thu1 = new TextBox();
            Tim = new Button();
            xoa = new Button();
            thoat = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // sothunhat
            // 
            sothunhat.AutoSize = true;
            sothunhat.Location = new Point(94, 80);
            sothunhat.Name = "sothunhat";
            sothunhat.Size = new Size(68, 15);
            sothunhat.TabIndex = 0;
            sothunhat.Text = "Số thứ nhất";
            // 
            // sothuhai
            // 
            sothuhai.AutoSize = true;
            sothuhai.Location = new Point(94, 132);
            sothuhai.Name = "sothuhai";
            sothuhai.Size = new Size(60, 15);
            sothuhai.TabIndex = 1;
            sothuhai.Text = "Số thứ hai";
            // 
            // sothuba
            // 
            sothuba.AutoSize = true;
            sothuba.Location = new Point(94, 183);
            sothuba.Name = "sothuba";
            sothuba.Size = new Size(57, 15);
            sothuba.TabIndex = 2;
            sothuba.Text = "Số thứ ba";
            // 
            // solonnhat
            // 
            solonnhat.AutoSize = true;
            solonnhat.Location = new Point(332, 80);
            solonnhat.Name = "solonnhat";
            solonnhat.Size = new Size(67, 15);
            solonnhat.TabIndex = 3;
            solonnhat.Text = "Số lớn nhất";
            // 
            // sonhonhat
            // 
            sonhonhat.AutoSize = true;
            sonhonhat.Location = new Point(332, 132);
            sonhonhat.Name = "sonhonhat";
            sonhonhat.Size = new Size(71, 15);
            sonhonhat.TabIndex = 4;
            sonhonhat.Text = "Số nhỏ nhẩt";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 129);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // thu3
            // 
            thu3.Location = new Point(163, 180);
            thu3.Name = "thu3";
            thu3.Size = new Size(100, 23);
            thu3.TabIndex = 7;
            thu3.TextChanged += thu3_TextChanged;
            // 
            // thu2
            // 
            thu2.Location = new Point(163, 129);
            thu2.Name = "thu2";
            thu2.Size = new Size(100, 23);
            thu2.TabIndex = 8;
            thu2.TextChanged += thu2_TextChanged;
            // 
            // thu1
            // 
            thu1.Location = new Point(163, 77);
            thu1.Name = "thu1";
            thu1.Size = new Size(100, 23);
            thu1.TabIndex = 9;
            thu1.TextChanged += thu1_TextChanged;
            // 
            // Tim
            // 
            Tim.Location = new Point(163, 247);
            Tim.Name = "Tim";
            Tim.Size = new Size(75, 23);
            Tim.TabIndex = 10;
            Tim.Text = "Tìm";
            Tim.UseVisualStyleBackColor = true;
            Tim.Click += Tim_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(304, 247);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 11;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(445, 247);
            thoat.Name = "thoat";
            thoat.Size = new Size(75, 23);
            thoat.TabIndex = 12;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(408, 77);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(Tim);
            Controls.Add(thu1);
            Controls.Add(thu2);
            Controls.Add(thu3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(sonhonhat);
            Controls.Add(solonnhat);
            Controls.Add(sothuba);
            Controls.Add(sothuhai);
            Controls.Add(sothunhat);
            Name = "Bai02";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sothunhat;
        private Label sothuhai;
        private Label sothuba;
        private Label solonnhat;
        private Label sonhonhat;
        private TextBox textBox1;
        private TextBox thu3;
        private TextBox thu2;
        private TextBox thu1;
        private Button Tim;
        private Button xoa;
        private Button thoat;
        private TextBox textBox2;
    }
}