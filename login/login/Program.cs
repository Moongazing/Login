using System;

namespace login
{

    class Uye
    {
        string kullaniciAdi, kullaniciSifre;
        public bool kontrol;

        public string ka
        {

            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        Console.Write("Girdiğiniz isim uygun değil!");
                        kontrol = false;
                        return;
                    }
                }
                kontrol = true;
                kullaniciAdi = value;
            }
            get { return kullaniciAdi; }

        }
        public string ks
        {
            get { return kullaniciSifre; }
            set { kullaniciSifre = value; }
        }
        public bool OturumKontrol()
        {
            if (kullaniciAdi == "root" && kullaniciSifre == "1234") return true;
            else return false;
                
        }

      }
    












    class Program
    {
        static void Main(string[] args)
        {
            Uye u1 = new Uye();
            do
            {
                Console.WriteLine("Kullanıcı Adını Giriniz:");
                u1.ka = Console.ReadLine();
                if (u1.kontrol==false) { Console.WriteLine("Tekrar"); } 
                
            }
            
            while (u1.kontrol == false);
            {
                Console.WriteLine("Şifrenizi Giriniz:");
                u1.ks = Console.ReadLine();
                Console.WriteLine("Kullanıcı Adı:{0}", u1.ka);
                Console.WriteLine("Şifre:{0}",u1.ks);
                if(u1.OturumKontrol())
                {
                    Console.WriteLine("Oturum Açıldı,Hoşgeldiniz {0}", u1.ka);
                }
                else
                {
                    Console.WriteLine("Kullanıcı Adı veya Şifre Yanlış!");
                }
                Console.ReadKey();


            }
        }
    }

}

