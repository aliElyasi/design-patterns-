using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.State
{
    internal class BrushTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("draw a line...");
        }
    }
}
