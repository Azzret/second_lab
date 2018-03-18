using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _43_TextToHTML
{
    class Director
    {
      
            Builder builder;
            public Director(Builder builder)
            {
                this.builder = builder;
            }
            public void Construct()
            {
                builder.BuildPartA();
                builder.HTML_RGBHex();
                builder.BuildPartC();
            }
        
    }
}
