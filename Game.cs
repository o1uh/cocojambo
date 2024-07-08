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
            return random.Next(1, 10001) <= chance;
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
            for (int k = 0; k < 5; k++)
                neighbors_cells[k] = new Neighbors();

            for (int ii = -1; ii < 2; ii++)
                for (int jj = -1; jj < 2; jj++) {
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
        private int evolution(int type) {
            switch (type)
            {
                case 0: {
                        if (chance_result(1)) 
                            return 1;
                        break;
                }
                case 1: {
                        if (chance_result(100)) 
                            return 2;
                        if (chance_result(10))
                            return 3;
                        if (chance_result(2))
                            return 4;
                        break;
                }
                case 2: {
                        if (chance_result(1000))
                            return 4;
                        break;
                }
                case 3: {
                        if (chance_result(4000))
                            return 4;
                        break;
                }
            }
            return type;
        }
        private bool death(Cell cell) {
            if (cell.hp <= 0) 
                return true;
            if (cell.hunger >= 100)
                return chance_result(cell.hunger*2);
            if (cell.age >= cell.age_death)
                return true;
            return chance_result(5);
        }
        private bool fight(Cell cell1,Cell cell2) {
            cell2.hp -= cell1.atk;
            if (death(cell2)) { 
                cell2 = new Cell();
                return true;
            }
            cell1.hp -= cell2.atk;
            return false;
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
                    int evo;
                    switch (field_copy[i,j].type) 
                    {
                        case 0: {
                                evo = evolution(field[i, j].type);
                                if (evo != field_copy[i, j].type && field[i, j].type == 0)
                                    field_copy[i, j] = new Cell(evo);
                                break;
                        }
                        case 1: {
                                if (death(field[i, j])){
                                    field_copy[i, j] = new Cell();
                                    break;
                                }

                                evo = evolution(field[i, j].type);
                                if (evo != field[i, j].type) { 
                                    field_copy[i, j] = new Cell(evo);
                                    break;
                                }

                                if (neighbors_cells[0].count > 0) 
                                    if (chance_result(field_copy[i, j].reproduction_chance)) {
                                        int rand_pos = random.Next(0, neighbors_cells[0].count);
                                        int x = neighbors_cells[0].pos[rand_pos].Item1;
                                        int y = neighbors_cells[0].pos[rand_pos].Item2;
                                        field_copy[x,y] = new Cell(1);
                                    }  

                                break;
                        }
                        case 2: {
                                if (death(field[i, j])) {
                                    field_copy[i, j] = new Cell();
                                    break;
                                }

                                if (neighbors_cells[3].count + neighbors_cells[4].count > 0)
                                    if (neighbors_cells[1].count > 0) {
                                        int rand_pos = random.Next(0, neighbors_cells[1].count);
                                        int x = neighbors_cells[1].pos[rand_pos].Item1;
                                        int y = neighbors_cells[1].pos[rand_pos].Item2;
                                        if (fight(field[i, j], field[x, y])) {
                                            field_copy[x, y] = field[i, j];
                                            field_copy[i, j] = new Cell();
                                            field_copy[x, y].hunger -= field_copy[x, y].atk;
                                        }
                                    }

                                break;
                        }
                        case 3: {
                                if (death(field[i, j])){
                                    field_copy[i, j] = new Cell();
                                    break;
                                }


                                break;
                        }
                        case 4: {
                                if (death(field[i, j])){
                                    field_copy[i, j] = new Cell();
                                    break;
                                }


                                break;
                        }
                    }
                    field_copy[i, j].age++;
                    if (field_copy[i, j].type != 1 || field_copy[i, j].type != 0)
                        field_copy[i, j].hunger += 10;

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
