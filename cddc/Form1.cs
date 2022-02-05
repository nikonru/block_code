using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
///using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace cddc
{
    public partial class Form1 : Form
    {
        int[,] G;
        int[,] H;
        int[] B;
        int[] Be;
        int[] E;
        int[] U;
        int[] S;

        bool createdmatrix = false;
        bool matrixerr = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cr = e.KeyChar;
            if (cr != '1' && cr != '0' && cr != 8)
                e.Handled = true;
            
        }
        int X;
        private void button1_Click(object sender, EventArgs e)
        {
           
            dataGridViewG.Rows.Clear();
            dataGridViewG.Columns.Clear();

            X = (int)(numericUpDownN.Value + numericUpDownL.Value);


            for (int x = 0; x < X; x++)
            {
                dataGridViewG.Columns.Add(x.ToString(), "");
                dataGridViewG.Columns[x].Width = 21;


            }


            for (int y = 0; y < (numericUpDownN.Value); y++)
            {
                string[] str = new string[X];
                for (int i = 0; i < X; i++)
                    if (y == i)
                        str[i] = "1";
                    else
                        if (i > (numericUpDownN.Value) - 1)
                        str[i] = "Y";
                    else
                        str[i] = "0";

                dataGridViewG.Rows.Add(str);
            }


            createdmatrix = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!createdmatrix)
            {
                System.Windows.Forms.MessageBox.Show("Кодер не настроен!");
                return;
            }
            matrixerr = true;

            if (textBoxU.Text.Length > (int)numericUpDownN.Value)
            {
                string tmp = textBoxU.Text;
                textBoxU.Text = "";
                for (int i = 0; i < (int)numericUpDownN.Value; i++)
                    textBoxU.Text += tmp[i];
            }
            if (textBoxU.Text.Length < (int)numericUpDownN.Value)
                for (int i = textBoxU.Text.Length; i < (int)numericUpDownN.Value; i++)
                    textBoxU.Text += "0";



            textBoxB.Text = "";
            U = new int[(int)numericUpDownN.Value];
            for (int i = 0; i < numericUpDownN.Value; i++)
                U[i] = textBoxU.Text[i] - '0';
            G = new int[(int)numericUpDownN.Value, X];
            for (int x = 0; x < X; x++)
                for (int y = 0; y < (numericUpDownN.Value); y++)
                {
                    if(dataGridViewG.Rows[y].Cells[x].Value==null)
                    {
                        System.Windows.Forms.MessageBox.Show("G matrix Error");
                        return;
                    }
                    string tmp = dataGridViewG.Rows[y].Cells[x].Value.ToString();
                    if (!int.TryParse(tmp, out G[y, x]))
                    {
                        System.Windows.Forms.MessageBox.Show("G matrix Error");
                        return;
                    }
                }


            H = new int[X, (int)numericUpDownL.Value];


            for (int x = 0; x < X; x++)
                for (int y = 0; y < (int)(numericUpDownL.Value); y++)
                {
                    if (x < (int)numericUpDownN.Value)
                    {
                        H[x, y] = G[x, y + (int)numericUpDownN.Value];
                      }
                    else
                    if (x - (int)numericUpDownN.Value == y)
                        H[x, y] = 1;
                    else
                        H[x, y] = 0;
                }

            dataGridViewH.Rows.Clear();
            dataGridViewH.Columns.Clear();

            for (int i = 0; i < X; i++)
            {   
                dataGridViewH.Columns.Add(i.ToString(), "");
                dataGridViewH.Columns[i].Width = 21;
            }

            for (int i = 0; i < (int)numericUpDownL.Value; i++)
            {
                string[] str = new string[X];
                for (int x = 0; x < X; x++)
                    str[x] = H[x, i].ToString();

                    dataGridViewH.Rows.Add(str);
            }


            B = new int[X];
            E = new int[X];
            Be = new int[X];
            for (int x = 0; x < X; x++)
            {
                B[x] = 0;
                for (int y = 0; y < (numericUpDownN.Value); y++)
                {
                    B[x] += U[y] * G[y, x];
                }
                B[x] %= 2;
                textBoxB.Text += B[x].ToString();
            }


            matrixerr = false;
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!createdmatrix)
            {
                System.Windows.Forms.MessageBox.Show("Кодер не настроен!");
                return;
            }
            if (matrixerr)
            {
                System.Windows.Forms.MessageBox.Show("G matrix Error");
                return;
            }



            if (textBoxE.Text.Length > X)
            {
                string tmp = textBoxE.Text;
                textBoxE.Text = "";
                for (int i = 0; i < X; i++)
                    textBoxE.Text += tmp[i];
            }

            if (textBoxE.Text.Length < X)
                for (int i = textBoxE.Text.Length; i < X; i++)
                    textBoxE.Text += "0";


            textBoxLienOut.Text = "";
            for (int i = 0; i < (int)(numericUpDownN.Value + numericUpDownL.Value); i++)
            {
                E[i] = textBoxE.Text[i] - '0';
                Be[i] = (B[i] + E[i]) % 2;
                textBoxLienOut.Text += Be[i].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!createdmatrix)
            {
                System.Windows.Forms.MessageBox.Show("Кодер не настроен!");
                return;
            }
            if (matrixerr)
            {
                System.Windows.Forms.MessageBox.Show("G matrix Error");
                return;
            }

            S =new int[(int)numericUpDownL.Value];
            textBoxS.Text = "";

            for (int i = 0; i < (int)numericUpDownL.Value; i++)
            {
                S[i] = 0;
                for (int t = 0; t < X; t++)
                    S[i] += Be[t] * H[t, i];
                
                S[i] %= 2;
                textBoxS.Text += S[i].ToString();

            }

            int[] errvec = new int[X];
            int[] Se = new int[(int)numericUpDownL.Value];

            for (int k = 0; k <= X; k++)
            {
                for (int i = 0; i < X; i++)
                    if (i != (k-1))
                        errvec[i] = 0;
                    else
                        errvec[i] = 1;

                String tmp = "";

                for (int i = 0; i < (int)numericUpDownL.Value; i++)
                {
                    Se[i] = 0;
                    for (int t = 0; t < X; t++)
                        Se[i] += errvec[t] * H[t, i];

                    Se[i] %= 2;
                    tmp += Se[i].ToString();
                }

                textBoxErr.Text = "";
                if (tmp == textBoxS.Text)
                {
                    for (int i = 0; i < X; i++)
                    {
                        textBoxErr.Text += errvec[i].ToString() ;
                    }
                    break;
                }

            }


            int[] Bee = new int[X];
            
            textBoxDC.Text = "";
            for (int i = 0; i < X; i++)
            {
                Bee[i] = (Be[i] + errvec[i]) % 2;
            }


           
            for (int i = 0; i < numericUpDownN.Value; i++)
                textBoxDC.Text += Bee[i].ToString();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            if (matrixerr) return;
            button3_Click(sender, e);
            button4_Click(sender, e);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
