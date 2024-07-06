using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace cocojambo {
    public partial class Form1 : Form {
        private Graphics graphics;
        private Game game;
        private int field_size;
        private int field_h,field_w;
        private int cells_size;
        private int indent_x,indent_y;

        private void b_start_Click(object sender, EventArgs e) {
            game_start();
        }

        private void timer_Tick(object sender, EventArgs e) {
            generation_next();
        }
        private void windowSizeUpdate() {
            field_h = pictureBox.Height;
            field_w = pictureBox.Width;

            cells_size = Math.Min(field_h, field_w) / field_size;
            indent_y = (field_h - field_size * cells_size) / 2;
            indent_x = (field_w - field_size * cells_size) / 2;
            pictureBox.Image = new Bitmap(field_w, field_h);
            graphics = Graphics.FromImage(pictureBox.Image);
            timer.Start();
        }
        private void generation_next() { 
            graphics.Clear(Color.White);
            var field = game.get_field();
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                    if (field[i,j] == 1)
                        graphics.FillRectangle(Brushes.Crimson, i * cells_size + indent_x, j * cells_size + indent_y, cells_size, cells_size);
            pictureBox.Refresh();
        }

        private void b_stop_Click(object sender, EventArgs e) {
            if (timer.Enabled) { 
                timer.Stop();
                num_size.Enabled = true;
            }
            return;
        }
        
        private void game_start() {
            num_size.Enabled = false;
            field_size = (int)num_size.Value;
            field_h = pictureBox.Height;
            field_w = pictureBox.Width;
            cells_size = Math.Min(field_h, field_w) / field_size;
            indent_y = (field_h - field_size * cells_size) / 2;
            indent_x = (field_w - field_size * cells_size) / 2;

            game = new Game(field_size);

            pictureBox.Image = new Bitmap(field_w, field_h);
            graphics = Graphics.FromImage(pictureBox.Image);
            timer.Start();



        }
        public Form1() {
            InitializeComponent();
        }

    }   
}