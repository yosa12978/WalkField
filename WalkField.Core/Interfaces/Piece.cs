using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkField.Core.Models;

namespace WalkField.Core.Interfaces
{
    public interface Piece
    {
        Tag Tag { get; }
        bool CanMove(Field field, Position src, Position dst);
    }
}
