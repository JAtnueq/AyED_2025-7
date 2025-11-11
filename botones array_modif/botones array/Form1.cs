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
        public Button[] boton = new Button[49]; // Modifica el limite de botones en pantalla
        private void button1_Click(object sender, EventArgs e)
        {
       
            int Loc = 0;
            int Loc1 = 0;


            for (int n = 0; n < 49; n++) // Generacion de cubos
            {
                boton[n] = new Button();
                this.Controls.Add(boton[n]);
                if (n == 7 || n == 14 || n == 21 || n == 28 || n ==  35 || n == 42 || n == 49) // Define el tamaño de las filas
                {
                    Loc = Loc + 90;
                    Loc1 = 0;
                }
                boton[n].Left = 1 + Loc1;
                boton[n].Top =15 + Loc;
                boton[n].Width =80;
                boton[n].Height = 80;
                boton[n].BackColor = SystemColors.Info;
                boton[n].Click += new EventHandler(Jugadas);      
           
                Loc1 = Loc1 + 90; // distancia entre los botones
  
            
    this.button1.Visible =false;

            }
        }

                    
    public void Jugadas(object sender, EventArgs e)
        {
         
            
                Button B = (Button)sender;
                B.Enabled = false;
               B.Text = "x";
            B.BackColor = Color.Red;

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    }
}
