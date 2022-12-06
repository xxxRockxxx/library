using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YES
{
    public class Сonverter
    {
        public void ConvertToDouble(string p_B, string p_S, string p_f, string G_f, string m_s, string k_fa, string Y_s, string x_k, string k_sa, string X_0)
        {
            Data.p_B=Convert.ToDouble(p_B);
            Data.p_S=Convert.ToDouble(p_S);
            Data.p_F = Convert.ToDouble(p_f);
            Data.G_F = Convert.ToDouble(G_f);
            Data.m_s=Convert.ToDouble(m_s);
            Data.k_fa=Convert.ToDouble(k_fa);
            Data.Y_s=Convert.ToDouble(Y_s);
            Data.x_k=Convert.ToDouble(x_k);
            Data.k_sa=Convert.ToDouble(k_sa);
            Data.X_O=Convert.ToDouble(X_0);


        }
    }
}
