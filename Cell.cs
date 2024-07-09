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

        public bool reproduction;         
        public int reproduction_chance  { get; private set; }
        public int age;
        public int age_death            { get; private set; }
        public int death_chance;

        public int[] target;
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
                        reproduction_chance = 5000;
                        age = 0;
                        age_death = 1000000;
                        death_chance = 0;

                        hunger = 0;
                        hp_max = 30;
                        hp = 30;
                        atk = 0;

                        break; 
                }
                case 2: {
                        brush = Brushes.Blue;

                        reproduction = true;
                        reproduction_chance = 8000;
                        age = 0;
                        age_death = 100;
                        death_chance = 0;

                        hunger = 0;
                        hp_max = 100;
                        hp = 100;
                        atk = 30;

                        break;
                }
                case 3: {
                        brush = Brushes.Red;

                        reproduction = true;
                        reproduction_chance = 4000;
                        age = 0;
                        age_death = 50;
                        death_chance = 0;

                        hunger = 0;
                        hp_max = 150;
                        hp = 150;
                        atk = 50;

                        break;
                }
                case 4: {
                        brush = Brushes.Gray;

                        reproduction = true;
                        reproduction_chance = 600;
                        age = 0;
                        age_death = 70;
                        death_chance = 0;

                        hunger = 0;
                        hp_max = 150;
                        hp = 150;
                        atk = 50;

                        break;
                }
                default: {
                        brush = Brushes.White;
                        break;
                }
            }
        }
       

        
    }
    
}
