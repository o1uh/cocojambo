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
        public bool[,] turn;
        private int field_size;
        public int field_buf_memory { get; private set; }
        public int generation { get; private set; }
        public Game(int field_size) {
            generation = 0;
            this.field_size = field_size;
            field_buf_memory = 0;
            field = new Cell[field_size, field_size];
            field_buf = new Cell[10][,];
            turn = new bool[field_size, field_size];

            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++) { 
                    field[i, j] = new Cell();
                    turn[i, j] = true;
                }
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
            if (validate_pos(i, j)) { 
                field[i, j] = new Cell(type);
                turn[i, j] = true;
            }
        }
        public void delete_cell(int i, int j) {
            if (validate_pos(i, j)) { 
                field[i, j] = new Cell();
                turn[i, j] = true;
            }
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
                    bool selected_cell = i == row && j == col || (ii+jj)%2 == 0;
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
                        if (chance_result(6000))
                            return 4;
                        break;
                }
                case 3: {
                        if (chance_result(9000))
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

        public void next_generation()
        {

            var field_copy = new Cell[field_size, field_size];
            for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++) { 
                    field_copy[i, j] = field[i, j];
                    turn[i,j] = true;
                }

            for (int i = field_buf_memory - 1; i > 0; i--)
                field_buf[i] = field_buf[i - 1];

            field_buf[0] = field;
            field = field_copy;
            if (field_buf_memory < 10) field_buf_memory++;
            generation++;

            /*for (int i = 0; i < field_size; i++)
                for (int j = 0; j < field_size; j++)*/
            for (int j = 0; j < field_size; j++)
                for (int i = 0; i < field_size; i++)
                {
                    if (turn[i, j])
                    {
                        Dictionary<int, Neighbors> neighbors_cells = new Dictionary<int, Neighbors>();
                        neighbors_cells = neighbors(i, j);
                        int evo;

                        field_copy[i, j].age++;
                        if (field_copy[i, j].type != 1 && field_copy[i, j].type != 0)
                            field_copy[i, j].hunger += 10;
                        if (field_copy[i, j].hunger < 100)
                            field_copy[i, j].hp += 10;

                        if (field_copy[i, j].hunger < 0)
                            field_copy[i, j].hunger = 0;
                        if (field_copy[i, j].hp > field_copy[i, j].hp_max)
                            field_copy[i, j].hp = field_copy[i, j].hp_max;

                        switch (field[i, j].type)
                        {
                            case 0:
                                {
                                    evo = evolution(field[i, j].type);
                                    if (evo != field_copy[i, j].type && field_copy[i, j].type == field[i, j].type)
                                        field_copy[i, j] = new Cell(evo);
                                    break;
                                }
                            case 1:
                                {
                                    if (death(field[i, j]) && field_copy[i, j].type == field[i, j].type)
                                    {
                                        field_copy[i, j] = new Cell();
                                        break;
                                    }

                                    evo = evolution(field[i, j].type);
                                    if (evo != field[i, j].type && field_copy[i, j].type == field[i, j].type)
                                    {
                                        field_copy[i, j] = new Cell(evo);
                                        /*occupied[i, j] = true;*/
                                        break;
                                    }

                                    if (neighbors_cells[0].count > 0)
                                        if (chance_result(field_copy[i, j].reproduction_chance) && field_copy[i, j].type == field[i, j].type)
                                        {
                                            int rand_pos = random.Next(0, neighbors_cells[0].count);
                                            int x = neighbors_cells[0].pos[rand_pos].Item1;
                                            int y = neighbors_cells[0].pos[rand_pos].Item2;
                                            field_copy[x, y] = new Cell(1);
                                            turn[x, y] = false;
                                        }

                                    break;
                                }
                            case 2:
                                {

                                    if (death(field[i, j]))
                                    {
                                        field_copy[i, j] = new Cell();

                                        break;
                                    }
                                    if (field[i, j].hunger >= 100 && evolution(field[i, j].type) != field[i, j].type)
                                    {
                                        field_copy[i, j] = new Cell(4);
                                        field_copy[i, j].hunger = 100;
                                        break;
                                    }
                                    if (neighbors_cells[2].count > 0 && neighbors_cells[0].count > 0 && field[i, j].reproduction)
                                    {
                                        for (int k = 0; k < neighbors_cells[2].count; k++)
                                        {
                                            int x = neighbors_cells[2].pos[k].Item1;
                                            int y = neighbors_cells[2].pos[k].Item2;
                                            if (field[x, y].reproduction && chance_result(field[i, j].reproduction_chance))
                                            {
                                                field_copy[x, y].reproduction = false;
                                                int rand_pos = random.Next(0, neighbors_cells[0].count);
                                                x = neighbors_cells[0].pos[rand_pos].Item1;
                                                y = neighbors_cells[0].pos[rand_pos].Item2;
                                                neighbors_cells[0].pos.Remove((x, y));
                                                neighbors_cells[2].pos.Add((x, y));
                                                neighbors_cells[0].count--;
                                                neighbors_cells[2].count++;
                                                field_copy[x, y] = new Cell(2);
                                                field_copy[x, y].reproduction = false;
                                                turn[x, y] = false;
                                                break;
                                            }
                                        }
                                        break;
                                    }

                                    if (neighbors_cells[1].count > 0)
                                    {
                                        int rand_pos = random.Next(0, neighbors_cells[1].count);
                                        int x = neighbors_cells[1].pos[rand_pos].Item1;
                                        int y = neighbors_cells[1].pos[rand_pos].Item2;
                                        if (fight(field[i, j], field[x, y]))
                                        {
                                            field_copy[x, y] = field[i, j];
                                            field_copy[i, j] = new Cell();
                                            field_copy[x, y].hunger = 0;
                                            turn[x, y] = false;
                                        }
                                        break;
                                    }
                                    if (neighbors_cells[0].count > 0)
                                    {
                                        int rand_pos = random.Next(0, neighbors_cells[0].count);
                                        int x = neighbors_cells[0].pos[rand_pos].Item1;
                                        int y = neighbors_cells[0].pos[rand_pos].Item2;
                                        field_copy[x, y] = field[i, j];
                                        field_copy[i, j] = new Cell();
                                        turn[x, y] = false;
                                        break;
                                    }
                                    for (int t = 3; t <= 4; t++) 
                                        if (neighbors_cells[t].count > 0)
                                        {
                                            int rand_pos = random.Next(0, neighbors_cells[t].count);
                                            int x = neighbors_cells[t].pos[rand_pos].Item1;
                                            int y = neighbors_cells[t].pos[rand_pos].Item2;
                                            if (fight(field[i, j], field[x, y]))
                                            {
                                                field_copy[x, y] = field[i, j];
                                                field_copy[i, j] = new Cell();
                                            }
                                            turn[i, j] = false;
                                            break;
                                        }

                                    break;
                                }
                            case 3:
                                {

                                    if (death(field[i, j]))
                                    {
                                        field_copy[i, j] = new Cell();
                                        break;
                                    }


                                    break;
                                }
                            case 4:
                                {

                                    if (death(field[i, j]))
                                    {
                                        field_copy[i, j] = new Cell();
                                        break;
                                    }


                                    break;
                                }
                        }

                        field_copy[i, j].reproduction = true;
                        field = field_copy;
                    }
                    /*turn[i, j] = true;*/
                }

            /*for(int i = field_buf_memory - 1; i > 0; i--) {
                field_buf[i] = field_buf[i - 1];
            }
            field_buf[0] = field;
            field = field_copy;
            if (field_buf_memory < 10) field_buf_memory++;
            generation++;*/
        }
    }
}
