using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHANA
{
    class Block
    {
        public const int MaxSupply = 10;
        public int BlockIndex { get; set; }
        public string BlockHash { get; set; }
        public TransacData TD { get; set; }
     
        public Block(int index, TransacData td, string hash )
        {
            this.BlockIndex = index;
            this.TD = td;
            this.BlockHash = hash;
        }
        
        

    }

    
}
