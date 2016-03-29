using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
    [Serializable]
    public class Characters
    {
        public Characters() { }
        
        interface ICommonChrStat
        {
            string _chrClass { get; set; }
            string _chrID { get; set; }
            float _dmg { get; set; }
            float _health { get; set; }
            int _staminaGap { get; set; }
            double _exp { get; set; }


        }

        public class Player : ICommonChrStat
        {

            public string _chrClass { get; set; }
            public string _chrID { get; set; }
            public float _dmg { get; set; }
            public float _health { get; set; }
            public int _staminaGap { get; set; }
            public double _exp { get; set; }

            public Player()  { }
            public Player(string chrClass, string chrID, int health, int staminaCap, int dmg)
            {
                _chrClass = chrClass;
                _chrID = chrID;
                _dmg = dmg;
                _health = health;
                _staminaGap = staminaCap;
                _exp = 0;


            }

            public string PlayerInfo()
            {
                return "Class: " + _chrClass + "\nName: " + _chrID + "\nHealth: " +_health;
            }
            public void TakeDmg(Enemy playerStats)
            {
                _health -= playerStats._dmg;
            }

        }

        public class Enemy : ICommonChrStat
        {

            public string _chrClass { get; set; }
            public string _chrID { get; set; }
            public float _dmg { get; set; }
            public float _health { get; set; }
            public int _staminaGap { get; set; }
            public double _exp { get; set; }
            public float _expDrop;
            public Enemy(string chrID, int health, int stamina, float expDrop, int dmg)
            {
                _chrID = chrID;
                _dmg = dmg;
                _health = health;
                _staminaGap = stamina;
                _exp = 0;
                _expDrop = expDrop;


            }

            public void TakeDmg(Player player)
            {
                _health -= player._dmg;
            }

        }
    }

}

