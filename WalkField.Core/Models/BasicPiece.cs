using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkField.Core.Interfaces;

namespace WalkField.Core.Models
{
    public class BasicPiece : Piece
    {
        private Tag tag { get; set; }
        public Tag Tag => tag;

        public BasicPiece(Tag tag)
        {
            this.tag = tag;
        }

        public bool CanMove(Field field, Position src, Position dst)
        {
            int[] dr = new int[8] { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] dc = new int[8] { 1, -1, 0, 1, -1, 0, 1, -1 };
            for (int i = 0; i < 8; i++)
                if (src.row + dr[i] < field.rows && src.row + dr[i] >= 0 &&
                    src.col + dc[i] < field.cols && src.col + dc[i] >= 0 &&
                    dst.row == dr[i] && dst.col == dc[i] && 
                    field.field[dst.row][dst.col] == Tag.None)
                    return true;
            return false;
        } 
    }
}
