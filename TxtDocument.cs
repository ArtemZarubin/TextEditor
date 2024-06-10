using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextEditor
{
    public class TxtDocument : Document
    {
        public TxtDocument(string text) : base(text)
        {
            // ...
        }

        public override void Save(string path)
        {
            File.WriteAllText(path, text_);
        }
    }
}
