﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders; 
        }

        //Returns True if Player Wins, false otherwise. 
        public bool Play()
        {
            //Run until all invaders are neutralized or an invader reaches the end of path. 

            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //Each tower has opportunity to fire on invaders 
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders); 
                }
                //Count and move invaders that are active. 
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }

              }//End While

            return true; 
        }
    }
}
