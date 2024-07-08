using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocojambo {
    public class Game {
        Random random = new Random();
        private Cell[,] field;
        private Cell[][,] field_buf;
        private int field_size;
        public int field_buf_memory { get; private set; }
        public int generation { get; private set; }
        public Game(int field_size) {
            generation = 0;
            this.field_size = field_size;
            field_buf_memory = 0;
            field = new Cell[field_size, field_size];
            field_buf = new Cell[10][,];
            
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                    field[i, j] = new Cell();
            for (int i = 0; i < 10; i++)
                field_buf[i] = field;
        }

        public Cell[,] get_field() {
            var field_copy = new Cell[field_size, field_size];
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                    field_copy[i, j] = field[i, j];
            return field_copy;
        }
        public Cell[,] get_field_memory(int n) {
            if (n > 0) {
                var field_copy = new Cell[field_size, field_size];
                for (int i = 0; i < field_size; i++)
                    for (int j = 0; j < field_size; j++)
                        field_copy[i, j] = field_buf[n - 1][i, j];
                return field_copy;
            }
            return get_field();
        }
        public void add_cell(int i, int j, int type) {
            if (validate_pos(i, j))
                field[i, j] = new Cell(type);
        }
        public void delete_cell(int i, int j) {
            if (validate_pos(i, j))
                field[i, j] = new Cell();
        }
        private bool validate_pos(int i, int j) {
            return i >= 0 && j >= 0 && i <= field_size && j <= field_size;
        }

        private bool chance_result(int chance) {
            return random.Next(1, 1001) <= chance;
        }
        public class Neighbors {
            public int count;
            public List<(int,int)> pos;
            public Neighbors() {
                count = 0;
                pos = new List<(int,int)> ();
            }
        }
        private Dictionary<int, Neighbors> neighbors(int i, int j) {
            
            Dictionary<int, Neighbors> neighbors_cells = new Dictionary<int,Neighbors>();
            for (int k = 0; k < 4; k++)
                neighbors_cells[k] = new Neighbors();

            for (int ii = -1; ii < 1; ii++)
                for (int jj = -1; jj < 1; jj++) {
                    int col = (i + ii + field_size) % field_size;
                    int row = (j + jj + field_size) % field_size;
                    bool selected_cell = i == row && j == col;
                    if (!selected_cell) {
                        neighbors_cells[field[col, row].type].count += 1;
                        neighbors_cells[field[col, row].type].pos.Add((col, row));
                    }
                }
            return neighbors_cells;
        }
        public void next_generation() {
            var field_copy = new Cell[field_size, field_size];
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                    field_copy[i, j] = field[i, j];

            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++) {
                    Dictionary<int, Neighbors> neighbors_cells = new Dictionary<int, Neighbors>();
                    neighbors_cells = neighbors(i, j);
                    switch (field_copy[i,j].type) 
                    {
                        case 0: {
                                if (chance_result(field_copy[i, j].reproduction_chance))
                                    field_copy[i, j] = new Cell(1);
                                break;
                        }
                        case 1: {
                                if (neighbors_cells[0].count > 0) 
                                    if (chance_result(field_copy[i, j].reproduction_chance)) {
                                        int rand_pos = random.Next(0, neighbors_cells[0].count);
                                        int x = neighbors_cells[0].pos[rand_pos].Item1;
                                        int y = neighbors_cells[0].pos[rand_pos].Item2;
                                        field_copy[x,y] = new Cell(1);
                                    }  
                                break;
                        }
                    }   
                }
            for(int i = field_buf_memory - 1; i > 0; i--) {
                field_buf[i] = field_buf[i - 1];
            }
            field_buf[0] = field;
            field = field_copy;
            if (field_buf_memory < 10) field_buf_memory++;
            generation++;
        }
    }
}
