namespace Builder.Interfaces
{
    internal interface IBaseQueryBuilder
    {
        public string Query { get; }
        public void Reset();
        public void BuildVerbPortion();
        public void BuildTablePortion(string table);
    }
}
