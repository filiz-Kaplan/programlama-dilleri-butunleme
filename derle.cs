using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace programlama_dilleri_bütünleme
{
    public class derle
    {
        string kod;
       
        public string uyari="";
        public derle(string kod)
        {
            this.kod = kod.ToLower();
        }
        public void islem()
        {
            kod = kod.Trim().Replace(" ", string.Empty);
            char[] veri = kod.ToCharArray();
            int t_sayi = 0;//t harfinin toplam miktarı
            int f_sayi = 0;//f harfinin toplam miktarı
            int c_sayi = 0;//ç harfinin toplam miktarı
            int b_sayi = 0;//b harfinin toplam miktarı
            int p_sayi = 0;//p harfinin toplam miktarı
            for (int j = 0; j < kod.Length; i++)
            {
                if (veri[j]=='t')
                {
                    t_sayi++;

                }
                else if (veri[j]=='f')
                {
                    f_sayi++;
                }
                else if (veri[j] == 'ç')
                {
                    c_sayi++;
                }
                else if (veri[j] == 'b')
                {
                    b_sayi++;
                }
                else if (veri[j] == 'p')
                {
                    p_sayi++;
                }
                
            }
            if (t_sayi%2==1&f_sayi%2==1&c_sayi%2==1&b_sayi%2==1&p_sayi%2==1)
            {
                uyari += "--> t,f,ç,b,p harfleri gereğinden eksik veya fazla kullanıldı/n";
            }
            else
            {
                string[] oprt = { "t", "f", "ç", "b"};
                Regex sayi = new Regex("^[0-9]*$");
                public int islem_sonuc = 0;
                foreach (string op in oprt)
                {
                    int indis = kod.IndexOf(op);
                    if (indis != -1)
                    {
                        string eleman="";
                        for (int i = indis + 1; i < kod.Length; i++)
                        {
                            if (Convert.ToBoolean(sayi.IsMatch(Convert.ToString(veri[indis + 1]))) | veri[indis + 1] == 's')
                            {
                                eleman += veri[i];
                                if (veri[i] == ',')
                                {
                                    eleman = eleman.Substring(0, eleman.Length - 1);

                                    if (sayi.IsMatch(Convert.ToString(veri[i + 1])))
                                    {
                                        if ((veri[i] == Convert.ToChar(op) & veri[i + 1] != ','))
                                        {
                                            if (op == "t")
                                            {
                                                islem_sonuc += Convert.ToInt32(eleman);
                                                eleman = "";
                                            }
                                            else if (op == "f")
                                            {
                                                islem_sonuc -= Convert.ToInt32(eleman);
                                                eleman = "";
                                            }
                                            else if (op == "ç")
                                            {
                                                islem_sonuc *= Convert.ToInt32(eleman);
                                                eleman = "";
                                            }
                                            else if (op == "b")
                                            {
                                                islem_sonuc /= Convert.ToInt32(eleman);
                                                eleman = "";
                                            }

                                        }
                                     

                                        else if ((veri[i] != Convert.ToChar(op) & veri[i + 1] != ','))
                                        {
                                            uyari += "--> " + op + " işleminin içinde ayrı bir işlem gerçekleştiremezsiniz";
                                        }
                                    }
                                    else if (veri[indis + 1] == 'p')
                                    {
                                        if (Convert.ToBoolean(sayi.IsMatch(Convert.ToString(veri[indis + 1]))) | veri[indis + 1] == 's')
                                        {
                                            eleman += veri[i];
                                            if (veri[i] == ',')
                                            {
                                                eleman = eleman.Substring(0, eleman.Length - 1);

                                                if (sayi.IsMatch(Convert.ToString(veri[i + 1])))
                                                {
                                                    if ((veri[i] == Convert.ToChar(op) & veri[i + 1] != ','))
                                                    {
                                                        if (op == "t")
                                                        {
                                                            islem_sonuc += Convert.ToInt32(eleman);
                                                            eleman = "";
                                                        }
                                                        else if (op == "f")
                                                        {
                                                            islem_sonuc -= Convert.ToInt32(eleman);
                                                            eleman = "";
                                                        }
                                                        else if (op == "ç")
                                                        {
                                                            islem_sonuc *= Convert.ToInt32(eleman);
                                                            eleman = "";
                                                        }
                                                        else if (op == "b")
                                                        {
                                                            islem_sonuc /= Convert.ToInt32(eleman);
                                                            eleman = "";
                                                        }

                                                    }

                                                    else if ((veri[i] != Convert.ToChar(op) & veri[i + 1] != ','))
                                                    {
                                                        uyari += "--> " + op + " işleminin içinde ayrı bir işlem gerçekleştiremezsiniz";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            
                        }   
                    }
                }
            }
            

        }
    }
}
















