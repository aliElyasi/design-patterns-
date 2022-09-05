using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.memento
{
    internal class editor
    {
        public string content { get; set; }


        public editorState createState() => new editorState() { content = content };

        public void restore(editorState state)
        {
            content = state.content;
        }
    }
}
