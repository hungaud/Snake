using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake {
   public partial class SnakeGame : Form {

      private int score;
      private readonly int POINTS = 10;
      private readonly int XOFFSET = 5;
      private readonly int YOFFSET = 29;
     // private String playButtonLabel = "P L A Y";
      private bool pause;
      private int[,] gameBoard;
      private Node snake;
      private Node food;


      public SnakeGame() {
         InitializeComponent();
         this.StartPosition = FormStartPosition.Manual;
         this.Location = new Point(0, 0);
         InitializeGame();
      }

      private void InitializeGame() {
         this.score = 0;
         this.scoreLabel.Text = score.ToString();
         this.pause = true;
         gameBoard = new int [20,20];
         snake = new SnakeNode();
         food = new FoodNode();

         

      }
   }
}


