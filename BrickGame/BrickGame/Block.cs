using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Block
    {
        public BLOCKDATA bd = new BLOCKDATA();
        private static readonly Random rand = new Random();

        public void Initialize()
        {
            
            bd.nX = rand.Next(2, 75);
            bd.nY = rand.Next(2, 15);
        }

        public void Render()
        {
            Program.gotoxy(bd.nX, bd.nY);
            Console.Write("▣");
        }


        
    }
}
