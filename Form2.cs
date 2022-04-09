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
using TICTACTOE_MA.Properties;

namespace TICTACTOE_MA
{
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            InitializeComponent();

            
        }


        

        public static int intCharacterSelect=0;
            public static Form1 MainGameForm = new Form1();
        public static Form2 CharSelectForm = new Form2();

        public void FormCharacterSelection_Load(object sender, EventArgs e)
        {


            Stream TitleTheme = Properties.Resources.Main_Theme;
            System.Media.SoundPlayer thm = new System.Media.SoundPlayer(TitleTheme);

            thm.Play();
            rdoMario.Checked = false;
            rdoGoombella.Checked = false;
            rdoKoops.Checked = false;
            rdoFlurrie.Checked = false;
            rdoYoshiKid.Checked = false;
            rdoBobbery.Checked = false;
            rdoMsMowz.Checked = false;
            MessageBox.Show("Welcome to the Paper Mario Tic Tac Toe Battle! Help Mario and his friends defeat the evil X-Naut forces. Begin by choosing your character!");
            
        }

        private void btnChooseChar_Click(object sender, EventArgs e)
        {
            if(rdoMario.Checked == true) 
            {
                intCharacterSelect = 1;
                
                CharSelectForm.Hide();
         
                MainGameForm.Show();
               
            }
            else if(rdoGoombella.Checked == true) 
            {
                intCharacterSelect = 2;

                
                this.Hide();
               
              
                MainGameForm.Show();
            }
            else if (rdoKoops.Checked == true)
            {
                intCharacterSelect = 3;

               
                this.Hide();
             
               
                MainGameForm.Show();
            }
            else if (rdoFlurrie.Checked == true)
            {
                intCharacterSelect = 4;
                
                this.Hide();
              
                
                MainGameForm.Show();
            }
            else if (rdoYoshiKid.Checked == true)
            {
                intCharacterSelect = 5;
                
                this.Hide();
           
                
                MainGameForm.Show();
            }
            else if (rdoVivian.Checked == true)
            {
                intCharacterSelect = 6;


                
                this.Hide();
                   
                MainGameForm.Show();
            }
            else if (rdoBobbery.Checked == true)
            {
                intCharacterSelect = 7;

                
                this.Hide();
              
             
                MainGameForm.Show();
            }
            else if (rdoMsMowz.Checked == true)
            {
                intCharacterSelect = 8;

                
                this.Hide();
        
                
                MainGameForm.Show();


            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
