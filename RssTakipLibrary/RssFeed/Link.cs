using System;
using System.Diagnostics;

namespace RssTakipLibrary.RssFeed
{
    public class Link
    {
        public static void Ac(string haberLinki)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = haberLinki,
                UseShellExecute = true
            });
        }
    }
}