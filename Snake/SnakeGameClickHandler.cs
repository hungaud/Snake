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

   }
}
