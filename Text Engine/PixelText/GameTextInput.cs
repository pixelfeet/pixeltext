using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelText
{
    public class GameTextInput : GameElement
    {
        protected string prompt;
        protected string data;

        public GameTextInput(string prompt = "> ") : base()
        {
            this.prompt = prompt;
        }

        public override void Call()
        {
            Console.Write(prompt);
            data = Console.ReadLine();
            Console.WriteLine();

            if (data == "exit") Environment.Exit(0);
        }
    }
}
