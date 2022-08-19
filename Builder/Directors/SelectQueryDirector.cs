using Builder.Builders;
using Builder.Interfaces.Aggregations;

namespace Builder.Directors
{
    internal class SelectQueryDirector
    {
        private readonly ISelectQueryBuilder _builder;

        public SelectQueryDirector()
        {
            _builder = new SelectQueryBuilder();
        }

        public string RequestSimpleSelectQuery(List<string> columns, string table)
        {
            _builder.BuildVerbPortion();
            _builder.BuildColumnsPortion(columns: columns);
            _builder.BuildTablePortion(table: table);
            return _builder.Query;
        }

        public string RequestConditionalSelectQuery(List<string> columns, string table, string condition)
        {
            _builder.BuildVerbPortion();
            _builder.BuildColumnsPortion(columns: columns);
            _builder.BuildTablePortion(table: table);
            _builder.BuildWherePortion(condition: condition);
            return _builder.Query;
        }
    }
}
