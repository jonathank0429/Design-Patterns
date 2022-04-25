using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorator");
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            ITextStyle bold = new Bold();
            bold.TextStyle(text);
            Console.WriteLine(bold + "\n");

            ITextStyle deleted = new Deleted();
            deleted.TextStyle(text);
            Console.WriteLine(deleted + "\n");

            ITextStyle emphasized = new Emphasized();
            emphasized.TextStyle(text);
            Console.WriteLine(emphasized + "\n");

            ITextStyle important = new Important();
            important.TextStyle(text);
            Console.WriteLine(important + "\n");

            ITextStyle inserted = new Inserted();
            inserted.TextStyle(text);
            Console.WriteLine(inserted + "\n");

            ITextStyle italic = new Italic();
            italic.TextStyle(text);
            Console.WriteLine(italic + "\n");

            ITextStyle marked = new Marked();
            marked.TextStyle(text);
            Console.WriteLine(marked + "\n");

            ITextStyle smaller = new Smaller();
            smaller.TextStyle(text);
            Console.WriteLine(smaller + "\n");

            ITextStyle subscript = new Subscript();
            subscript.TextStyle(text);
            Console.WriteLine(subscript + "\n");

            ITextStyle superscript = new Superscript();
            superscript.TextStyle(text);
            Console.WriteLine(superscript + "\n");
            Console.ReadKey();
        }
    }
}