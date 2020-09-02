using Bridge;
using Newtonsoft.Json;
using System;

using ROT;
namespace rot.Bridge.Client
{
    public class App
    {
        public static void Main()
        {
            // Write a message to the Console
            Console.WriteLine("Welcome to Bridge.NET");

            var d = new Display(new DisplayOptions() { Width = 5, Height = 10 });
            var m = new RogueSharp.Map(5, 10);
            Console.WriteLine(m.Height);
            // After building (Ctrl + Shift + B) this project, 
            // browse to the /bin/Debug or /bin/Release folder.

            // A new bridge/ folder has been created and
            // contains your projects JavaScript files. 

            // Open the bridge/index.html file in a browser by
            // Right-Click > Open With..., then choose a
            // web browser from the list

            // This application will then run in the browser.
        }
    }
}