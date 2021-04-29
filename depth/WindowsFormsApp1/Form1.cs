using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public class node
        {
            public char letter;
            public node down;
            public node right;
            public node left;
            public node before;
            public node before2;
            public int v;
        }
        public node selected = new node();
        public string r;
        public string z;
        public string n;
        public string m;
        public string o;
        public string p;
        public string q;
        public string cc;



        public string x;
        string opened;
        string closed ;



        public Form1()
        {
            InitializeComponent();
            node  s = new node();
            node a = new node();
            node b = new node();
            node c = new node();
            node d = new node();
            node g = new node();
            node e = new node();
            node f = new node();
            node h = new node();
            node j = new node();
            node g2 = new node();

            s.letter = 'S';
            s.left = a;
            s.down = b;
            s.right = c;
            s.v = 0;
           


            a.letter = 'A';
            a.left = d;
            a.down = h;
            a.before = s;
            a.v = 7;

            b.letter = 'B';
            b.left = h;
            b.down = g;
            b.right = j;
            b.before = s;
            b.v = 10;




            c.letter = 'C';
            c.left = b;
            c.down = e;
            c.right = f;
            c.before = s;
            c.v = 5;


            d.letter = 'D';
            d.right = h;
            d.before = a;
            d.v = 4;


            g.letter = 'G';
            g.before = b;
            g.v = 0;


            e.letter = 'E';
            e.right = f;
            e.before = c;
            e.v=7;


            f.letter = 'f';
            f.right = g2;
            f.before = c;
            f.v = 9;

            h.letter = 'H';
            h.right = j;
            h.before = a;
            h.before2 = b;
            h.v = 6;

            j.letter = 'J';
            j.right= g2;
            j.before = b;
            j.v = 8;


            g2.letter = 'g';
            g2.before = f;
            g2.before2 = j;
            g2.v = 0;

            node selected = new node();
            node reset = new node();
            node ayhaga = new node();
            node sright = new node();
            node sleft = new node();
            node sdown = new node();
            selected = s;
            sright = s.right;
            sleft = s.left;
            sdown = s.down;
            int count = 0;
            int flag = 1;
            int ct = 0;
            close1.Text += "[ ]";
           
            while(selected!=null)
            {
                if (ct == 0)
                {
                    reset = selected;
                    x += selected.letter;
                    r += selected.letter;
                    close2.Text +=r;
                    ct++;
                }
                while(selected.left!=null)
                {
                    selected = selected.left;
                    x += selected.letter;
                    if (ct == 1)
                    {
                        r += selected.letter;
                        close3.Text += r;
                        ct++;
                    }
                    
                    

                    if (selected.letter == 'G' || selected.letter == 'g')
                    {
                        flag = 0;
                    }
                }
                r += selected.letter;
                close4.Text += r;
                if (selected.left == null)
                {
                    selected = selected.before;
                    count++;
                }
                
                if (selected.down != null)
                {
                    selected = selected.down;
                    x += selected.letter;
                    
                    if (ct == 2)
                    {
                        r += selected.letter;

                        closed5.Text += r;
                        ct++;

                    }

                }

                
                if(selected.left==null )
                {
                    selected = selected.before;
                    selected = selected.before;
                }
                if (selected.down!=null)
                {
                    selected = selected.down;
                    x += selected.letter;
                    if (ct == 3)
                    {
                        r += selected.letter;
                        close6.Text += r;

                        ct++;
                    }
                    
                    
                    if (selected.letter == 'G' || selected.letter == 'g')
                    {
                        flag = 0;
                    }

                }
                while (selected.left != null)
                {
                    selected = selected.left;
                    if (selected.letter == 'G'|| selected.letter == 'g')
                    {
                        flag = 0;
                    }

                }
                if (count%2!=0)
                {
                    count++;
                    selected = selected.before2;
                }
                while (selected.down != null)
                {
                    selected = selected.down;
                    x += selected.letter;
                    if (ct == 4)
                    {
                        r += selected.letter;
                        closed7.Text += r;
                        ct++;

                    }
                    if (selected.letter=='G' || selected.letter == 'g')
                    {
                        flag = 0;
                    }
                }
                if (flag==0)
                {
                    break;

                }
                
                }
            selected = reset;
            int ctt = 0;
            while(selected!=null)
            {
               if (ctt==0)
                {
                    n += selected.letter;

                    open1.Text += n;
                    ctt++;
                }
               
               if (ctt==1)
                {
                    if (selected.left != null)
                    {
                       
                        selected = selected.left;
                        
                        z += selected.letter;
                    }
                    selected = reset;
                    if (selected.down != null)
                    {
                        selected = selected.down;
                        ayhaga = selected;
                        z += selected.letter;
                        p += selected.letter;
                    }
                    selected = reset;
                    if (selected.right != null)
                    {
                        selected = selected.right;
                        z += selected.letter;
                        cc += selected.letter;
                        p += selected.letter;
                    }
                    open2.Text += z;
                    ctt++;
                }
                selected = reset;
                if (ctt == 2)
                {
                    if (selected.left != null)
                    {
                        selected = selected.left;
                        o += d.letter;
                    }
                    selected = reset;
                    if (selected.down != null)
                    {
                        selected = selected.down;
                        n += h.letter;
                       
                    }
                    open3.Text +="DHBC";
                    ctt++;
                }
                reset = selected;
                if (ctt == 3)
                {

                    open4.Text += h.letter+ p;
                    ctt++;
                }
                if(ctt==4)
                {
                    open5.Text += p;
                    ctt++;
                }

                selected = ayhaga;
                if(ctt==5)
                {
                    if (selected.down != null)
                    {
                        selected = selected.down;
                        q += selected.letter;
                        open6.Text += q +j.letter+ cc;

                    }
                    if (ctt==5)
                    {
                        break;
                    }
                    

                   
                 




                }








               




               




            }
            MessageBox.Show("path is "+ x);




            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       

    }
}
