using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
    [Serializable()]
    public class Charecters
    {

        interface ICommonChrStat
        {
            string _chrClass { get; set; }
            string _chrID { get; set; }
            float _attMultyPlyer { get; set; }
            int _health { get; set; }
            int _staminaGap { get; set; }
            double _exp { get; set; }




            void TakeDmg();
            void DealDmg();

        }


        public class Player : ICommonChrStat
        {

            public string _chrClass { get; set; }
            public string _chrID { get; set; }
            public float _attMultyPlyer { get; set; }
            public int _health { get; set; }
            public int _staminaGap { get; set; }
            public double _exp { get; set; }

            public Player(string chrClass, string chrID, int health, int staminaGap)
            {
                _chrClass = chrClass;
                _chrID = chrID;
                _attMultyPlyer = .5f;
                _health = health;
                _staminaGap = staminaGap;
                _exp = 0;


            }

            public void TakeDmg()
            {

            }

            public void DealDmg()
            {

            }


            public class Enemy : ICommonChrStat
            {

                public string _chrClass { get; set; }
                public string _chrID { get; set; }
                public float _attMultyPlyer { get; set; }
                public int _health { get; set; }
                public int _staminaGap { get; set; }
                public double _exp { get; set; }

                public Enemy(int health, int stamina) 
                {
                    _chrClass = "Beast";
                    _chrID = "Salamon";
                    _attMultyPlyer = .5f;
                    _health = health;
                    _staminaGap = stamina;
                    _exp = 0;


                }

                public void TakeDmg()
                {

                }

                public void DealDmg()
                {

                }

            }
            //public class Sentinel : ICommonChrStat
            //{
            //    string _chrClass { get; set; }
            //    string _chrID { get; set; }
            //    public float _attMultyPlyer { get; set; }
            //    public int _health { get; set; }
            //    public int _stamina { get; set; }
            //    public double _exp { get; set; }

            //    public Sentinel(int health, int stamina)
            //    {
            //        _chrClass = "Sentinel";
            //        _chrID = "Snow";
            //        _attMultyPlyer = .3f;
            //        _health = health;
            //        _stamina = stamina;
            //        _exp = 0;

            //    }

            //    public void TakeDmg()
            //    {

            //    }

            //    public void DealDmg()
            //    {

            //    }
        }
        //public class Warrior : ICommonChrStat
        //{
        //    string _chrClass { get; set; }
        //    string _chrID { get; set; }
        //    public float _attMultyPlyer { get; set; }
        //    public int _health { get; set; }
        //    public int _stamina { get; set; }
        //    public double _exp { get; set; }

        //    public Warrior(int health, int stamina)
        //    {
        //        _chrClass = "Commando";
        //        _chrID = "Cloud";
        //        _attMultyPlyer = .9f;
        //        _health = health;
        //        _stamina = stamina;
        //        _exp = 0;

        //    }

        //    public void TakeDmg()
        //    {

        //    }

        //    public void DealDmg()
        //    {

        //    }

    } 

        
       
    
}