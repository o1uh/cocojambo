using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocojambo {
    public class Game {
        Random random = new Random();
        private Cell[,] field;
        private int field_size;
        public Game(int field_size) {
            this.field_size = field_size; 
            field = new Cell[field_size, field_size];
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                    field[i, j] = new Cell();
        }
        
        public Cell[,] get_field() {
            var field_copy = new Cell[field_size,field_size];
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)
                    field_copy[i,j] = field[i, j];
            return field_copy; 
        }
        public void add_cell(int i, int j, int type) {
            if (validate_pos(i,j))
                field[i,j] = new Cell(type);
        }
        public void delete_cell(int i, int j) {
            if (validate_pos(i, j))
                field[i, j] = new Cell();
        }
        private bool validate_pos(int i, int j) { 
            return i >= 0 && j >= 0 && i<=field_size && j<=field_size;
        }

        private bool chance_result(int chance) {
            return random.Next(1, 101) <= chance;
        }
        private Dictionary<int, int> neighbors(int i, int j) {

            Dictionary<int, int> neighbors_cells = new Dictionary<int, int>();
            for (int k = 0; k < 4; k++)
                neighbors_cells[k] = 0;
            for (int ii = -1; ii < 1; ii++)
                for (int jj = -1; jj < 1; jj++) {
                    int col = (i + ii + field_size) % field_size;
                    int row = (j + jj + field_size) % field_size;
                    bool selected_cell = i == row && j == col;
                    if (!selected_cell)
                        neighbors_cells[field[col, row].type] += 1;
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
                    Dictionary<int, int> neighbors_cells = new Dictionary<int, int>();
                    neighbors_cells = neighbors(i, j);
                    switch (field_copy[i,j].type) 
                    {
                        case 0: {

                                if (chance_result(field_copy[i, j].reproduction_chance))
                                    field_copy[i, j] = new Cell(1);
                                break;
                        }
                    }
                }
            field = field_copy;
        }
    }
}
