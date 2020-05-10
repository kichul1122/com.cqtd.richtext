using NUnit.Framework;
using UnityEngine;
using CQ;

namespace RichText
{
    public class Print
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PrintSimplePasses()
        {
            Debug.Log("Aqua".Aqua());
            Debug.Log("Black".Black());
            Debug.Log("Blue".Blue());
            Debug.Log("Brown".Brown());
            Debug.Log("Cyan".Cyan());
            Debug.Log("DarkBlue".DarkBlue());
            Debug.Log("Fuchsia".Fuchsia());
            Debug.Log("Green".Green());
            Debug.Log("Grey".Grey());
            Debug.Log("Gray".Gray());
            Debug.Log("LightBlue".LightBlue());
            Debug.Log("Lime".Lime());
            Debug.Log("Magenta".Magenta());
            Debug.Log("Maroon".Maroon());
            Debug.Log("Navy".Navy());
            Debug.Log("Olive".Olive());
            Debug.Log("Orange".Orange());
            Debug.Log("Purple".Purple());
            Debug.Log("Red".Red());
            Debug.Log("Silver".Silver());
            Debug.Log("Teal".Teal());
            Debug.Log("White".White());
            Debug.Log("Yellow".Yellow());
        }
    }
}
