using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocojambo {
    public class Game {
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
    }
}
