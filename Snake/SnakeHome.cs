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
   public partial class SnakeHome : Form {

      public SnakeHome() {
         InitializeComponent();
      }

      private void playButton_Click(object sender, EventArgs e) {
         SnakeGame gameForm = new SnakeGame();
         gameForm.FormClosed += new FormClosedEventHandler(gameFormClose);
         gameForm.Show();
         this.Hide();
      }

      private void gameFormClose(Object sender, FormClosedEventArgs e) {
         this.Close();
      }
   }
}