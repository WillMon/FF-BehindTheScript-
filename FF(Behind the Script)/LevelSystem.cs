using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace ADGP_125
{
    [Serializable()]
    public class LevelingSystem
    {
        public class Player // This is set all the conditions for what makes the palyer level
        {
            int _level; // Player Level 
            int _exp; // Player Expirence gain
            int _expGain; // Players Expirnce 
            int _expMaxCap; // Players Expirence Cap ~ when player stops level stops leveling 
            int _expCap; // What it takes for him to reach the nevt level

            /// <summary>
            /// Set the comstructer for the Player Leveling System 
            /// </summary>
            /// <param name="expGain"></param>
            public Player(int expGain)
            {
                _level = 1;
                _exp = 0;
                _expGain = expGain;
                _expMaxCap = 1000;
                _expCap = 80;
            }

            public void Level()
            {

                if (_expCap <= _expMaxCap)
                {
                    _exp += _expGain;
                    if (_exp <= _expCap) { }
                }
            }
        }
    }

    public class Enemy // This will set up the condition of what make a Enemy level Difficulty 
    {

        int _lvlDef;
        int _expDrop;
        bool alive;

        public Enemy()
        {
            _lvlDef = 1;
            _expDrop = 45;
            alive = true;
        }

        public void Level()
        {

        }

    }
}
