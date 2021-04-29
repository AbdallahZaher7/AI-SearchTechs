using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deepp
{
    public partial class Form1 : Form
    {

        public class node
        {
            public int num, pathc;
            public node down, right, left;
            public char letter;

        }
        public node selected = new node();

        string x = "";
        char open;
        string closed = "";
        public Form1()
        {
            InitializeComponent();

            List<node> list = new List<node>();
            node g2 = new node();
            g2.letter = 'G';
            list.Add(g2);
            node J = new node();
            J.letter = 'J';
            J.right = g2;
            list.Add(J);
            node H = new node();
            H.letter = 'H';
            H.right = J;
            list.Add(H);
            node F = new node();
            F.letter = 'F';
            F.down = H;
            list.Add(F);
            node E = new node();
            E.letter = 'E';
            E.right = F;
            list.Add(E);
            node G1 = new node();
            G1.letter = 'G';
            G1.right = E;
            list.Add(G1);
            node D = new node();
            D.letter = 'D';
            D.right = G1;
            list.Add(D);
            node C = new node();
            C.letter = 'C';
            C.down = D;
            list.Add(C);
            node B = new node();
            B.letter = 'B';
            B.right = C;
            list.Add(B);
            node A = new node();
            A.letter = 'A';
            A.right = B;
            list.Add(A);
            node S = new node();
            S.letter = 'S';
            S.down = A;
            list.Add(S);
            selected = S;
            int ct = 0;
            while (selected.down != null)
            {
                
                x += selected.letter;
               
                selected = selected.down;
                while (selected.right != null)
                {
                    closed += selected.letter+"\n";
                    x += selected.letter;
                    
                    open = selected.letter;
                    selected = selected.right;
                    if (selected.letter == 'E')
                    {
                        break;
                    }
                }
                if (selected.letter == 'E')
                {
                    break;
                }
            }
            label1.Text ="The Path is "+ x;
            closed1.Text = null;
            closed2.Text += S.letter;
            closed3.Text += A.letter+""+S.letter;
            closed4.Text += D.letter +""+ A.letter+""+S.letter;
            closed5.Text += H.letter +""+ D.letter +""+A.letter+""+S.letter;
            closed6.Text += B.letter + "" + H.letter + "" + D.letter + "" + A.letter+""+S.letter;
           




            Open1.Text += S.letter;
            open2.Text += A.letter + "" + B.letter + "" + C.letter;
            open3.Text += B.letter + "" + C.letter + "" + D.letter + "" + H.letter;
            open4.Text += C.letter + "" + D.letter + "" + G1.letter + "" + J.letter;
            open5.Text += D.letter + "" + H.letter + "" + G1.letter + "" + J.letter + "" + E.letter + "" + F.letter + "";
            open6.Text+= H.letter+""+G1.letter+""+ J.letter + "" + E.letter + "" + F.letter + "";
            open7.Text += G1.letter + "" + J.letter + "" + E.letter + "" + F.letter ;






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void opend1_Click(object sender, EventArgs e)
        {

        }
    }
}
