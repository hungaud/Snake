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

      private List<SnakeNode> snakeNodeList = new List<SnakeNode>();
      
      private SnakeNode snakeHead;
      private Node food;

      Timer wt = new Timer();


      public SnakeGame() {
         InitializeComponent();
         this.StartPosition = FormStartPosition.Manual;
         this.Location = new Point(0, 0);
         wt.Interval = 50;
         wt.Tick += new EventHandler(wt_Tick);
         wt.Enabled = false;
         InitializeGame();
         
      }

      private void wt_Tick(object sender, EventArgs e) {
         //throw new NotImplementedException();
      }

      private void InitializeGame() {
         this.score = 0;
         this.scoreLabel.Text = score.ToString();
         this.pause = true;
         gameBoard = new int [20,20];
         snakeHead = new SnakeNode(Node.Direction.East, XOFFSET, YOFFSET, true);
         food = new FoodNode(XOFFSET, YOFFSET);
         //snake.direction1();
         wt.Start();

         Invalidate();  


      }

      protected override void OnPaint(PaintEventArgs e) {
         //base.OnPaint(e);
         Graphics g = e.Graphics;
         SolidBrush blackBrush = new SolidBrush(Color.Black);
         SolidBrush whiteBrush = new SolidBrush(Color.White);
         Rectangle board = new Rectangle(XOFFSET, YOFFSET, 600, 600);
         Rectangle test = new Rectangle(snakeHead.x, snakeHead.y, 30, 30);
         g.FillRectangle(blackBrush, board);
         g.FillRectangle(whiteBrush, test);

      }


   }
}


