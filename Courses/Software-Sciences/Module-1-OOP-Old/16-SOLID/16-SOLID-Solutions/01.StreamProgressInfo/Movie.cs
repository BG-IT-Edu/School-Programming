using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class Movie : IStream
    {
        private string title;
        public Movie(string title, int lenght, int bytesSent)
        {
            this.title = title;
            this.BytesSent = bytesSent;
            this.Length = lenght;
        }

        public int BytesSent { get ; set; }
        public int Length { get ; set; }
    }
}
