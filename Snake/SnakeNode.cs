using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake {
   public class SnakeNode : Node, UpdateGame {

      private Direction d;
      private int xCoordinate;
      private int yCoordinate;
     //private int size;
      private Random r;

      private Queue<Direction> directionOnQueue;


      public int x {
         get {
            return this.xCoordinate;
         }
         set {
            this.xCoordinate = value;
         }
      }

      public int y {
         get {
            return this.yCoordinate;
         }
         set {
            this.yCoordinate = value;
         }
      }

      public SnakeNode(int x, int y) : this(Direction.Null, x, y) {
         
      }

      public SnakeNode(Direction d, int x, int y) : base() {
         this.d = d;
         r = new Random();
         xCoordinate = x + (r.Next(20) * 20);
         yCoordinate = y + (r.Next(20) * 20);

      }

      public void direction1() {
         MessageBox.Show(d.ToString());
      }


      public void updateCoordinates(int x, int y) {
         throw new NotImplementedException();
      }

      public void updateDirection(Direction direction) {
         throw new NotImplementedException();
      }
   }
}
