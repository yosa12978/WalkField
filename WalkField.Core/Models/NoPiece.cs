using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkField.Core.Interfaces;

namespace WalkField.Core.Models
{
    public class NoPiece : Piece
    {
        public Tag Tag => Tag.None;

        public bool CanMove(Field field, Position src, Position dst)
        {
            return false;
        }
    }
}
