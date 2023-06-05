using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkField.Core.Exceptions;
using WalkField.Core.Interfaces;

namespace WalkField.Core.Models
{
    public class Field
    {
        public int rows { get; private set; }
        public int cols { get; private set; }
        public Tag[][] field { get; set; }
        public Field()
        {
            rows = 8;
            cols = 8;
            field = new Tag[rows][];
            for (int i = 0; i < rows; i++)
            {
                field[i] = new Tag[cols];
                for (int j = 0; j < cols; j++)
                    field[i][j] = Tag.None;
            }
            field[0][0] = Tag.Red;
            field[0][1] = Tag.Green;
        }

        public bool CanMove(Position src, Position dst)
        {
            int[] dr = new int[8] { 0, 0, 1, 1, 1, -1, -1, -1 };
            int[] dc = new int[8] { 1, -1, 0, 1, -1, 0, 1, -1 };
            for (int i = 0; i < 8; i++)
                if (src.row + dr[i] < rows && src.row + dr[i] >= 0 &&
                    src.col + dc[i] < cols && src.col + dc[i] >= 0 &&
                    dst.row == dr[i] && dst.col == dc[i] &&
                    field[dst.row][dst.col] == Tag.None)
                    return true;
            return false;
        }

        public void Move(Position src, Position dst)
        {
            if (!CanMove(src, dst))
                throw new IteractionException("you can't move this way");
            field[dst.row][dst.col] = field[src.row][src.col];
            field[src.row][src.col] = Tag.None;
        }
    }
}
