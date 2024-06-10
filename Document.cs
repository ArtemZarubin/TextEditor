using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public abstract class Document
    {
        protected string text_;

        public Document(string text)
        {
            text_ = text;
        }

        public abstract void Save(string path);
    }
}
