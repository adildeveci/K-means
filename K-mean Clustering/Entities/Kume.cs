using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace K_mean_Clustering.Entities
{
    class Kume
    {
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public Color ColorOfPoint { get; set; }

        public double XTotal { get; set; }//kume elemanlarının x degeri toplamları
        public double YTotal { get; set; }//kume elemanlarının y toplamları
        public int ToplamNokta { get; set; }//bu kumeye ait eleman sayısı

        public double OldXPoint { get; set; }
        public double OldYPoint { get; set; }
        public int EskiToplamNokta { get; set; }

        public Kume(int number, double xPoint, double yPoint, Color colorOfPoint)
        {
            Id = number;
            X = xPoint;
            Y = yPoint;
            ColorOfPoint = colorOfPoint;

            XTotal = 0;
            YTotal = 0;
            ToplamNokta = 0;
        }

        public void SetToDefaultTotal()
        {
            EskiToplamNokta = ToplamNokta;

            XTotal = 0;
            YTotal = 0;
            ToplamNokta = 0;
        }

        public void setXPoint(double xPoint)
        {
            OldXPoint = X;
            X = xPoint;
        }

        public void setYPoint(double yPoint)
        {
            OldYPoint = Y;
            Y = yPoint;
        }
    }
}
