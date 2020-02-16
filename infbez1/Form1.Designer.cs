namespace infbez1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_in
            // 
            this.txt_in.BackColor = System.Drawing.SystemColors.Window;
            this.txt_in.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_in.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_in.Location = new System.Drawing.Point(12, 130);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(585, 220);
            this.txt_in.TabIndex = 0;
            this.txt_in.TabStop = false;
            this.txt_in.Tag = "";
            this.txt_in.Text = "";
            this.txt_in.TextChanged += new System.EventHandler(this.txt_in_TextChanged);
            // 
            // txt_out
            // 
            this.txt_out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_out.Location = new System.Drawing.Point(765, 130);
            this.txt_out.Name = "txt_out";
            this.txt_out.Size = new System.Drawing.Size(429, 220);
            this.txt_out.TabIndex = 2;
            this.txt_out.TabStop = false;
            this.txt_out.Text = "";
            // 
            // btm_coding
            // 
            this.btm_coding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_coding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_coding.Location = new System.Drawing.Point(223, 550);
            this.btm_coding.Name = "btm_coding";
            this.btm_coding.Size = new System.Drawing.Size(135, 50);
            this.btm_coding.TabIndex = 4;
            this.btm_coding.TabStop = false;
            this.btm_coding.Text = "Хэшировать";
            this.btm_coding.UseVisualStyleBackColor = true;
            this.btm_coding.Click += new System.EventHandler(this.btm_coding_Click);
            // 
            // btm_Rfile_text
            // 
            this.btm_Rfile_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_Rfile_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_Rfile_text.Location = new System.Drawing.Point(422, 20);
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
            this.txt_file_in.Location = new System.Drawing.Point(16, 54);
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
            this.label2.Location = new System.Drawing.Point(770, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Файл с хэшем:";
            // 
            // txt_file_out
            // 
            this.txt_file_out.BackColor = System.Drawing.SystemColors.Window;
            this.txt_file_out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_file_out.Location = new System.Drawing.Point(765, 54);
            this.txt_file_out.Name = "txt_file_out";
            this.txt_file_out.ReadOnly = true;
            this.txt_file_out.Size = new System.Drawing.Size(380, 27);
            this.txt_file_out.TabIndex = 10;
            this.txt_file_out.TabStop = false;
            this.txt_file_out.Text = "out_text.txt";
            // 
            // btm_Wfile_text
            // 
            this.btm_Wfile_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_Wfile_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm_Wfile_text.Location = new System.Drawing.Point(1016, 24);
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
            this.label12.Location = new System.Drawing.Point(12, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Исходный текст:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(770, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Хэш-функция:";
            // 
            // btn_choice_filein
            // 
            this.btn_choice_filein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choice_filein.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_choice_filein.Location = new System.Drawing.Point(554, 54);
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
            this.btn_choice_fileout.Location = new System.Drawing.Point(1151, 53);
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
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(391, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(616, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 80);
            this.listBox1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1206, 612);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIPEMD-128";
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

