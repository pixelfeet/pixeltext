using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelText
{
    /// <summary>
    /// The basic game class, in instance of Game must be created in the Main function of Program.cs.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Store for the game name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Store for the game version.
        /// </summary>
        private string _version;

        /// <summary>
        /// Queue for the actions to be taken each turn.
        /// </summary>
        private Queue<GameElement> turn_queue;

        /// <summary>
        /// Constructor for the Game class.
        /// </summary>
        public Game()
        {
            turn_queue = new Queue<GameElement>();
            turn_queue.Enqueue(new GameText("Lorem ipsum dolor sit amet, consectetur adipiscing elit. In suscipit mi sed sem maximus aliquam. Phasellus dapibus luctus sagittis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis vitae placerat ex. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed egestas auctor tellus nec gravida. Donec id gravida sem. Quisque a rutrum dui. Vivamus sit amet finibus velit. Donec in arcu lobortis, euismod ante non, finibus enim. Cras a viverra dui. Nullam condimentum aliquet nunc eget rutrum. Sed non dolor et lorem placerat sagittis. Morbi sit amet pellentesque risus, bibendum rhoncus tortor. Aenean volutpat neque non quam malesuada, in imperdiet ex ultricies. Sed interdum orci eu iaculis finibus."));
            turn_queue.Enqueue(new GameTextInput());
        }

        /// <summary>
        /// Manages the the turn queue, calling each item in turn.
        /// </summary>
        public void Turn()
        {
            int steps = turn_queue.Count;
            Queue<GameElement> new_queue = new Queue<GameElement>();

            for(int i = 0; i < steps; i++)
            {
                GameElement temp = turn_queue.Dequeue();
                new_queue.Enqueue(temp);
                temp.Call();
            }

            turn_queue = new_queue;
        }
    }
}
