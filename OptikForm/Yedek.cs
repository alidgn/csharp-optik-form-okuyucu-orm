//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OptikForm
//{
//    class Yedek
//    {
//    }
//}
//private void pictureBox1_SizeChanged(object sender, EventArgs e)
//{
//    label1.Text = "Genişlik: " + pictureBox1.Width.ToString();
//    label2.Text = "Yükseklik: " + pictureBox1.Height.ToString();
//}
//private void pictureBox1_MouseHover(object sender, EventArgs e)
//{

//}

//private void ad_oku_Click(object sender, EventArgs e)
//{
//    int x = 61;
//    int y = 102;
//    int oran = 11;
//    int tekrar = 29;
//    int tekrar_sag = 10;
//    int count = 0;
//    Color c;
//    int red, green, blue;

//    List<string> dizi = new List<string>(new string[] {
//        "A", "B", "C","Ç","D","E","F","G","Ğ","H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T","U","Ü","V","Y","Z"
//    });

//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar; j++)
//        {

//            c = resim.GetPixel(x, y);
//            red = c.R;
//            green = c.G;
//            blue = c.B;
//            int w = 102;
//            if ((0 <= red && red < 127) || (0 <= green && green < 127) || (0 <= blue && blue < 127))
//            {
//                // x : 83 , y: 223
//                //richTextBox1.Text += x + " , " + y + " -> " + red + " , " + green + " , " + blue + "\n";

//                for (int a = 0; a < tekrar_sag; a++)
//                {
//                    for (int b = 0; b < tekrar; b++)
//                    {
//                        if (y == w)
//                        {
//                            //txt.Text += dizi[count];
//                            txt_ad.Text += dizi[count];

//                        }
//                        count++;
//                        w += oran;
//                    }
//                    count = 0;
//                }

//            }
//            y += oran;
//        }
//        y = Convert.ToInt32(txt_y.Text);
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }
//}
//private void soyad_oku_Click(object sender, EventArgs e, int x,int y, int oran, int tekrar_asagi, int tekrar_sag,int count)
//{
//    //int x = 61;
//    //int y = 451;
//    //int oran = 11;
//    //int tekrar = 29;
//    //int tekrar_sag = 10;
//    //int count = 0;
//    Color c;
//    int red, green, blue;
//    label2.Text = "SOYADI: ";
//    List<string> dizi = new List<string>(new string[] {
//        "A", "B", "C","Ç","D","E","F","G","Ğ","H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T","U","Ü","V","Y","Z",
//        "0","1","2","3","4","5","6","7","8","9",""
//    });

//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar_asagi; j++)
//        {

//            c = resim.GetPixel(x, y);
//            red = c.R;
//            green = c.G;
//            blue = c.B;
//            int w = 451;
//            if ((0 <= red && red < 127) || (0 <= green && green < 127) || (0 <= blue && blue < 127))
//            {
//                // x : 83 , y: 223
//                richTextBox1.Text += x + " , " + y + " -> " + red + " , " + green + " , " + blue + "\n";

//                for (int a = 0; a < tekrar_sag; a++)
//                {
//                    for (int b = 0; b < tekrar_asagi; b++)
//                    {
//                        if (y == w)
//                        {
//                            //label2.Text += dizi[count];
//                            txt_soyad.Text += dizi[count];

//                        }
//                        count++;
//                        w += oran;
//                    }
//                    count = 0;
//                }

//            }
//            y += oran;
//        }
//        y = 451;
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }
//}
//private void tc_oku_Click(object sender, EventArgs e)
//{
//    richTextBox1.Clear();
//    int x = 225;
//    int y = 102;
//    int oran = 11;
//    int tekrar_asagi = 10;
//    int tekrar_sag = 11;
//    int count = 0;
//    Color c;
//    int red, green, blue;
//    label4.Text = "TC: ";
//    List<string> dizi = new List<string>(new string[] {                
//        "0","1","2","3","4","5","6","7","8","9",""
//    });

//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar_asagi; j++)
//        {

//            c = resim.GetPixel(x, y);
//            red = c.R;
//            green = c.G;
//            blue = c.B;
//            int w = 102;
//            if ((0 <= red && red < 127) || (0 <= green && green < 127) || (0 <= blue && blue < 127))
//            {
//                // x : 225 , y: 157
//                richTextBox1.Text += x + " , " + y + " -> " + red + " , " + green + " , " + blue + "\n";

//                for (int a = 0; a < tekrar_sag; a++)
//                {
//                    for (int b = 0; b < tekrar_asagi; b++)
//                    {
//                        if (y == w)
//                        {
//                            txt_tc.Text += dizi[count];
//                        }
//                        count++;
//                        w += oran;
//                    }
//                    count = 0;
//                }

//            }
//            y += oran;
//        }
//        y = 102;
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }
//}
//private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
//{
//    this.Cursor = new Cursor(Cursor.Current.Handle);
//    int xCoordinate = Cursor.Position.X;
//    int yCoordinate = Cursor.Position.Y;
//    label3.Text = "x: " + xCoordinate + " y: " + yCoordinate;
//}

//private void button1_Click(object sender, EventArgs e)
//{
//    int Red, Green, Blue, ort;
//    Color c;
//    for (int i = 0; i < pictureBox1.Width; i++)
//    {
//        for (int j = 0; j < pictureBox1.Height; j++)
//        {
//            c = resim.GetPixel(i, j);
//            Red = c.R;
//            Blue = c.B;
//            Green = c.G;
//            ort = (Red + Green + Blue) / 3;
//            resim.SetPixel(i, j, Color.FromArgb(ort, ort, ort));
//        }
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }

//}

//private void button2_Click(object sender, EventArgs e)
//{
//    int x = 61;
//    int y = 102;
//    int oran = 11;
//    int tekrar = 29;
//    int tekrar_sag = 10;
//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar; j++)
//        {
//            resim.SetPixel(x, y, Color.FromArgb(255, 0, 0));
//            richTextBox1.Text += x + " " + y + "\n";
//            y += oran;
//        }
//        y = Convert.ToInt32(txt_y.Text);
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }

//}
//private void button6_Click(object sender, EventArgs e)
//{
//    int x = 61;
//    int y = 451;
//    int oran = 11;
//    int tekrar = 29;
//    int tekrar_sag = 10;
//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar; j++)
//        {
//            resim.SetPixel(x, y, Color.FromArgb(255, 0, 0));
//            richTextBox1.Text += x + " " + y + "\n";
//            y += oran;
//        }
//        y = 451;
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }
//}
//private void tc_nokta_Click(object sender, EventArgs e)
//{
//    int x = 225;
//    int y = 102;
//    int oran = 11;
//    int tekrar_asagi = 10;
//    int tekrar_sag = 11;
//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar_asagi; j++)
//        {
//            resim.SetPixel(x, y, Color.FromArgb(255, 0, 0));
//            richTextBox1.Text += x + " " + y + "\n";
//            y += oran;
//        }
//        y = Convert.ToInt32(txt_y.Text);
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }

//}

//private void tr_nokta_Click(object sender, EventArgs e)
//{
//    int x = 279;
//    int y = 277;
//    int oran = 11;
//    int tekrar_asagi = 20;
//    int tekrar_sag = 4;
//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar_asagi; j++)
//        {
//            resim.SetPixel(x, y, Color.FromArgb(255, 0, 0));
//            richTextBox1.Text += x + " " + y + "\n";
//            y += oran;
//        }
//        y = 277;
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }
//}
//private void mat_nokta_Click(object sender, EventArgs e)
//{
//    int x = 356;
//    int y = 277;
//    int oran = 11;
//    int tekrar_asagi = 20;
//    int tekrar_sag = 4;
//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar_asagi; j++)
//        {
//            resim.SetPixel(x, y, Color.FromArgb(255, 0, 0));
//            richTextBox1.Text += x + " " + y + "\n";
//            y += oran;
//        }
//        y = 277;
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }
//}
//private void ing_nokta_Click(object sender, EventArgs e)
//{

//    int x = 433;
//    int y = 277;
//    int oran = 11;
//    int tekrar_asagi = 20;
//    int tekrar_sag = 4;

//    for (int i = 0; i < tekrar_sag; i++)
//    {
//        for (int j = 0; j < tekrar_asagi; j++)
//        {
//            resim.SetPixel(x, y, Color.FromArgb(255, 0, 0));
//            richTextBox1.Text += x + " " + y + "\n";
//            y += oran;
//        }
//        y = 277;
//        x += oran;
//        pictureBox1.Image = resim;
//        this.Refresh();
//    }
//}
//private void TR_oku_Click(object sender, EventArgs e)
//{
//    richTextBox1.Clear();
//    int x = 279;
//    int y = 277;
//    int oran = 11;
//    int tekrar_asagi = 20;
//    int tekrar_sag = 4;
//    int count = 0;
//    Color c;
//    int red, green, blue;
//    label4.Text = "TC: ";
//    List<string> cevap_anahtari = new List<string>(new string[] {
//        "A","A","A","A","A","B","B","B","B","B","C","C","C","C","C","D","D","D","D","D"
//    });

//    List<string> cevaplar = new List<string>();
//    int soru = 1;
//    int kontrol = 0;

//    for (int i = 0; i < tekrar_asagi; i++)
//    {
//        for (int j = 0; j < tekrar_sag; j++)
//        {
//            //279,277
//            c = resim.GetPixel(x, y);
//            red = c.R;
//            green = c.G;
//            blue = c.B;
//            //int w = 279;

//            if ((0 <= red && red < 127) || (0 <= green && green < 127) || (0 <= blue && blue < 127))
//            {
//                if (kontrol < 2)
//                {
//                    kontrol++;
//                    //richTextBox1.Text += x + " , " + y + " -> " + red + " , " + green + " , " + blue + "\n";
//                    //label4.Text += "\n" + soru + ". " + secenekler[count];
//                    cevaplar.Add(secenekler[count]);
//                    //soru++;

//                }
//                if(kontrol == 2) {
//                    //label4.Text += "\n" + soru + ". " + secenekler[5];
//                    cevaplar.RemoveAt(cevaplar.Count - 1);
//                    cevaplar.RemoveAt(cevaplar.Count - 1);
//                    cevaplar.Add(secenekler[5]);
//                    //soru++;
//                }

//            }
//            if (j == 3)
//            {
//                if (kontrol == 0)
//                {
//                    cevaplar.Add(secenekler[4]);
//                    //label4.Text += "\n" + soru + ". " + secenekler[4];
//                    //soru++;
//                }
//            }
//            //if (kontrol > 1)
//            //{
//            //    label4.Text += "\n" + soru + ". " + secenekler[5];
//            //    soru++;
//            //}
//            x += oran;
//            count++;
//        }
//        kontrol = 0;
//        x = 279;
//        y += oran;
//        count = 0;
//    }

//    int h = 1;
//    foreach (var item in cevaplar)
//    {
//        rich_tr_kisi.Text += "\n" + h + ". " + item;
//        h++;
//    }
//    int z = 1;
//    foreach (var item in cevap_anahtari)
//    {
//        rich_tr_cevap.Text += "\n" + z + ". " + item;
//        z++;
//    }

//}
//private void mat_oku_Click(object sender, EventArgs e)
//{
//    richTextBox1.Clear();
//    int x = 356;
//    int y = 277;
//    int oran = 11;
//    int tekrar_asagi = 20;
//    int tekrar_sag = 4;
//    int count = 0;
//    Color c;
//    int red, green, blue;
//    label4.Text = "TC: ";
//    List<string> cevap_anahtari = new List<string>(new string[] {
//        "A","A","A","A","A","B","B","B","B","B","C","C","C","C","C","D","D","D","D","D"
//    });
//    List<string> secenekler = new List<string>(new string[] {
//        "A","B","C","D","BOS","GECERSIZ"
//    });
//    List<string> cevaplar = new List<string>();
//    //int soru = 1;
//    int kontrol = 0;

//    for (int i = 0; i < tekrar_asagi; i++)
//    {
//        for (int j = 0; j < tekrar_sag; j++)
//        {
//            //279,277
//            c = resim.GetPixel(x, y);
//            red = c.R;
//            green = c.G;
//            blue = c.B;
//            //int w = 279;

//            if ((0 <= red && red < 127) || (0 <= green && green < 127) || (0 <= blue && blue < 127))
//            {
//                if (kontrol < 2)
//                {
//                    kontrol++;
//                    //richTextBox1.Text += x + " , " + y + " -> " + red + " , " + green + " , " + blue + "\n";
//                    //label4.Text += "\n" + soru + ". " + secenekler[count];
//                    cevaplar.Add(secenekler[count]);
//                    //soru++;

//                }
//                if (kontrol == 2)
//                {
//                    //label4.Text += "\n" + soru + ". " + secenekler[5];
//                    cevaplar.RemoveAt(cevaplar.Count - 1);
//                    cevaplar.RemoveAt(cevaplar.Count - 1);
//                    cevaplar.Add(secenekler[5]);
//                    //soru++;
//                }

//            }
//            if (j == 3)
//            {
//                if (kontrol == 0)
//                {
//                    cevaplar.Add(secenekler[4]);
//                    //label4.Text += "\n" + soru + ". " + secenekler[4];
//                    //soru++;
//                }
//            }
//            //if (kontrol > 1)
//            //{
//            //    label4.Text += "\n" + soru + ". " + secenekler[5];
//            //    soru++;
//            //}
//            x += oran;
//            count++;
//        }
//        kontrol = 0;
//        x = 356;
//        y += oran;
//        count = 0;
//    }

//    int h = 1;
//    foreach (var item in cevaplar)
//    {
//        rich_mat_kisi.Text += "\n" + h + ". " + item;
//        h++;
//    }
//    int z = 1;
//    foreach (var item in cevap_anahtari)
//    {
//        rich_mat_cevap.Text += "\n" + z + ". " + item;
//        z++;
//    }
//}
//private void ing_oku_Click(object sender, EventArgs e)
//{
//    richTextBox1.Clear();
//    int x = 433;
//    int y = 277;
//    int oran = 11;
//    int tekrar_asagi = 20;
//    int tekrar_sag = 4;
//    int count = 0;
//    Color c;
//    int red, green, blue;
//    label4.Text = "TC: ";
//    List<string> cevap_anahtari = new List<string>(new string[] {
//        "A","A","A","A","A","B","B","B","B","B","C","C","C","C","C","D","D","D","D","D"
//    });
//    List<string> secenekler = new List<string>(new string[] {
//        "A","B","C","D","BOS","GECERSIZ"
//    });
//    List<string> cevaplar = new List<string>();
//    //int soru = 1;
//    int kontrol = 0;

//    for (int i = 0; i < tekrar_asagi; i++)
//    {
//        for (int j = 0; j < tekrar_sag; j++)
//        {
//            //279,277
//            c = resim.GetPixel(x, y);
//            red = c.R;
//            green = c.G;
//            blue = c.B;
//            //int w = 279;

//            if ((0 <= red && red < 127) || (0 <= green && green < 127) || (0 <= blue && blue < 127))
//            {
//                if (kontrol < 2)
//                {
//                    kontrol++;
//                    //richTextBox1.Text += x + " , " + y + " -> " + red + " , " + green + " , " + blue + "\n";
//                    //label4.Text += "\n" + soru + ". " + secenekler[count];
//                    cevaplar.Add(secenekler[count]);
//                    //soru++;

//                }
//                if (kontrol == 2)
//                {
//                    //label4.Text += "\n" + soru + ". " + secenekler[5];
//                    cevaplar.RemoveAt(cevaplar.Count - 1);
//                    cevaplar.RemoveAt(cevaplar.Count - 1);
//                    cevaplar.Add(secenekler[5]);
//                    //soru++;
//                }
//            }
//            if (j == 3)
//            {
//                if (kontrol == 0)
//                {
//                    cevaplar.Add(secenekler[4]);
//                    //label4.Text += "\n" + soru + ". " + secenekler[4];
//                    //soru++;
//                }
//            }
//            //if (kontrol > 1)
//            //{
//            //    label4.Text += "\n" + soru + ". " + secenekler[5];
//            //    soru++;
//            //}
//            x += oran;
//            count++;
//        }
//        kontrol = 0;
//        x = 433;
//        y += oran;
//        count = 0;
//    }

//    int h = 1;
//    foreach (var item in cevaplar)
//    {
//        rich_ing_kisi.Text += "\n" + h + ". " + item;
//        h++;
//    }
//    int z = 1;
//    foreach (var item in cevap_anahtari)
//    {
//        rich_ing_cevap.Text += "\n" + z + ". " + item;
//        z++;
//    }
//}