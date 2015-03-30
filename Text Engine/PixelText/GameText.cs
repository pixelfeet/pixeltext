using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelText
{
    public class GameText : GameElement
    {
        protected string text;

        public GameText(string text) : base()
        {
            this.text = text;
        }

        public override void Call()
        {
            Console.WriteLine(wrap(text));
            Console.WriteLine();
        }
    }
}
