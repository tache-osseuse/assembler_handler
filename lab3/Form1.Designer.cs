﻿
namespace _1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_code = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGrid_oper = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid_add = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGrid_name = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox_bin_code = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox_first_err = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBox_sec_err = new System.Windows.Forms.RichTextBox();
            this.but_first_cycle = new System.Windows.Forms.Button();
            this.but_sec_cycle = new System.Windows.Forms.Button();
            this.but_fill_default = new System.Windows.Forms.Button();
            this.but_reset = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_choice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_oper)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_add)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_name)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_code);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходный код";
            // 
            // richTextBox_code
            // 
            this.richTextBox_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_code.Location = new System.Drawing.Point(19, 32);
            this.richTextBox_code.Name = "richTextBox_code";
            this.richTextBox_code.Size = new System.Drawing.Size(245, 360);
            this.richTextBox_code.TabIndex = 0;
            this.richTextBox_code.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGrid_oper);
            this.groupBox2.Location = new System.Drawing.Point(12, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица кодов операций";
            // 
            // dataGrid_oper
            // 
            this.dataGrid_oper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_oper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_oper.ColumnHeadersVisible = false;
            this.dataGrid_oper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6});
            this.dataGrid_oper.Location = new System.Drawing.Point(19, 30);
            this.dataGrid_oper.Name = "dataGrid_oper";
            this.dataGrid_oper.RowHeadersVisible = false;
            this.dataGrid_oper.RowHeadersWidth = 51;
            this.dataGrid_oper.RowTemplate.Height = 24;
            this.dataGrid_oper.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_oper.Size = new System.Drawing.Size(376, 213);
            this.dataGrid_oper.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid_add);
            this.groupBox3.Location = new System.Drawing.Point(299, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 409);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вспомогательная таблица";
            // 
            // dataGrid_add
            // 
            this.dataGrid_add.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_add.ColumnHeadersVisible = false;
            this.dataGrid_add.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGrid_add.Location = new System.Drawing.Point(21, 32);
            this.dataGrid_add.Name = "dataGrid_add";
            this.dataGrid_add.RowHeadersVisible = false;
            this.dataGrid_add.RowHeadersWidth = 51;
            this.dataGrid_add.RowTemplate.Height = 24;
            this.dataGrid_add.Size = new System.Drawing.Size(499, 360);
            this.dataGrid_add.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGrid_name);
            this.groupBox4.Location = new System.Drawing.Point(433, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 262);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Таблица символических имен";
            // 
            // dataGrid_name
            // 
            this.dataGrid_name.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_name.ColumnHeadersVisible = false;
            this.dataGrid_name.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column2,
            this.Column3});
            this.dataGrid_name.Location = new System.Drawing.Point(16, 30);
            this.dataGrid_name.Name = "dataGrid_name";
            this.dataGrid_name.RowHeadersVisible = false;
            this.dataGrid_name.RowHeadersWidth = 51;
            this.dataGrid_name.RowTemplate.Height = 24;
            this.dataGrid_name.Size = new System.Drawing.Size(440, 213);
            this.dataGrid_name.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox_bin_code);
            this.groupBox5.Location = new System.Drawing.Point(845, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 409);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Двоичный код";
            // 
            // richTextBox_bin_code
            // 
            this.richTextBox_bin_code.Location = new System.Drawing.Point(16, 32);
            this.richTextBox_bin_code.Name = "richTextBox_bin_code";
            this.richTextBox_bin_code.Size = new System.Drawing.Size(225, 360);
            this.richTextBox_bin_code.TabIndex = 0;
            this.richTextBox_bin_code.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox_first_err);
            this.groupBox6.Location = new System.Drawing.Point(914, 427);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 180);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ошибки первого прохода";
            // 
            // richTextBox_first_err
            // 
            this.richTextBox_first_err.Location = new System.Drawing.Point(16, 23);
            this.richTextBox_first_err.Name = "richTextBox_first_err";
            this.richTextBox_first_err.Size = new System.Drawing.Size(182, 140);
            this.richTextBox_first_err.TabIndex = 0;
            this.richTextBox_first_err.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.richTextBox_sec_err);
            this.groupBox7.Location = new System.Drawing.Point(1118, 202);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(252, 152);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ошибки второго прохода";
            // 
            // richTextBox_sec_err
            // 
            this.richTextBox_sec_err.Location = new System.Drawing.Point(16, 23);
            this.richTextBox_sec_err.Name = "richTextBox_sec_err";
            this.richTextBox_sec_err.Size = new System.Drawing.Size(225, 107);
            this.richTextBox_sec_err.TabIndex = 0;
            this.richTextBox_sec_err.Text = "";
            // 
            // but_first_cycle
            // 
            this.but_first_cycle.Location = new System.Drawing.Point(955, 621);
            this.but_first_cycle.Name = "but_first_cycle";
            this.but_first_cycle.Size = new System.Drawing.Size(131, 38);
            this.but_first_cycle.TabIndex = 9;
            this.but_first_cycle.Text = "Первый проход";
            this.but_first_cycle.UseVisualStyleBackColor = true;
            this.but_first_cycle.Click += new System.EventHandler(this.but_first_cycle_Click);
            // 
            // but_sec_cycle
            // 
            this.but_sec_cycle.Enabled = false;
            this.but_sec_cycle.Location = new System.Drawing.Point(1188, 366);
            this.but_sec_cycle.Name = "but_sec_cycle";
            this.but_sec_cycle.Size = new System.Drawing.Size(126, 38);
            this.but_sec_cycle.TabIndex = 10;
            this.but_sec_cycle.Text = "Второй проход";
            this.but_sec_cycle.UseVisualStyleBackColor = true;
            this.but_sec_cycle.Click += new System.EventHandler(this.but_sec_cycle_Click);
            // 
            // but_fill_default
            // 
            this.but_fill_default.Location = new System.Drawing.Point(1158, 565);
            this.but_fill_default.Name = "but_fill_default";
            this.but_fill_default.Size = new System.Drawing.Size(190, 39);
            this.but_fill_default.TabIndex = 11;
            this.but_fill_default.Text = "Пример по умолчанию";
            this.but_fill_default.UseVisualStyleBackColor = true;
            this.but_fill_default.Click += new System.EventHandler(this.but_fill_default_Click);
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(1158, 520);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(190, 39);
            this.but_reset.TabIndex = 12;
            this.but_reset.Text = "Сброс";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView1);
            this.groupBox8.Location = new System.Drawing.Point(1118, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(252, 184);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Таблица модификаторов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.address});
            this.dataGridView1.Location = new System.Drawing.Point(26, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(204, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox_choice
            // 
            this.comboBox_choice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_choice.FormattingEnabled = true;
            this.comboBox_choice.Items.AddRange(new object[] {
            "Прямая адресация",
            "Относительная адресация",
            "Смешанная адресация"});
            this.comboBox_choice.Location = new System.Drawing.Point(1144, 461);
            this.comboBox_choice.Name = "comboBox_choice";
            this.comboBox_choice.Size = new System.Drawing.Size(218, 24);
            this.comboBox_choice.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1217, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Примеры";
            // 
            // address
            // 
            this.address.HeaderText = "Column2";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_choice);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.but_fill_default);
            this.Controls.Add(this.but_sec_cycle);
            this.Controls.Add(this.but_first_cycle);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_oper)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_add)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_name)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGrid_oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGrid_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGrid_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox_bin_code;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox_first_err;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox_sec_err;
        private System.Windows.Forms.Button but_first_cycle;
        private System.Windows.Forms.Button but_sec_cycle;
        private System.Windows.Forms.RichTextBox richTextBox_code;
        private System.Windows.Forms.Button but_fill_default;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_choice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

