using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
   public class SnakeNode : Node {

      private Direction d;

      public SnakeNode() : this(Direction.Null) {
         
      }

      public SnakeNode(Direction d) : base() {
         this.d = d;
      }

   }
}
