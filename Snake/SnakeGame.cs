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
      private String playButtonLabel = "P L A Y";



      public SnakeGame() {
         InitializeComponent();
         this.StartPosition = FormStartPosition.Manual;
         this.Location = new Point(0, 0);
         InitializeGame();
      }

      private void InitializeGame() {
         this.score = 0;
         scoreLabel.Text = score.ToString();

      }


   }
}


