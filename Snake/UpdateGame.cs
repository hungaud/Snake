using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
   public interface UpdateGame {

      int x {
         get;
         set;
      }

      int y {
         get;
         set;
      }

      void updateDirection(Node.Direction direction);
      void updateCoordinates(int x, int y);
      
   }
}
