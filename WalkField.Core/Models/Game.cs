using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkField.Core.Models
{
    public class Game
    {
        private Field field { get; set; } = default!;
        private Tag tag { get; set; } = Tag.None;
        public Game(Tag tag) 
        { 
            this.field = new Field();
            this.tag = tag;
        }
        public Tag[][] Field 
        { 
            get
            {
                return field.field;
            }
            set
            {
                field.field = value;
            }
        }
    }
}
