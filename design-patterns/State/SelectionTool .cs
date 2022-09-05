using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.State
{
    internal class SelectionTool : ITool
    {
        public void mouseDown()
        {

            Console.WriteLine("Selection icon.");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle.");

        }
    }
}
