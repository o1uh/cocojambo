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
        private int field_hw;
        private float cells_size;
        private float indent;

        private void b_start_Click(object sender, EventArgs e) {
            game_start();
        }
        private void b_stop_Click(object sender, EventArgs e) {
            game_stop();
        }
        private void timer_Tick(object sender, EventArgs e) {
            field_generation();
        }
        private void field_create() { 
            
            field_size = (int)bar_size.Value * 10;
            field_hw = pictureBox.Height;

            cells_size = field_hw / field_size;
            indent = (field_hw - cells_size * field_size) / 2;

            game = new Game(field_size);

            pictureBox.Image = new Bitmap(field_hw, field_hw);
            graphics = Graphics.FromImage(pictureBox.Image);

            graphics.Clear(Color.Black);
            var field = game.get_field();
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                        graphics.FillRectangle(Brushes.White, i * cells_size + indent, j * cells_size + indent, cells_size - 1, cells_size-1);
            pictureBox.Refresh();
        }
        private void game_start() {
            bar_size.Enabled = false;
            b_start.Enabled = false;
            timer.Start();
        }
        private void game_stop() {
            if (timer.Enabled) {
                timer.Stop();
                bar_size.Enabled = true;
                b_start.Enabled = true;
            }
            return;
        }
        private void field_generation() { 
            
        }
        
        public Form1() {
            InitializeComponent();
            field_create();
        }

        private void bar_size_Scroll(object sender, EventArgs e) {
            field_create();
        }

        private void b_clear_Click(object sender, EventArgs e){
            field_create();
        }
    }   
}