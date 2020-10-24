using ServiceMtk_P1_20180140067;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCFC_P4_20180140067_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            Console.WriteLine("2 / 2 = " + hasilBagi);
            Console.ReadLine();

            Koordinat objk = new Koordinat();

            //Masukan kedalam label
            label1.Text = "1 + 2 = " + hasilTambah + Environment.NewLine + "3 - 2 = " +
                hasilKurang + Environment.NewLine + "2 x 2 = " + hasilKali + Environment.NewLine +
                "2 / 2 = " + hasilBagi;

        }
    }
}
