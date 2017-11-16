//Mouse click handler class. for better style.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake {
   public partial class SnakeGame {

      public bool IsPause {
         get {
            return pause;
         }
         set {
            pause = value;
         }
      }

      private void playPauseButton_Click(object sender, EventArgs e) {
         if (IsPause) {
            IsPause = false;
            playPauseButton.Text = "P A U S E";
         } else {
            IsPause = true;
            playPauseButton.Text = "P L A Y";

         }
      }

      /* public void SnakeGame_KeyDown(object sender, KeyEventArgs e) {
          if (e.KeyCode == Keys.Right) {
             MessageBox.Show("right");
          }
       }
       */


      protected override void OnKeyDown(KeyEventArgs e) {
         base.OnKeyDown(e);
         switch (e.KeyCode) {
            case Keys.Left:
               MessageBox.Show("Left");
               return;
            case Keys.Right:
            case Keys.Up:
            case Keys.Down:
            if (e.Shift) {

            } else {
            }
            break;
         }

      }
   }
}
