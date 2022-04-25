using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Bold : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<b>" + Text + "</b>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Deleted : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<del>" + Text + "</del>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Emphasized : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<em>" + Text + "</em>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Important : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<strong>" + Text + "</strong>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Inserted : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<ins>" + Text + "</ins>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Italic : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<italic>" + Text + "</italic>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Marked : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<mark>" + Text + "</mark>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Smaller : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<small>" + Text + "</small>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Subscript : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<sub>" + Text + "</sub>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }

    public class Superscript : ITextStyle
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return "<sup>" + Text + "</sup>";
        }

        public ITextStyle TextStyle(string text)
        {
            Text = text;
            return this;
        }
    }
}
