using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {  
            InitializeComponent();
        }
        public Button[] boton = new Button[15];
        private void button1_Click(object sender, EventArgs e)
        {
       
            int Loc = 0;
            int Loc1 = 0;
           
                
for (int n = 0; n < 9; n++)
            {
                boton[n] = new Button();
                this.Controls.Add(boton[n]);
                if (n == 3 || n == 6 || n == 9 )
                {
                    Loc = Loc + 90;
                    Loc1 = 0;
                }
                boton[n].Left = 90 + Loc1;
                boton[n].Top = 90 + Loc;
                boton[n].Width = 80;
                boton[n].Height = 80;
                boton[n].BackColor = SystemColors.Info;
                boton[n].Click += new EventHandler(Jugadas);      
           
                Loc1 = Loc1 + 200;
  
            
    this.button1.Visible =false;

            }
        }

                    
    public void Jugadas(object sender, EventArgs e)
        {
         
            
                Button B = (Button)sender;
                B.Enabled = false;
               B.Text = "X";

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    }
}
