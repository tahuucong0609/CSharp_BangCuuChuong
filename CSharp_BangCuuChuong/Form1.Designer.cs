namespace CSharp_BangCuuChuong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnXem = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            iblketqua = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtso = new DomainUpDown();
            listBox1 = new ListBox();
            button3 = new Button();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            Select = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnXem
            // 
            btnXem.Location = new Point(618, 70);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(117, 33);
            btnXem.TabIndex = 0;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(618, 122);
            button2.Name = "button2";
            button2.Size = new Size(117, 30);
            button2.TabIndex = 2;
            button2.Text = "Xem Lại 1";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 27);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 3;
            label1.Text = "Ứng Dụng HIển Thị Bảng Cửu Chương";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 68);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 4;
            label2.Text = "Chọn Bảng Cửu Chương";
            // 
            // iblketqua
            // 
            iblketqua.AutoSize = true;
            iblketqua.Location = new Point(66, 206);
            iblketqua.Name = "iblketqua";
            iblketqua.Size = new Size(49, 15);
            iblketqua.TabIndex = 5;
            iblketqua.Text = "Kết Quả";
            // 
            // txtso
            // 
            txtso.Location = new Point(384, 66);
            txtso.Name = "txtso";
            txtso.Size = new Size(120, 23);
            txtso.TabIndex = 7;
            txtso.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(618, 235);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(618, 168);
            button3.Name = "button3";
            button3.Size = new Size(117, 33);
            button3.TabIndex = 0;
            button3.Text = "Xem Lại 2";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 122);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 4;
            label5.Text = "Chọn Bảng Cửu Chương";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(240, 133);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "2";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(277, 133);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "3";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(315, 133);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(31, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "4";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(347, 133);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(31, 19);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "5";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(384, 133);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(31, 19);
            radioButton5.TabIndex = 11;
            radioButton5.TabStop = true;
            radioButton5.Text = "6";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(421, 133);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(31, 19);
            radioButton6.TabIndex = 11;
            radioButton6.TabStop = true;
            radioButton6.Text = "7";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(459, 133);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(31, 19);
            radioButton7.TabIndex = 11;
            radioButton7.TabStop = true;
            radioButton7.Text = "8";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(496, 133);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(31, 19);
            radioButton8.TabIndex = 11;
            radioButton8.TabStop = true;
            radioButton8.Text = "9";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // Select
            // 
            Select.FormattingEnabled = true;
            Select.ItemHeight = 15;
            Select.Location = new Point(229, 112);
            Select.Name = "Select";
            Select.Size = new Size(312, 49);
            Select.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(textBox1);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton4);
            Controls.Add(radioButton6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(Select);
            Controls.Add(listBox1);
            Controls.Add(txtso);
            Controls.Add(iblketqua);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnXem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXem;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label iblketqua;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DomainUpDown txtso;
        private ListBox listBox1;
        private Button button3;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private ListBox Select;
        private TextBox textBox1;
    }
}
