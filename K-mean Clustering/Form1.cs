using K_mean_Clustering.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_mean_Clustering
{
    public partial class Form1 : Form
    {
        private bool isFinished;

        private int iterationNumber;

        private List<Nokta> noktalar;
        private List<Kume> kumeler;
        private List<Color> renkler;
        private int kumeSayisi;
    
        public Form1()
        {
            InitializeComponent();

            InitializeVariables();
        }
         

        #region Functional Methods 
        private void InitializeVariables()
        {


            kumeler = new List<Kume>();
            renkler = new List<Color>();

            noktalar = new List<Nokta>();
            Random rnd = new Random();
            for (int i = 0; i < 2000; i++)
            { 
                renkler.Add(Color.FromArgb(rnd.Next(250), rnd.Next(250), rnd.Next(250)));
            } 



            //for ile 1000 tane ekle
            //kume sayısı degisince son butonu pasif yap tekrar kume hesaplaya butonlarina basinca aktif yap
        }
        private void KumeEkleIyilestirilmis()
        {
            kumeler = new List<Kume>();

            // Starting point of space
            int XCenter = 0;
            int YCenter = 0;

            //tum verilerin yeni merkezlere olan uzaklıkları hesaplanır
            foreach (Nokta nokta in noktalar)
            {
                int xdis = (nokta.X - XCenter);
                int ydis = (nokta.Y - YCenter);
                int tot = (xdis * xdis + ydis * ydis);
                double distance = Math.Sqrt(tot);//  karekok(x^2+ y^2)
                nokta.Distace = distance;
            }

            // farka gore sirala
            for (int i = 0; i < noktalar.Count; i++)
            {
                for (int j = 0; j < noktalar.Count - 1; j++)
                {
                    if (noktalar[j].Distace > noktalar[j + 1].Distace)
                    {
                        Nokta tempDP = noktalar[j];
                        noktalar[j] = noktalar[j + 1];
                        noktalar[j + 1] = tempDP;
                    }
                }
            }
            //kume merkezlerini elmanların icinden secicez
            //elemanlari sıraladık
            //kumenin katları olan noktalardan atama yapıcaz

            for (int i = 0; i < kumeSayisi; i++)
            {
                // int index = Convert.ToInt16(noktalar.Count / (kumeSayisi* 2) * (2 * i + 1));

                int index = Convert.ToInt16(noktalar.Count / (kumeSayisi * 2) * (2 * i + 1));
                int xPoint = noktalar[index].X;
                int yPoint = noktalar[index].Y;
                 
                Kume kume = new Kume(i + 1, xPoint, yPoint, renkler[i]);
                kumeler.Add(kume); //küme merkezlerileri seçilir
            }
        }

        private void KumeEkle()
        {
            //yeni kume listesi tanimla
            kumeler = new List<Kume>();
            Random rand = new Random(); 
            for (int i = 0; i < kumeSayisi; i++)
            {
                Nokta rasgeleNokta = noktalar[rand.Next(noktalar.Count())];
                int xPoint = rasgeleNokta.X;
                int yPoint = rasgeleNokta.Y; 

                Kume kume = new Kume(i + 1, xPoint, yPoint, renkler[i]);
                kumeler.Add(kume);
            }
        }

        private void PaneleCiz()
        {
            Graphics graphicsObj;
            graphicsObj = panel1.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 5);

            //noktalari ciz
            foreach (Nokta nokta in noktalar)
            {
                if (nokta.Kume != null)
                {
                    myPen.Color = nokta.Kume.ColorOfPoint;
                }

                Rectangle rect = new Rectangle(nokta.X, nokta.Y, 1, 1);
                graphicsObj.DrawEllipse(myPen, rect);
            } 
            //kumeleri ciz
            foreach (Kume kume in kumeler)
            {
                Rectangle rect = new Rectangle(Convert.ToInt32(kume.X-7), Convert.ToInt32(kume.Y-7), 14, 14);
                myPen.Color = kume.ColorOfPoint;
                graphicsObj.DrawRectangle(myPen, rect);
            }
        }
        private void KumelendirRasgele()
        {
            //tum elemanlari rasgele kumelendir
            Random rand = new Random();
            foreach (Nokta nokta in noktalar)
            {
                nokta.Kume = kumeler[rand.Next((int)kumeSayisi)];
            } 
        }
        private void NoktayiEnYakinKumeyeAta()
        {
            int i = 1;
            iterationNumber++;
            foreach (Nokta nokta in noktalar)//her dugumu
            {
                Kume enYakinKume = null;
                double distance = 999999999999;
                foreach (Kume kume in kumeler)//tbutun kumelerle karsilastir
                {
                    double tempDistance = GetFark(nokta, kume);
                    if (tempDistance < distance)//eger siradaki kumeye daha yakinsa
                    {
                        enYakinKume = kume;//siradaki kumeyi en yakin olarak belirle
                        distance = tempDistance;//yeni kume merkezi uzakligini guncelle
                    }
                }
                nokta.Kume = enYakinKume;//her noktaya en yakın oldugu kumeyi ata

                if ((i % 2) == 1)
                {
                    //MessageBox.Show("X:" + nokta.Kume.X.ToString() + " Y:" + nokta.Kume.Y.ToString());
                }
                i++;
            }


            // redraw
            panel1.Invalidate();
        }


        private void KumelerinMerkezleriniHesapla()
        {
            //butun kumelere ait elemanların x ve y toplamlarını hesapla
            foreach (Nokta nokta in noktalar)
            {
                nokta.Kume.XTotal += nokta.X;
                nokta.Kume.YTotal += nokta.Y;

                nokta.Kume.ToplamNokta++;//kumeye ait eleman sayısını arttır
            }

            bool isSame = true;//aynı mı
            foreach (Kume kume in kumeler)
            {
                if (kume.ToplamNokta > 0)
                {
                    kume.setXPoint(kume.XTotal / kume.ToplamNokta);
                    kume.setYPoint(kume.YTotal / kume.ToplamNokta);

                    if (!(kume.X == kume.OldXPoint &&
                        kume.Y == kume.OldYPoint &&
                        kume.ToplamNokta == kume.EskiToplamNokta))
                    {//eger herhangi bir degisiklik varsa aynı olmadigini belirt kumenin
                        isSame = false;
                    }

                    kume.SetToDefaultTotal();
                }
            }

            if (isSame)//kume aynıysa
            {//kume aynıysa k means biter
                isFinished = true;
                string msg = "Algoritma Tamamlandı" + Environment.NewLine;

                foreach (Kume kume in kumeler)
                {
                    msg += "Küme: " + kume.Id+" (x="+kume.X+", y="+kume.Y+")---> nokta sayısı: " + kume.EskiToplamNokta.ToString()+ Environment.NewLine;
                }

                msg += "Adım Sayısı : " + iterationNumber.ToString();
                MessageBox.Show(msg);
                iterationNumber = 0;
            }


            // redraw
            panel1.Invalidate();
        }

        private double GetFark(Nokta nokta, Kume kume)
        {
            double xdis = (nokta.X - kume.X);
            double ydis = (nokta.Y - kume.Y);
            double tot = (xdis * xdis + ydis * ydis);
            double distance = Math.Sqrt(tot);

            return distance;
        }




        private void NoktalariGrideBas()
        {
            dataGridView1.Rows.Clear();
            foreach (var nokta in noktalar)
            {
                dataGridView1.Rows.Add(nokta.X, nokta.Y);
            }
        }

        private void showKumeKordinatlari()
        {
            string msg="İlk adım: başlangıç kümereleri seçildi" + Environment.NewLine;
            foreach (Kume kume in kumeler)
            {
                msg += "Küme: " + kume.Id + " (x=" + kume.X + ", y=" + kume.Y + ")"+ Environment.NewLine;
            }
            MessageBox.Show(msg);
        }
        #endregion

        #region Button Actions

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaneleCiz();
            txKumeSayisi.Enabled = true;
        }
        private void panel1_Click(object sender, EventArgs e)//adil
        {
            Point point = panel1.PointToClient(Cursor.Position);
            Nokta nokta = new Nokta(noktalar.Count + 1, point.X, point.Y, null);
            noktalar.Add(nokta);

            NoktalariGrideBas();
            panel1.Invalidate();//panel1_paint olayi tetikle
        }

        private void btnInitializeCluster_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txKumeSayisi.Text, out kumeSayisi))
                return;//sayısal bşe girmediyse geri dön
             
            if (kumeSayisi > noktalar.Count)
            {
                MessageBox.Show("Küme sayısı nokta sayısından fazla olmamalı !");
                return;

            } 
            btnFindTheResult.Enabled = true; 
            //baslangic kumesini rasgele sec
            iterationNumber = 0;
             
            
            KumeEkle();

            KumelendirRasgele();

            // yeniden ciz
            panel1.Invalidate();
            panel1.Enabled = false;
            btnEkle.Enabled = false;
            showKumeKordinatlari();
        }




        private void btnFindTheResult_Click(object sender, EventArgs e)
        {
            txKumeSayisi.Enabled = false;

            btnInitializeCluster.Enabled = false;
            btnInitializeClusterWithImproving.Enabled = false;
            isFinished = false;
            while (!isFinished)
            {
                NoktayiEnYakinKumeyeAta();
                KumelerinMerkezleriniHesapla();

            }

            panel1.Enabled = false;
            btnEkle.Enabled = false;
        }
        private void btnInitializeClusterWithImproving_Click(object sender, EventArgs e)
        { 
            if (!int.TryParse(txKumeSayisi.Text, out kumeSayisi)) 
                return;//sayısal bşe girmediyse geri dön
           
            if (kumeSayisi > noktalar.Count)
            {
                MessageBox.Show("Küme sayısı nokta sayısından fazla olmamalı !");
                return;
            }

            btnFindTheResult.Enabled = true;

            iterationNumber = 0;
            KumeEkleIyilestirilmis();
            KumelendirRasgele();
            //yeniden ciz
            panel1.Invalidate();
            panel1.Enabled = false;
            btnEkle.Enabled = false;
            showKumeKordinatlari();
        }

        #endregion

        private void txKumeSayisi_TextChanged(object sender, EventArgs e)
        {
            btnInitializeCluster.Enabled = true;
            btnInitializeClusterWithImproving.Enabled = true;
            btnFindTheResult.Enabled = false;
            panel1.Enabled = true;
            btnEkle.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            txKumeSayisi.Enabled = false;
            btnFindTheResult.Enabled = false;
            btnInitializeCluster.Enabled = false;
            btnInitializeClusterWithImproving.Enabled = false;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int xPoint, yPoint;
            if (int.TryParse(txX.Text, out xPoint) && int.TryParse(txY.Text, out yPoint))
            {
                dataGridView1.Rows.Add(xPoint, yPoint);
                noktalar.Add(new Nokta(noktalar.Count + 1, xPoint, yPoint, null));
                panel1.Invalidate();//panel1_paint olayi tetikle
            }

        }
        private void txKumeSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
