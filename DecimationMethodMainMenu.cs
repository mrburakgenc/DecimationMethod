using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decimation_Method_v2
{
    public partial class DecimationMethodMainMenu : Form
    {
        public static string mesaj, yedekalfabe = "";
        public static char[] harfdizisi;
        public static char[] ingilizcealfabe = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static char[] turkcealfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
        public static char[] yedekturkcealfabe;
        public static char[] yedekingilizcealfabe;
        public static char[] anahtarkelime;
        public static char[] transferalfabe;
        public static char[] transferalfabeson;
        public static char[] transferalfabeson2;
        public static char[] yedektransfer;
        public static int transferalfabesira = 0;
        public static char[] mesajdizisi;
        public static int geriyekalan;
        public static string kullanicimesaji;
        public static int harfsirasi = 0;
        public static int harfsirasi2 = 0;
        public static int rota = 0;
        public static int kontrol = 0;
        public static int transferkontrol = 0;
        public static int toplamharf = 0;
        public static bool whiledurum = true;
        public static string transfer;
        public static string transfer2;
        public static char[] transferarray;
        public static int temp1;
        public static int gecici = 0;

        public DecimationMethodMainMenu()
        {
            InitializeComponent();
        }
        /* Fonksiyonlar Start */
        
        /* Anahtar Alfabeyi Oluşturmak İçin Gerekli Fonksiyonlar */


        //Adım 1 Aynı Harfleri Elimine Etme 
        public static void IlkEliminasyon(int temp1)
        {
            for (int i = 0; i < anahtarkelime.Length; i++)
            {
                for (int j = 0; j < anahtarkelime.Length; j++)
                {

                    if (anahtarkelime[j] == anahtarkelime[i] && j != i && anahtarkelime[i] != ' ' && anahtarkelime[j] != ' ')
                    {
                        anahtarkelime[j] = ' ';
                    }
                }
            }
            for (int i = 0; i < anahtarkelime.Length; i++)
            {
                if (anahtarkelime[i] != ' ')
                {
                    transfer = transfer + anahtarkelime[i];
                }
            }
            transferarray = transfer.ToCharArray();
            toplamharf = transferarray.Length;
            transferalfabeson = new char[transferarray.Length];


            temp1 = temp1 - 1;

            while (toplamharf >= temp1 + 1)
            {
                transferalfabeson[gecici] = transferarray[temp1];
                Array.Clear(transferarray, temp1, 1);
                kaydir(temp1);
                gecici++;
                toplamharf--;
            }
            for (int i = 0; i < transferarray.Length; i++)
            {
                transferalfabeson[gecici] = transferarray[i];
                gecici++;
            }
        }
        // Adım 2 Şeçilen Dil'e Göre Alfabeyi Oluşturma
        public static void AlfabeOlusturma(string Hedef)
        {
            if (Hedef == "İngilizce")
            {

                for (int i = 0; i < ingilizcealfabe.Length; i++)
                {
                    yedekingilizcealfabe[i] = ingilizcealfabe[i];

                }
                for (int i = 0; i < transferalfabeson.Length; i++)
                {
                    for (int j = 0; j < yedekingilizcealfabe.Length; j++)
                    {
                        if (transferalfabeson[i] == yedekingilizcealfabe[j])
                        {
                            yedekingilizcealfabe[j] = ' ';
                        }

                    }
                }
                transferalfabeson2 = new char[ingilizcealfabe.Length];
                for (int i = 0; i < transferalfabeson.Length; i++)
                {
                    transferalfabeson2[i] = transferalfabeson[i];
                }
                for (int i = 0; i < transferalfabeson2.Length; i++)
                {
                    if (transferalfabeson2[i] != yedekingilizcealfabe[i] && yedekingilizcealfabe[i] != ' ')
                    {
                        transferalfabeson2[gecici] = yedekingilizcealfabe[i];
                        gecici++;
                    }
                }
                //Alfabe Listeleme
                for (int i = 0; i < ingilizcealfabe.Length; i++)
                {
                    yedekalfabe = yedekalfabe + ingilizcealfabe[i];
                }
                MessageBox.Show("İngilizce Alfabe..:" + yedekalfabe);
                yedekalfabe = "";
                for (int i = 0; i < transferalfabeson2.Length; i++)
                {
                    yedekalfabe = yedekalfabe + transferalfabeson2[i];
                }
                MessageBox.Show("Şifreli İngilizce Alfabe..:" + yedekalfabe);
                kontrol = 0;
            }
            else
            {

                for (int i = 0; i < turkcealfabe.Length; i++)
                {
                    yedekturkcealfabe[i] = turkcealfabe[i];

                }
                for (int i = 0; i < transferalfabeson.Length; i++)
                {
                    for (int j = 0; j < yedekturkcealfabe.Length; j++)
                    {
                        if (transferalfabeson[i] == yedekturkcealfabe[j])
                        {
                            yedekturkcealfabe[j] = ' ';
                        }

                    }
                }
                transferalfabeson2 = new char[turkcealfabe.Length];
                for (int i = 0; i < transferalfabeson.Length; i++)
                {
                    transferalfabeson2[i] = transferalfabeson[i];
                }
                for (int i = 0; i < transferalfabeson2.Length; i++)
                {
                    if (transferalfabeson2[i] != yedekturkcealfabe[i] && yedekturkcealfabe[i] != ' ')
                    {
                        transferalfabeson2[gecici] = yedekturkcealfabe[i];
                        gecici++;
                    }
                }
                //Alfabe Listeleme
                for (int i = 0; i < turkcealfabe.Length; i++)
                {
                    yedekalfabe = yedekalfabe + turkcealfabe[i];
                }
                MessageBox.Show("Türkçe Alfabe..:" + yedekalfabe);
                yedekalfabe = "";
                for (int i = 0; i < transferalfabeson2.Length; i++)
                {
                    yedekalfabe = yedekalfabe + transferalfabeson2[i];
                }
                MessageBox.Show("Şifreli Türkçe Alfabe..:" + yedekalfabe);
                kontrol = 0;
            }

        }

        //Dizi Kaydırma 
        public static void kaydir(int baslangic)
        {
            char harf;
            char[] yedekdizi = new char[transferarray.Length];
            int sira = 0;
            int sirakontrol = 0;

            for (int i = baslangic; i < transferarray.Length - 1; i++)
            {
                harf = transferarray[i + 1];
                transferarray[i] = harf;
                yedekdizi[sira] = harf;
                sira++;
            }
            sirakontrol = transferarray.Length - sira;
            for (int i = 0; i < sirakontrol; i++)
            {
                yedekdizi[sira] = transferarray[i];
                sira++;
            }
            transferarray = new char[yedekdizi.Length - 1];
            for (int i = 0; i < transferarray.Length; i++)
            {
                transferarray[i] = yedekdizi[i];
            }

        }

        /* Anahtar Alfabeyi Oluşturmak İçin Gerekli Fonksiyonlar Bitti */
       
        public static void Temizle()
        {

            harfdizisi = new char[1];
            anahtarkelime = new char[1];
            transferalfabe = new char[1];
            transferalfabeson = new char[1];
            mesajdizisi = new char[1];
            transferarray = new char[1];
            harfsirasi = 0;
            harfsirasi2 = 0;
            kontrol = 0;
            transferkontrol = 0;
            geriyekalan = 0;
            transferalfabesira = 0;
            toplamharf = 0;
            transfer = "";
            mesaj = "";
            kullanicimesaji = "";
            yedekalfabe = "";
            whiledurum = true;
            temp1 = 0;
            gecici = 0;
        }

        /*- Fonksiyonlar Stop -*/

        /*İşlem Butonu */
        private void AssignBut_Click(object sender, EventArgs e)
        {
            if (MessageInputRich.Text == "" && MessageOfKeyAlphabet.Text == "" && LanguageOptionCom.SelectedItem == "" && OddIntervalCom.SelectedItem == "")
            {
                MessageBox.Show("Alanları Doldurun..");
            }

            else
            {
                anahtarkelime = MessageOfKeyAlphabet.Text.ToCharArray();
                mesajdizisi = MessageInputRich.Text.ToCharArray();
                IlkEliminasyon(Convert.ToInt32(OddIntervalCom.SelectedItem));
                if (LanguageOptionCom.SelectedItem == "Türkçe")
                {
                    yedekturkcealfabe = new char[turkcealfabe.Length];
                    AlfabeOlusturma("Türkçe");
                    if (EncryptionRadio.Checked == true)
                    {
                        harfdizisi = MessageInputRich.Text.ToCharArray();
                        //Türkçe Şifreleme
                        for (int i = 0; i < harfdizisi.Length; i++)
                        {
                            for (int j = 0; j < transferalfabeson2.Length; j++)
                            {
                                if (harfdizisi[i] == turkcealfabe[j])
                                {
                                    rota = j;
                                }
                            }
                            MessageOutputRich.Text = MessageOutputRich.Text + transferalfabeson2[rota];
                        }
                        
                    }
                    else if (DecryptionRadio.Checked == true)
                    {
                        harfdizisi = MessageInputRich.Text.ToCharArray();
                        //Türkçe Deşifreleme
                        for (int i = 0; i < harfdizisi.Length; i++)
                        {
                            for (int j = 0; j < transferalfabeson2.Length; j++)
                            {
                                if (harfdizisi[i] == transferalfabeson2[j])
                                {
                                    rota = j;
                                }
                            }
                            MessageOutputRich.Text = MessageOutputRich.Text + turkcealfabe[rota];
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("ilk Temizle Butonunu Kullanın.. Sonra Yapılacak Yöntemi Şeçmeyi Unutmayın...");
                        
                    }

                }
                else
                {
                    yedekingilizcealfabe = new char[ingilizcealfabe.Length];
                    AlfabeOlusturma("İngilizce");
                    if (LanguageOptionCom.SelectedItem == "İngilizce")
                    {
                        if (EncryptionRadio.Checked == true)
                        {
                            harfdizisi = MessageInputRich.Text.ToCharArray();
                            //İngilizce Şifreleme
                            for (int i = 0; i < harfdizisi.Length; i++)
                            {
                                for (int j = 0; j < transferalfabeson2.Length; j++)
                                {
                                    if (harfdizisi[i] == ingilizcealfabe[j])
                                    {
                                        rota = j;
                                    }
                                }
                                MessageOutputRich.Text = MessageOutputRich.Text + transferalfabeson2[rota];
                            }
                            

                        }
                        else if (DecryptionRadio.Checked == true)
                        {
                            harfdizisi = MessageInputRich.Text.ToCharArray();
                            //İngilizce Deşifreleme
                            for (int i = 0; i < harfdizisi.Length; i++)
                            {
                                for (int j = 0; j < transferalfabeson2.Length; j++)
                                {
                                    if (harfdizisi[i] == transferalfabeson2[j])
                                    {
                                        rota = j;
                                    }
                                }
                                MessageOutputRich.Text = MessageOutputRich.Text + ingilizcealfabe[rota];
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("ilk Temizle Butonunu Kullanın.. Sonra Yapılacak Yöntemi Şeçmeyi Unutmayın...");
                            
                        }
                    }
                }
            }
        }

        /* İşlem Buton Son*/
       
        /* - Not Serious But Important Bölümü -*/
        
       
        private void HowToBut_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Decimation Method(Cipher)..: Yöntem Kısaca Bakıldığında Verilen Anahtar Kelime veya Mesaj İle Şifre Alfabe Oluşturulup O Alfabe İle Kelimedeki veya Mesajdaki Her Harf Teker Teker Şifre Alfabede Karışılık Gelen Harf ile Şifrelenir");
            MessageBox.Show("Decimation Method(Cipher)..: Şifre Alfabe Oluşturulken, Ele Alınan Anahtar Mesaj(Kelime veya Metin) Öncelikle Kendi İçindeki Tekrar Eden Harfler Çıkartılıp Sonra İstenilen Tek Sayı(Odd Interval)ya Göre Tekrar Sıralanır");
            MessageBox.Show("Decimation Method(Cipher)..: Örneğin Anahtar Mesajımız 'salsa' Olsun Burada Tekrar Eden Harfler 4. ve 5. Harfler Olan 's ve a' Harfleri Çıkartılır..");
            MessageBox.Show("Decimation Method(Cipher)..: Daha Sonra Şeçilen Tek Sayı=3 Olduğunu Düşünelim 'salsa' Kelimesinden Kalan Harflerinin('s a l') 3.Harfi 'l' Harfi Başa Getirilir, Ancak Belirtililen Sayıya Denk Gelen Başka Harf Kalmadığından geriye kalan harfler Tek Sayıya Eşit Olmadığından 'lsa' Olarak Sıralanıp Ardından Eksik Olan Alfabe Harfleri Eklenir");
            MessageBox.Show("Decimation Method(Cipher)..: Sıralamanın Nasıl Çalıştığının Anlaşılması İçin Başka Bir Örnek Verecek Olursak Mesajı 'burak' Diye Ele Alalım");
            MessageBox.Show("Decimation Method(Cipher)..: 'burak' Kelimesinde Mesajında Tekrar Eden Harf Olmadığı İçin Herhangi Tekrar Eden Harf Elemesi Yapmıyoruz. ");
            MessageBox.Show("Decimation Method(Cipher)..: Şeçtiğimiz Tek Sayı(Odd Interval) Yine 3 Olsun İlk Adımda Mesajın 3. Harfi 'r' Harfini Mesajdan Çıkartıp Şifre Alfabenin İlk Elemanı Olarak Ekliyoruz");
            MessageBox.Show("Decimation Method(Cipher)..: Daha Sonra, Çıkarttığımız Harften Sonrasını('a') Başlayarak Sayarken Mesajın Sonunada Geldiğimizde Tekrar Mesajın Baştaki Harfine Dönerek Devam Ediyoruz Bu Yöntemde Devam Ederken Bir Sonraki 3. harfi 'b' Bir Sonraki 3. Harfi 'k' Olarak Buluruz ve Geriye Kalan Harfleri Sıranın Sonuna Ekliyoruz. ");
            MessageBox.Show("Decimation Method(Cipher)..: Dipnot: Odd Interval'i mesaj harflerinden Yüksek Girildiği Takdirde Varsa Tekrar Eden Harfler Çıkartılır Harf Harf Şifre Alfabeye Eklenir, Eğerki Tekrar Eden Harfler Yoksa Mesaj Şifre Harf Harf Alfabede Aynen Sıralanır.. ");
            MessageBox.Show("Decimation Method(Cipher)..: Harf Sıralamasını Yaptıktan Sonra Alfabenin Eksik Kalan Harflerini Şifre Alfabeye Ekliyoruz.");
            MessageBox.Show("Decimation Method(Cipher)..: İlk Önce İstenilen Dilin Alfabesi Yan Yana Yazılır Ardından Şifre Alfabe Altına Aynen Yazılır ");
            MessageBox.Show("Decimation Method(Cipher)..: Şifreleme Esnasında Mesajı Harf Harf Ayırarak Şifrelenecek Harf Dil Alfabesinde Bulunup Altındaki Şifre Alfabedeki Harf İle Şifrelenir..");
            MessageBox.Show("Decimation Method(Cipher)..: Deşifre işleminde Şifre Alfabe Aynen Şifreleme İşlemindeki Gibi Oluşturulur Daha Sonra İlk Şifre Alfabe Yan Yana Yazılır Altına İstenilen Dilin Alfabesi Aynen Yazılır.. ");
            MessageBox.Show("Decimation Method(Cipher)..: Deşifreleme Esnasında Mesajı Harf Harf Ayırarak Şifrelenecek Şifre Alfabesinde Bulunup Altındaki Dil Alfabedeki Harf İle Deşifrelenir..");

        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            Temizle();
            MessageOutputRich.Text = "";
        }
    }
}
