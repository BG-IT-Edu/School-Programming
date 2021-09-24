namespace P01.Stream_Progress
{
    public class File : IStream
    {
        private string name;

        public File(string name, int length, int bytesSent) 
        {
            this.name = name;
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int BytesSent { get ; set; }
        public int Length { get; set; }
    }
}
