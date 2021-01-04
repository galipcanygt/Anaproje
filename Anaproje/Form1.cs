using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Karadeniz Tır Galerisi";
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";

            listBox1.SelectionMode = SelectionMode.MultiExtended;

            Image form1resim = new Bitmap(@"C:\Users\ASUS\Desktop\XD.jpg");
            Image pic3resim = new Bitmap(@"C:\Users\ASUS\Desktop\Proje\ii.png");
            BackgroundImage = form1resim;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = pic3resim;
            BackgroundImageLayout = ImageLayout.Stretch;

            label1.Text = "Karadeniz Tır Galerisi";
            label1.Font = new Font("Arial", 31);
            label1.ForeColor = Color.Gold;
            label1.BackColor = Color.Transparent;

            tabControl1.Visible = false;

            label11.Text = "Normal Yük";
            label12.Text = "Ağır Yük";
            label13.Text = "Manevra Kabiliyeti";
            label14.Text = "Yokuş Tırmanma";
            label15.Text = "Engebeli Arazi";

            label21.Text = "Normal Yük";
            label22.Text = "Ağır Yük";
            label23.Text = "Manevra Kabiliyeti";
            label24.Text = "Yokuş Tırmanma";
            label25.Text = "Engebeli Arazi";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //      DAF     //
            tabControl1.Visible = true;
            tabPage1.Text = "XF105";
            tabPage2.Text = "XF";
            Tır tır = new DAF(85,20,95,40,50);
            Tır tır2 = new DAF(85, 20, 95, 40, 50); 
            progressBar11.Value = tır.normalYuk;            
            progressBar12.Value = tır.agırYuk;
            progressBar13.Value = tır.manevra;
            progressBar14.Value = tır.yokusTırmanma;
            progressBar15.Value = tır.engebeliArazi;
            progressBar21.Value = tır2.normalYuk;                  
            progressBar22.Value = tır2.agırYuk; 
            progressBar23.Value = tır2.manevra;
            progressBar24.Value = tır2.yokusTırmanma;
            progressBar25.Value = tır2.engebeliArazi;
            tır.motorGucu();
            tır.motorTorku();
            tır.vitesAdedi();
            tır.benzinKapasite();
            tır.Fiyat();
            tır2.Fiyat(1299);
            tır2.benzinKapasite(1921);
            tır2.motorGucu(1453);
            tır2.motorTorku(1071);
            tır2.vitesAdedi(1967);
            label7.Text =tır.motorGuc.ToString()+" bg";
            label27.Text = tır2.motorGuc.ToString()+" bg";
            label8.Text = tır.motorTork.ToString() + " Nm";
            label28.Text = tır2.motorTork.ToString() + " Nm";
            label9.Text = tır.benzinKapasitesi.ToString() + " Litre";
            label29.Text = tır2.benzinKapasitesi.ToString() + " Litre";
            label10.Text = tır.vitesSayi.ToString();
            label30.Text = tır2.vitesSayi.ToString();
            label16.Text =tır.fiyati.ToString() + " €";
            label31.Text =tır2.fiyati.ToString() + " €";


            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\dafff.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\daffffff.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //      Iveco       //
            tabControl1.Visible = true;
            tabPage1.Text = "Stralis Active";
            tabPage2.Text = "Stralis Hi-Way";
            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\Ivecostralis.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\Ivecohiway.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Tır tır = new Iveco(90, 10, 96, 25, 50);
            Tır tır2 = new Iveco(83, 15, 90, 30, 48);

            tır.motorGucu();
            tır.motorTorku();
            tır.vitesAdedi();
            tır.benzinKapasite();
            tır.Fiyat();
            tır2.Fiyat(1299);
            tır2.benzinKapasite(1921);
            tır2.motorGucu(1453);
            tır2.motorTorku(1071);
            tır2.vitesAdedi(1967);
            progressBar11.Value = tır.normalYuk;
            progressBar12.Value = tır.agırYuk;
            progressBar13.Value = tır.manevra;
            progressBar14.Value = tır.yokusTırmanma;
            progressBar15.Value = tır.engebeliArazi;
            progressBar21.Value = tır2.normalYuk;
            progressBar22.Value = tır2.agırYuk;
            progressBar23.Value = tır2.manevra;
            progressBar24.Value = tır2.yokusTırmanma;
            progressBar25.Value = tır2.engebeliArazi;
            label7.Text = tır.motorGuc.ToString() + " bg";
            label27.Text = tır2.motorGuc.ToString() + " bg";
            label8.Text = tır.motorTork.ToString() + " Nm";
            label28.Text = tır2.motorTork.ToString() + " Nm";
            label9.Text = tır.benzinKapasitesi.ToString() + " Litre";
            label29.Text = tır2.benzinKapasitesi.ToString() + " Litre";
            label10.Text = tır.vitesSayi.ToString();
            label30.Text = tır2.vitesSayi.ToString();
            label16.Text = tır.fiyati.ToString() + " €";
            label31.Text = tır2.fiyati.ToString() + " €";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //      MAN     //
            tabControl1.Visible = true;
            tabPage1.Text = "TGX";
            tabPage2.Text = "TGX Euro 6";
            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\mantgxx.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\mantgxeuroo.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Tır tır = new MAN(90, 22, 95, 35, 50);
            Tır tır2 = new MAN(92, 18, 96, 41, 50);

            tır.motorGucu();
            tır.motorTorku();
            tır.vitesAdedi();
            tır.benzinKapasite();
            tır.Fiyat();
            tır2.Fiyat(1299);
            tır2.benzinKapasite(1921);
            tır2.motorGucu(1453);
            tır2.motorTorku(1071);
            tır2.vitesAdedi(1967);
            progressBar11.Value = tır.normalYuk;
            progressBar12.Value = tır.agırYuk;
            progressBar13.Value = tır.manevra;
            progressBar14.Value = tır.yokusTırmanma;
            progressBar15.Value = tır.engebeliArazi;
            progressBar21.Value = tır2.normalYuk;
            progressBar22.Value = tır2.agırYuk;
            progressBar23.Value = tır2.manevra;
            progressBar24.Value = tır2.yokusTırmanma;
            progressBar25.Value = tır2.engebeliArazi;
            label7.Text = tır.motorGuc.ToString() + " bg";
            label27.Text = tır2.motorGuc.ToString() + " bg";
            label8.Text = tır.motorTork.ToString() + " Nm";
            label28.Text = tır2.motorTork.ToString() + " Nm";
            label9.Text = tır.benzinKapasitesi.ToString() + " Litre";
            label29.Text = tır2.benzinKapasitesi.ToString() + " Litre";
            label10.Text = tır.vitesSayi.ToString();
            label30.Text = tır2.vitesSayi.ToString();
            label16.Text = tır.fiyati.ToString() + " €";
            label31.Text = tır2.fiyati.ToString() + " €";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //      Mercedes-Benz       //
            tabControl1.Visible = true;
            tabPage1.Text = "Actros";
            tabPage2.Text = "New Actros";
            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\acros.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\newacros.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Tır tır = new Mercedes(80, 20, 96, 40, 50);
            Tır tır2 = new Mercedes(85, 15, 95, 30, 50);

            tır.motorGucu();
            tır.motorTorku();
            tır.vitesAdedi();
            tır.benzinKapasite();
            tır.Fiyat();
            tır2.Fiyat(1299);
            tır2.benzinKapasite(1921);
            tır2.motorGucu(1453);
            tır2.motorTorku(1071);
            tır2.vitesAdedi(1967);
            progressBar11.Value = tır.normalYuk;
            progressBar12.Value = tır.agırYuk;
            progressBar13.Value = tır.manevra;
            progressBar14.Value = tır.yokusTırmanma;
            progressBar15.Value = tır.engebeliArazi;
            progressBar21.Value = tır2.normalYuk;
            progressBar22.Value = tır2.agırYuk;
            progressBar23.Value = tır2.manevra;
            progressBar24.Value = tır2.yokusTırmanma;
            progressBar25.Value = tır2.engebeliArazi;
            label7.Text = tır.motorGuc.ToString() + " bg";
            label27.Text = tır2.motorGuc.ToString() + " bg";
            label8.Text = tır.motorTork.ToString() + " Nm";
            label28.Text = tır2.motorTork.ToString() + " Nm";
            label9.Text = tır.benzinKapasitesi.ToString() + " Litre";
            label29.Text = tır2.benzinKapasitesi.ToString() + " Litre";
            label10.Text = tır.vitesSayi.ToString();
            label30.Text = tır2.vitesSayi.ToString();
            label16.Text = tır.fiyati.ToString() + " €";
            label31.Text = tır2.fiyati.ToString() + " €";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //      Renault     //
            tabControl1.Visible = true;
            tabPage1.Text = "Magnum";
            tabPage2.Text = "T";
            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\magnum.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\T.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Tır tır = new Renault(93, 25, 96, 60, 45);
            Tır tır2 = new Renault(85, 15, 95, 35, 50);

            tır.motorGucu();
            tır.motorTorku();
            tır.vitesAdedi();
            tır.benzinKapasite();
            tır.Fiyat();
            tır2.Fiyat(1299);
            tır2.benzinKapasite(1921);
            tır2.motorGucu(1453);
            tır2.motorTorku(1071);
            tır2.vitesAdedi(1967);
            progressBar11.Value = tır.normalYuk;
            progressBar12.Value = tır.agırYuk;
            progressBar13.Value = tır.manevra;
            progressBar14.Value = tır.yokusTırmanma;
            progressBar15.Value = tır.engebeliArazi;
            progressBar21.Value = tır2.normalYuk;
            progressBar22.Value = tır2.agırYuk;
            progressBar23.Value = tır2.manevra;
            progressBar24.Value = tır2.yokusTırmanma;
            progressBar25.Value = tır2.engebeliArazi;
            label7.Text = tır.motorGuc.ToString() + " bg";
            label27.Text = tır2.motorGuc.ToString() + " bg";
            label8.Text = tır.motorTork.ToString() + " Nm";
            label28.Text = tır2.motorTork.ToString() + " Nm";
            label9.Text = tır.benzinKapasitesi.ToString() + " Litre";
            label29.Text = tır2.benzinKapasitesi.ToString() + " Litre";
            label10.Text = tır.vitesSayi.ToString();
            label30.Text = tır2.vitesSayi.ToString();
            label16.Text = tır.fiyati.ToString() + " €";
            label31.Text = tır2.fiyati.ToString() + " €";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //      Scania      //
            tabControl1.Visible = true;
            tabPage1.Text = "Streamline";
            tabPage2.Text = "R";
            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\streamline.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\R.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Tır tır = new Scania(90, 10, 95, 25, 40);
            Tır tır2 = new Scania(88, 10, 96, 25, 45);

            tır.motorGucu();
            tır.motorTorku();
            tır.vitesAdedi();
            tır.benzinKapasite();
            tır.Fiyat();
            tır2.Fiyat(1299);
            tır2.benzinKapasite(1921);
            tır2.motorGucu(1453);
            tır2.motorTorku(1071);
            tır2.vitesAdedi(1967);
            progressBar11.Value = tır.normalYuk;
            progressBar12.Value = tır.agırYuk;
            progressBar13.Value = tır.manevra;
            progressBar14.Value = tır.yokusTırmanma;
            progressBar15.Value = tır.engebeliArazi;
            progressBar21.Value = tır2.normalYuk;
            progressBar22.Value = tır2.agırYuk;
            progressBar23.Value = tır2.manevra;
            progressBar24.Value = tır2.yokusTırmanma;
            progressBar25.Value = tır2.engebeliArazi;
            label7.Text = tır.motorGuc.ToString() + " bg";
            label27.Text = tır2.motorGuc.ToString() + " bg";
            label8.Text = tır.motorTork.ToString() + " Nm";
            label28.Text = tır2.motorTork.ToString() + " Nm";
            label9.Text = tır.benzinKapasitesi.ToString() + " Litre";
            label29.Text = tır2.benzinKapasitesi.ToString() + " Litre";
            label10.Text = tır.vitesSayi.ToString();
            label30.Text = tır2.vitesSayi.ToString();
            label16.Text = tır.fiyati.ToString() + " €";
            label31.Text = tır2.fiyati.ToString() + " €";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //      Volvo       //
            tabControl1.Visible = true;
            tabPage1.Text = "FH Classic";
            tabPage2.Text = "FH";
            pictureBox1.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\fhcla.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:\\Users\\ASUS\\Desktop\\Proje\\fh.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.BackColor = Color.Transparent;

            Tır tır = new Volvo(80, 20, 95, 45, 50);
            Tır tır2 = new Volvo(80, 20, 95, 45, 50);

            tır.motorGucu();
            tır.motorTorku();
            tır.vitesAdedi();
            tır.benzinKapasite();
            tır.Fiyat();
            tır2.Fiyat(1299);
            tır2.benzinKapasite(1921);
            tır2.motorGucu(1453);
            tır2.motorTorku(1071);
            tır2.vitesAdedi(1967);
            progressBar11.Value = tır.normalYuk;
            progressBar12.Value = tır.agırYuk;
            progressBar13.Value = tır.manevra;
            progressBar14.Value = tır.yokusTırmanma;
            progressBar15.Value = tır.engebeliArazi;
            progressBar21.Value = tır2.normalYuk;
            progressBar22.Value = tır2.agırYuk;
            progressBar23.Value = tır2.manevra;
            progressBar24.Value = tır2.yokusTırmanma;
            progressBar25.Value = tır2.engebeliArazi;
            label7.Text = tır.motorGuc.ToString() + " bg";
            label27.Text = tır2.motorGuc.ToString() + " bg";
            label8.Text = tır.motorTork.ToString() + " Nm";
            label28.Text = tır2.motorTork.ToString() + " Nm";
            label9.Text = tır.benzinKapasitesi.ToString() + " Litre";
            label29.Text = tır2.benzinKapasitesi.ToString() + " Litre";
            label10.Text = tır.vitesSayi.ToString();
            label30.Text = tır2.vitesSayi.ToString();
            label16.Text = tır.fiyati.ToString() + " €";
            label31.Text = tır2.fiyati.ToString() + " €";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Add(tabPage1.Text + "  " + label16.Text);
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            if (tabPage1.Text == "XF105")
                Tır.odeFiyat += 117270;
            if (tabPage1.Text == "Stralis Active")
                Tır.odeFiyat += 149260;
            if (tabPage1.Text == "TGX")
                Tır.odeFiyat += 99965;
            if (tabPage1.Text == "Actros")
                Tır.odeFiyat += 116005;
            if (tabPage1.Text == "Magnum")
                Tır.odeFiyat += 125785;
            if (tabPage1.Text == "Streamline")
                Tır.odeFiyat += 112615;
            if (tabPage1.Text == "FH Classic")
                Tır.odeFiyat += 113680;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            listBox1.Items.Add(tabPage2.Text + "  " + label31.Text);

            if (tabPage2.Text == "XF")
                Tır.odeFiyat += 127690;
            if (tabPage2.Text == "Stralis Hi-Way")
                Tır.odeFiyat += 157945;
            if (tabPage2.Text == "TGX Euro 6")
                Tır.odeFiyat += 109175;
            if (tabPage2.Text == "New Actros")
                Tır.odeFiyat += 118775;
            if (tabPage2.Text == "T")
                Tır.odeFiyat += 115213;
            if (tabPage2.Text == "R")
                Tır.odeFiyat += 117400;
            if (tabPage2.Text == "FH")
                Tır.odeFiyat += 114590;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            int secili = listBox1.SelectedIndex;
            if (secili != -1)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    if (listBox1.SelectedItems[i].ToString() == "XF105  117270 €")
                        Tır.odeFiyat -= 117270;
                    if (listBox1.SelectedItems[i].ToString() == "Stralis Actris  149260 €")
                        Tır.odeFiyat -= 149260;
                    if (listBox1.SelectedItems[i].ToString() == "TGX  99965 €")
                        Tır.odeFiyat -= 99965;
                    if (listBox1.SelectedItems[i].ToString() == "Actros  116005 €")
                        Tır.odeFiyat -= 116005;
                    if (listBox1.SelectedItems[i].ToString() == "Magnum  125785 €")
                        Tır.odeFiyat -= 125785;
                    if (listBox1.SelectedItems[i].ToString() == "Streamline  112615 €")
                        Tır.odeFiyat -= 112615;
                    if (listBox1.SelectedItems[i].ToString() == "FH Classic  113680 €")
                        Tır.odeFiyat -= 113680;
                    if (listBox1.SelectedItems[i].ToString() == "XF  127690 €")
                        Tır.odeFiyat -= 127690;
                    if (listBox1.SelectedItems[i].ToString() == "Stralis Hi-Way  157945 €")
                        Tır.odeFiyat -= 157945;
                    if (listBox1.SelectedItems[i].ToString() == "New Actros  118775 €")
                        Tır.odeFiyat -= 118775;
                    if (listBox1.SelectedItems[i].ToString() == "TGX Euro 6  109175 €")
                        Tır.odeFiyat -= 109175;
                    if (listBox1.SelectedItems[i].ToString() == "T  115213 €")
                        Tır.odeFiyat -= 115213;
                    if (listBox1.SelectedItems[i].ToString() == "R  117400 €")
                        Tır.odeFiyat -= 117400;
                    if (listBox1.SelectedItems[i].ToString() == "FH  114590 €")
                        Tır.odeFiyat -= 114590;
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                   if (listBox1.SelectedItems.Count == 0)
                    {
                        if (listBox1.Items.Count == 0)
                        {
                            listBox1.Visible = false;
                            button10.Visible = false;
                            button11.Visible = false;
                            button12.Visible = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sepetten kaldırılacak öğeyi seçiniz!");
            }   
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Tır.odeFiyat = 0;
            listBox1.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            int sepetIci = listBox1.Items.Count;
            if (sepetIci  != 0)
            {  
                bool donen = Tır.satinAl(listBox1.Items.Count);
                if (donen == true)
                {
                    StringBuilder str = new StringBuilder();
                    foreach (object selectedItem in listBox1.Items)
                    {
                        str.AppendLine(selectedItem.ToString());
                    }
                    MessageBox.Show("Bu Tırları Sipariş Ettiniz: " 
                        + Environment.NewLine + str 
                        + "Ödeyeceğiniz Toplam Tutar : " + Tır.odeFiyat.ToString() + " €");
                    listBox1.Items.Clear();
                    Tır.odeFiyat = 0;
                }
            }
            //else MessageBox.Show("Sepetinizde tır bulunmamaktadır!");
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            listBox1.Visible = false;
        }
    }
}