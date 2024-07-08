using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocojambo {
    public class Cell {
        public int type                 { get; private set; }
        public Brush brush              { get; private set; }

        public int reproduction         { get; private set; }
        public int reproduction_chance  { get; private set; }
        public int age;
        public int age_death            { get; private set; }
        public int death_chance;

        public int view_radius          { get; private set; }
        public string agression         { get; private set; }
        public bool escape;
        public bool hunt;
        public int hunger;
        public int hp_max               { get; private set; }
        public int hp;
        public int atk                  { get; private set; }
        public Cell(int type = 0) { 
            this.type = type;
            switch (type)
            {
                case 1: {
                        brush = Brushes.Green;

                        reproduction = 0;
                        reproduction_chance = 300;
                        age = 0;
                        age_death = 1000000;
                        death_chance = 0;

                        view_radius = 0;
                        agression = "none";
                        escape = false;
                        hunt = false;
                        hunger = 0;
                        hp_max = 25;
                        hp = 25;
                        atk = 0;

                        break; 
                }
                case 2: {
                        brush = Brushes.Blue;

                        reproduction = 1;
                        reproduction_chance = 800;
                        age = 0;
                        age_death = 100;
                        death_chance = 0;

                        view_radius = 1;
                        agression = "def";
                        escape = false;
                        hunt = false;
                        hunger = 0;
                        hp_max = 100;
                        hp = 100;
                        atk = 10;

                        break;
                }
                case 3: {
                        brush = Brushes.Red;

                        reproduction = 1;
                        reproduction_chance = 400;
                        age = 0;
                        age_death = 50;
                        death_chance = 0;

                        view_radius = 1;
                        agression = "other";
                        escape = false;
                        hunt = false;
                        hunger = 0;
                        hp_max = 150;
                        hp = 150;
                        atk = 15;

                        break;
                }
                case 4: {
                        brush = Brushes.Gray;

                        reproduction = 1;
                        reproduction_chance = 60;
                        age = 0;
                        age_death = 70;
                        death_chance = 0;

                        view_radius = 1;
                        agression = "all";
                        escape = false;
                        hunt = true;
                        hunger = 0;
                        hp_max = 150;
                        hp = 150;
                        atk = 20;

                        break;
                }
                default: {
                        brush = Brushes.White;
                        reproduction_chance = 1;
                        break;
                }
            }
        }
        public static Cell operator ++(Cell cell) { cell.age++; return cell; }

        
    }
    
}
