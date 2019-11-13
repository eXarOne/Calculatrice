﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice.View
{
    public partial class Calculatrice : Form
    {
        /* Déclaration des controllers*/
        readonly Controler.Addition add = new Controler.Addition();
        readonly Controler.Soustraction sous = new Controler.Soustraction();
        readonly Controler.Multiplication mult = new Controler.Multiplication();
        readonly Controler.Division div = new Controler.Division();

        /* Déclarations variables de stockage et choix d'opérations*/
        string Get_1 = "";
        string Get_2="";
        int choix = 0;

        /*Début des évenements*/
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {
 
            Prec.Visible = false;
        }

        private void Picture_Leave_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            RichBox.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            RichBox.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            RichBox.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            RichBox.Text += "4";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            RichBox.Text += "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            RichBox.Text += "6";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            RichBox.Text += "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            RichBox.Text += "8";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            RichBox.Text += "9";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            RichBox.Text += "0";
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            RichBox.Text = "";
            Prec.Text = "";
            choix = 0;

        }

        private void Button_Dot_Click(object sender, EventArgs e)
        {
            RichBox.Text += ".";
        }
 
        private void Button_Addition_Click(object sender, EventArgs e)
        {

            Get_1 = RichBox.Text;
            RichBox.Text += "+";
            Prec.Text = RichBox.Text;
            Prec.Visible = true;
            RichBox.Text = "";
            choix = 1;
        }

        private void Button_Soustraction_Click(object sender, EventArgs e)
        {
            Get_1 = RichBox.Text;
            RichBox.Text += "-";
            Prec.Text = RichBox.Text;
            Prec.Visible = true;
            RichBox.Text = "";
            choix = 2; 
        }

        private void Button_Division_Click(object sender, EventArgs e)
        {
            Get_1 = RichBox.Text;
            RichBox.Text += "/";
            Prec.Text = RichBox.Text;
            Prec.Visible = true;
            RichBox.Text = "";
            choix = 3;
        }

        private void Button_Multiplication_Click(object sender, EventArgs e)
        {
            Get_1 = RichBox.Text;
            RichBox.Text += "X";
            Prec.Text = RichBox.Text;
            Prec.Visible = true;
            RichBox.Text = "";
            choix = 4;
        }

        private void Button_Equal_Click(object sender, EventArgs e)
        {
          
            char[] MyChar = { '+', '-', '/', 'X', ' ' };
            Get_2 = RichBox.Text.TrimStart(MyChar);
            Prec.Text = "";


            double A = int.Parse(Get_1.ToString());
            double B = int.Parse(Get_2.ToString());
            
            if (choix == 1)
            {
                string resultat = add.Fct_Add(A, B).ToString();
                RichBox.Text = resultat.ToString();
                choix = 0;
            }
            else if (choix == 2)
            {
                string resultat = sous.Fct_Sous(A, B).ToString();
                RichBox.Text = resultat.ToString();
                choix = 0;
            }
            else if (choix == 3)
            {
                double resultat = div.Fct_Div(A, B);
                RichBox.Text = resultat.ToString();
                choix = 0;
            }
            else if (choix == 4)
            {
                string resultat = mult.Fct_Mult(A, B).ToString();
                RichBox.Text = resultat.ToString();
                choix = 0;
            }

            
        }

        
    }
}
