using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.memento
{
    public class History
    {
        private List<editorState> states = new List<editorState>();

        public void push(editorState editorState)
        {
            states.Add(editorState);
        }

        public editorState? pop()
        {
            return states.LastOrDefault();
        }
    }
}
