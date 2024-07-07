using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocojambo {
    public class Cell {
        private int type;
        private Brush brush;
      
        private int reproduction;
        private int age;
        private int age_death;
        private int death_chance;
        
        private int view_radius;
        private string agression;
        private bool escape;
        private bool hunt;
        private int hunger;
        private int hp_max;
        private int hp;
        private int atk;
        public Cell(int type = 0) { 
            this.type = type;
            switch (type)
            {
                case 1: {
                        brush = Brushes.Green;

                        reproduction = 0;
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

                        break;
                }
                
                
            }
        }
        public Brush get_brush() {
            return brush;
        }
       
    }
    
}
