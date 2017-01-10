using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro2namespace
{
    public partial class inputForm : Form
    {//
        private double KV,P;
        public double test=0;
        public inputForm(double inputV,double inputP)
        {
            InitializeComponent();
            KV = inputV;
            P = inputP;
            textBoxP.Text = (Math.Round(P,3)).ToString();
            textBoxKV.Text = Math.Round(KV, 3).ToString();
            putTextRTB(rtbFS_KM1, "K", "м1");
            putTextRTB(rtbFS_KM2, "K", "м2");
            putTextRTB(rtbFS_KM3, "K", "м3");
            putTextRTB(rtbFS_KMZ, "K", "мз");

            putTextRTB(rtbSA_KM1, "K", "м1");
            putTextRTB(rtbSA_KM2, "K", "м2");
            putTextRTB(rtbSA_KM3, "K", "м3");
            putTextRTB(rtbSA_KMZ, "K", "мз");

            putTextRTB(rtbKV, "K", "в");
        }

        private void putTextRTB(RichTextBox rtb, string Normal, string low)
        {
            rtb.Clear();
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, 10);
            rtb.SelectionCharOffset = 0;
            rtb.AppendText(Normal);
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, 7);
            rtb.SelectionCharOffset = -10 / 2;
            rtb.SelectedText = low;
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, 10);
            rtb.SelectionCharOffset = 0;
            rtb.SelectedText = (" = ");
        }


        private void putTextRTBans(string Normal, string low,double date)
        {
            var rtb = rtbAnswer;
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, 10);
            rtb.SelectionCharOffset = 0;
            rtb.AppendText(Normal);
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, 7);
            rtb.SelectionCharOffset = -10 / 2;
            rtb.AppendText( low);
            rtb.SelectionFont = new Font(rtb.Font.FontFamily, 10);
            rtb.SelectionCharOffset = 0;
            date = Math.Round(date, 3);
            rtb.AppendText("="+date.ToString());

        }
        


        private double SA_KM1, SA_KM2, SA_KM3, SA_KMZ;
        private double FS_KM1, FS_KM2, FS_KM3, FS_KMZ;

        private double coef(TextBox TB)
        {
            try
            {
                double[] mas = TB.Text.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).Select(
                    a => double.Parse(a)).ToArray();
                double ans = 1;
                for (int i = 0; i < mas.Length; i++)
                    ans *= mas[i];
                return ans;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Некоректні вихідні дані ("+ex.ToString()+")");
                return 1;
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            SA_KM1 = coef(textBoxSA_KM1);
            SA_KM2 = coef(textBoxSA_KM2);
            SA_KM3 = coef(textBoxSA_KM3);
            SA_KMZ = coef(textBoxSA_KMZ);
            FS_KM1 = coef(textBoxFS_KM1);
            FS_KM2 = coef(textBoxFS_KM2);
            FS_KM3 = coef(textBoxFS_KM3);
            FS_KMZ = coef(textBoxFS_KMZ);
            rtbAnswer.Clear();
            double SP = 0;
            SP = P*FS_KM1 * FS_KM2 * FS_KM3 * FS_KMZ / (SA_KM1 * SA_KM2 * SA_KM3 * SA_KMZ);
            putTextRTBans("P", "шукана", SP);
            rtbAnswer.AppendText ("\nШукана земельна ділянка\tЗемельна ділянка передбачена для обміну\n");
            putTextRTBans("K", "м1", SA_KM1); putTextRTBans("\t\t\t\tK", "м1", FS_KM1);
            putTextRTBans("\nK", "м2", SA_KM2); putTextRTBans("\t\t\t\tK", "м2", FS_KM2);
            putTextRTBans("\nK", "м3", SA_KM3); putTextRTBans("\t\t\t\tK", "м3", FS_KM3);
            putTextRTBans("\nK", "мз", SA_KMZ); putTextRTBans("\t\t\t\tK", "мз", FS_KMZ);
            putTextRTBans("\nK", "в", KV);
            

        }

        private char[] fine = { '1', '2', '3', '4', '5', '6', '7',
                                  '8', '9', '0', ' ', ',' };
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

        private void textBoxSA_KM1_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Регіональний коефіцієнт за місце розташування шуканої земельної ділянки";
        }

        private void textBoxFS_KM1_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Регіональний коефіцієнт за місце розташування земельної ділянки, передбаченої до обміну";
        }

        private void textBoxSA_KM2_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Зональний коефіцієнт за місце розташування шуканої земельної ділянки";
        }

        private void textBoxFS_KM2_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Зональний коефіцієнт за місце розташування земельної ділянки, передбаченої до обміну";
        }

        private void textBoxSA_KM3_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Локальні коефіцієнти за місце розташування шуканої земельної ділянки\n(функціонально-планувані, історико-культурні, природно-ландшафтні, санітарно-гігєнічні)";
        }

        private void textBoxFS_KM3_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Локальні коефіцієнти за місце розташування земельної ділянки, передбаченої до обміну\n(функціонально-планувані, історико-культурні, природно-ландшафтні, санітарно-гігєнічні)";
        }

        private void textBoxSA_KMZ_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Локальні коефіцієнти за місце розташування шуканої земельної ділянки\n(інженерно-геологічні, інженерно-інфраструктурні)";
        }

        private void textBoxFS_KMZ_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Локальні коефіцієнти за місце розташування земельної ділянки, передбаченої до обміну\n(інженерно-геологічні, інженерно-інфраструктурні)";
        }

        private void textBoxKV_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Коефіціент відцентрованості";
        }

        private void textBoxP_Click(object sender, EventArgs e)
        {
            rtbHelp.Text = "Площа земельної ділянки, передбаченої для обміну";
        }

        private void butCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
