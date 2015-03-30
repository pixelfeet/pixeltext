using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelText
{
    /// <summary>
    /// The basic GameElement class. All PixelText objects other than Game inherit from this.
    /// </summary>
    public class GameElement
    {
        /// <summary>
        /// The default constructor for GameElement.
        /// </summary>
        public GameElement()
        {
            
        }

        /// <summary>
        /// The action this GameElement should take each turn.
        /// </summary>
        public virtual void Call()
        {
            
        }

        /// <summary>
        /// Wraps a string so words that would typically be cut off are printed on the next line.
        /// </summary>
        /// <param name="original">The string to format.</param>
        /// <returns>Returns a string formatted with word wrap for the current console buffer size.</returns>
        protected string wrap(string original)
        {
            int width = Console.BufferWidth - 1;
            string new_string = "";
            int temp = 0;

            string[] words = original.Split(' ');

            foreach (string word in words)
            {
                temp = temp + word.Length + 1;

                if (temp < width)
                {
                    new_string += word;
                    new_string += " ";
                }
                else
                {
                    new_string += "\n";
                    new_string += word;
                    new_string += " ";
                    temp = word.Length;
                }
            }

            return new_string;
        }
    }
}
