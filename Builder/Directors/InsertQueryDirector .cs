using Builder.Builders;
using Builder.Interfaces.Aggregations;

namespace Builder.Directors
{
    internal class InsertQueryDirector
    {
        private readonly IInsertQueryBuilder _builder;

        public InsertQueryDirector()
        {
            _builder = new InsertQueryBuilder();
        }

        public string RequestInsertQuery(string table, Dictionary<string, string> columnsToValuesMap)
        {
            _builder.BuildVerbPortion();
            _builder.BuildTablePortion(table: table);
            _builder.BuildColumnsToValuesPortion(columnsToValuesMap: columnsToValuesMap);
            return _builder.Query;
        }
    }
}
