namespace Kom_graphics_Laba_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Drow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.returnBox = new System.Windows.Forms.CheckBox();
            this.checkBoxXY = new System.Windows.Forms.CheckBox();
            this.degreesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 900);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Drow
            // 
            this.Drow.BackColor = System.Drawing.SystemColors.Control;
            this.Drow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drow.Location = new System.Drawing.Point(1108, 497);
            this.Drow.Name = "Drow";
            this.Drow.Size = new System.Drawing.Size(165, 69);
            this.Drow.TabIndex = 1;
            this.Drow.Text = "Отрисовать";
            this.Drow.UseVisualStyleBackColor = false;
            this.Drow.Click += new System.EventHandler(this.Drow_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1108, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1108, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Смещение по X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1104, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Смещение по Y";
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Location = new System.Drawing.Point(1078, 116);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(225, 20);
            this.checkBoxX.TabIndex = 10;
            this.checkBoxX.Text = "Отображение относительно X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Location = new System.Drawing.Point(1077, 142);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(226, 20);
            this.checkBoxY.TabIndex = 11;
            this.checkBoxY.Text = "Отображение относительно Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // returnBox
            // 
            this.returnBox.AutoSize = true;
            this.returnBox.Location = new System.Drawing.Point(1078, 376);
            this.returnBox.Name = "returnBox";
            this.returnBox.Size = new System.Drawing.Size(149, 20);
            this.returnBox.TabIndex = 12;
            this.returnBox.Text = "Вернуть исходный";
            this.returnBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxXY
            // 
            this.checkBoxXY.AutoSize = true;
            this.checkBoxXY.Location = new System.Drawing.Point(1077, 168);
            this.checkBoxXY.Name = "checkBoxXY";
            this.checkBoxXY.Size = new System.Drawing.Size(234, 20);
            this.checkBoxXY.TabIndex = 13;
            this.checkBoxXY.Text = "Отображение относительно XY";
            this.checkBoxXY.UseVisualStyleBackColor = true;
            // 
            // degreesBox
            // 
            this.degreesBox.Location = new System.Drawing.Point(1089, 247);
            this.degreesBox.Name = "degreesBox";
            this.degreesBox.Size = new System.Drawing.Size(100, 22);
            this.degreesBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(992, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Повернуть на ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1195, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "градусов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(992, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Относительно точки";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(1140, 278);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(20, 22);
            this.xBox.TabIndex = 18;
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(1188, 278);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(20, 22);
            this.yBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1166, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "(x)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1214, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "(y)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 634);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.degreesBox);
            this.Controls.Add(this.checkBoxXY);
            this.Controls.Add(this.returnBox);
            this.Controls.Add(this.checkBoxY);
            this.Controls.Add(this.checkBoxX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Drow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Drow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox returnBox;
        private System.Windows.Forms.CheckBox checkBoxXY;
        private System.Windows.Forms.TextBox degreesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

