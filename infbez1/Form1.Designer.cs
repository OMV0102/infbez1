﻿namespace infbez1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_in = new System.Windows.Forms.RichTextBox();
            this.txt_out = new System.Windows.Forms.RichTextBox();
            this.btm_coding = new System.Windows.Forms.Button();
            this.btm_Rfile_text = new System.Windows.Forms.Button();
            this.txt_file_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_file_out = new System.Windows.Forms.TextBox();
            this.btm_Wfile_text = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_choice_filein = new System.Windows.Forms.Button();
            this.btn_choice_fileout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.btn_analyz = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_in
            // 
            this.txt_in.BackColor = System.Drawing.SystemColors.Window;
            this.txt_in.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_in.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_in.Location = new System.Drawing.Point(20, 130);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(585, 86);
            this.txt_in.TabIndex = 0;
            this.txt_in.TabStop = false;
            this.txt_in.Tag = "";
            this.txt_in.Text = "";
            this.txt_in.TextChanged += new System.EventHandler(this.txt_in_TextChanged);
            // 
            // txt_out
            // 
            this.txt_out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_out.Location = new System.Drawing.Point(148, 364);
            this.txt_out.Name = "txt_out";
            this.txt_out.Size = new System.Drawing.Size(293, 31);
            this.txt_out.TabIndex = 2;
            this.txt_out.TabStop = false;
            this.txt_out.Text = "";
            // 
            // btm_coding
            // 
            this.btm_coding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_coding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_coding.Location = new System.Drawing.Point(218, 234);
            this.btm_coding.Name = "btm_coding";
            this.btm_coding.Size = new System.Drawing.Size(158, 50);
            this.btm_coding.TabIndex = 4;
            this.btm_coding.TabStop = false;
            this.btm_coding.Text = "↓   Хэшировать   ↓";
            this.btm_coding.UseVisualStyleBackColor = true;
            this.btm_coding.Click += new System.EventHandler(this.btm_coding_Click);
            // 
            // btm_Rfile_text
            // 
            this.btm_Rfile_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_Rfile_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_Rfile_text.Location = new System.Drawing.Point(430, 20);
            this.btm_Rfile_text.Name = "btm_Rfile_text";
            this.btm_Rfile_text.Size = new System.Drawing.Size(175, 27);
            this.btm_Rfile_text.TabIndex = 6;
            this.btm_Rfile_text.TabStop = false;
            this.btm_Rfile_text.Tag = "";
            this.btm_Rfile_text.Text = "Прочитать файл";
            this.btm_Rfile_text.UseVisualStyleBackColor = true;
            this.btm_Rfile_text.Click += new System.EventHandler(this.btm_Rfile_text_Click);
            // 
            // txt_file_in
            // 
            this.txt_file_in.BackColor = System.Drawing.SystemColors.Window;
            this.txt_file_in.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_in.Location = new System.Drawing.Point(24, 54);
            this.txt_file_in.Name = "txt_file_in";
            this.txt_file_in.ReadOnly = true;
            this.txt_file_in.Size = new System.Drawing.Size(532, 27);
            this.txt_file_in.TabIndex = 7;
            this.txt_file_in.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Файл с исходным текстом:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Файл с хэшем:";
            // 
            // txt_file_out
            // 
            this.txt_file_out.BackColor = System.Drawing.SystemColors.Window;
            this.txt_file_out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_out.Location = new System.Drawing.Point(20, 327);
            this.txt_file_out.Name = "txt_file_out";
            this.txt_file_out.ReadOnly = true;
            this.txt_file_out.Size = new System.Drawing.Size(536, 27);
            this.txt_file_out.TabIndex = 10;
            this.txt_file_out.TabStop = false;
            // 
            // btm_Wfile_text
            // 
            this.btm_Wfile_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_Wfile_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_Wfile_text.Location = new System.Drawing.Point(427, 297);
            this.btm_Wfile_text.Name = "btm_Wfile_text";
            this.btm_Wfile_text.Size = new System.Drawing.Size(178, 27);
            this.btm_Wfile_text.TabIndex = 11;
            this.btm_Wfile_text.TabStop = false;
            this.btm_Wfile_text.Text = "Записать в файл";
            this.btm_Wfile_text.UseVisualStyleBackColor = true;
            this.btm_Wfile_text.Click += new System.EventHandler(this.btm_Wfile_text_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(20, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Исходный текст:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(29, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Хэш-функция:";
            // 
            // btn_choice_filein
            // 
            this.btn_choice_filein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choice_filein.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_choice_filein.Location = new System.Drawing.Point(562, 54);
            this.btn_choice_filein.Name = "btn_choice_filein";
            this.btn_choice_filein.Size = new System.Drawing.Size(43, 27);
            this.btn_choice_filein.TabIndex = 40;
            this.btn_choice_filein.TabStop = false;
            this.btn_choice_filein.Tag = "";
            this.btn_choice_filein.Text = ". . .";
            this.btn_choice_filein.UseVisualStyleBackColor = true;
            this.btn_choice_filein.Click += new System.EventHandler(this.btn_choice_filein_Click);
            // 
            // btn_choice_fileout
            // 
            this.btn_choice_fileout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choice_fileout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_choice_fileout.Location = new System.Drawing.Point(562, 326);
            this.btn_choice_fileout.Name = "btn_choice_fileout";
            this.btn_choice_fileout.Size = new System.Drawing.Size(43, 27);
            this.btn_choice_fileout.TabIndex = 41;
            this.btn_choice_fileout.TabStop = false;
            this.btn_choice_fileout.Tag = "";
            this.btn_choice_fileout.Text = ". . .";
            this.btn_choice_fileout.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 217);
            this.label3.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(602, 118);
            this.label4.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(602, 239);
            this.label5.TabIndex = 44;
            // 
            // numeric
            // 
            this.numeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric.Location = new System.Drawing.Point(65, 466);
            this.numeric.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(77, 26);
            this.numeric.TabIndex = 46;
            this.numeric.TabStop = false;
            this.numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_analyz
            // 
            this.btn_analyz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_analyz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_analyz.Location = new System.Drawing.Point(45, 542);
            this.btn_analyz.Name = "btn_analyz";
            this.btn_analyz.Size = new System.Drawing.Size(128, 50);
            this.btn_analyz.TabIndex = 47;
            this.btn_analyz.TabStop = false;
            this.btn_analyz.Text = "Исследовать";
            this.btn_analyz.UseVisualStyleBackColor = true;
            this.btn_analyz.Click += new System.EventHandler(this.btn_analyz_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(305, 426);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 203);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(631, 660);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_analyz);
            this.Controls.Add(this.numeric);
            this.Controls.Add(this.btn_choice_fileout);
            this.Controls.Add(this.btn_choice_filein);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btm_Wfile_text);
            this.Controls.Add(this.txt_file_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_file_in);
            this.Controls.Add(this.btm_Rfile_text);
            this.Controls.Add(this.btm_coding);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIPEMD-128";
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_in;
        private System.Windows.Forms.RichTextBox txt_out;
        private System.Windows.Forms.Button btm_coding;
        private System.Windows.Forms.Button btm_Rfile_text;
        private System.Windows.Forms.TextBox txt_file_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_file_out;
        private System.Windows.Forms.Button btm_Wfile_text;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_choice_filein;
        private System.Windows.Forms.Button btn_choice_fileout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Button btn_analyz;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

