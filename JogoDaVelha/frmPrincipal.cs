using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class frmPrincipal : Form
    {
        int jogadas = 0;
        int player = 1;
        bool final = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            btnClose.Visible = false;
        }
        public void Chekar()
        {
            if (((btn1.Text == "X") && (btn2.Text == "X") && (btn3.Text == "X")) || ((btn1.Text == "O") && (btn2.Text == "O") && (btn3.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (((btn1.Text == "X") && (btn4.Text == "X") && (btn7.Text == "X")) || ((btn1.Text == "O") && (btn4.Text == "O") && (btn7.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (((btn1.Text == "X") && (btn5.Text == "X") && (btn9.Text == "X")) || ((btn1.Text == "O") && (btn5.Text == "O") && (btn9.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (((btn2.Text == "X") && (btn5.Text == "X") && (btn8.Text == "X")) || ((btn2.Text == "O") && (btn5.Text == "O") && (btn8.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (((btn3.Text == "X") && (btn6.Text == "X") && (btn9.Text == "X")) || ((btn3.Text == "O") && (btn6.Text == "O") && (btn9.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (((btn4.Text == "X") && (btn5.Text == "X") && (btn6.Text == "X")) || ((btn4.Text == "O") && (btn5.Text == "O") && (btn6.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (((btn7.Text == "X") && (btn8.Text == "X") && (btn9.Text == "X")) || ((btn7.Text == "O") && (btn8.Text == "O") && (btn9.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (((btn3.Text == "X") && (btn5.Text == "X") && (btn7.Text == "X")) || ((btn3.Text == "O") && (btn5.Text == "O") && (btn7.Text == "O")))
            {
                final = true;
                label1.Text = "O jogador " + player + " Ganhou";
                btnClose.Visible = true;
            }
            else if (jogadas == 9)
            {
                final = true;
                label1.Text = "O JOGO DEU VELHA!!!";
                btnClose.Visible = true;
            }
            else
            {
                final = false;
            }
        }
        public void MostrarPlayer()
        {
            if (final == false)
            {
                if (player == 1)
                {
                    player++;
                    label1.Text = "Vez do Jogador " + (player);
                }
                else
                {
                    player--;
                    label1.Text = "Vez do Jogador " + (player);
                }
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn1.Text == "")
                {
                    if (player == 1)
                    {
                        btn1.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn1.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            } 
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn2.Text == "")
                {
                    if (player == 1)
                    {
                        btn2.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn2.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn3.Text == "")
                {
                    if (player == 1)
                    {
                        btn3.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn3.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn4.Text == "")
                {
                    if (player == 1)
                    {
                        btn4.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn4.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn5.Text == "")
                {
                    if (player == 1)
                    {
                        btn5.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn5.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn6.Text == "")
                {
                    if (player == 1)
                    {
                        btn6.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn6.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn7.Text == "")
                {
                    if (player == 1)
                    {
                        btn7.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn7.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn8.Text == "")
                {
                    if (player == 1)
                    {
                        btn8.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn8.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (final == false)
            {
                if (btn9.Text == "")
                {
                    if (player == 1)
                    {
                        btn9.Text = "X";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                    else
                    {
                        btn9.Text = "O";
                        jogadas++;
                        Chekar();
                        MostrarPlayer();
                    }
                }
                else
                {
                    label1.Text = "Já jogaram aqui!";
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}