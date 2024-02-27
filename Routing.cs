using Mini_Uber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Design_Pattern
{

    //singletone
    public class Routing
    {
        static DbProxy db = DbProxy.GetDB();
        public static int [,] dist= new int [41,41];
        public static int[,] tmp = new int[41, 41];

        static Routing(){
            RunAlgo();
        }

        private static void RunAlgo()
        {
            db.GetDestinations(tmp);

            for(int i = 0; i < 40; i++)
            {
                for(int j = 0; j < 40; j++)
                {
                    if (tmp[i, j] != 0)
                    {
                        dist[i, j] = tmp[i, j];
                    }
                    else
                    {
                        dist[i, j] = 100;
                    }
                }
            }

            for (int k = 0; k < 40; k++)
            {
              for (int i = 0; i < 40; i++)
                {
                for (int j = 0; j < 40; j++)
                    {
                        dist[i, j] = Math.Min(dist[i, j], dist[k, j] + dist[i, k]);
                    }
                }
            }
        }

    }
}
