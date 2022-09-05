using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.memento
{
    internal class Document
    {
        public string content { get; set; }
        public string fontName { get; set; }
        public int fontSize { get; set; }

        public void restore(DocumentState state)
        {
            content = state.content;
            fontName = state.fontName;
            fontSize = state.fontSize;

        }

        public DocumentState getState()
        {
            return new DocumentState()
            {
                content = content,
                fontName = fontName,
                fontSize = fontSize
            };
        }

    }



    public class DocumentState
    {
        public string content { get; set; }
        public string fontName { get; set; }
        public int fontSize { get; set; }

        

    }

    public class DocumentStateHisotry
    {
        public List<DocumentState> documentStates { get; set; }
    }

}

