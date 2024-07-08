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
        private int cells_size;
        private int indent;
        private int cell_type;
        private int speed;
        private int step_back;

        private void b_start_Click(object sender, EventArgs e) {
            game_start();
        }
        private void b_stop_Click(object sender, EventArgs e) {
            game_stop();
        }
        private void update_text() {
            if (step_back == 0) { 
                Text = $"Поколение: {game.generation}";
                return;
            }
            Text = $"Поколение: {game.generation - step_back} ({game.generation})";
        }
        private void timer_Tick(object sender, EventArgs e) {
            game.next_generation();
            field_update(game.get_field());
        }
        private void field_create() {
            cell_type = 0;
            field_size = (int)bar_size.Value * 10;
            field_hw = pictureBox.Height;

            cells_size = field_hw / field_size;
            indent = (field_hw - cells_size * field_size) / 2;

            game = new Game(field_size);
            step_back = 0;

            pictureBox.Image = new Bitmap(field_hw, field_hw);
            graphics = Graphics.FromImage(pictureBox.Image);

            field_update(game.get_field());
        }
        private void game_start() {
            b_green.Enabled = false;
            b_blue.Enabled = false;
            b_red.Enabled = false;
            b_black.Enabled = false;

            b_next.Enabled = false;
            b_now.Enabled = false;  
            b_back.Enabled = false;

            bar_size.Enabled = false;
            b_start.Enabled = false;

            timer.Start();
        }
        private void game_stop() {
            if (timer.Enabled) {
                timer.Stop();

                b_green.Enabled = true;
                b_blue.Enabled = true;
                b_red.Enabled = true;
                b_black.Enabled = true;

                b_next.Enabled = true;
                b_now.Enabled = true;
                b_back.Enabled = true;

                bar_size.Enabled = true;
                b_start.Enabled = true;
            }
            return;
        }
        
        private void field_update(Cell[,] field) { 
            graphics.Clear(Color.Black);
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                    graphics.FillRectangle(field[i, j].brush, i * cells_size + indent, j * cells_size + indent, cells_size - 1, cells_size - 1);
            pictureBox.Refresh();
            update_text();
        }
        public Form1() {
            InitializeComponent();
            field_create();
            speed = timer.Interval;
        }

        private void bar_size_Scroll(object sender, EventArgs e) {
            field_create();
        }

        private void b_clear_Click(object sender, EventArgs e){
            game_stop();
            field_create();
        }
        private void update_cell(object sender, MouseEventArgs e) { 
            if (e.Button == MouseButtons.Left && e.Y < field_hw && e.X < field_hw && cell_type > 0) { 
                int i = (e.X - indent) / cells_size;
                int j = (e.Y - indent) / cells_size;
                game.add_cell(i, j, cell_type);
                field_update(game.get_field());
            }
            if (e.Button == MouseButtons.Right && e.Y < field_hw && e.X < field_hw) {
                int i = (e.X - indent) / cells_size;
                int j = (e.Y - indent) / cells_size;
                game.delete_cell(i, j);
                field_update(game.get_field());
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
            if (timer.Enabled || step_back != 0) return;
            update_cell(sender, e);
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e) {
            if (timer.Enabled || step_back != 0) return;
            update_cell(sender, e);
        }
        private void remove_cell_type(){
            cell_type = 0;
        }
        private void b_green_Click(object sender, EventArgs e){
            cell_type = 1;
        }

        private void b_blue_Click(object sender, EventArgs e){
            cell_type = 2;
        }

        private void b_red_Click(object sender, EventArgs e){
            cell_type = 3;
        }

        private void b_black_Click(object sender, EventArgs e){
            cell_type = 4;
        }

        private void b_green_Leave(object sender, EventArgs e) {
            remove_cell_type();
        }

        private void b_blue_Leave(object sender, EventArgs e) {
            remove_cell_type();
        }

        private void b_red_Leave(object sender, EventArgs e) {
            remove_cell_type();
        }

        private void b_black_Leave(object sender, EventArgs e) {
            remove_cell_type();
        }

        private void bar_speed_Scroll(object sender, EventArgs e) {
            timer.Interval = speed / bar_speed.Value;
        }

        private void b_next_Click(object sender, EventArgs e) {
            if (step_back == 0) { 
                game.next_generation();
                field_update(game.get_field());
            }
            if (step_back == 1)
            {
                step_back--;
                field_update(game.get_field());
            }
            if (step_back > 1){
                step_back--;
                var field = game.get_field_memory(step_back);
                field_update(field);
            }
        }

        private void b_back_Click(object sender, EventArgs e) {
            if (step_back < 10 && step_back < game.field_buf_memory) step_back++;
            var field = game.get_field_memory(step_back);
            field_update(field);
        }

        private void b_now_Click(object sender, EventArgs e) {
            step_back = 0;
            field_update(game.get_field());
            
        }
    }   
}