
namespace cddc
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownL = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxLienOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewH = new System.Windows.Forms.DataGridView();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxErr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Передаваемый символ";
            // 
            // numericUpDownL
            // 
            this.numericUpDownL.Location = new System.Drawing.Point(184, 35);
            this.numericUpDownL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownL.Name = "numericUpDownL";
            this.numericUpDownL.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownL.TabIndex = 2;
            this.numericUpDownL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "кол-во проверочных символов r";
            // 
            // dataGridViewG
            // 
            this.dataGridViewG.AllowUserToAddRows = false;
            this.dataGridViewG.AllowUserToDeleteRows = false;
            this.dataGridViewG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewG.ColumnHeadersHeight = 21;
            this.dataGridViewG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewG.ColumnHeadersVisible = false;
            this.dataGridViewG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewG.Location = new System.Drawing.Point(13, 98);
            this.dataGridViewG.Name = "dataGridViewG";
            this.dataGridViewG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewG.RowHeadersVisible = false;
            this.dataGridViewG.RowHeadersWidth = 21;
            this.dataGridViewG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewG.Size = new System.Drawing.Size(233, 194);
            this.dataGridViewG.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать матрицу G";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Закодировать ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(41, 338);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(205, 20);
            this.textBoxB.TabIndex = 7;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(89, 14);
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(157, 20);
            this.numericUpDownN.TabIndex = 8;
            this.numericUpDownN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "длина кода n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "код";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "вектор ошибок";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "передать по каналу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxLienOut
            // 
            this.textBoxLienOut.Location = new System.Drawing.Point(389, 23);
            this.textBoxLienOut.Name = "textBoxLienOut";
            this.textBoxLienOut.ReadOnly = true;
            this.textBoxLienOut.Size = new System.Drawing.Size(125, 20);
            this.textBoxLienOut.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "код с ошибкой";
            // 
            // dataGridViewH
            // 
            this.dataGridViewH.AllowUserToAddRows = false;
            this.dataGridViewH.AllowUserToDeleteRows = false;
            this.dataGridViewH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewH.ColumnHeadersHeight = 21;
            this.dataGridViewH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewH.ColumnHeadersVisible = false;
            this.dataGridViewH.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewH.Location = new System.Drawing.Point(13, 37);
            this.dataGridViewH.Name = "dataGridViewH";
            this.dataGridViewH.ReadOnly = true;
            this.dataGridViewH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewH.RowHeadersVisible = false;
            this.dataGridViewH.RowHeadersWidth = 21;
            this.dataGridViewH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewH.Size = new System.Drawing.Size(233, 194);
            this.dataGridViewH.TabIndex = 16;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(78, 307);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(168, 20);
            this.textBoxS.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Синдром S";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Декодировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(99, 22);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(118, 20);
            this.textBoxE.TabIndex = 22;
            this.textBoxE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(133, 15);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(136, 20);
            this.textBoxU.TabIndex = 23;
            this.textBoxU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Вектор ошибок E";
            // 
            // textBoxErr
            // 
            this.textBoxErr.Location = new System.Drawing.Point(110, 332);
            this.textBoxErr.Name = "textBoxErr";
            this.textBoxErr.ReadOnly = true;
            this.textBoxErr.Size = new System.Drawing.Size(136, 20);
            this.textBoxErr.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Принятый символ";
            // 
            // textBoxDC
            // 
            this.textBoxDC.Location = new System.Drawing.Point(396, 15);
            this.textBoxDC.Name = "textBoxDC";
            this.textBoxDC.ReadOnly = true;
            this.textBoxDC.Size = new System.Drawing.Size(136, 20);
            this.textBoxDC.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.dataGridViewG);
            this.groupBox1.Controls.Add(this.numericUpDownL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.numericUpDownN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 367);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кодер";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dataGridViewH);
            this.groupBox2.Controls.Add(this.textBoxS);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxErr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(275, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 367);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Декодер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Проверочная матрица H";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxE);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBoxLienOut);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 57);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Канал связи";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(196, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 26);
            this.button5.TabIndex = 31;
            this.button5.Text = "Передать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(239, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "НГТУ 18-ССК Капля В.В., Парамонов А.С.   апрель 2021г";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(541, 517);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxU);
            this.Controls.Add(this.textBoxDC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Блочный код";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxLienOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewH;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxErr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
    }
}

