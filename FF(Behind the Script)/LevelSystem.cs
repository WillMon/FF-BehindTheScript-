using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace ADGP_125
{
    public class LevelingSystem
    {
        public double m_level;
        double m_exp;
        double m_expGain;
        public LevelingSystem(int expGain)
        {
            m_level = 1;
            m_exp = 0;
            m_expGain = expGain;
        }

        public void Level()
        {
            List<double> LevelCap = new List<double>();
            LevelCap.Add((Math.Sqrt(4)*5*Math.Log(m_level)));

            foreach (double expCap in LevelCap) {
                if(expCap == m_exp)
                    ++m_level;
            }
        }

    }
}
