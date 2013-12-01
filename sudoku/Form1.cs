using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Text = "6";
            button2.Enabled = false;

            button4.Text = "1";
            button4.Enabled = false;

            button6.Text = "4";
            button6.Enabled = false;

            button8.Text = "5";
            button8.Enabled = false;

            button12.Text = "8";
            button12.Enabled = false;

            button13.Text = "3";
            button13.Enabled = false;

            button15.Text = "5";
            button15.Enabled = false;

            button16.Text = "6";
            button16.Enabled = false;

            button19.Text = "2";
            button19.Enabled = false;

            button27.Text = "1";
            button27.Enabled = false;

            button2.Text = "6";
            button2.Enabled = false;

            button54.Text = "8";
            button54.Enabled = false;

            button51.Text = "4";
            button51.Enabled = false;

            button49.Text = "7";
            button49.Enabled = false;

            button46.Text = "6";
            button46.Enabled = false;

            button43.Text = "6";
            button43.Enabled = false;

            button39.Text = "3";
            button39.Enabled = false;

            button36.Text = "7";
            button36.Enabled = false;

            button33.Text = "9";
            button33.Enabled = false;

            button31.Text = "1";
            button31.Enabled = false;

            button28.Text = "4";
            button28.Enabled = false;

            button81.Text = "5";
            button81.Enabled = false;

            button73.Text = "2";
            button73.Enabled = false;

            button70.Text = "7";
            button70.Enabled = false;

            button69.Text = "2";
            button69.Enabled = false;

            button67.Text = "6";
            button67.Enabled = false;

            button66.Text = "9";
            button66.Enabled = false;

            button62.Text = "4";
            button62.Enabled = false;

            button60.Text = "5";
            button60.Enabled = false;

            button58.Text = "8";
            button58.Enabled = false;

            button56.Text = "7";
            button56.Enabled = false;

        }

        public Button Button1 { get { return button1; } }
        public Button Button2 { get { return button2; } }
        public Button Button3 { get { return button3; } }
        public Button Button4 { get { return button4; } }
        public Button Button5 { get { return button5; } }
        public Button Button6 { get { return button6; } }
        public Button Button7 { get { return button7; } }
        public Button Button8 { get { return button8; } }
        public Button Button9 { get { return button9; } }
        public Button Button10 { get { return button10; } }
        public Button Button11 { get { return button11; } }
        public Button Button12 { get { return button12; } }
        public Button Button13 { get { return button13; } }
        public Button Button14 { get { return button14; } }
        public Button Button15 { get { return button15; } }
        public Button Button16 { get { return button16; } }
        public Button Button17 { get { return button17; } }
        public Button Button18 { get { return button18; } }
        public Button Button19 { get { return button19; } }
        public Button Button20 { get { return button20; } }
        public Button Button21 { get { return button21; } }
        public Button Button22 { get { return button22; } }
        public Button Button23 { get { return button23; } }
        public Button Button24 { get { return button24; } }
        public Button Button25 { get { return button25; } }
        public Button Button26 { get { return button26; } }
        public Button Button27 { get { return button27; } }
        public Button Button28 { get { return button28; } }
        public Button Button29 { get { return button29; } }
        public Button Button30 { get { return button30; } }
        public Button Button31 { get { return button31; } }
        public Button Button32 { get { return button32; } }
        public Button Button33 { get { return button33; } }
        public Button Button34 { get { return button34; } }
        public Button Button35 { get { return button35; } }
        public Button Button36 { get { return button36; } }
        public Button Button37 { get { return button37; } }
        public Button Button38 { get { return button38; } }
        public Button Button39 { get { return button39; } }
        public Button Button40 { get { return button40; } }
        public Button Button41 { get { return button41; } }
        public Button Button42 { get { return button42; } }
        public Button Button43 { get { return button43; } }
        public Button Button44 { get { return button44; } }
        public Button Button45 { get { return button45; } }
        public Button Button46 { get { return button46; } }
        public Button Button47 { get { return button47; } }
        public Button Button48 { get { return button48; } }
        public Button Button49 { get { return button49; } }
        public Button Button50 { get { return button50; } }
        public Button Button51 { get { return button51; } }
        public Button Button52 { get { return button52; } }
        public Button Button53 { get { return button53; } }
        public Button Button54 { get { return button54; } }
        public Button Button55 { get { return button55; } }
        public Button Button56 { get { return button56; } }
        public Button Button57 { get { return button57; } }
        public Button Button58 { get { return button58; } }
        public Button Button59 { get { return button59; } }
        public Button Button60 { get { return button60; } }
        public Button Button61 { get { return button61; } }
        public Button Button62 { get { return button62; } }
        public Button Button63 { get { return button63; } }
        public Button Button64 { get { return button64; } }
        public Button Button65 { get { return button65; } }
        public Button Button66 { get { return button66; } }
        public Button Button67 { get { return button67; } }
        public Button Button68 { get { return button68; } }
        public Button Button69 { get { return button69; } }
        public Button Button70 { get { return button70; } }
        public Button Button71 { get { return button71; } }
        public Button Button72 { get { return button72; } }
        public Button Button73 { get { return button73; } }
        public Button Button74 { get { return button74; } }
        public Button Button75 { get { return button75; } }
        public Button Button76 { get { return button76; } }
        public Button Button77 { get { return button77; } }
        public Button Button78 { get { return button78; } }
        public Button Button79 { get { return button79; } }
        public Button Button80 { get { return button80; } }
        public Button Button81 { get { return button81; } }

        string selected;
    
        public void button1_Click(object sender, EventArgs e)
        {
            Button field = (Button)sender;
            field.Text = selected;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            selected = number.Text;

        }

        public void button91_Click(object sender, EventArgs e)
        {
            int br = 0;
            bool checker = false;
            List<Button> numbers = new List<Button>
            {
                button82, button83, button84, button85, button86, button87, button88, button89, button90
            };

            List<Button> row1 = new List<Button>
            {
                button1, button2, button3, button4, button5, button6, button7, button8, button9
            };

            List<Button> row2 = new List<Button>
            {
                button10, button11, button12, button13, button14, button15, button16, button17, button18
            };

            List<Button> row3 = new List<Button>
            {
                button19, button20, button21, button22, button23, button24, button25, button26, button27
            };

            List<Button> row4 = new List<Button>
            {
                button46, button47, button48, button49, button50, button51, button52, button53, button54
            };

            List<Button> row5 = new List<Button>
            {
                button45, button37, button38, button39, button40, button41, button42, button43, button44
            };

            List<Button> row6 = new List<Button>
            {
                button28, button29, button30, button31, button32, button33, button34, button35, button36
            };

            List<Button> row7 = new List<Button>
            {
                button77, button78, button79, button80, button81, button73, button74, button75, button76
            };

            List<Button> row8 = new List<Button>
            {
                button67, button68, button69, button70, button71, button72, button64, button65, button66
            };

            List<Button> row9 = new List<Button>
            {
                button57, button58, button59, button60, button61, button62, button63, button55, button56
            };

            List<Button> col1 = new List<Button>
            {
                button1, button10, button19, button45, button54, button72, button81, button36, button63
            };

            List<Button> col2 = new List<Button>
            {
                button2, button11, button20, button44, button53, button71, button80, button35, button62
            };

            List<Button> col3 = new List<Button>
            {
                button3, button12, button21, button43, button52, button70, button79, button34, button61
            };

            List<Button> col4 = new List<Button>
            {
                button4, button13, button22, button42, button51, button69, button78, button33, button60
            };

            List<Button> col5 = new List<Button>
            {
                button5, button14, button23, button41, button50, button68, button77, button32, button59
            };

            List<Button> col6 = new List<Button>
            {
                button6, button15, button24, button40, button49, button67, button76, button31, button58
            };

            List<Button> col7 = new List<Button>
            {
                button7, button16, button25, button39, button48, button66, button75, button30, button57
            };

            List<Button> col8 = new List<Button>
            {
                button8, button17, button26, button38, button47, button65, button74, button29, button56
            };

            List<Button> col9 = new List<Button>
            {
                button9, button18, button27, button37, button46, button64, button73, button28, button55
            };

            List<Button> square1 = new List<Button>
            {
                button1, button2, button3, button10, button11, button12, button19, button20, button21
            };

            List<Button> square2 = new List<Button>
            {
                button4, button5, button6, button13, button14, button15, button22, button23, button24
            };

            List<Button> square3 = new List<Button>
            {
                button7, button8, button9, button16, button17, button18, button25, button26, button27
            };

            List<Button> square4 = new List<Button>
            {
                button54, button53, button52, button45, button44, button43, button36, button35, button34
            };

            List<Button> square5 = new List<Button>
            {
                button51, button50, button49, button42, button41, button40, button33, button32, button31
            };

            List<Button> square6 = new List<Button>
            {
                button48, button47, button46, button39, button38, button37, button30, button29, button28
            };

            List<Button> square7 = new List<Button>
            {
                button81, button80, button79, button72, button71, button70, button63, button62, button61
            };

            List<Button> square8 = new List<Button>
            {
                button78, button77, button76, button69, button68, button67, button60, button59, button58
            };

            List<Button> square9 = new List<Button>
            {
                button75, button74, button73, button66, button65, button64, button57, button56, button55
            };

            List<List<Button>> list = new List<List<Button>>{
                col1, col2, col3, col4, col5, col6, col7, col8, col9, row1, row2, row3, row4, row5, row6, row7, row8, row9, square1, square2, square3, square4, square5, square6, square7, square8, square9
            };

            for (int i = 0; i < list.Count; i++) {
                for (int j = 0; j < list[i].Count; j++) {

                    if (list[i][j].Text != "")
                        br += int.Parse(list[i][j].Text);
                    else {
                        MessageBox.Show("There are still some empty boxes!");
                        break;
                    }
                }

                if (br == 45) {
                    checker = true;
                    br = 0;
                }

                else {
                    checker = false;
                    br = 0;
                    break;
                }

            }

            if (checker)
            {
                MessageBox.Show("Correct! :) ");
                br = 0;
            }
            else {
                MessageBox.Show("Incorrect :( ");
                br = 0;
            }

        }

    }
}
