using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.State
{
    internal class Canvas
    {
        private ITool tool;
        public Canvas(ITool tool)
        {
            this.tool = tool;
        }

        public void mouseDown()
        {

            tool.mouseDown();
        }

        public void mouseUp()
        {
            tool.mouseUp();

        }
    }
}
