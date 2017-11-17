//Mouse click handler class. for better style.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace Snake {
   public partial class SnakeGame {
      private object button1;

 

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

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
         switch (keyData) {
            case Keys.Down:
               MessageBox.Show("DOWN is pressed");

               return true;
            case Keys.Up:
               MessageBox.Show("UP is pressed");

               return true;
            case Keys.Right:
               MessageBox.Show("RIGHT is pressed");

               return true;
            case Keys.Left:
               MessageBox.Show("LEFT is pressed");

               return true;
         }
         return base.ProcessCmdKey(ref msg, keyData);
      }


      /*   public void Form_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.F) {
               MessageBox.Show("f is pressed");
            }
         }



        public void Window_KeyDown(object sender, KeyEventArgs e) {
           if (e.KeyCode == Keys.Space) {
              MessageBox.Show("Down");
           }

        }*/




   }
}
