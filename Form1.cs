using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;

using Word = Microsoft.Office.Interop.Word;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
//using WFAinput;

namespace pro2namespace
{
    public partial class MLV : Form
    {
        public MLV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
            //Еталонні дані 
             N = 5;
            //0,00	0,00	105,55	0,00	105,55	23,46	0,00	23,46	-2,07	11,73
             X[0] = 0; Y[0] = 0;
             X[1] = 105.55; Y[1] = 0;
             X[2] = 105.55; Y[2] = 23.46;
             X[3] = 0; Y[3] = 23.46;
             X[4] = -2.07; Y[4] = 11.73;
            Calc(); // обрахунок на основі еталонних даних
            //oopenFileD.InitialDirectory = @"C:\";
            //задання початкового розташування інструментрів
            /*
            rtbP1.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);

            rtbP1.SelectionCharOffset = 0;
            rtbP1.SelectedText = "P";
            rtbP1.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB / 2);
            rtbP1.SelectionCharOffset = -heightRTB / 2;
            rtbP1.SelectedText = "1";
            */
            InicialezateRTB(rtbP1, "P", "1");
            InicialezateRTB(rtbB1, "B", "1");
            InicialezateRTB(rtbB2, "B", "2");



            Calc();
            timer.Enabled = true;

        }

        void InicialezateRTB(RichTextBox rtb, string text, string lowText)
        {
            rtb.Clear();
            rtb.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            rtb.SelectionCharOffset = 0;
            rtb.SelectedText = text;
            rtb.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB * 2 / 3);
            rtb.SelectionCharOffset = -heightRTB / 2;
            rtb.SelectedText = lowText;
            rtb.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            rtb.SelectionCharOffset = 0;
            rtb.AppendText(" = ");
        }





        private void Form1_Resize(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private double[] X = new double[101];
        private double[] Y = new double[101];
        private int N=0;
        public const double Eps = 0.0000000001;
        double  b1 = 0, maxX = 0, minX = double.MaxValue;
        private int stepRound = 3;
    

        private bool Read()
        {
            {
                var temp = openFileD.FileName;
                openFileD.ShowDialog();
                if (openFileD.FileName == temp)
                {
                    MessageBox.Show("Файл не обрано");
                    return false;
                }
            }
            StreamReader sr = new StreamReader(openFileD.FileName);

            N = Convert.ToInt32(sr.ReadLine());
            X = sr.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();

            Y = sr.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();

            return true;
        }
      
        double B1 = 20, B2 = 38, P1 = 2500,maxY,minY;
        double x0,y0,K1,K2 = 0.671;

        private double dist(double x1,double y1,double x2,double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        private double area(double x1,double y1,double x2,double y2,double x3,double y3)
        {
            return Math.Abs((x1 * (y2 - y3) - y1 * (x2 - x3) + (x2 * y3 - y2 * x3)) / 2);
        }
        private double dist(double x1,double y1,double x2,double y2,double X0,double Y0)
        {
            return 2 * area(x1, y1, x2, y2, X0, Y0) / dist(x1, y1, x2, y2);
        }
        private double RdivR(double x1,double y1,double x2,double y2,double x3,double y3)
        {
            double Rh = dist(x2, y2, x3, y3, x1, y1);
            double R1 = dist(x1, y1, x2, y2);
            double R2 = dist(x1, y1, x3, y3);
            double Rmax = Math.Max(R1,R2);
            double Dcheck = Math.Sqrt(Rmax * Rmax - Rh * Rh);
            double Rmin = Math.Min(R1,R2);
            if (Dcheck <= dist(x2, y2, x3, y3)) Rmin = Math.Min(Rmin, Rh);
            return Rmin / Rmax;
            //(53,2938/54,56895+11,7278/54,56895+53,2938/54,56895+9,4333/54,32442+9,4333/54,32442)/5=0,675
            ///важливий порядок ввеення
        }

        private bool Calc()
        {
            double[] Xmas=new double [N], Ymas=new double [N];
            for (int i = 1; i < N-1; i++)
            {
                Xmas[i-1] = (X[0] + X[i] + X[i + 1]) / 3;
                Ymas[i-1] = (Y[0] + Y[i] + Y[i + 1]) / 3;
            }
            x0=0; y0=0;
            double[] S = new double[N-1];
            for (int i = 1; i < N - 1; i++)
                S[i - 1] = area(X[0], Y[0], X[i], Y[i], X[i + 1], Y[i + 1]);

            double denominator = 0;
            for (int i = 0; i < N-2;i++)
            {
                x0 += S[i] * Xmas[i];
                y0 += S[i] * Ymas[i];
                denominator += S[i];
            }
            x0 = x0 / denominator;
            y0 = y0 / denominator;
            double Kk = 0;
            for (int i = 0; i < N - 1; i++)
                Kk += RdivR(x0, y0, X[i], Y[i], X[i + 1], Y[i + 1]);
            Kk += RdivR(x0, y0, X[0], Y[0], X[N - 1], Y[N - 1]);
            K1 = Kk / N;

            maxX = int.MinValue;
            minX = int.MaxValue;
            maxY = int.MinValue;
            minY = int.MaxValue;

            for(int i=0; i<N;i++)
            {
                if (maxX < X[i]) maxX = X[i];
                if (minX > X[i]) minX = X[i];
                if (maxY < Y[i]) maxY = Y[i];
                if (minY > Y[i]) minY = Y[i];
            }
            onlineReport();
            return true;
        }
        delegate Point CoordinatesConverter(int i);
        Point[] pointMas;
        private void draw()
        {
        
            //   10+280*X[i]/(maxX-minX)
            CoordinatesConverter convertedPoint = (i) => new Point((int)(10 + 280 * X[i] / (maxX - minX)),(int)(10 + 280 * Y[i] / (maxY - minY)));
            pointMas = new Point[N];

            Graphics g = pB.CreateGraphics();
            g.Clear(Color.White);
            Pen dot = new Pen(Color.Red, 5);
            Pen line = new Pen(Color.Blue, 2);
            for (int i = 0; i < N; i++)
                pointMas[i] = convertedPoint(i);
            g.DrawPolygon(line, pointMas);
            for (int i = 0; i < N;i++)
                g.DrawEllipse(dot, pointMas[i].X - 2, pointMas[i].Y - 2, 4, 4);

        }
        private int heightRTB = 11;
        private void putTextRTB(string Q, int pow, double date)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            date = Math.Round(date,stepRound);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.SelectedText = Q;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB/2);
            richTextBox.SelectionCharOffset = heightRTB/2;
            richTextBox.SelectedText = pow.ToString();
            richTextBox.SelectionCharOffset = 0;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            richTextBox.AppendText(" = " + date.ToString());
            richTextBox.AppendText("\n");
        }
        private void putTextRTB(string Q, string low, double date)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            date = Math.Round(date, stepRound);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.SelectedText = Q;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB/2);
            richTextBox.SelectionCharOffset = -heightRTB/2;
            richTextBox.SelectedText = low;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.AppendText(" = " + date.ToString());
            richTextBox.AppendText("\n");
        }
        private void putTextRTB(string Q, string low, string secondNormal, double date)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            date = Math.Round(date, stepRound);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.SelectedText = Q;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB/2);
            richTextBox.SelectionCharOffset = -heightRTB/2;
            richTextBox.SelectedText = low;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.AppendText(secondNormal + " = " + date.ToString());
            richTextBox.AppendText("\n");
        }
        private void putTextRTB(string Q,  double date)
        {

            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            date = Math.Round(date,stepRound);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.SelectedText = Q;
            richTextBox.AppendText(" = " + date.ToString());
            richTextBox.AppendText("\n");
        }
        private void putTextRTB(double leftDate,string Q, string low, string secondNormal, double rightDate)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            leftDate = Math.Round(leftDate, stepRound);
            rightDate = Math.Round(rightDate, stepRound);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.AppendText(leftDate.ToString());
            richTextBox.SelectedText = Q;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB / 2);
            richTextBox.SelectionCharOffset = -heightRTB / 2;
            richTextBox.SelectedText = low;
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            richTextBox.SelectionCharOffset = 0;
            richTextBox.AppendText(secondNormal + rightDate.ToString());
            richTextBox.AppendText("\n");
        }
        
        // кирилиця на opengl
        // звіт 
        


        private bool onlineReport()
        {

          /*  double leftDate = Math.Round(ymin, stepRound);
            double rightDate = Math.Round(ymax, stepRound);
            RTBmain.SelectionCharOffset = 0;
            RTBmain.AppendText(leftDate.ToString());
            RTBmain.SelectedText = " < y";
            RTBmain.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB / 2, FontStyle.Bold);
            RTBmain.SelectionCharOffset = -heightRTB / 2;
            RTBmain.SelectedText = "n";
            RTBmain.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB, FontStyle.Bold);
            RTBmain.SelectionCharOffset = 0;
            RTBmain.AppendText(" < " + rightDate.ToString());

            */

            richTextBox.Clear();
            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, heightRTB);
            
            putTextRTB("x", "0",x0);
            putTextRTB("y", "0", y0);
            putTextRTB("b", "1", b1);
            // input dalta Yn;
            putTextRTB("K", "ф1", K1);
            putTextRTB("К", "ф2", K2);
            /*
            putTextRTB("E", "X", "(y)", Eelast);
            putTextRTB("σ", 2, sigma_2);
            putTextRTB("D(b", "1", ")", D_b1);
            putTextRTB("D(b", "0", ")", D_b0);
            putTextRTB("t", T);
            putTextRTB("R", 2, R_2);
            putTextRTB("S", S);
            putTextRTB("S", "f", Sf);

            putTextRTB(beta0min, " < β", "0", " < ", beta0max);
            putTextRTB(beta1min, " < β", "1", " < ", beta1max);
            putTextRTB(f(x) - deltaY, " < y", "n", " < ", f(x) + deltaY);
           */
           return true;
       }

       private void ReplaceWordStub(string stubToReplace, double data, Word._Document wordDocument)
       {
           data = Math.Round(data, stepRound);
           bool flag=true;
           while (flag)
           {
               var range = wordDocument.Content;
               range.Find.ClearFormatting();
               flag = range.Find.Execute(FindText: stubToReplace, ReplaceWith: data.ToString());
           }
       }
       private void ReplaceWordStub(string stubToReplace, string Text, Word._Document wordDocument)
       {
           bool flag = true;
           while (flag)
           {
               var range = wordDocument.Content;
               range.Find.ClearFormatting();
               flag = range.Find.Execute(FindText: stubToReplace, ReplaceWith: Text);
           }
       }
        
       private void timer_Tick(object sender, EventArgs e)
       {
           timer.Enabled = false;
           timer.Interval = 100;
           draw();
       }

       private string PrtScGrafic()
       {
        //   int h = ant.Height, w = ant.Width;
           int h=1, w = 1;
           draw();
           Bitmap bmp;
           /*Bitmap bmp = new Bitmap(w, h);
           System.Drawing.Imaging.BitmapData data = bmp.LockBits(new Rectangle(0, 0, w, h), System.Drawing.Imaging.ImageLockMode.ReadWrite,
               System.Drawing.Imaging.PixelFormat.Format24bppRgb);
           Gl.glReadPixels(0, 0, w, h, Gl.GL_BGR, Gl.GL_UNSIGNED_BYTE, data.Scan0);
           Gl.glFinish();

           bmp.UnlockBits(data);
           bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);*/
           string s = System.IO.Directory.GetCurrentDirectory()+ @"\img_1.bmp";
           bmp = (Bitmap)pB.Image.Clone();
           bmp.Save(s);
           return s;
       }
      
        private bool SaveWord()
        {
            Microsoft.Office.Interop.Word._Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = false;
            Word._Document wordDocument = wordApp.Documents.Open( System.IO.Directory.GetCurrentDirectory() + @"\Shablon.doc");
            wordDocument.GrammarChecked = false;

            wordDocument.Paragraphs[7].Range.InlineShapes.AddPicture(FileName: PrtScGrafic());

            ReplaceWordStub("{x0}", x0, wordDocument);
            /*ReplaceWordStub("{Eelast}", Eelast, wordDocument);
            ReplaceWordStub("{D_b1}", D_b1, wordDocument);
            ReplaceWordStub("{D_b0}", D_b0, wordDocument);
            ReplaceWordStub("{T}", T, wordDocument);
            ReplaceWordStub("{sigma2}", sigma_2, wordDocument);
            ReplaceWordStub("{R_2}", R_2, wordDocument);
            ReplaceWordStub("{S}", S, wordDocument);
            ReplaceWordStub("{func}", "y=" + Math.Round(b1, stepRound).ToString() + "*x" + "+" 
                                        + Math.Round(b0, stepRound).ToString(), wordDocument);
            ReplaceWordStub("{X}", x, wordDocument);
            
            ReplaceWordStub( "{beta1min}", beta1min, wordDocument);
            ReplaceWordStub( "{beta0min}", beta0min, wordDocument);
            ReplaceWordStub( "{beta1max}", beta1max, wordDocument);
            ReplaceWordStub( "{beta0max}", beta0max, wordDocument);
            ReplaceWordStub( "{y(x)}", f(x), wordDocument);
            ReplaceWordStub( "{k}",N-2 , wordDocument);
            ReplaceWordStub( "{R_2_100}",R_2*100 , wordDocument);
            ReplaceWordStub( "{1_R_2_100}",(1-R_2)*100 , wordDocument);
            ReplaceWordStub( "{dy}", deltaY, wordDocument);
            ReplaceWordStub( "{ymin}", ymin, wordDocument);
            ReplaceWordStub( "{ymax}", ymax , wordDocument);
            ReplaceWordStub( "{z}",Sn , wordDocument);
            //ReplaceWordStub( "{}", .ToString(), wordDocument);*/
            try
            {
                wordDocument.SaveAs2();
            }
            catch
            {
                Status.Text += " SaveError ";
            }
            finally
            {
                Status.Text += " Saved ";
            }
            Status.Text += " | ";
            try
            {
                ((Microsoft.Office.Interop.Word._Document)wordDocument).Close(SaveChanges: false);
                ((Microsoft.Office.Interop.Word._Application)wordApp).Quit();
            }
            catch
            {
                Status.Text += ("NO_CLOSE");
            }
            finally
            {
                Status.Text += "closed";
            }
            return true;
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWord();
        }

        private void оновитиОбчисленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc();
        }
       
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void десятихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stepRound = 1;
            onlineReport();
            draw();
        }

        private void сотихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stepRound = 2;
            onlineReport();
            draw();
        }

        private void тисячнихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stepRound = 3;
            onlineReport();
            draw();
        }

        private void десятитисячнихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stepRound = 4;
            onlineReport();
            draw();
        }

        //Обработчик события получения данных из дочерней формы
    

        private void оновитиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void відкритиВихідніДаніЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Read())
            {
                Calc();
                draw();
            }
        }
        private char[] fine = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ', ',','-'};
       
        private void textBoxChanged(object sender, EventArgs e)
        {
            var T = sender as TextBox;
            int position = T.SelectionStart;
            string s = T.Text;
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (fine.Contains(s[i]))
                    temp += s[i];
                if (s[i] == '.') temp += ',';
            }
            T.Text = temp;
            //MessageBox.Show(position.ToString());
            position += temp.Length - s.Length;
            T.SelectionStart = position;
            T.SelectionLength = 0;
        }
        private bool CheckMasError(string s)
        {
            if (s.Length == 0) return false;
            int i = 0;
            while (s[i] == ' ') i++;
            if (s[i] == ',') return false;
            i++;
            for (; i + 1 < s.Length; i++)
                if (s[i] == ',' && (!char.IsDigit(s[i + 1]) || !char.IsDigit(s[i - 1]))) return false;

            return true;
        }
        private string recreateS(string s)
        {
            string temp = "";
            for(int i=0; i < s.Length;i++)
                if (s[i] == '.') temp +=',';
                else temp += s[i];
            return temp;
        }
        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            bool flag = true;
            flag = flag && CheckMasError(textBoxP1.Text) && CheckMasError(textBoxB1.Text) && CheckMasError(textBoxB2.Text);
            flag = flag && CheckMasError(textBoxX.Text) && CheckMasError(textBoxY.Text);
            if (!flag)
            {
                MessageBox.Show("помилкові дані");
                return;
            }
            double[] tempX;
            double[] tempY;
            double[] tempP1;
            double[] tempB1;
            double[] tempB2;
            tempX = textBoxX.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();
            tempY = textBoxY.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();
            tempP1 = textBoxP1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();
            tempB1 = textBoxB1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();
            tempB2 = textBoxB2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();
            if (tempX.Count() != tempY.Count()) flag = false;
            if (tempP1.Count() != tempB1.Count() || tempB1.Count() != tempB2.Count() || tempB2.Count() != 1) flag = false;
            if (! flag)
            {
                MessageBox.Show("некоректні дані");
                return;
            }
            N = tempX.Count();
            X = tempX;
            Y = tempY;
            P1 = tempP1[0];
            B1 = tempB1[0];
            B2 = tempB2[0];
            Calc();
            draw();
        }

        private void textBoxP1_Click(object sender, EventArgs e)
        {
            labelDescription.Text = "Значення площі вихідної земельної ділянки";
        }

        private void textBoxB1_Click(object sender, EventArgs e)
        {
            labelDescription.Text = "Значення середнього балу бонітету Бср1 для земельної ділянки";
        }

        private void textBoxB2_Click(object sender, EventArgs e)
        {
            labelDescription.Text = "Значення середнього балу бонітету Бср2 для земельної ділянки";
        }

        private void textBoxY_Click(object sender, EventArgs e)
        {
            labelDescription.Text = "Абсциси n поворотних точок";
        }

        private void textBoxX_Click(object sender, EventArgs e)
        {
            labelDescription.Text = "Ординати n поворотних точок";
        }

        private void pB_MouseMove(object sender, MouseEventArgs e)
        {
            double temp = 0;
            temp = Math.Round((e.X-10)*(maxX - minX)/280 , 3);
            statusXY.Text = " X = " + temp.ToString();
            temp = Math.Round((e.Y - 10) * (maxY - minY) / 280, 3);
            statusXY.Text += " Y = " + temp.ToString();
        }

        private void розрахунокРівноцінногоОбмінуЗабудованихЗемельНаселенихПунктівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double P = 0;
            for (int i = 0; i < N - 1; i++)
                P += (X[i] * Y[i + 1] - X[i + 1] * Y[i])/2;
            
            inputForm FormInput = new inputForm(K1,P);
            FormInput.Show();
        }

        private void butSaveWord_Click(object sender, EventArgs e)
        {

        }

        //end MLV Class-------------------------------------------------
    }
    
    
}