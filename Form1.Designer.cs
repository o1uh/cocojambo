namespace cocojambo
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bar_size = new System.Windows.Forms.TrackBar();
            this.b_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_cells = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_green = new System.Windows.Forms.Button();
            this.b_blue = new System.Windows.Forms.Button();
            this.b_black = new System.Windows.Forms.Button();
            this.b_red = new System.Windows.Forms.Button();
            this.b_now = new System.Windows.Forms.Button();
            this.bar_speed = new System.Windows.Forms.TrackBar();
            this.b_back = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_size)).BeginInit();
            this.box_cells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bar_size);
            this.splitContainer1.Panel1.Controls.Add(this.b_clear);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.box_cells);
            this.splitContainer1.Panel1.Controls.Add(this.b_now);
            this.splitContainer1.Panel1.Controls.Add(this.bar_speed);
            this.splitContainer1.Panel1.Controls.Add(this.b_back);
            this.splitContainer1.Panel1.Controls.Add(this.b_next);
            this.splitContainer1.Panel1.Controls.Add(this.b_stop);
            this.splitContainer1.Panel1.Controls.Add(this.b_start);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(906, 602);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // bar_size
            // 
            this.bar_size.LargeChange = 1;
            this.bar_size.Location = new System.Drawing.Point(3, 37);
            this.bar_size.Maximum = 5;
            this.bar_size.Minimum = 1;
            this.bar_size.Name = "bar_size";
            this.bar_size.Size = new System.Drawing.Size(292, 45);
            this.bar_size.TabIndex = 19;
            this.bar_size.Value = 1;
            this.bar_size.Scroll += new System.EventHandler(this.bar_size_Scroll);
            // 
            // b_clear
            // 
            this.b_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_clear.Location = new System.Drawing.Point(62, 566);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(177, 23);
            this.b_clear.TabIndex = 18;
            this.b_clear.Text = "ОЧИСТИТЬ ПОЛЕ";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Скорость x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Шаг";
            // 
            // box_cells
            // 
            this.box_cells.Controls.Add(this.label7);
            this.box_cells.Controls.Add(this.label6);
            this.box_cells.Controls.Add(this.label5);
            this.box_cells.Controls.Add(this.label4);
            this.box_cells.Controls.Add(this.b_green);
            this.box_cells.Controls.Add(this.b_blue);
            this.box_cells.Controls.Add(this.b_black);
            this.box_cells.Controls.Add(this.b_red);
            this.box_cells.Location = new System.Drawing.Point(3, 102);
            this.box_cells.Name = "box_cells";
            this.box_cells.Size = new System.Drawing.Size(292, 227);
            this.box_cells.TabIndex = 15;
            this.box_cells.TabStop = false;
            this.box_cells.Text = "Клетки";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(59, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 45);
            this.label7.TabIndex = 17;
            this.label7.Text = "Эволюционированная клтека. Агрессивна абсолютно ко всем. Попарное размножение.\r\n";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(59, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 45);
            this.label6.TabIndex = 16;
            this.label6.Text = "Эволюционированная клетка. Агрессивна к другим видам. Попарное размножение.";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(59, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 45);
            this.label5.TabIndex = 15;
            this.label5.Text = "Эволюционированная клетка. Может постоять за себя. Попарное размножение.\r\n";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(59, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 45);
            this.label4.TabIndex = 14;
            this.label4.Text = "Естественная клетка. Не агрессивна. Размножение случайно.";
            // 
            // b_green
            // 
            this.b_green.BackColor = System.Drawing.Color.Green;
            this.b_green.Location = new System.Drawing.Point(8, 19);
            this.b_green.Name = "b_green";
            this.b_green.Size = new System.Drawing.Size(45, 45);
            this.b_green.TabIndex = 10;
            this.b_green.UseVisualStyleBackColor = false;
            this.b_green.Click += new System.EventHandler(this.b_green_Click);
            this.b_green.Leave += new System.EventHandler(this.b_green_Leave);
            // 
            // b_blue
            // 
            this.b_blue.BackColor = System.Drawing.Color.Blue;
            this.b_blue.Location = new System.Drawing.Point(8, 70);
            this.b_blue.Name = "b_blue";
            this.b_blue.Size = new System.Drawing.Size(45, 45);
            this.b_blue.TabIndex = 11;
            this.b_blue.UseVisualStyleBackColor = false;
            this.b_blue.Click += new System.EventHandler(this.b_blue_Click);
            this.b_blue.Leave += new System.EventHandler(this.b_blue_Leave);
            // 
            // b_black
            // 
            this.b_black.BackColor = System.Drawing.Color.Gray;
            this.b_black.Location = new System.Drawing.Point(8, 172);
            this.b_black.Name = "b_black";
            this.b_black.Size = new System.Drawing.Size(45, 45);
            this.b_black.TabIndex = 13;
            this.b_black.UseVisualStyleBackColor = false;
            this.b_black.Click += new System.EventHandler(this.b_black_Click);
            this.b_black.Leave += new System.EventHandler(this.b_black_Leave);
            // 
            // b_red
            // 
            this.b_red.BackColor = System.Drawing.Color.Red;
            this.b_red.Location = new System.Drawing.Point(8, 121);
            this.b_red.Name = "b_red";
            this.b_red.Size = new System.Drawing.Size(45, 45);
            this.b_red.TabIndex = 12;
            this.b_red.UseVisualStyleBackColor = false;
            this.b_red.Click += new System.EventHandler(this.b_red_Click);
            this.b_red.Leave += new System.EventHandler(this.b_red_Leave);
            // 
            // b_now
            // 
            this.b_now.Location = new System.Drawing.Point(109, 379);
            this.b_now.Name = "b_now";
            this.b_now.Size = new System.Drawing.Size(80, 23);
            this.b_now.TabIndex = 9;
            this.b_now.Text = "с";
            this.b_now.UseVisualStyleBackColor = true;
            // 
            // bar_speed
            // 
            this.bar_speed.LargeChange = 1;
            this.bar_speed.Location = new System.Drawing.Point(3, 454);
            this.bar_speed.Minimum = 1;
            this.bar_speed.Name = "bar_speed";
            this.bar_speed.Size = new System.Drawing.Size(292, 45);
            this.bar_speed.TabIndex = 8;
            this.bar_speed.Value = 1;
            this.bar_speed.Scroll += new System.EventHandler(this.bar_speed_Scroll);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(3, 379);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(100, 23);
            this.b_back.TabIndex = 7;
            this.b_back.Text = "н";
            this.b_back.UseVisualStyleBackColor = true;
            // 
            // b_next
            // 
            this.b_next.Location = new System.Drawing.Point(195, 379);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(100, 23);
            this.b_next.TabIndex = 5;
            this.b_next.Text = "в";
            this.b_next.UseVisualStyleBackColor = true;
            // 
            // b_stop
            // 
            this.b_stop.Location = new System.Drawing.Point(164, 524);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(75, 23);
            this.b_stop.TabIndex = 3;
            this.b_stop.Text = "СТОП";
            this.b_stop.UseVisualStyleBackColor = true;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(62, 524);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 2;
            this.b_start.Text = "СТАРТ";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер поля";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 600);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(906, 602);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_size)).EndInit();
            this.box_cells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.TrackBar bar_speed;
        private System.Windows.Forms.Button b_now;
        private System.Windows.Forms.Button b_black;
        private System.Windows.Forms.Button b_red;
        private System.Windows.Forms.Button b_blue;
        private System.Windows.Forms.Button b_green;
        private System.Windows.Forms.GroupBox box_cells;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.TrackBar bar_size;
    }
}

