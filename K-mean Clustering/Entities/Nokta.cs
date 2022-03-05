using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_mean_Clustering.Entities
{
    class Nokta
    {
        public int Number { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Kume Kume { get; set; }

        public double Distace { get; set; }

        public Nokta(int number, int xPoint, int yPoint, Kume cluster)
        {
            Number = number;
            X = xPoint;
            Y = yPoint;
            Kume = cluster;
        }
    }
}
