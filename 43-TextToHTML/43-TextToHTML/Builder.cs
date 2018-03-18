using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _43_TextToHTML
{
    abstract class Builder
    {
     
            public abstract string BuildPartA(RichTextBox Rtb);
            public abstract string HTML_RGBHex(byte R, byte G, byte B);
            public abstract string BuildPartC(RichTextBox Rtb);
            public abstract Product GetResult();

            internal void BuildPartA()
            {
                throw new NotImplementedException();
            }

            internal void HTML_RGBHex()
            {
                throw new NotImplementedException();
            }

            internal void BuildPartC()
            {
                throw new NotImplementedException();
            }
        
    }
}
