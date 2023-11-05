namespace Bells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            btnNew = new Button();
            btnEdit = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAbout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(19, 293);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(356, 49);
            btnStart.TabIndex = 7;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(19, 348);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(175, 35);
            btnNew.TabIndex = 8;
            btnNew.Text = "Създай разписание";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(200, 348);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(175, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Промени разписание";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(19, 433);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(356, 38);
            btnExit.TabIndex = 10;
            btnExit.Text = "Изход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 157);
            label2.Name = "label2";
            label2.Size = new Size(339, 20);
            label2.TabIndex = 13;
            label2.Text = "ПРОФЕСИОНАЛНА ГИМНАЗИЯ ПО ЗЕМЕДЕЛИЕ";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 166);
            label3.Name = "label3";
            label3.Size = new Size(350, 45);
            label3.TabIndex = 14;
            label3.Text = "\"ТОДОР РАЧИНСКИ\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 206);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 15;
            label1.Text = "ГЕНЕРАЛ ТОШЕВО";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(68, 232);
            label4.Name = "label4";
            label4.Size = new Size(259, 21);
            label4.TabIndex = 16;
            label4.Text = "Училищен автоматичен звънец";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 253);
            label5.Name = "label5";
            label5.Size = new Size(233, 15);
            label5.TabIndex = 17;
            label5.Text = "Разработено от: Тошко Стоянов Тодоров";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 268);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 18;
            label6.Text = "Випуск 2024";
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.Location = new Point(19, 389);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(356, 38);
            btnAbout.TabIndex = 19;
            btnAbout.Text = "За програмата";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 483);
            Controls.Add(btnAbout);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начало";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStart;
        private Button btnNew;
        private Button btnEdit;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAbout;
    }
}