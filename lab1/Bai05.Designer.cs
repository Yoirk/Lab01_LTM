namespace lab1
{
    partial class Bai5
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
            danhsach = new Label();
            groupBox1 = new GroupBox();
            dsdiem = new TextBox();
            SuspendLayout();
            // 
            // danhsach
            // 
            danhsach.AutoSize = true;
            danhsach.Location = new Point(76, 78);
            danhsach.Name = "danhsach";
            danhsach.Size = new Size(95, 15);
            danhsach.TabIndex = 1;
            danhsach.Text = "Danh sách điểm:";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(76, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 195);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dsdiem
            // 
            dsdiem.Location = new Point(177, 75);
            dsdiem.Name = "dsdiem";
            dsdiem.Size = new Size(470, 23);
            dsdiem.TabIndex = 3;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dsdiem);
            Controls.Add(groupBox1);
            Controls.Add(danhsach);
            Name = "Bai5";
            Text = "Bài 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label danhsach;
        private GroupBox groupBox1;
        private TextBox dsdiem;
    }
}