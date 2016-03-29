using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace ADGP_125
{
    [Serializable]
    public class LevelingSystem
    {
        public class Player // This is set all the conditions for what makes the palyer level
        {
            Player() { }
            int _level; // Player Level 
           double _exp; // Player Expirence gain
           double _expGain; // Players Expirnce 
           double _expMaxCap; // Players Expirence Cap ~ when player stops level stops leveling 
           double _expCap; // What it takes for him to reach the nevt level


            /// <summary>
            /// Set the comstructer for the Player Leveling System 
            /// </summary>
            /// <param name="expGain"></param>
            public Player(Characters.Enemy enemy)
            {
                _level = 1;
                _exp = 0;
                _expGain = enemy._expDrop;
                _expMaxCap = 1000;
                _expCap = 50;
            }

            public void Level()
            {
                _exp += _expGain;

                if (_exp >= _expCap)
                {
                    _exp = _exp - _expCap;
                    _expCap += _level * (_expCap * 1 / 5);
                    ++_level;
                    if (_expCap >= _expMaxCap)
                        _expCap = _expMaxCap;
                }
            }
            public string PlayerStatInfo()
            {
                return "Player Stats: " + _expCap + " " + _level + " " + _exp + " " + _expGain + " " + _expMaxCap;
            }
        }

        public class Enemy // This will set up the condition of what make a Enemy lele _expCap; /vel Difficulty 
        {
            Enemy() { }
            int _lvlDef;
            public double _expDrop;
            double _scalling;

            public Enemy(Characters.Enemy enemy)
            {
                _lvlDef = 1;
                _expDrop = enemy._expDrop;
                _scalling = _lvlDef * (enemy._dmg * 1 / 5);
            }

            public void Level()
            {

            }

        }
    }
}
