using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public abstract class TextStyleDecorator : ITextStyle
    {
        protected ITextStyle style;
        public TextStyleDecorator(ITextStyle style)
        {
            this.style = style;
        }
        public virtual ITextStyle TextStyle(string text)
        {
            return style.TextStyle(text);
        }
    }
}
