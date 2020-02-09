namespace LR1__program_CS
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
            this.in_txt = new System.Windows.Forms.RichTextBox();
            this.out_txt = new System.Windows.Forms.RichTextBox();
            this.btm_coding = new System.Windows.Forms.Button();
            this.btm_decoding = new System.Windows.Forms.Button();
            this.btm_Rfile_text = new System.Windows.Forms.Button();
            this.txt_file_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_file_out = new System.Windows.Forms.TextBox();
            this.btm_Wfile_text = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_alph = new System.Windows.Forms.TextBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_file_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Wfile_code = new System.Windows.Forms.Button();
            this.txt_file_code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_average_length = new System.Windows.Forms.Label();
            this.txt_redundancy = new System.Windows.Forms.Label();
            this.txt_inequality_kraft = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_count_alph = new System.Windows.Forms.TextBox();
            this.txt_file_alph = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // in_txt
            // 
            this.in_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.in_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.in_txt.Location = new System.Drawing.Point(12, 75);
            this.in_txt.Name = "in_txt";
            this.in_txt.Size = new System.Drawing.Size(585, 220);
            this.in_txt.TabIndex = 0;
            this.in_txt.Tag = "";
            this.in_txt.Text = "";
            // 
            // out_txt
            // 
            this.out_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out_txt.Location = new System.Drawing.Point(609, 75);
            this.out_txt.Name = "out_txt";
            this.out_txt.Size = new System.Drawing.Size(585, 220);
            this.out_txt.TabIndex = 2;
            this.out_txt.Text = "";
            // 
            // btm_coding
            // 
            this.btm_coding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_coding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_coding.Location = new System.Drawing.Point(223, 550);
            this.btm_coding.Name = "btm_coding";
            this.btm_coding.Size = new System.Drawing.Size(135, 50);
            this.btm_coding.TabIndex = 4;
            this.btm_coding.Text = "Закодировать";
            this.btm_coding.UseVisualStyleBackColor = true;
            this.btm_coding.Click += new System.EventHandler(this.btm_coding_Click);
            // 
            // btm_decoding
            // 
            this.btm_decoding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_decoding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_decoding.Location = new System.Drawing.Point(856, 550);
            this.btm_decoding.Name = "btm_decoding";
            this.btm_decoding.Size = new System.Drawing.Size(135, 50);
            this.btm_decoding.TabIndex = 5;
            this.btm_decoding.Text = "Раскодировать";
            this.btm_decoding.UseVisualStyleBackColor = true;
            this.btm_decoding.Click += new System.EventHandler(this.btm_decoding_Click);
            // 
            // btm_Rfile_text
            // 
            this.btm_Rfile_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_Rfile_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_Rfile_text.Location = new System.Drawing.Point(413, 21);
            this.btm_Rfile_text.Name = "btm_Rfile_text";
            this.btm_Rfile_text.Size = new System.Drawing.Size(110, 27);
            this.btm_Rfile_text.TabIndex = 6;
            this.btm_Rfile_text.Tag = "";
            this.btm_Rfile_text.Text = "Прочитать";
            this.btm_Rfile_text.UseVisualStyleBackColor = true;
            this.btm_Rfile_text.Click += new System.EventHandler(this.btm_Rfile_text_Click);
            // 
            // txt_file_in
            // 
            this.txt_file_in.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_in.Location = new System.Drawing.Point(220, 21);
            this.txt_file_in.Name = "txt_file_in";
            this.txt_file_in.Size = new System.Drawing.Size(187, 27);
            this.txt_file_in.TabIndex = 7;
            this.txt_file_in.Text = "in_text.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Файл с исходным текстом:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(609, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Файл с результатом:";
            // 
            // txt_file_out
            // 
            this.txt_file_out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_out.Location = new System.Drawing.Point(777, 25);
            this.txt_file_out.Name = "txt_file_out";
            this.txt_file_out.Size = new System.Drawing.Size(214, 27);
            this.txt_file_out.TabIndex = 10;
            this.txt_file_out.Text = "out_text.txt";
            // 
            // btm_Wfile_text
            // 
            this.btm_Wfile_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_Wfile_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_Wfile_text.Location = new System.Drawing.Point(997, 26);
            this.btm_Wfile_text.Name = "btm_Wfile_text";
            this.btm_Wfile_text.Size = new System.Drawing.Size(159, 27);
            this.btm_Wfile_text.TabIndex = 11;
            this.btm_Wfile_text.Text = "Записать в файл";
            this.btm_Wfile_text.UseVisualStyleBackColor = true;
            this.btm_Wfile_text.Click += new System.EventHandler(this.btm_Wfile_text_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Файл с алфавитом:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Алфавит:";
            // 
            // txt_alph
            // 
            this.txt_alph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_alph.Location = new System.Drawing.Point(85, 368);
            this.txt_alph.Name = "txt_alph";
            this.txt_alph.Size = new System.Drawing.Size(512, 27);
            this.txt_alph.TabIndex = 19;
            // 
            // txt_p
            // 
            this.txt_p.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_p.Location = new System.Drawing.Point(108, 497);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(489, 27);
            this.txt_p.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Вероятности:";
            // 
            // txt_file_p
            // 
            this.txt_file_p.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_p.Location = new System.Drawing.Point(182, 459);
            this.txt_file_p.Name = "txt_file_p";
            this.txt_file_p.Size = new System.Drawing.Size(176, 27);
            this.txt_file_p.TabIndex = 21;
            this.txt_file_p.Text = "p3_RAV.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Файл с вероятностями:";
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_code.Location = new System.Drawing.Point(730, 368);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(468, 27);
            this.txt_code.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(605, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Коды символов:";
            // 
            // txt_Wfile_code
            // 
            this.txt_Wfile_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Wfile_code.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Wfile_code.Location = new System.Drawing.Point(972, 328);
            this.txt_Wfile_code.Name = "txt_Wfile_code";
            this.txt_Wfile_code.Size = new System.Drawing.Size(167, 27);
            this.txt_Wfile_code.TabIndex = 29;
            this.txt_Wfile_code.Text = "Записать в файл";
            this.txt_Wfile_code.UseVisualStyleBackColor = true;
            this.txt_Wfile_code.Click += new System.EventHandler(this.txt_Wfile_code_Click);
            // 
            // txt_file_code
            // 
            this.txt_file_code.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_code.Location = new System.Drawing.Point(800, 330);
            this.txt_file_code.Name = "txt_file_code";
            this.txt_file_code.Size = new System.Drawing.Size(159, 27);
            this.txt_file_code.TabIndex = 27;
            this.txt_file_code.Text = "code_simbols.txt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(605, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Файл с кодами символов:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(626, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Средняя длина кодового слова:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(626, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Избыточность:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(626, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Неравенство Крафта:";
            // 
            // txt_average_length
            // 
            this.txt_average_length.AutoSize = true;
            this.txt_average_length.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_average_length.Location = new System.Drawing.Point(923, 425);
            this.txt_average_length.Name = "txt_average_length";
            this.txt_average_length.Size = new System.Drawing.Size(20, 23);
            this.txt_average_length.TabIndex = 35;
            this.txt_average_length.Text = "0";
            // 
            // txt_redundancy
            // 
            this.txt_redundancy.AutoSize = true;
            this.txt_redundancy.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_redundancy.Location = new System.Drawing.Point(772, 463);
            this.txt_redundancy.Name = "txt_redundancy";
            this.txt_redundancy.Size = new System.Drawing.Size(20, 23);
            this.txt_redundancy.TabIndex = 36;
            this.txt_redundancy.Text = "0";
            // 
            // txt_inequality_kraft
            // 
            this.txt_inequality_kraft.AutoSize = true;
            this.txt_inequality_kraft.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_inequality_kraft.Location = new System.Drawing.Point(833, 500);
            this.txt_inequality_kraft.Name = "txt_inequality_kraft";
            this.txt_inequality_kraft.Size = new System.Drawing.Size(17, 23);
            this.txt_inequality_kraft.TabIndex = 37;
            this.txt_inequality_kraft.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Исходный текст:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(609, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Полученный текст:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 416);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(274, 19);
            this.label14.TabIndex = 40;
            this.label14.Text = "Количество символов в алфавите =";
            // 
            // txt_count_alph
            // 
            this.txt_count_alph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_count_alph.Location = new System.Drawing.Point(288, 413);
            this.txt_count_alph.Name = "txt_count_alph";
            this.txt_count_alph.Size = new System.Drawing.Size(61, 27);
            this.txt_count_alph.TabIndex = 41;
            this.txt_count_alph.Text = "0";
            this.txt_count_alph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_file_alph
            // 
            this.txt_file_alph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_alph.Location = new System.Drawing.Point(170, 330);
            this.txt_file_alph.Name = "txt_file_alph";
            this.txt_file_alph.Size = new System.Drawing.Size(179, 27);
            this.txt_file_alph.TabIndex = 43;
            this.txt_file_alph.Text = "alphabet.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1206, 612);
            this.Controls.Add(this.txt_file_alph);
            this.Controls.Add(this.txt_count_alph);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_inequality_kraft);
            this.Controls.Add(this.txt_redundancy);
            this.Controls.Add(this.txt_average_length);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Wfile_code);
            this.Controls.Add(this.txt_file_code);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_file_p);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_alph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btm_Wfile_text);
            this.Controls.Add(this.txt_file_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_file_in);
            this.Controls.Add(this.btm_Rfile_text);
            this.Controls.Add(this.btm_decoding);
            this.Controls.Add(this.btm_coding);
            this.Controls.Add(this.out_txt);
            this.Controls.Add(this.in_txt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Кодирование Шеннона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox in_txt;
        private System.Windows.Forms.RichTextBox out_txt;
        private System.Windows.Forms.Button btm_coding;
        private System.Windows.Forms.Button btm_decoding;
        private System.Windows.Forms.Button btm_Rfile_text;
        private System.Windows.Forms.TextBox txt_file_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_file_out;
        private System.Windows.Forms.Button btm_Wfile_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txt_Wfile_code;
        private System.Windows.Forms.TextBox txt_file_code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txt_average_length;
        private System.Windows.Forms.Label txt_redundancy;
        private System.Windows.Forms.Label txt_inequality_kraft;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_count_alph;
        public System.Windows.Forms.TextBox txt_alph;
        private System.Windows.Forms.TextBox txt_file_alph;
        private System.Windows.Forms.TextBox txt_file_p;
    }
}

