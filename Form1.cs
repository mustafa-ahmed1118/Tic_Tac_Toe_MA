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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
            
        }
        
        //Game sound effects
        static Stream ActionCommand = Properties.Resources.Action_Command;
        System.Media.SoundPlayer snd = new System.Media.SoundPlayer(ActionCommand);

        static Stream PlayerWinsEffect = Properties.Resources.Stylish;
        System.Media.SoundPlayer sty = new System.Media.SoundPlayer(PlayerWinsEffect);

        static Stream BadMovePlayer = Properties.Resources.AC_Fail;
        System.Media.SoundPlayer acf = new System.Media.SoundPlayer(BadMovePlayer);

        static Stream PlayerLoseEffect = Properties.Resources.dazed;
        System.Media.SoundPlayer playlos = new System.Media.SoundPlayer(PlayerLoseEffect);

        static Stream MessageBoxEffect = Properties.Resources.MessageBox;
        System.Media.SoundPlayer msg = new System.Media.SoundPlayer(MessageBoxEffect);

        static Stream Blink = Properties.Resources.Blink;
        System.Media.SoundPlayer blnk = new System.Media.SoundPlayer(Blink);

        static Stream CrowdBoo = Properties.Resources.crowd_boo_2;
        System.Media.SoundPlayer boo = new System.Media.SoundPlayer(CrowdBoo);





        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Curtains_Background;
            
            this.rdoEasyDiff.Checked = false;
            this.rdoMediumDiff.Checked = false;
            this.rdoHardDiff.Checked = false;

            msg.Play();
            MessageBox.Show("Please select a game difficulty");
            blnk.Play();

            this.btn1.Enabled = false;
            this.btn2.Enabled = false;
            this.btn3.Enabled = false;
            this.btn4.Enabled = false;
            this.btn5.Enabled = false;
            this.btn6.Enabled = false;
            this.btn7.Enabled = false;
            this.btn8.Enabled = false;
            this.btn9.Enabled = false;

            this.btnRestart.Enabled = false;
            btnbtnEndGame.Enabled = false;

        }


        int intCompScore = 0;
        int intUserScore = 0;
        int intNumofGames = 0;
        int intNumofDraws = 0;

        //global variables
        bool blnClickedOne = false;
        bool blnClickedTwo = false;
        bool blnClickedThree = false;
        bool blnClickedFour = false;
        bool blnClickedFive = false;
        bool blnClickedSix = false;
        bool blnClickedSeven = false;
        bool blnClickedEight = false;
        bool blnClickedNine = false;

        bool blnPlayerTurn = true;

        int intCounterPlayer = -1;
        int intCounterComp = -1;

        int[] playerMoves = new int[5];
        int[] compMoves = new int[5];


        Random rnd = new Random();

        int intDiff = 0;

        
        public void NewGame()
        {
            
            MessageBox.Show("Get ready... The next battle begins now!");
            blnk.Play();
            //reset text on buttons
            this.btn1.BackgroundImage = null;
            this.btn2.BackgroundImage = null;
            this.btn3.BackgroundImage = null;
            this.btn4.BackgroundImage = null;
            this.btn5.BackgroundImage = null;
            this.btn6.BackgroundImage = null;
            this.btn7.BackgroundImage = null;
            this.btn8.BackgroundImage = null;
            this.btn9.BackgroundImage = null;

            //reset moves on buttons

            blnClickedOne = false;
            blnClickedTwo = false;
            blnClickedThree = false;
            blnClickedFour = false;
            blnClickedFive = false;
            blnClickedSix = false;
            blnClickedSeven = false;
            blnClickedEight = false;
            blnClickedNine = false;

            //re enable clicked buttons
            this.btn1.Enabled = true;
            this.btn2.Enabled = true;
            this.btn3.Enabled = true;
            this.btn4.Enabled = true;
            this.btn5.Enabled = true;
            this.btn6.Enabled = true;
            this.btn7.Enabled = true;
            this.btn8.Enabled = true;
            this.btn9.Enabled = true;


            //reset moves counter
            intCounterComp = -1;
            intCounterPlayer = -1;

            //reset the player and computer moves
            compMoves = new int[5];
            playerMoves = new int[5];

        }


        public void CheckWinner()
        {

            if (Winner(compMoves))
            {
                playlos.Play();//plays sound effect for player losing
                MessageBox.Show("No, it can't be...The X-Nauts won!");
                blnk.Play();
                intCompScore++;
                intNumofGames++;
                lblComputerScoreNumber.Text = intCompScore.ToString();
                lblGmeNumber.Text = intNumofGames.ToString();
                NewGame();
            }
            else if (Winner(playerMoves))
            {
                sty.Play();//plays sound effect for player winning
                MessageBox.Show("Mario and friends won!");
                blnk.Play();
                intUserScore++;
                intNumofGames++;
                lblPlayerScoreNum.Text = intUserScore.ToString();
                lblGmeNumber.Text = intNumofGames.ToString();
                NewGame();
                
            }
            else if ((intCounterPlayer + intCounterComp) == 7)
            {
                boo.Play();
                MessageBox.Show("BOOO! It's a draw!");
                blnk.Play();
                intNumofGames++;
                intNumofDraws++;
                lblGmeNumber.Text = intNumofGames.ToString();
                lblNumberOfDraws.Text = intNumofDraws.ToString();
                NewGame();
            }

        }

        public bool Winner(int[] intMoves)
        {
            bool blnWin = false;
            //check winer or end game
            if (intMoves[2] + intMoves[3] + intMoves[4] == 15)
            {
                if (intMoves[2] != 0 && intMoves[3] != 0 && intMoves[4] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[0] + intMoves[1] + intMoves[3] == 15)
            {
                if (intMoves[0] != 0 && intMoves[1] != 0 && intMoves[3] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[0] + intMoves[1] + intMoves[4] == 15)
            {
                if (intMoves[0] != 0 && intMoves[1] != 0 && intMoves[4] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[0] + intMoves[2] + intMoves[3] == 15)
            {
                if (intMoves[0] != 0 && intMoves[2] != 0 && intMoves[3] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[1] + intMoves[3] + intMoves[4] == 15)
            {
                if (intMoves[1] != 0 && intMoves[3] != 0 && intMoves[4] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[0] + intMoves[2] + intMoves[4] == 15)
            {
                if (intMoves[0] != 0 && intMoves[2] != 0 && intMoves[4] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[0] + intMoves[3] + intMoves[4] == 15)
            {
                if (intMoves[0] != 0 && intMoves[3] != 0 && intMoves[4] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[1] + intMoves[2] + intMoves[4] == 15)
            {
                if (intMoves[1] != 0 && intMoves[2] != 0 && intMoves[4] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[0] + intMoves[1] + intMoves[2] == 15)
            {
                if (intMoves[0] != 0 && intMoves[1] != 0 && intMoves[2] != 0)
                {
                    blnWin = true;
                }
            }
            else if (intMoves[1] + intMoves[2] + intMoves[3] == 15)
            {
                if (intMoves[1] != 0 && intMoves[2] != 0 && intMoves[3] != 0)
                {
                    blnWin = true;
                }
            }

            return blnWin;
        }

        public void ComputerMove()
        {
            if (intDiff == 1)
            {
                ComputerMoveEasy();
            }
            else if (intDiff == 2)
            {
                ComputerMoveMedium();
            }
            else if (intDiff == 3)
            {
                ComputerMoveHard();
            }

        }

        public void ComputerMoveEasy()
        {
            intCounterComp++;

            int rndMove;
            



            while (true)
            {
                rndMove = rnd.Next(1, 10); //random value 1 to 9



                if (rndMove == 1 && blnClickedOne == false)
                {
                    this.btn1.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 2;
                    blnClickedOne = true;
                    btn1.Enabled = false;
                    
                    snd.Play();
                    break;
                }
                else if (rndMove == 2 && blnClickedTwo == false)
                {
                    this.btn2.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 9;
                    blnClickedTwo = true;
                    
                    snd.Play();
                    btn2.Enabled = false;

                    break;
                }
                else if (rndMove == 3 && blnClickedThree == false)
                {
                    this.btn3.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 4;
                    blnClickedThree = true;
                    
                    snd.Play();
                    btn3.Enabled = false;

                    break;
                }
                else if (rndMove == 4 && blnClickedFour == false)
                {
                    this.btn4.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 7;
                    blnClickedFour = true;
                    btn4.Enabled = false;
                    
                    snd.Play();
                    break;
                }
                else if (rndMove == 5 && blnClickedFive == false)
                {
                    this.btn5.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 5;
                    blnClickedFive = true;
                    btn5.Enabled = false;
                   
                    snd.Play();
                    break;
                }
                else if (rndMove == 6 && blnClickedSix == false)
                {
                    this.btn6.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 3;
                    blnClickedSix = true;
                    btn6.Enabled = false;
                    
                    snd.Play();
                    break;
                }
                else if (rndMove == 7 && blnClickedSeven == false)
                {
                    this.btn7.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 6;
                    blnClickedSeven = true;
                    btn7.Enabled = false;
                    
                    snd.Play();
                    break;
                }
                else if (rndMove == 8 && blnClickedEight == false)
                {
                    this.btn8.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 1;
                    blnClickedEight = true;
                    btn8.Enabled = false;
                   
                    snd.Play();
                    break;
                }
                else if (rndMove == 9 && blnClickedNine == false)
                {
                    this.btn9.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 8;
                    blnClickedNine = true;
                    btn9.Enabled = false;
                    
                    snd.Play();
                    break;
                }
            }

            blnPlayerTurn = true;
            CheckWinner();
        }
        public void ComputerMoveMedium()
        {
            

            intCounterComp++;

            while (true)
            {


                //moves to cut off player at corners
                if (blnClickedFive == false)
                {
                    this.btn5.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 5;
                    blnClickedFive = true;
                    btn5.Enabled = false;
                    snd.Play();
                    break;
                }
                else if (blnClickedOne == false)
                {
                    this.btn1.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 2;
                    blnClickedOne = true;
                    btn1.Enabled = false;
                    snd.Play();
                    break;
                }
                else if (blnClickedThree == false)
                {
                    this.btn3.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 4;
                    blnClickedThree = true;
                    btn3.Enabled = false;
                    snd.Play();
                    break;
                }
                else if (blnClickedSeven == false)
                {
                    this.btn7.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 6;
                    blnClickedSeven = true;
                    btn7.Enabled = false;
                    snd.Play();
                    break;
                }
                else if (blnClickedNine == false)
                {
                    this.btn9.BackgroundImage = Resources.XNaut_Symbol; ;
                    compMoves[intCounterComp] = 8;
                    blnClickedNine = true;
                    btn9.Enabled = false;
                    snd.Play();
                    break;
                }

                //less significant moves
                else if (blnClickedFour == false)
                {
                    this.btn4.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 7;
                    blnClickedFour = true;
                    btn4.Enabled = false;
                    snd.Play();
                    break;
                }

                else if (blnClickedSix == false)
                {
                    this.btn6.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 3;
                    blnClickedSix = true;
                    btn6.Enabled = false;
                    snd.Play();
                    break;
                }


                else if (blnClickedEight == false)
                {
                    this.btn8.BackgroundImage = Resources.XNaut_Symbol; 
                    compMoves[intCounterComp] = 1;
                    blnClickedEight = true;
                    btn8.Enabled = false;
                    snd.Play();
                    break;
                }


                else if (blnClickedTwo == false)
                {
                    this.btn2.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 9;
                    blnClickedTwo = true;
                    btn2.Enabled = false;
                    snd.Play();
                    break;
                }
            }

            blnPlayerTurn = true;
            CheckWinner();
        }

        public void ComputerMoveHard()
        {
            intCounterComp++;

           //go for win if computer can win
                if ((BlockMove(compMoves)== 2 && (blnClickedOne ==false))|| 
                (BlockMove(compMoves) == 9 && (blnClickedTwo == false))||
                (BlockMove(compMoves) == 4 && (blnClickedThree == false))|| 
                (BlockMove(compMoves) == 7 && (blnClickedFour == false))|| 
                (BlockMove(compMoves) == 5 && (blnClickedFive == false))||
                (BlockMove(compMoves) == 3 && (blnClickedSix == false))|| 
                (BlockMove(compMoves) == 6 && (blnClickedSeven == false))||
                (BlockMove(compMoves) == 1 && (blnClickedEight == false))|| 
                (BlockMove(compMoves) == 8 && (blnClickedNine == false)))
                {
                 

                    if (BlockMove(compMoves) == 2)
                    {
                        btn1.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedOne = true;
                        compMoves[intCounterComp] = 2;
                        btn1.Enabled = false;
                      
                      

                    }
                    else if (BlockMove(compMoves) == 9)
                    {
                        btn2.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedTwo = true;
                        compMoves[intCounterComp] = 9;
                        btn2.Enabled = false;
                


                }
                    else if (BlockMove(compMoves) == 4)
                    {
                        btn3.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedThree = true;
                        compMoves[intCounterComp] = 4;
                        btn3.Enabled = false;
                 


                }
                    else if (BlockMove(compMoves) == 7)
                    {
                        btn4.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedFour = true;
                        compMoves[intCounterComp] = 7;
                        btn4.Enabled = false;
                  ;


                }
                    else if (BlockMove(compMoves) == 5)
                    {
                        btn5.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedFive = true;
                        compMoves[intCounterComp] = 5;
                        btn5.Enabled = false;
               


                }
                    else if (BlockMove(compMoves) == 3)
                    {
                        btn6.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedSix = true;
                        compMoves[intCounterComp] = 3;
                        btn6.Enabled = false;
              


                }
                    else if (BlockMove(compMoves) == 6)
                    {
                        btn7.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedSeven = true;
                        compMoves[intCounterComp] = 6;
                        btn7.Enabled = false;
         


                }
                    else if (BlockMove(compMoves) == 1)
                    {
                        btn8.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedEight = true;
                        compMoves[intCounterComp] = 1;
                        btn8.Enabled = false;
       


                }
                    else if (BlockMove(compMoves) == 8)
                    {
                        btn9.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedNine = true;
                        compMoves[intCounterComp] = 8;
                        btn9.Enabled = false;
           


                }

                }

                //block player if can't win and 
                else if ((BlockMove(playerMoves) == 2 && (blnClickedOne == false)) ||
                (BlockMove(playerMoves) == 9 && (blnClickedTwo == false)) ||
                (BlockMove(playerMoves) == 4 && (blnClickedThree == false)) ||
                (BlockMove(playerMoves) == 7 && (blnClickedFour == false)) ||
                (BlockMove(playerMoves) == 5 && (blnClickedFive == false)) ||
                (BlockMove(playerMoves) == 3 && (blnClickedSix == false)) ||
                (BlockMove(playerMoves) == 6 && (blnClickedSeven == false)) ||
                (BlockMove(playerMoves) == 1 && (blnClickedEight == false)) ||
                (BlockMove(playerMoves) == 8 && (blnClickedNine == false)))
            {
                    
                    if (BlockMove(playerMoves) == 2)
                    {
                        btn1.BackgroundImage = Resources.XNaut_Symbol; ;
                        blnClickedOne = true;
                        compMoves[intCounterComp] = 2;
                        btn1.Enabled = false;
                    acf.Play();


                }
                    else if (BlockMove(playerMoves) == 9)
                    {
                        btn2.BackgroundImage = Resources.XNaut_Symbol;
                        blnClickedTwo = true;
                        compMoves[intCounterComp] = 9;
                        btn2.Enabled = false;
                    acf.Play();



                }
                    else if (BlockMove(playerMoves) == 4)
                    {
                        btn3.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedThree = true;
                        compMoves[intCounterComp] = 4;
                        btn3.Enabled = false;
                    acf.Play();

                }
                    else if (BlockMove(playerMoves) == 7)
                    {
                        btn4.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedFour = true;
                        compMoves[intCounterComp] = 7;
                        btn4.Enabled = false;
                    acf.Play();

                }
                    else if (BlockMove(playerMoves) == 5)
                    {
                        btn5.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedFive = true;
                        compMoves[intCounterComp] = 5;
                        btn5.Enabled = false;
                    acf.Play();


                }
                    else if (BlockMove(playerMoves) == 3)
                    {
                        btn6.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedSix = true;
                        compMoves[intCounterComp] = 3;
                        btn6.Enabled = false;
                    acf.Play();


                }
                    else if (BlockMove(playerMoves) == 6)
                    {
                        btn7.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedSeven = true;
                        compMoves[intCounterComp] = 6;
                        btn7.Enabled = false;
                    acf.Play();

                }
                    else if (BlockMove(playerMoves) == 1)
                    {
                        btn8.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedEight = true;
                        compMoves[intCounterComp] = 1;
                        btn8.Enabled = false;
                    acf.Play();

                }
                    else if (BlockMove(playerMoves) == 8)
                    {
                        btn9.BackgroundImage = Resources.XNaut_Symbol;
                    blnClickedNine = true;
                        compMoves[intCounterComp] = 8;
                        btn9.Enabled = false;
                    acf.Play();

                }
                }

                //if can't win or block go for whatever available tile
                else
                {
                   
                    //moves to cut off player at corners
                    if (blnClickedFive == false)
                    {
                        this.btn5.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 5;
                        blnClickedFive = true;
                    btn5.Enabled = false;
                    snd.Play();
               
                    }
                    else if (blnClickedOne == false)
                    {
                        this.btn1.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 2;
                        blnClickedOne = true;
                        btn1.Enabled = false;
                    snd.Play();

                }
                    else if (blnClickedThree == false)
                    {
                        this.btn3.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 4;
                        blnClickedThree = true;
                        btn3.Enabled = false;
                    snd.Play();

                }
                    else if (blnClickedSeven == false)
                    {
                        this.btn7.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 6;
                        blnClickedSeven = true;
                        btn7.Enabled = false;
                    snd.Play();

                }
                    else if (blnClickedNine == false)
                    {
                        this.btn9.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 8;
                        blnClickedNine = true;
                        btn9.Enabled = false;
                    snd.Play();

                }

                    //less significant moves
                    else if (blnClickedFour == false)
                    {
                        this.btn4.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 7;
                        blnClickedFour = true;
                        btn4.Enabled = false;
                    snd.Play();


                }

                    else if (blnClickedSix == false)
                    {
                        this.btn6.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 3;
                        blnClickedSix = true;
                        btn6.Enabled = false;
                    snd.Play();


                }


                    else if (blnClickedEight == false)
                    {
                        this.btn8.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 1;
                        blnClickedEight = true;
                        btn8.Enabled = false;
                    snd.Play();


                }


                    else if (blnClickedTwo == false)
                    {
                        this.btn2.BackgroundImage = Resources.XNaut_Symbol;
                    compMoves[intCounterComp] = 9;
                        blnClickedTwo = true;
                        btn2.Enabled = false;
                    snd.Play();

                }

                }
               

            

            blnPlayerTurn = true;
            CheckWinner();
        }
        
        
     //determine computer hard moves
            public int BlockMove(int[] Move)
            {
                int intMoveToMake = 0;

                //BLOCK 1

                //block move at 1 if 9 4 taken
                if ((Move[0] == 4 && Move[1] == 9 && (15-Move[0]-Move[1]==2)) ||
                (Move[0] == 9 && Move[1] == 4 && (15 - Move[0] - Move[1] == 2)) ||
                (Move[0] == 4 && Move[2] == 9 && (15 - Move[0] - Move[2] == 2)) ||
                (Move[0] == 9 && Move[2] == 4 && (15 - Move[0] - Move[2] == 2)) ||
                (Move[0] == 4 && Move[3] == 9 && (15 - Move[0] - Move[3] == 2)) ||
                (Move[0] == 9 && Move[3] == 4 && (15 - Move[0] - Move[3] == 2)) ||
                (Move[0] == 4 && Move[4] == 9 && (15 - Move[0] - Move[4] == 2)) ||
                (Move[0] == 9 && Move[4] == 4 && (15 - Move[0] - Move[4] == 2)) ||

                (Move[1] == 9 && Move[2] == 4 && (15 - Move[1] - Move[2] == 2)) ||
                (Move[1] == 4 && Move[2] == 9 && (15 - Move[1] - Move[2] == 2)) ||
                (Move[1] == 9 && Move[3] == 4 && (15 - Move[1] - Move[3] == 2)) ||
                (Move[1] == 4 && Move[3] == 9 && (15 - Move[1] - Move[3] == 2)) ||
                (Move[1] == 9 && Move[4] == 4 && (15 - Move[1] - Move[4] == 2)) ||
                (Move[1] == 4 && Move[4] == 9 && (15 - Move[1] - Move[4] == 2)) ||

                (Move[2] == 9 && Move[3] == 4 && (15 - Move[2] - Move[3] == 2)) ||
                (Move[2] == 4 && Move[3] == 9 && (15 - Move[2] - Move[3] == 2)) ||
                (Move[2] == 9 && Move[4] == 4 && (15 - Move[2] - Move[4] == 2)) ||
                (Move[2] == 4 && Move[4] == 9 && (15 - Move[2] - Move[4] == 2)) ||


                (Move[3] == 9 && Move[4] == 4 && (15 - Move[3] - Move[4] == 2)) ||
                (Move[3] == 4 && Move[4] == 4 && (15 - Move[3] - Move[4] == 2)))
                {
                    intMoveToMake = 2;
                }

                //block move at 1 if 7 6 taken
                else if ((Move[0] == 7 && Move[1] == 6 && (15 - Move[0] - Move[1] == 2)) ||
                (Move[0] == 6 && Move[1] == 7 && (15 - Move[0] - Move[1] == 2)) ||
                (Move[0] == 7 && Move[2] == 6 && (15 - Move[0] - Move[2] == 2)) ||
                (Move[0] == 6 && Move[2] == 7 && (15 - Move[0] - Move[2] == 2)) ||
                (Move[0] == 7 && Move[3] == 6 && (15 - Move[0] - Move[3] == 2)) ||
                (Move[0] == 6 && Move[3] == 7 && (15 - Move[0] - Move[3] == 2)) ||
                (Move[0] == 7 && Move[4] == 6 && (15 - Move[0] - Move[4] == 2)) ||
                (Move[0] == 6 && Move[4] == 7 && (15 - Move[0] - Move[4] == 2)) ||

                (Move[1] == 7 && Move[2] == 6 && (15 - Move[1] - Move[2] == 2)) ||
                (Move[1] == 6 && Move[2] == 7 && (15 - Move[1] - Move[2] == 2)) ||
                (Move[1] == 7 && Move[3] == 6 && (15 - Move[1] - Move[3] == 2)) ||
                (Move[1] == 6 && Move[3] == 7 && (15 - Move[1] - Move[3] == 2)) ||
                (Move[1] == 7 && Move[4] == 6 && (15 - Move[1] - Move[4] == 2)) ||
                (Move[1] == 6 && Move[4] == 7 && (15 - Move[1] - Move[4] == 2)) ||

                (Move[2] == 7 && Move[3] == 6 && (15 - Move[2] - Move[3] == 2)) ||
                (Move[2] == 6 && Move[3] == 7 && (15 - Move[2] - Move[3] == 2)) ||
                (Move[2] == 7 && Move[4] == 6 && (15 - Move[2] - Move[4] == 2)) ||
                (Move[2] == 6 && Move[4] == 7 && (15 - Move[2] - Move[4] == 2)) ||


                (Move[3] == 7 && Move[4] == 6 && (15 - Move[3] - Move[4] == 2)) ||
                (Move[3] == 6 && Move[4] == 7 && (15 - Move[3] - Move[4] == 2)))
                {
                    intMoveToMake = 2;
                }

                //block 1 if 5 and 8 taken
                else if ((Move[0] == 5 && Move[1] == 8 && (15 - Move[0] - Move[1] == 2)) ||
                (Move[0] == 8 && Move[1] == 5 && (15 - Move[0] - Move[1] == 2)) ||
                (Move[0] == 5 && Move[2] == 8 && (15 - Move[0] - Move[2] == 2)) ||
                (Move[0] == 8 && Move[2] == 5 && (15 - Move[0] - Move[2] == 2)) ||
                (Move[0] == 5 && Move[3] == 8 && (15 - Move[0] - Move[3] == 2)) ||
                (Move[0] == 8 && Move[3] == 5 && (15 - Move[0] - Move[3] == 2)) ||
                (Move[0] == 5 && Move[4] == 8 && (15 - Move[0] - Move[4] == 2)) ||
                (Move[0] == 8 && Move[4] == 5 && (15 - Move[0] - Move[4] == 2)) ||

                (Move[1] == 5 && Move[2] == 8 && (15 - Move[1] - Move[2] == 2)) ||
                (Move[1] == 8 && Move[2] == 5 && (15 - Move[1] - Move[2] == 2)) ||
                (Move[1] == 5 && Move[3] == 8 && (15 - Move[1] - Move[3] == 2)) ||
                (Move[1] == 8 && Move[3] == 5 && (15 - Move[1] - Move[3] == 2)) ||
                (Move[1] == 5 && Move[4] == 8 && (15 - Move[1] - Move[4] == 2)) ||
                (Move[1] == 8 && Move[4] == 5 && (15 - Move[1] - Move[4] == 2)) ||

                (Move[2] == 5 && Move[3] == 8 && (15 - Move[2] - Move[3] == 2)) ||
                (Move[2] == 8 && Move[3] == 5 && (15 - Move[2] - Move[3] == 2)) ||
                (Move[2] == 5 && Move[4] == 8 && (15 - Move[2] - Move[4] == 2)) ||
                (Move[2] == 8 && Move[4] == 5 && (15 - Move[2] - Move[4] == 2)) ||


                (Move[3] == 5 && Move[4] == 8 && (15 - Move[3] - Move[4] == 2)) ||
                (Move[3] == 8 && Move[4] == 5 && (15 - Move[3] - Move[4] == 2)))
                {
                    intMoveToMake = 2;
                }

                //BLOCK 2

                //block 2 if 5 1 taken
                else if ((Move[0] == 5 && Move[1] == 1 && (15 - Move[0] - Move[1] == 9)) ||
                (Move[0] == 1 && Move[1] == 5 && (15 - Move[0] - Move[1] == 9)) ||
                (Move[0] == 5 && Move[2] == 1 && (15 - Move[0] - Move[2] == 9)) ||
                (Move[0] == 1 && Move[2] == 5 && (15 - Move[0] - Move[2] == 9)) ||
                (Move[0] == 5 && Move[3] == 1 && (15 - Move[0] - Move[3] == 9)) ||
                (Move[0] == 1 && Move[3] == 5 && (15 - Move[0] - Move[3] == 9)) ||
                (Move[0] == 5 && Move[4] == 1 && (15 - Move[0] - Move[4] == 9)) ||
                (Move[0] == 1 && Move[4] == 5 && (15 - Move[0] - Move[4] == 9)) ||

                (Move[1] == 5 && Move[2] == 1 && (15 - Move[1] - Move[2] == 9)) ||
                (Move[1] == 1 && Move[2] == 5 && (15 - Move[1] - Move[2] == 9)) ||
                (Move[1] == 5 && Move[3] == 1 && (15 - Move[1] - Move[3] == 9)) ||
                (Move[1] == 1 && Move[3] == 5 && (15 - Move[1] - Move[3] == 9)) ||
                (Move[1] == 5 && Move[4] == 1 && (15 - Move[1] - Move[4] == 9)) ||
                (Move[1] == 1 && Move[4] == 5 && (15 - Move[1] - Move[4] == 9)) ||

                (Move[2] == 5 && Move[3] == 1 && (15 - Move[2] - Move[3] == 9)) ||
                (Move[2] == 1 && Move[3] == 5 && (15 - Move[2] - Move[3] == 9)) ||
                (Move[2] == 5 && Move[4] == 1 && (15 - Move[2] - Move[4] == 9)) ||
                (Move[2] == 1 && Move[4] == 5 && (15 - Move[2] - Move[4] == 9)) ||


                (Move[3] == 5 && Move[4] == 1 && (15 - Move[3] - Move[4] == 9)) ||
                (Move[3] == 1 && Move[4] == 5 && (15 - Move[3] - Move[4] == 9)))
                {
                    intMoveToMake = 9;
                }

                //block 2 if 2 4 taken
                else if ((Move[0] == 2 && Move[1] == 4 && (15 - Move[0] - Move[1] == 9)) ||
                (Move[0] == 4 && Move[1] == 2 && (15 - Move[0] - Move[1] == 9)) ||
                (Move[0] == 2 && Move[2] == 4 && (15 - Move[0] - Move[2] == 9)) ||
                (Move[0] == 4 && Move[2] == 2 && (15 - Move[0] - Move[2] == 9)) ||
                (Move[0] == 2 && Move[3] == 4 && (15 - Move[0] - Move[3] == 9)) ||
                (Move[0] == 4 && Move[3] == 2 && (15 - Move[0] - Move[3] == 9)) ||
                (Move[0] == 2 && Move[4] == 4 && (15 - Move[0] - Move[4] == 9)) ||
                (Move[0] == 4 && Move[4] == 2 && (15 - Move[0] - Move[4] == 9)) ||

                (Move[1] == 2 && Move[2] == 4 && (15 - Move[1] - Move[2] == 9)) ||
                (Move[1] == 4 && Move[2] == 2 && (15 - Move[1] - Move[2] == 9)) ||
                (Move[1] == 2 && Move[3] == 4 && (15 - Move[1] - Move[3] == 9)) ||
                (Move[1] == 4 && Move[3] == 2 && (15 - Move[1] - Move[3] == 9)) ||
                (Move[1] == 2 && Move[4] == 4 && (15 - Move[1] - Move[4] == 9)) ||
                (Move[1] == 4 && Move[4] == 2 && (15 - Move[1] - Move[4] == 9)) ||

                (Move[2] == 2 && Move[3] == 4 && (15 - Move[2] - Move[3] == 9)) ||
                (Move[2] == 4 && Move[3] == 2 && (15 - Move[2] - Move[3] == 9)) ||
                (Move[2] == 2 && Move[4] == 4 && (15 - Move[2] - Move[4] == 9)) ||
                (Move[2] == 4 && Move[4] == 2 && (15 - Move[2] - Move[4] == 9)) ||


                (Move[3] == 2 && Move[4] == 4 && (15 - Move[3] - Move[4] == 9)) ||
                (Move[3] == 4 && Move[4] == 2 && (15 - Move[3] - Move[4] == 9)))
                {
                    intMoveToMake = 9;
                }

                //BLOCK 3

                //block 3 if 6 5 taken
                else if ((Move[0] == 6 && Move[1] == 5 && (15 - Move[0] - Move[1] == 4)) ||
                    (Move[0] == 5 && Move[1] == 6 && (15 - Move[0] - Move[1] == 4)) ||
                    (Move[0] == 6 && Move[2] == 5 && (15 - Move[0] - Move[2] == 4)) ||
                    (Move[0] == 5 && Move[2] == 6 && (15 - Move[0] - Move[2] == 4)) ||
                    (Move[0] == 6 && Move[3] == 5 && (15 - Move[0] - Move[3] == 4)) ||
                    (Move[0] == 5 && Move[3] == 6 && (15 - Move[0] - Move[3] == 4)) ||
                    (Move[0] == 6 && Move[4] == 5 && (15 - Move[0] - Move[4] == 4)) ||
                    (Move[0] == 5 && Move[4] == 6 && (15 - Move[0] - Move[4] == 4)) ||

                    (Move[1] == 6 && Move[2] == 5 && (15 - Move[1] - Move[2] == 4)) ||
                    (Move[1] == 5 && Move[2] == 6 && (15 - Move[1] - Move[2] == 4)) ||
                    (Move[1] == 6 && Move[3] == 5 && (15 - Move[1] - Move[3] == 4)) ||
                    (Move[1] == 5 && Move[3] == 6 && (15 - Move[1] - Move[3] == 4)) ||
                    (Move[1] == 6 && Move[4] == 5 && (15 - Move[1] - Move[4] == 4)) ||
                    (Move[1] == 5 && Move[4] == 6 && (15 - Move[1] - Move[4] == 4)) ||

                    (Move[2] == 6 && Move[3] == 5 && (15 - Move[2] - Move[3] == 4)) ||
                    (Move[2] == 5 && Move[3] == 6 && (15 - Move[2] - Move[3] == 4)) ||
                    (Move[2] == 6 && Move[4] == 5 && (15 - Move[2] - Move[4] == 4)) ||
                    (Move[2] == 5 && Move[4] == 6 && (15 - Move[2] - Move[4] == 4)) ||


                    (Move[3] == 6 && Move[4] == 5 && (15 - Move[3] - Move[4] == 4)) ||
                    (Move[3] == 5 && Move[4] == 6) && (15 - Move[3] - Move[4] == 4))
                {
                    intMoveToMake = 4;
                }

                // block 3 if 3 8 taken
                else if ((Move[0] == 3 && Move[1] == 8 && (15 - Move[0] - Move[1] == 4)) ||
                    (Move[0] == 8 && Move[1] == 3 && (15 - Move[0] - Move[1] == 4)) ||
                    (Move[0] == 3 && Move[2] == 8 && (15 - Move[0] - Move[2] == 4)) ||
                    (Move[0] == 8 && Move[2] == 3 && (15 - Move[0] - Move[2] == 4)) ||
                    (Move[0] == 3 && Move[3] == 8 && (15 - Move[0] - Move[3] == 4)) ||
                    (Move[0] == 8 && Move[3] == 3 && (15 - Move[0] - Move[3] == 4)) ||
                    (Move[0] == 3 && Move[4] == 8 && (15 - Move[0] - Move[4] == 4)) ||
                    (Move[0] == 8 && Move[4] == 3 && (15 - Move[0] - Move[4] == 4)) ||

                    (Move[1] == 3 && Move[2] == 8 && (15 - Move[1] - Move[2] == 4)) ||
                    (Move[1] == 8 && Move[2] == 3 && (15 - Move[1] - Move[2] == 4)) ||
                    (Move[1] == 3 && Move[3] == 8 && (15 - Move[1] - Move[3] == 4)) ||
                    (Move[1] == 8 && Move[3] == 3 && (15 - Move[1] - Move[3] == 4)) ||
                    (Move[1] == 3 && Move[4] == 8 && (15 - Move[1] - Move[4] == 4)) ||
                    (Move[1] == 8 && Move[4] == 3 && (15 - Move[1] - Move[4] == 4)) ||

                    (Move[2] == 3 && Move[3] == 8 && (15 - Move[2] - Move[3] == 4)) ||
                    (Move[2] == 8 && Move[3] == 3 && (15 - Move[2] - Move[3] == 4)) ||
                    (Move[2] == 3 && Move[4] == 8 && (15 - Move[2] - Move[4] == 4)) ||
                    (Move[2] == 8 && Move[4] == 3 && (15 - Move[2] - Move[4] == 4)) ||


                    (Move[3] == 3 && Move[4] == 8 && (15 - Move[3] - Move[4] == 4)) ||
                    (Move[3] == 8 && Move[4] == 3 && (15 - Move[3] - Move[4] == 4)))
                {
                    intMoveToMake = 4;
                }
                //block 3 if 2 9  taken
                else if ((Move[0] == 2 && Move[1] == 9 && (15 - Move[0] - Move[1] == 4)) ||
                    (Move[0] == 9 && Move[1] == 2 && (15 - Move[0] - Move[1] == 4)) ||
                    (Move[0] == 2 && Move[2] == 9 && (15 - Move[0] - Move[2] == 4)) ||
                    (Move[0] == 9 && Move[2] == 2 && (15 - Move[0] - Move[2] == 4)) ||
                    (Move[0] == 2 && Move[3] == 9 && (15 - Move[0] - Move[3] == 4)) ||
                    (Move[0] == 9 && Move[3] == 2 && (15 - Move[0] - Move[3] == 4)) ||
                    (Move[0] == 2 && Move[4] == 9 && (15 - Move[0] - Move[4] == 4)) ||
                    (Move[0] == 9 && Move[4] == 2 && (15 - Move[0] - Move[4] == 4)) ||

                    (Move[1] == 2 && Move[2] == 9 && (15 - Move[1] - Move[2] == 4)) ||
                    (Move[1] == 9 && Move[2] == 2 && (15 - Move[1] - Move[2] == 4)) ||
                    (Move[1] == 2 && Move[3] == 9 && (15 - Move[1] - Move[3] == 4)) ||
                    (Move[1] == 9 && Move[3] == 2 && (15 - Move[1] - Move[3] == 4)) ||
                    (Move[1] == 2 && Move[4] == 9 && (15 - Move[1] - Move[4] == 4)) ||
                    (Move[1] == 9 && Move[4] == 2 && (15 - Move[1] - Move[4] == 4)) ||

                    (Move[2] == 2 && Move[3] == 9 && (15 - Move[2] - Move[3] == 4)) ||
                    (Move[2] == 9 && Move[3] == 2 && (15 - Move[2] - Move[3] == 4)) ||
                    (Move[2] == 2 && Move[4] == 9 && (15 - Move[2] - Move[4] == 4)) ||
                    (Move[2] == 9 && Move[4] == 2 && (15 - Move[2] - Move[4] == 4)) ||


                    (Move[3] == 2 && Move[4] == 9 && (15 - Move[3] - Move[4] == 4)) ||
                    (Move[3] == 9 && Move[4] == 2 && (15 - Move[3] - Move[4] == 4)))
                {
                    intMoveToMake = 4;
                }

                //BLOCK 4

                //block 4 if 5 3 takem
                else if ((Move[0] == 5 && Move[1] == 3 && (15 - Move[0] - Move[1] == 7)) ||
                  (Move[0] == 3 && Move[1] == 5 && (15 - Move[0] - Move[1] == 7)) ||
                  (Move[0] == 5 && Move[2] == 3 && (15 - Move[0] - Move[2] == 7)) ||
                  (Move[0] == 3 && Move[2] == 5 && (15 - Move[0] - Move[2] == 7)) ||
                  (Move[0] == 5 && Move[3] == 3 && (15 - Move[0] - Move[3] == 7)) ||
                  (Move[0] == 3 && Move[3] == 5 && (15 - Move[0] - Move[3] == 7)) ||
                  (Move[0] == 5 && Move[4] == 3 && (15 - Move[0] - Move[4] == 7)) ||
                  (Move[0] == 3 && Move[4] == 5 && (15 - Move[0] - Move[4] == 7)) ||

                  (Move[1] == 5 && Move[2] == 3 && (15 - Move[1] - Move[2] == 7)) ||
                  (Move[1] == 3 && Move[2] == 2 && (15 - Move[1] - Move[2] == 7)) ||
                  (Move[1] == 5 && Move[3] == 3 && (15 - Move[1] - Move[3] == 7)) ||
                  (Move[1] == 3 && Move[3] == 2 && (15 - Move[1] - Move[3] == 7)) ||
                  (Move[1] == 5 && Move[4] == 3 && (15 - Move[1] - Move[4] == 7)) ||
                  (Move[1] == 3 && Move[4] == 2 && (15 - Move[1] - Move[4] == 7)) ||

                  (Move[2] == 5 && Move[3] == 3 && (15 - Move[2] - Move[3] == 7)) ||
                  (Move[2] == 3 && Move[3] == 2 && (15 - Move[2] - Move[3] == 7)) ||
                  (Move[2] == 5 && Move[4] == 3 && (15 - Move[2] - Move[4] == 7)) ||
                  (Move[2] == 3 && Move[4] == 2 && (15 - Move[2] - Move[4] == 7)) ||


                  (Move[3] == 5 && Move[4] == 9 && (15 - Move[3] - Move[4] == 7)) ||
                  (Move[3] == 3 && Move[4] == 2 && (15 - Move[3] - Move[4] == 7)))
                {
                    intMoveToMake = 7;
                }

                //block 4 if 2 6 taken
                else if ((Move[0] == 2 && Move[1] == 6 && (15 - Move[0] - Move[1] == 7)) ||
                  (Move[0] == 6 && Move[1] == 2 && (15 - Move[0] - Move[1] == 7)) ||
                  (Move[0] == 2 && Move[2] == 6 && (15 - Move[0] - Move[2] == 7)) ||
                  (Move[0] == 6 && Move[2] == 2 && (15 - Move[0] - Move[2] == 7)) ||
                  (Move[0] == 2 && Move[3] == 6 && (15 - Move[0] - Move[3] == 7)) ||
                  (Move[0] == 6 && Move[3] == 2 && (15 - Move[0] - Move[3] == 7)) ||
                  (Move[0] == 2 && Move[4] == 6 && (15 - Move[0] - Move[4] == 7)) ||
                  (Move[0] == 6 && Move[4] == 2 && (15 - Move[0] - Move[4] == 7)) ||

                  (Move[1] == 2 && Move[2] == 6 && (15 - Move[1] - Move[2] == 7)) ||
                  (Move[1] == 6 && Move[2] == 2 && (15 - Move[1] - Move[2] == 7)) ||
                  (Move[1] == 2 && Move[3] == 6 && (15 - Move[1] - Move[3] == 7)) ||
                  (Move[1] == 6 && Move[3] == 2 && (15 - Move[1] - Move[3] == 7)) ||
                  (Move[1] == 2 && Move[4] == 6 && (15 - Move[1] - Move[4] == 7)) ||
                  (Move[1] == 6 && Move[4] == 2 && (15 - Move[1] - Move[4] == 7)) ||

                  (Move[2] == 2 && Move[3] == 6 && (15 - Move[2] - Move[3] == 7)) ||
                  (Move[2] == 6 && Move[3] == 2 && (15 - Move[2] - Move[3] == 7)) ||
                  (Move[2] == 2 && Move[4] == 6 && (15 - Move[2] - Move[4] == 7)) ||
                  (Move[2] == 6 && Move[4] == 2 && (15 - Move[2] - Move[4] == 7)) ||


                  (Move[3] == 2 && Move[4] == 6 && (15 - Move[3] - Move[4] == 7)) ||
                  (Move[3] == 6 && Move[4] == 2 && (15 - Move[3] - Move[4] == 7)))
                {
                    intMoveToMake = 7;
                }

                //BLOCK 5

                //if 2 8 taken 
                else if ((Move[0] == 2 && Move[1] == 8 && (15 - Move[0] - Move[1] == 5)) ||
                  (Move[0] == 8 && Move[1] == 2 && (15 - Move[0] - Move[1] == 5)) ||
                  (Move[0] == 2 && Move[2] == 8 && (15 - Move[0] - Move[2] == 5)) ||
                  (Move[0] == 8 && Move[2] == 2 && (15 - Move[0] - Move[2] == 5)) ||
                  (Move[0] == 2 && Move[3] == 8 && (15 - Move[0] - Move[3] == 5)) ||
                  (Move[0] == 8 && Move[3] == 2 && (15 - Move[0] - Move[3] == 5)) ||
                  (Move[0] == 2 && Move[4] == 8 && (15 - Move[0] - Move[4] == 5)) ||
                  (Move[0] == 8 && Move[4] == 2 && (15 - Move[0] - Move[4] == 5)) ||

                  (Move[1] == 2 && Move[2] == 8 && (15 - Move[1] - Move[2] == 5)) ||
                  (Move[1] == 8 && Move[2] == 2 && (15 - Move[1] - Move[2] == 5)) ||
                  (Move[1] == 2 && Move[3] == 8 && (15 - Move[1] - Move[3] == 5)) ||
                  (Move[1] == 8 && Move[3] == 2 && (15 - Move[1] - Move[3] == 5)) ||
                  (Move[1] == 2 && Move[4] == 8 && (15 - Move[1] - Move[4] == 5)) ||
                  (Move[1] == 8 && Move[4] == 2 && (15 - Move[1] - Move[4] == 5)) ||

                  (Move[2] == 2 && Move[3] == 8 && (15 - Move[2] - Move[3] == 5)) ||
                  (Move[2] == 8 && Move[3] == 2 && (15 - Move[2] - Move[3] == 5)) ||
                  (Move[2] == 2 && Move[4] == 8 && (15 - Move[2] - Move[4] == 5)) ||
                  (Move[2] == 8 && Move[4] == 2 && (15 - Move[2] - Move[4] == 5)) ||


                  (Move[3] == 2 && Move[4] == 8 && (15 - Move[3] - Move[4] == 5)) ||
                  (Move[3] == 8 && Move[4] == 2 && (15 - Move[3] - Move[4] == 5)))
                {
                    intMoveToMake = 5;
                }

                //if 6 4 taken
                else if ((Move[0] == 4 && Move[1] == 6 && (15 - Move[0] - Move[1] == 5)) ||
                   (Move[0] == 6 && Move[1] == 4 && (15 - Move[0] - Move[1] == 5)) ||
                   (Move[0] == 4 && Move[2] == 6 && (15 - Move[0] - Move[2] == 5)) ||
                   (Move[0] == 6 && Move[2] == 4 && (15 - Move[0] - Move[2] == 5)) ||
                   (Move[0] == 4 && Move[3] == 6 && (15 - Move[0] - Move[3] == 5)) ||
                   (Move[0] == 6 && Move[3] == 4 && (15 - Move[0] - Move[3] == 5)) ||
                   (Move[0] == 4 && Move[4] == 6 && (15 - Move[0] - Move[4] == 5)) ||
                   (Move[0] == 6 && Move[4] == 4 && (15 - Move[0] - Move[4] == 5)) ||

                   (Move[1] == 4 && Move[2] == 6 && (15 - Move[1] - Move[2] == 5)) ||
                   (Move[1] == 6 && Move[2] == 4 && (15 - Move[1] - Move[2] == 5)) ||
                   (Move[1] == 4 && Move[3] == 6 && (15 - Move[1] - Move[3] == 5)) ||
                   (Move[1] == 6 && Move[3] == 4 && (15 - Move[1] - Move[3] == 5)) ||
                   (Move[1] == 4 && Move[4] == 6 && (15 - Move[1] - Move[4] == 5)) ||
                   (Move[1] == 6 && Move[4] == 4 && (15 - Move[1] - Move[4] == 5)) ||

                   (Move[2] == 4 && Move[3] == 6 && (15 - Move[2] - Move[3] == 5)) ||
                   (Move[2] == 6 && Move[3] == 4 && (15 - Move[2] - Move[3] == 5)) ||
                   (Move[2] == 4 && Move[4] == 6 && (15 - Move[2] - Move[4] == 5)) ||
                   (Move[2] == 6 && Move[4] == 4 && (15 - Move[2] - Move[4] == 5)) ||


                   (Move[3] == 4 && Move[4] == 6 && (15 - Move[3] - Move[4] == 5)) ||
                   (Move[3] == 6 && Move[4] == 4 && (15 - Move[3] - Move[4] == 5)))
                { 
                
                    intMoveToMake = 5;
                }

                //if 9 1 taken
                else if ((Move[0] == 9 && Move[1] == 1 && (15 - Move[0] - Move[1] == 5)) ||
                   (Move[0] == 1 && Move[1] == 9 && (15 - Move[0] - Move[1] == 5)) ||
                   (Move[0] == 9 && Move[2] == 1 && (15 - Move[0] - Move[2] == 5)) ||
                   (Move[0] == 1 && Move[2] == 9 && (15 - Move[0] - Move[2] == 5)) ||
                   (Move[0] == 9 && Move[3] == 1 && (15 - Move[0] - Move[3] == 5)) ||
                   (Move[0] == 1 && Move[3] == 9 && (15 - Move[0] - Move[3] == 5)) ||
                   (Move[0] == 9 && Move[4] == 1 && (15 - Move[0] - Move[4] == 5)) ||
                   (Move[0] == 1 && Move[4] == 9 && (15 - Move[0] - Move[4] == 5)) ||

                   (Move[1] == 9 && Move[2] == 1 && (15 - Move[1] - Move[2] == 5)) ||
                   (Move[1] == 1 && Move[2] == 9 && (15 - Move[1] - Move[2] == 5)) ||
                   (Move[1] == 9 && Move[3] == 1 && (15 - Move[1] - Move[3] == 5)) ||
                   (Move[1] == 1 && Move[3] == 9 && (15 - Move[1] - Move[3] == 5)) ||
                   (Move[1] == 9 && Move[4] == 1 && (15 - Move[1] - Move[4] == 5)) ||
                   (Move[1] == 1 && Move[4] == 9 && (15 - Move[1] - Move[4] == 5)) ||

                   (Move[2] == 9 && Move[3] == 1 && (15 - Move[2] - Move[3] == 5)) ||
                   (Move[2] == 1 && Move[3] == 9 && (15 - Move[2] - Move[3] == 5)) ||
                   (Move[2] == 9 && Move[4] == 1 && (15 - Move[2] - Move[4] == 5)) ||
                   (Move[2] == 1 && Move[4] == 9 && (15 - Move[2] - Move[4] == 5)) ||


                   (Move[3] == 9 && Move[4] == 9 && (15 - Move[3] - Move[4] == 5)) ||
                   (Move[3] == 1 && Move[4] == 1 && (15 - Move[3] - Move[4] == 5)))
                {
                    intMoveToMake = 5;
                }

                //if 7 3 taken
                else if ((Move[0] == 7 && Move[1] == 3 && (15 - Move[0] - Move[1] == 5)) ||
                   (Move[0] == 3 && Move[1] == 7 && (15 - Move[0] - Move[1] == 5)) ||
                   (Move[0] == 7 && Move[2] == 3 && (15 - Move[0] - Move[2] == 5)) ||
                   (Move[0] == 3 && Move[2] == 7 && (15 - Move[0] - Move[2] == 5)) ||
                   (Move[0] == 7 && Move[3] == 3 && (15 - Move[0] - Move[3] == 5)) ||
                   (Move[0] == 3 && Move[3] == 7 && (15 - Move[0] - Move[3] == 5)) ||
                   (Move[0] == 7 && Move[4] == 3 && (15 - Move[0] - Move[4] == 5)) ||
                   (Move[0] == 3 && Move[4] == 7 && (15 - Move[0] - Move[4] == 5)) ||

                   (Move[1] == 7 && Move[2] == 3 && (15 - Move[1] - Move[2] == 5)) ||
                   (Move[1] == 3 && Move[2] == 7 && (15 - Move[1] - Move[2] == 5)) ||
                   (Move[1] == 7 && Move[3] == 3 && (15 - Move[1] - Move[3] == 5)) ||
                   (Move[1] == 3 && Move[3] == 7 && (15 - Move[1] - Move[3] == 5)) ||
                   (Move[1] == 7 && Move[4] == 3 && (15 - Move[1] - Move[4] == 5)) ||
                   (Move[1] == 3 && Move[4] == 7 && (15 - Move[1] - Move[4] == 5)) ||

                   (Move[2] == 7 && Move[3] == 3 && (15 - Move[2] - Move[3] == 5)) ||
                   (Move[2] == 3 && Move[3] == 7 && (15 - Move[2] - Move[3] == 5)) ||
                   (Move[2] == 7 && Move[4] == 3 && (15 - Move[2] - Move[4] == 5)) ||
                   (Move[2] == 3 && Move[4] == 7 && (15 - Move[2] - Move[4] == 5)) ||


                   (Move[3] == 7 && Move[4] == 3 && (15 - Move[3] - Move[4] == 5)) ||
                   (Move[3] == 3 && Move[4] == 7 && (15 - Move[3] - Move[4] == 5)))
                {
                    intMoveToMake = 5;
                }


                //BLOCK 6

                //if 7 5 taken block 6
                else if ((Move[0] == 7 && Move[1] == 5 && (15 - Move[0] - Move[1] == 3)) ||
                   (Move[0] == 5 && Move[1] == 7 && (15 - Move[0] - Move[1] == 3)) ||
                   (Move[0] == 7 && Move[2] == 5 && (15 - Move[0] - Move[2] == 3)) ||
                   (Move[0] == 5 && Move[2] == 7 && (15 - Move[0] - Move[2] == 3)) ||
                   (Move[0] == 7 && Move[3] == 5 && (15 - Move[0] - Move[3] == 3)) ||
                   (Move[0] == 5 && Move[3] == 7 && (15 - Move[0] - Move[3] == 3)) ||
                   (Move[0] == 7 && Move[4] == 5 && (15 - Move[0] - Move[4] == 3)) ||
                   (Move[0] == 5 && Move[4] == 7 && (15 - Move[0] - Move[4] == 3)) ||

                   (Move[1] == 7 && Move[2] == 5 && (15 - Move[1] - Move[2] == 3)) ||
                   (Move[1] == 5 && Move[2] == 7 && (15 - Move[1] - Move[2] == 3)) ||
                   (Move[1] == 7 && Move[3] == 5 && (15 - Move[1] - Move[3] == 3)) ||
                   (Move[1] == 5 && Move[3] == 7 && (15 - Move[1] - Move[3] == 3)) ||
                   (Move[1] == 7 && Move[4] == 5 && (15 - Move[1] - Move[4] == 3)) ||
                   (Move[1] == 5 && Move[4] == 7 && (15 - Move[1] - Move[4] == 3)) ||

                   (Move[2] == 7 && Move[3] == 5 && (15 - Move[2] - Move[3] == 3)) ||
                   (Move[2] == 5 && Move[3] == 7 && (15 - Move[2] - Move[3] == 3)) ||
                   (Move[2] == 7 && Move[4] == 5 && (15 - Move[2] - Move[4] == 3)) ||
                   (Move[2] == 5 && Move[4] == 7 && (15 - Move[2] - Move[4] == 3)) ||


                   (Move[3] == 7 && Move[4] == 5 && (15 - Move[3] - Move[4] == 3)) ||
                   (Move[3] == 5 && Move[4] == 7 && (15 - Move[3] - Move[4] == 3)))
                {
                    intMoveToMake = 3;
                }

                // if 4 8 taken block 6
                else if ((Move[0] == 4 && Move[1] == 8 && (15 - Move[0] - Move[1] == 3)) ||
                   (Move[0] == 8 && Move[1] == 4 && (15 - Move[0] - Move[1] == 3)) ||
                   (Move[0] == 4 && Move[2] == 8 && (15 - Move[0] - Move[2] == 3)) ||
                   (Move[0] == 8 && Move[2] == 4 && (15 - Move[0] - Move[2] == 3)) ||
                   (Move[0] == 4 && Move[3] == 8 && (15 - Move[0] - Move[3] == 3)) ||
                   (Move[0] == 8 && Move[3] == 4 && (15 - Move[0] - Move[3] == 3)) ||
                   (Move[0] == 4 && Move[4] == 8 && (15 - Move[0] - Move[4] == 3)) ||
                   (Move[0] == 8 && Move[4] == 4 && (15 - Move[0] - Move[4] == 3)) ||

                   (Move[1] == 4 && Move[2] == 8 && (15 - Move[1] - Move[2] == 3)) ||
                   (Move[1] == 8 && Move[2] == 4 && (15 - Move[1] - Move[2] == 3)) ||
                   (Move[1] == 4 && Move[3] == 8 && (15 - Move[1] - Move[3] == 3)) ||
                   (Move[1] == 8 && Move[3] == 4 && (15 - Move[1] - Move[3] == 3)) ||
                   (Move[1] == 4 && Move[4] == 8 && (15 - Move[1] - Move[4] == 3)) ||
                   (Move[1] == 8 && Move[4] == 4 && (15 - Move[1] - Move[4] == 3)) ||

                   (Move[2] == 4 && Move[3] == 8 && (15 - Move[2] - Move[3] == 3)) ||
                   (Move[2] == 8 && Move[3] == 4 && (15 - Move[2] - Move[3] == 3)) ||
                   (Move[2] == 4 && Move[4] == 8 && (15 - Move[2] - Move[4] == 3)) ||
                   (Move[2] == 8 && Move[4] == 4 && (15 - Move[2] - Move[4] == 3)) ||


                   (Move[3] == 4 && Move[4] == 8 && (15 - Move[3] - Move[4] == 3)) ||
                   (Move[3] == 8 && Move[4] == 4 && (15 - Move[3] - Move[4] == 3)))
                {
                    intMoveToMake = 3;
                }

                //BLOCK 7 

                //if 5 4 taken
                else if ((Move[0] == 4 && Move[1] == 5 && (15 - Move[0] - Move[1] == 6)) ||
                    (Move[0] == 5 && Move[1] == 4 && (15 - Move[0] - Move[1] == 6)) ||
                    (Move[0] == 4 && Move[2] == 5 && (15 - Move[0] - Move[2] == 6)) ||
                    (Move[0] == 5 && Move[2] == 4 && (15 - Move[0] - Move[2] == 6)) ||
                    (Move[0] == 4 && Move[3] == 5 && (15 - Move[0] - Move[3] == 6)) ||
                    (Move[0] == 5 && Move[3] == 4 && (15 - Move[0] - Move[3] == 6)) ||
                    (Move[0] == 4 && Move[4] == 5 && (15 - Move[0] - Move[4] == 6)) ||
                    (Move[0] == 5 && Move[4] == 4 && (15 - Move[0] - Move[4] == 6)) ||

                    (Move[1] == 4 && Move[2] == 5 && (15 - Move[1] - Move[2] == 6)) ||
                    (Move[1] == 5 && Move[2] == 4 && (15 - Move[1] - Move[2] == 6)) ||
                    (Move[1] == 4 && Move[3] == 5 && (15 - Move[1] - Move[3] == 6)) ||
                    (Move[1] == 5 && Move[3] == 4 && (15 - Move[1] - Move[3] == 6)) ||
                    (Move[1] == 4 && Move[4] == 5 && (15 - Move[1] - Move[4] == 6)) ||
                    (Move[1] == 5 && Move[4] == 4 && (15 - Move[1] - Move[4] == 6)) ||

                    (Move[2] == 4 && Move[3] == 5 && (15 - Move[2] - Move[3] == 6)) ||
                    (Move[2] == 5 && Move[3] == 4 && (15 - Move[2] - Move[3] == 6)) ||
                    (Move[2] == 4 && Move[4] == 5 && (15 - Move[2] - Move[4] == 6)) ||
                    (Move[2] == 5 && Move[4] == 4 && (15 - Move[2] - Move[4] == 6)) ||


                    (Move[3] == 4 && Move[4] == 5 && (15 - Move[3] - Move[4] == 6)) ||
                    (Move[3] == 5 && Move[4] == 4 && (15 - Move[3] - Move[4] == 6)))
                {
                    intMoveToMake = 6;
                }

                //if 2 7 taken
                else if ((Move[0] == 2 && Move[1] == 7 && (15 - Move[0] - Move[1] == 6)) ||
                    (Move[0] == 7 && Move[1] == 2 && (15 - Move[0] - Move[1] == 6)) ||
                    (Move[0] == 2 && Move[2] == 7 && (15 - Move[0] - Move[2] == 6)) ||
                    (Move[0] == 7 && Move[2] == 2 && (15 - Move[0] - Move[2] == 6)) ||
                    (Move[0] == 2 && Move[3] == 7 && (15 - Move[0] - Move[3] == 6)) ||
                    (Move[0] == 7 && Move[3] == 2 && (15 - Move[0] - Move[3] == 6)) ||
                    (Move[0] == 2 && Move[4] == 7 && (15 - Move[0] - Move[4] == 6)) ||
                    (Move[0] == 7 && Move[4] == 2 && (15 - Move[0] - Move[4] == 6)) ||

                    (Move[1] == 2 && Move[2] == 7 && (15 - Move[1] - Move[2] == 6)) ||
                    (Move[1] == 7 && Move[2] == 2 && (15 - Move[1] - Move[2] == 6)) ||
                    (Move[1] == 2 && Move[3] == 7 && (15 - Move[1] - Move[3] == 6)) ||
                    (Move[1] == 7 && Move[3] == 2 && (15 - Move[1] - Move[3] == 6)) ||
                    (Move[1] == 2 && Move[4] == 7 && (15 - Move[1] - Move[4] == 6)) ||
                    (Move[1] == 7 && Move[4] == 2 && (15 - Move[1] - Move[4] == 6)) ||

                    (Move[2] == 2 && Move[3] == 7 && (15 - Move[2] - Move[3] == 6)) ||
                    (Move[2] == 7 && Move[3] == 2 && (15 - Move[2] - Move[3] == 6)) ||
                    (Move[2] == 2 && Move[4] == 7 && (15 - Move[2] - Move[4] == 6)) ||
                    (Move[2] == 7 && Move[4] == 2 && (15 - Move[2] - Move[4] == 6)) ||


                    (Move[3] == 2 && Move[4] == 7 && (15 - Move[3] - Move[4] == 6)) ||
                    (Move[3] == 7 && Move[4] == 2 && (15 - Move[3] - Move[4] == 6)))
                {
                    intMoveToMake = 6;
                }
                // if 1 8 taken
                else if ((Move[0] == 1 && Move[1] == 8 && (15 - Move[0] - Move[1] == 6)) ||
                    (Move[0] == 8 && Move[1] == 1 && (15 - Move[0] - Move[1] == 6)) ||
                    (Move[0] == 1 && Move[2] == 8 && (15 - Move[0] - Move[2] == 6)) ||
                    (Move[0] == 8 && Move[2] == 1 && (15 - Move[0] - Move[2] == 6)) ||
                    (Move[0] == 1 && Move[3] == 8 && (15 - Move[0] - Move[3] == 6)) ||
                    (Move[0] == 8 && Move[3] == 1 && (15 - Move[0] - Move[3] == 6)) ||
                    (Move[0] == 1 && Move[4] == 8 && (15 - Move[0] - Move[4] == 6)) ||
                    (Move[0] == 8 && Move[4] == 1 && (15 - Move[0] - Move[4] == 6)) ||

                    (Move[1] == 1 && Move[2] == 8 && (15 - Move[1] - Move[2] == 6)) ||
                    (Move[1] == 8 && Move[2] == 1 && (15 - Move[1] - Move[2] == 6)) ||
                    (Move[1] == 1 && Move[3] == 8 && (15 - Move[1] - Move[3] == 6)) ||
                    (Move[1] == 8 && Move[3] == 1 && (15 - Move[1] - Move[3] == 6)) ||
                    (Move[1] == 1 && Move[4] == 8 && (15 - Move[1] - Move[4] == 6)) ||
                    (Move[1] == 8 && Move[4] == 1 && (15 - Move[1] - Move[4] == 6)) ||

                    (Move[2] == 1 && Move[3] == 8 && (15 - Move[2] - Move[3] == 6)) ||
                    (Move[2] == 8 && Move[3] == 1 && (15 - Move[2] - Move[3] == 6)) ||
                    (Move[2] == 1 && Move[4] == 8 && (15 - Move[2] - Move[4] == 6)) ||
                    (Move[2] == 8 && Move[4] == 1 && (15 - Move[2] - Move[4] == 6)) ||


                    (Move[3] == 1 && Move[4] == 8 && (15 - Move[3] - Move[4] == 6)) ||
                    (Move[3] == 8 && Move[4] == 1 && (15 - Move[3] - Move[4] == 6)))
                {
                    intMoveToMake = 6;
                }

                //BLOCK 8

                //if 9 5 taken
                else if ((Move[0] == 9 && Move[1] == 5 && (15 - Move[0] - Move[1] == 1)) ||
               (Move[0] == 5 && Move[1] == 9 && (15 - Move[0] - Move[1] == 1)) ||
               (Move[0] == 9 && Move[2] == 5 && (15 - Move[0] - Move[2] == 1)) ||
               (Move[0] == 5 && Move[2] == 9 && (15 - Move[0] - Move[2] == 1)) ||
               (Move[0] == 9 && Move[3] == 5 && (15 - Move[0] - Move[3] == 1)) ||
               (Move[0] == 5 && Move[3] == 9 && (15 - Move[0] - Move[3] == 1)) ||
               (Move[0] == 9 && Move[4] == 5 && (15 - Move[0] - Move[4] == 1)) ||
               (Move[0] == 5 && Move[4] == 9 && (15 - Move[0] - Move[4] == 1)) ||

               (Move[1] == 9 && Move[2] == 5 && (15 - Move[1] - Move[2] == 1)) ||
               (Move[1] == 5 && Move[2] == 9 && (15 - Move[1] - Move[2] == 1)) ||
               (Move[1] == 9 && Move[3] == 5 && (15 - Move[1] - Move[3] == 1)) ||
               (Move[1] == 5 && Move[3] == 9 && (15 - Move[1] - Move[3] == 1)) ||
               (Move[1] == 9 && Move[4] == 5 && (15 - Move[1] - Move[4] == 1)) ||
               (Move[1] == 5 && Move[4] == 9 && (15 - Move[1] - Move[4] == 1)) ||
            
               (Move[2] == 9 && Move[3] == 5 && (15 - Move[2] - Move[3] == 1)) ||
               (Move[2] == 5 && Move[3] == 9 && (15 - Move[2] - Move[3] == 1)) ||
               (Move[2] == 9 && Move[4] == 5 && (15 - Move[2] - Move[4] == 1)) ||
               (Move[2] == 5 && Move[4] == 9 && (15 - Move[2] - Move[4] == 1)) ||


               (Move[3] == 9 && Move[4] == 5 && (15 - Move[3] - Move[4] == 1)) ||
               (Move[3] == 5 && Move[4] == 9 && (15 - Move[3] - Move[4] == 1)))
                {
                    intMoveToMake = 1;
                }

                // if 6 8 taken
                else if ((Move[0] == 6 && Move[1] == 8 && (15 - Move[0] - Move[1] == 1)) ||
                    (Move[0] == 8 && Move[1] == 6 && (15 - Move[0] - Move[1] == 1)) ||
                    (Move[0] == 6 && Move[2] == 8 && (15 - Move[0] - Move[2] == 1)) ||
                    (Move[0] == 8 && Move[2] == 6 && (15 - Move[0] - Move[2] == 1)) ||
                    (Move[0] == 6 && Move[3] == 8 && (15 - Move[0] - Move[3] == 1)) ||
                    (Move[0] == 8 && Move[3] == 6 && (15 - Move[0] - Move[3] == 1)) ||
                    (Move[0] == 6 && Move[4] == 8 && (15 - Move[0] - Move[4] == 1)) ||
                    (Move[0] == 8 && Move[4] == 6 && (15 - Move[0] - Move[4] == 1)) ||

                    (Move[1] == 6 && Move[2] == 8 && (15 - Move[1] - Move[2] == 1)) ||
                    (Move[1] == 8 && Move[2] == 6 && (15 - Move[1] - Move[2] == 1)) ||
                    (Move[1] == 6 && Move[3] == 8 && (15 - Move[1] - Move[3] == 1)) ||
                    (Move[1] == 8 && Move[3] == 6 && (15 - Move[1] - Move[3] == 1)) ||
                    (Move[1] == 6 && Move[4] == 8 && (15 - Move[1] - Move[4] == 1)) ||
                    (Move[1] == 8 && Move[4] == 6 && (15 - Move[1] - Move[4] == 1)) ||

                    (Move[2] == 6 && Move[3] == 8 && (15 - Move[2] - Move[3] == 1)) ||
                    (Move[2] == 8 && Move[3] == 6 && (15 - Move[2] - Move[3] == 1)) ||
                    (Move[2] == 6 && Move[4] == 8 && (15 - Move[2] - Move[4] == 1)) ||
                    (Move[2] == 8 && Move[4] == 6 && (15 - Move[2] - Move[4] == 1)) ||


                    (Move[3] == 6 && Move[4] == 8 && (15 - Move[3] - Move[4] == 1)) ||
                    (Move[3] == 8 && Move[4] == 6 && (15 - Move[3] - Move[4] == 1)))
                {
                    intMoveToMake = 1;
                }

                //BLOCK 9
                // if 6 1 takeN
                else if ((Move[0] == 6 && Move[1] == 1 && (15 - Move[0] - Move[1] == 8)) ||
                    (Move[0] == 1 && Move[1] == 6 && (15 - Move[0] - Move[1] == 8)) ||
                    (Move[0] == 6 && Move[2] == 1 && (15 - Move[0] - Move[2] == 8)) ||
                    (Move[0] == 1 && Move[2] == 6 && (15 - Move[0] - Move[2] == 8)) ||
                    (Move[0] == 6 && Move[3] == 1 && (15 - Move[0] - Move[3] == 8)) ||
                    (Move[0] == 1 && Move[3] == 6 && (15 - Move[0] - Move[3] == 8)) ||
                    (Move[0] == 6 && Move[4] == 1 && (15 - Move[0] - Move[4] == 8)) ||
                    (Move[0] == 1 && Move[4] == 6 && (15 - Move[0] - Move[4] == 8)) ||

                    (Move[1] == 6 && Move[2] == 1 && (15 - Move[1] - Move[2] == 8)) ||
                    (Move[1] == 1 && Move[2] == 6 && (15 - Move[1] - Move[2] == 8)) ||
                    (Move[1] == 6 && Move[3] == 1 && (15 - Move[1] - Move[3] == 8)) ||
                    (Move[1] == 1 && Move[3] == 6 && (15 - Move[1] - Move[3] == 8)) ||
                    (Move[1] == 6 && Move[4] == 1 && (15 - Move[1] - Move[4] == 8)) ||
                    (Move[1] == 1 && Move[4] == 6 && (15 - Move[1] - Move[4] == 8)) ||

                    (Move[2] == 6 && Move[3] == 1 && (15 - Move[2] - Move[3] == 8)) ||
                    (Move[2] == 1 && Move[3] == 6 && (15 - Move[2] - Move[3] == 8)) ||
                    (Move[2] == 6 && Move[4] == 1 && (15 - Move[2] - Move[4] == 8)) ||
                    (Move[2] == 1 && Move[4] == 6 && (15 - Move[2] - Move[4] == 8)) ||


                    (Move[3] == 6 && Move[4] == 1 && (15 - Move[3] - Move[4] == 8)) ||
                    (Move[3] == 1 && Move[4] == 6 && (15 - Move[3] - Move[4] == 8)))
                {
                    intMoveToMake = 8;
                }



                //if 4 3  taken
             else if ((Move[0] == 4 && Move[1] == 3 && (15 - Move[0] - Move[1] == 8)) ||
               (Move[0] == 3 && Move[1] == 4 && (15 - Move[0] - Move[1] == 8)) ||
               (Move[0] == 4 && Move[2] == 3 && (15 - Move[0] - Move[2] == 8)) ||
               (Move[0] == 3 && Move[2] == 4 && (15 - Move[0] - Move[2] == 8)) ||
               (Move[0] == 4 && Move[3] == 3 && (15 - Move[0] - Move[3] == 8)) ||
               (Move[0] == 3 && Move[3] == 4 && (15 - Move[0] - Move[3] == 8)) ||
               (Move[0] == 4 && Move[4] == 3 && (15 - Move[0] - Move[4] == 8)) ||
               (Move[0] == 3 && Move[4] == 4 && (15 - Move[0] - Move[4] == 8)) ||

               (Move[1] == 4 && Move[2] == 3 && (15 - Move[1] - Move[2] == 8)) ||
               (Move[1] == 3 && Move[2] == 4 && (15 - Move[1] - Move[2] == 8)) ||
               (Move[1] == 4 && Move[3] == 3 && (15 - Move[1] - Move[3] == 8)) ||
               (Move[1] == 3 && Move[3] == 4 && (15 - Move[1] - Move[3] == 8)) ||
               (Move[1] == 4 && Move[4] == 3 && (15 - Move[1] - Move[4] == 8)) ||
               (Move[1] == 3 && Move[4] == 4 && (15 - Move[1] - Move[4] == 8)) ||

               (Move[2] == 4 && Move[3] == 3 && (15 - Move[2] - Move[3] == 8)) ||
               (Move[2] == 3 && Move[3] == 4 && (15 - Move[2] - Move[3] == 8)) ||
               (Move[2] == 4 && Move[4] == 3 && (15 - Move[2] - Move[4] == 8)) ||
               (Move[2] == 3 && Move[4] == 4 && (15 - Move[2] - Move[4] == 8)) ||


               (Move[3] == 4 && Move[4] == 3 && (15 - Move[3] - Move[4] == 8)) ||
               (Move[3] == 3 && Move[4] == 4 && (15 - Move[3] - Move[4] == 8)))
                {
                    intMoveToMake = 8;
                }

                // if 2 5 taken
                else if ((Move[0] == 2 && Move[1] == 5 && (15 - Move[0] - Move[1] == 8)) ||
                    (Move[0] == 5 && Move[1] == 2 && (15 - Move[0] - Move[1] == 8)) ||
                    (Move[0] == 2 && Move[2] == 5 && (15 - Move[0] - Move[2] == 8)) ||
                    (Move[0] == 5 && Move[2] == 2 && (15 - Move[0] - Move[2] == 8)) ||
                    (Move[0] == 2 && Move[3] == 5 && (15 - Move[0] - Move[3] == 8)) ||
                    (Move[0] == 5 && Move[3] == 2 && (15 - Move[0] - Move[3] == 8)) ||
                    (Move[0] == 2 && Move[4] == 5 && (15 - Move[0] - Move[4] == 8)) ||
                    (Move[0] == 5 && Move[4] == 2 && (15 - Move[0] - Move[4] == 8)) ||

                    (Move[1] == 2 && Move[2] == 5 && (15 - Move[1] - Move[2] == 8)) ||
                    (Move[1] == 5 && Move[2] == 2 && (15 - Move[1] - Move[2] == 8)) ||
                    (Move[1] == 2 && Move[3] == 5 && (15 - Move[1] - Move[3] == 8)) ||
                    (Move[1] == 5 && Move[3] == 2 && (15 - Move[1] - Move[3] == 8)) ||
                    (Move[1] == 2 && Move[4] == 5 && (15 - Move[1] - Move[4] == 8)) ||
                    (Move[1] == 5 && Move[4] == 2 && (15 - Move[1] - Move[4] == 8)) ||

                    (Move[2] == 2 && Move[3] == 5 && (15 - Move[2] - Move[3] == 8)) ||
                    (Move[2] == 5 && Move[3] == 2 && (15 - Move[2] - Move[3] == 8)) ||
                    (Move[2] == 2 && Move[4] == 5 && (15 - Move[2] - Move[4] == 8)) ||
                    (Move[2] == 5 && Move[4] == 2 && (15 - Move[2] - Move[4] == 8)) ||


                    (Move[3] == 2 && Move[4] == 5 && (15 - Move[3] - Move[4] == 8)) ||
                    (Move[3] == 5 && Move[4] == 2 && (15 - Move[3] - Move[4] == 8)))
                {
                    intMoveToMake = 8;
                }

                return intMoveToMake;
            }





            //PLAYER TURNS
            private void btn1_Click(object sender, EventArgs e)
            {
                int intBtnVal = 2;

                intCounterPlayer++;

            if (blnClickedOne == false)
            {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn1.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn1.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn1.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn1.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn1.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn1.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn1.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn1.BackgroundImage = Resources.MsMowz_Head;
                }
            
                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }
           

            blnClickedOne = true;
                btn1.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn2_Click(object sender, EventArgs e)
            {
                int intBtnVal = 9;

                intCounterPlayer++;

                if (blnClickedTwo == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn2.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn2.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn2.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn2.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn2.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn2.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn2.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn2.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedTwo = true;
                btn2.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn3_Click(object sender, EventArgs e)
            {
                int intBtnVal = 4;

                intCounterPlayer++;

                if (blnClickedThree == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn3.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn3.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn3.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn3.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn3.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn3.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn3.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn3.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedThree = true;
                btn3.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn4_Click(object sender, EventArgs e)
            {
                int intBtnVal = 7;

                intCounterPlayer++;

                if (blnClickedFour == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn4.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn4.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn4.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn4.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn4.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn4.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn4.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn4.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedFour = true;
                btn4.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn5_Click(object sender, EventArgs e)
            {
                int intBtnVal = 5;

                intCounterPlayer++;

                if (blnClickedFive == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn5.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn5.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn5.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn5.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn5.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn5.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn5.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn5.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedFive = true;
                btn5.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn6_Click(object sender, EventArgs e)
            {
                int intBtnVal = 3;

                intCounterPlayer++;

                if (blnClickedSix == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn6.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn6.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn6.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn6.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn6.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn6.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn6.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn6.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedSix = true;
                btn6.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn7_Click(object sender, EventArgs e)
            {
                int intBtnVal = 6;

                intCounterPlayer++;

                if (blnClickedSeven == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn7.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn7.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn7.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn7.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn7.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn7.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn7.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn7.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedSeven = true;
                btn7.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn8_Click(object sender, EventArgs e)
            {
                int intBtnVal = 1;

                intCounterPlayer++;

                if (blnClickedEight == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn8.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn8.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn8.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn8.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn8.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn8.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn8.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn8.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedEight = true;
                btn8.Enabled = false;
                CheckWinner();
                ComputerMove();
            }
            private void btn9_Click(object sender, EventArgs e)
            {
                int intBtnVal = 8;

                intCounterPlayer++;

                if (blnClickedNine == false)
                {
                if (Form2.intCharacterSelect == 1)
                {
                    this.btn9.BackgroundImage = Resources.Mario_Head;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    this.btn9.BackgroundImage = Resources.Goombella_Head;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    this.btn9.BackgroundImage = Resources.Koops_Head;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    this.btn9.BackgroundImage = Resources.Flurrie_Head;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    this.btn9.BackgroundImage = Resources.Yoshikid_Head;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    this.btn9.BackgroundImage = Resources.Vivian_head;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    this.btn9.BackgroundImage = Resources.Bobbery_Head;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    this.btn9.BackgroundImage = Resources.MsMowz_Head;
                }

                playerMoves[intCounterPlayer] = intBtnVal;
                    blnPlayerTurn = false;
                }

                blnClickedNine = true;
                btn9.Enabled = false;
                CheckWinner();
                ComputerMove();
            }



            private void btnStart_Click(object sender, EventArgs e)
            {
                if (rdoEasyDiff.Checked == true)
                {
                    intDiff = 1;

                //open curtains and show one bad guy
                this.BackgroundImage = Resources.Stage_Background;
                pcbXNaut.BackgroundImage = Resources.XNaut_Norm;
                lblXNautForces.Text = "X-Naut Forces";

                if(Form2.intCharacterSelect == 1) 
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Battle_Mario; 
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Goombella_Norm;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Koops_Norm;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Flurrie_Norm;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.BattleYoshi;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Vivian_Norm;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Bobbery_Norm;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.MsMowz_Norm;
                }




                medBattlethemePlayer.URL = "C:/Users/Mustafa Ahmed/Documents/Visual Studio Projects/TICTACTOE_MA - Copy - Copy/TICTACTOE_MA/Resources/Battle_Theme.wav";

                this.btn1.Enabled = true;
                    this.btn2.Enabled = true;
                    this.btn3.Enabled = true;
                    this.btn4.Enabled = true;
                    this.btn5.Enabled = true;
                    this.btn6.Enabled = true;
                    this.btn7.Enabled = true;
                    this.btn8.Enabled = true;
                    this.btn9.Enabled = true;

                    this.btnRestart.Enabled = true;
                this.btnbtnEndGame.Enabled = true;

                    rdoEasyDiff.Enabled = false;
                    rdoMediumDiff.Enabled = false;
                    rdoHardDiff.Enabled = false;

                    this.btnStart.Enabled = false;


                }




                else if (rdoMediumDiff.Checked == true)
                {
                    intDiff = 2;
                //open curtains ans show 2 bad guys
                this.BackgroundImage = Resources.Stage_Background;
                pcbXNaut.BackgroundImage = Resources.XNaut_Norm;
                pcbCrump.BackgroundImage = Resources.LordCrump_Normal;
                lblXNautForces.Text = "X-Naut Forces";

                if (Form2.intCharacterSelect == 1)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Battle_Mario;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Goombella_Norm;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Koops_Norm;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Flurrie_Norm;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.BattleYoshi;
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Vivian_Norm;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Bobbery_Norm;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.MsMowz_Norm;
                }
                medBattlethemePlayer.URL = "C:/Users/Mustafa Ahmed/Documents/Visual Studio Projects/TICTACTOE_MA - Copy - Copy/TICTACTOE_MA/Resources/Battle_Theme.wav";

                this.btn1.Enabled = true;
                    this.btn2.Enabled = true;
                    this.btn3.Enabled = true;
                    this.btn4.Enabled = true;
                    this.btn5.Enabled = true;
                    this.btn6.Enabled = true;
                    this.btn7.Enabled = true;
                    this.btn8.Enabled = true;
                    this.btn9.Enabled = true;

                    this.btnRestart.Enabled = true;
                this.btnbtnEndGame.Enabled = true;

                rdoEasyDiff.Enabled = false;
                    rdoMediumDiff.Enabled = false;
                    rdoHardDiff.Enabled = false;

                    this.btnStart.Enabled = false;
                }

                else if (rdoHardDiff.Checked == true)
                {
                    intDiff = 3;

                //open curtains and show all bad guys
                this.BackgroundImage = Resources.Stage_Background;
                pcbXNaut.BackgroundImage = Resources.XNaut_Norm;
                pcbCrump.BackgroundImage = Resources.LordCrump_Normal;
                pcbGrodus.BackgroundImage = Resources.Grodus_Norm;
                lblXNautForces.Text = "X-Naut Forces";

                if (Form2.intCharacterSelect == 1)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Battle_Mario;
                }
                else if (Form2.intCharacterSelect == 2)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Goombella_Norm;
                }
                else if (Form2.intCharacterSelect == 3)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Koops_Norm;
                }
                else if (Form2.intCharacterSelect == 4)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Flurrie_Norm;
                }
                else if (Form2.intCharacterSelect == 5)
                {
                    
                    pcbPlayerCharacter.BackgroundImage = Resources.BattleYoshi;
                    
                }
                else if (Form2.intCharacterSelect == 6)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Vivian_Norm;
                }
                else if (Form2.intCharacterSelect == 7)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.Bobbery_Norm;
                }
                else if (Form2.intCharacterSelect == 8)
                {
                    pcbPlayerCharacter.BackgroundImage = Resources.MsMowz_Norm;
                }
                medBattlethemePlayer.URL = "C:/Users/Mustafa Ahmed/Documents/Visual Studio Projects/TICTACTOE_MA - Copy - Copy/TICTACTOE_MA/Resources/Battle_Theme.wav";

                this.btn1.Enabled = true;
                    this.btn2.Enabled = true;
                    this.btn3.Enabled = true;
                    this.btn4.Enabled = true;
                    this.btn5.Enabled = true;
                    this.btn6.Enabled = true;
                    this.btn7.Enabled = true;
                    this.btn8.Enabled = true;
                    this.btn9.Enabled = true;

                    this.btnRestart.Enabled = true;
                this.btnbtnEndGame.Enabled = true;

                rdoEasyDiff.Enabled = false;
                    rdoMediumDiff.Enabled = false;
                    rdoHardDiff.Enabled = false;

                    this.btnStart.Enabled = false;
                }



            }

            private void btnRestart_Click(object sender, EventArgs e)
            {
            
              
            medBattlethemePlayer.URL = "C:/ Users / Mustafa Ahmed / Documents / Visual Studio Projects/ TICTACTOE_MA - Copy - Copy / TICTACTOE_MA / Resources / Silent.wav";

            pcbCrump.BackgroundImage = null;
            pcbGrodus.BackgroundImage = null;
            pcbXNaut.BackgroundImage = null;
            pcbPlayerCharacter.BackgroundImage = null;

            this.BackgroundImage = Resources.Curtains_Background;
            lblXNautForces.Text = "";

            
            //reset score
            intCompScore = 0;
                intUserScore = 0;
                intNumofGames = 0;
                intNumofDraws = 0;

                //reset moves counter
                intCounterComp = -1;
                intCounterPlayer = -1;

                compMoves = new int[5];
                playerMoves = new int[5];

            //reset text on buttons
            this.btn1.BackgroundImage = null;
            this.btn2.BackgroundImage = null;
            this.btn3.BackgroundImage = null;
            this.btn4.BackgroundImage = null;
            this.btn5.BackgroundImage = null;
            this.btn6.BackgroundImage = null;
            this.btn7.BackgroundImage = null;
            this.btn8.BackgroundImage = null;
            this.btn9.BackgroundImage = null;

            this.lblComputerScoreNumber.Text = "";
                this.lblPlayerScoreNum.Text = "";
                this.lblGmeNumber.Text = "";
                this.lblNumberOfDraws.Text = "";

                //reset moves on buttons
                blnClickedOne = false;
                blnClickedTwo = false;
                blnClickedThree = false;
                blnClickedFour = false;
                blnClickedFive = false;
                blnClickedSix = false;
                blnClickedSeven = false;
                blnClickedEight = false;
                blnClickedNine = false;

                //reset checking on radio buttons
                this.rdoEasyDiff.Checked = false;
                this.rdoMediumDiff.Checked = false;
                this.rdoHardDiff.Checked = false;

                MessageBox.Show("Please select a game difficulty");

                //disables move tiles so player choses difficulty agaain
                this.btn1.Enabled = false;
                this.btn2.Enabled = false;
                this.btn3.Enabled = false;
                this.btn4.Enabled = false;
                this.btn5.Enabled = false;
                this.btn6.Enabled = false;
                this.btn7.Enabled = false;
                this.btn8.Enabled = false;
                this.btn9.Enabled = false;

                //disable restart button but enable start button
                this.btnRestart.Enabled = false;
                this.btnStart.Enabled = true;
           

                //re enable radio buttons to choose difficulty
                rdoEasyDiff.Enabled = true;
                rdoMediumDiff.Enabled = true;
                rdoHardDiff.Enabled = true;
            }

        private void btnFullGameRestart_Click(object sender, EventArgs e)
        {
           
            Form2 CharSelectForm = new Form2();
            CharSelectForm.Close();
            this.Close();

           

        }
    }


    } 



//side notes below(IGNORE)


           


