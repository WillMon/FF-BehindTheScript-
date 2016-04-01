using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{


    interface ICommonChrStat
    {
        string _chrClass { get; set; }
        string _chrID { get; set; }
        int _dmg { get; set; }
        int _health { get; set; }
        bool _alive { get; set; }
        double _exp { get; set; }


    }
    [Serializable]
    public class Unit : ICommonChrStat
    {

        public string _chrClass { get; set; }
        public string _chrID { get; set; }
        public int _dmg { get; set; }
        public int _health { get; set; }
        public bool _alive { get; set; }

        public double _exp { get; set; }

        public Unit() { }
        public Unit(string chrClass, string chrID, int health, int dmg)
        {
            _chrClass = chrClass;
            _chrID = chrID;
            _dmg = dmg;
            _health = health;

            _exp = 0;


        }

        public string PlayerInfo
        {
            get
            {
                return "Class: " + _chrClass + "\nName: " + _chrID + "\nHealth: " + _health;
            }
        }
        public void TakeDmg(Unit p)
        {
            this._health -= p._dmg;
        }

    }
}

        //public class Enemy : ICommonChrStat
        //{

        //    public string _chrClass { get; set; }
        //    public string _chrID { get; set; }
        //    public int _dmg { get; set; }
        //    public int _health { get; set; }

        //    public double _exp { get; set; }
        //    public float _expDrop;
        //    public Enemy(string chrID, int health, float expDrop, int dmg)
        //    {
        //        _chrID = chrID;
        //        _dmg = dmg;
        //        _health = health;
        //        _exp = 0;
        //        _expDrop = expDrop;


        //    }

        //    public void TakeDmg(Player player)
        //    {
        //        _health -= player._dmg;
        //    }

        //}
    


