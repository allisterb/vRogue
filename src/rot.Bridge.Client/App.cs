using Bridge;
using Newtonsoft.Json;
using System;

using ROT;
using Bridge.Html5;

namespace rot.Bridge.Client
{
    public class App
    {
        public static void Main()
        {
            // Write a message to the Console
            Console.WriteLine("Welcome to Bridge.NET");

            var display = new ROT.Display(new DisplayOptions() { Width = 40, Height = 9, FontSize = 20, FontStyle = "bold"});
            Document.Body.AppendChild(display.GetContainer());
            display.Draw(5, 4, "@");
            display.Draw(15, 4, "%");          /* foreground color */
            display.Draw(25, 4, "#");  /* and background color */
        }
    }
}