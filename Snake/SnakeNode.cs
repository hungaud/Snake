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
      private bool isHead;
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

      public Direction directtion {
         get {
            return this.d;
         }
         set {
            this.d = value;
         }
      }

      public SnakeNode(int x, int y, bool isHead) : this(Direction.Null, x, y, isHead) {
         
      }

      public SnakeNode(Direction d, int x, int y, bool isHead) : base() {
         this.d = d;
         r = new Random();
         this.isHead = isHead;
         if (isHead) {
            xCoordinate = x + (r.Next(20) * 20);
            yCoordinate = y + (r.Next(20) * 20);
         } else {
            this.xCoordinate = x;
            this.yCoordinate = y;
         }

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
