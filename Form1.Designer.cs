﻿namespace cocojambo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_cells = new System.Windows.Forms.GroupBox();
            this.b_green = new System.Windows.Forms.Button();
            this.b_blue = new System.Windows.Forms.Button();
            this.b_black = new System.Windows.Forms.Button();
            this.b_red = new System.Windows.Forms.Button();
            this.b_size = new System.Windows.Forms.Button();
            this.b_now = new System.Windows.Forms.Button();
            this.bar_speed = new System.Windows.Forms.TrackBar();
            this.b_stepBack = new System.Windows.Forms.Button();
            this.b_stepForward = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.num_size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.box_cells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.box_cells);
            this.splitContainer1.Panel1.Controls.Add(this.b_size);
            this.splitContainer1.Panel1.Controls.Add(this.b_now);
            this.splitContainer1.Panel1.Controls.Add(this.bar_speed);
            this.splitContainer1.Panel1.Controls.Add(this.b_stepBack);
            this.splitContainer1.Panel1.Controls.Add(this.b_stepForward);
            this.splitContainer1.Panel1.Controls.Add(this.b_stop);
            this.splitContainer1.Panel1.Controls.Add(this.b_start);
            this.splitContainer1.Panel1.Controls.Add(this.num_size);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Скорость x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 273);
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
            this.box_cells.Location = new System.Drawing.Point(3, 67);
            this.box_cells.Name = "box_cells";
            this.box_cells.Size = new System.Drawing.Size(180, 203);
            this.box_cells.TabIndex = 15;
            this.box_cells.TabStop = false;
            this.box_cells.Text = "Клетки";
            // 
            // b_green
            // 
            this.b_green.Location = new System.Drawing.Point(8, 19);
            this.b_green.Name = "b_green";
            this.b_green.Size = new System.Drawing.Size(40, 40);
            this.b_green.TabIndex = 10;
            this.b_green.Text = "g";
            this.b_green.UseVisualStyleBackColor = true;
            // 
            // b_blue
            // 
            this.b_blue.Location = new System.Drawing.Point(8, 65);
            this.b_blue.Name = "b_blue";
            this.b_blue.Size = new System.Drawing.Size(40, 40);
            this.b_blue.TabIndex = 11;
            this.b_blue.Text = "b";
            this.b_blue.UseVisualStyleBackColor = true;
            // 
            // b_black
            // 
            this.b_black.Location = new System.Drawing.Point(8, 157);
            this.b_black.Name = "b_black";
            this.b_black.Size = new System.Drawing.Size(40, 40);
            this.b_black.TabIndex = 13;
            this.b_black.Text = "black";
            this.b_black.UseVisualStyleBackColor = true;
            // 
            // b_red
            // 
            this.b_red.Location = new System.Drawing.Point(8, 111);
            this.b_red.Name = "b_red";
            this.b_red.Size = new System.Drawing.Size(40, 40);
            this.b_red.TabIndex = 12;
            this.b_red.Text = "r";
            this.b_red.UseVisualStyleBackColor = true;
            // 
            // b_size
            // 
            this.b_size.Location = new System.Drawing.Point(108, 32);
            this.b_size.Name = "b_size";
            this.b_size.Size = new System.Drawing.Size(75, 23);
            this.b_size.TabIndex = 14;
            this.b_size.Text = "Применить";
            this.b_size.UseVisualStyleBackColor = true;
            // 
            // b_now
            // 
            this.b_now.Location = new System.Drawing.Point(69, 302);
            this.b_now.Name = "b_now";
            this.b_now.Size = new System.Drawing.Size(48, 23);
            this.b_now.TabIndex = 9;
            this.b_now.Text = "с";
            this.b_now.UseVisualStyleBackColor = true;
            // 
            // bar_speed
            // 
            this.bar_speed.Location = new System.Drawing.Point(3, 363);
            this.bar_speed.Minimum = 1;
            this.bar_speed.Name = "bar_speed";
            this.bar_speed.Size = new System.Drawing.Size(180, 45);
            this.bar_speed.TabIndex = 8;
            this.bar_speed.Value = 1;
            // 
            // b_stepBack
            // 
            this.b_stepBack.Location = new System.Drawing.Point(3, 302);
            this.b_stepBack.Name = "b_stepBack";
            this.b_stepBack.Size = new System.Drawing.Size(60, 23);
            this.b_stepBack.TabIndex = 7;
            this.b_stepBack.Text = "н";
            this.b_stepBack.UseVisualStyleBackColor = true;
            // 
            // b_stepForward
            // 
            this.b_stepForward.Location = new System.Drawing.Point(123, 302);
            this.b_stepForward.Name = "b_stepForward";
            this.b_stepForward.Size = new System.Drawing.Size(60, 23);
            this.b_stepForward.TabIndex = 5;
            this.b_stepForward.Text = "в";
            this.b_stepForward.UseVisualStyleBackColor = true;
            // 
            // b_stop
            // 
            this.b_stop.Location = new System.Drawing.Point(108, 414);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(75, 23);
            this.b_stop.TabIndex = 3;
            this.b_stop.Text = "СТОП";
            this.b_stop.UseVisualStyleBackColor = true;
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(3, 414);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 2;
            this.b_start.Text = "СТАРТ";
            this.b_start.UseVisualStyleBackColor = true;
            // 
            // num_size
            // 
            this.num_size.Location = new System.Drawing.Point(15, 35);
            this.num_size.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_size.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_size.Name = "num_size";
            this.num_size.Size = new System.Drawing.Size(87, 20);
            this.num_size.TabIndex = 1;
            this.num_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер поля";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 448);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(54, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 40);
            this.label4.TabIndex = 14;
            this.label4.Text = "Естественная клетка. Не агрессивна. ";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(54, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Может постоять за себя.";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(54, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Агрессивна к другим видам";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(54, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "Агрессивна абсолютно ко всем.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.box_cells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_size;
        private System.Windows.Forms.Button b_stepBack;
        private System.Windows.Forms.Button b_stepForward;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.TrackBar bar_speed;
        private System.Windows.Forms.Button b_now;
        private System.Windows.Forms.Button b_black;
        private System.Windows.Forms.Button b_red;
        private System.Windows.Forms.Button b_blue;
        private System.Windows.Forms.Button b_green;
        private System.Windows.Forms.Button b_size;
        private System.Windows.Forms.GroupBox box_cells;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

