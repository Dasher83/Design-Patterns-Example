namespace Command.Structs
{
    internal struct TextSelection
    {
        public int? start;
        public int? end;

        public TextSelection(int? start = null, int? end = null)
        {
            this.start = start;
            this.end = end;
        }
    }
}
