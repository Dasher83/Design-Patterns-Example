using Builder.Interfaces.Aggregations;
using System.Text;

namespace Builder.Builders
{
    internal class SelectQueryBuilder : ISelectQueryBuilder
    {
        private string _query = new StringBuilder("").ToString();
        private bool _verbPortionBuilt;
        private bool _columnsPortionBuilt;
        private bool _tablePortionBuilt;

        public SelectQueryBuilder()
        {
            Reset();
        }

        private bool IsReady
        {
            get
            {
                return _verbPortionBuilt && _columnsPortionBuilt && _tablePortionBuilt;
            }
        }

        public string Query 
        { 
            get 
            {
                if (!IsReady) {
                    throw new FieldAccessException(message: "Query is not ready for retrieval!");
                }
                _query = _query.Trim();
                _query += ";";
                string result = new StringBuilder(_query).ToString();
                Reset();
                return result; 
            } 
        }

        public void Reset()
        {
            _query = new StringBuilder("").ToString();
            _verbPortionBuilt = false;
            _columnsPortionBuilt = false;
            _tablePortionBuilt = false;
        }

        public void BuildVerbPortion()
        {
            _query += "SELECT ";
            _verbPortionBuilt = true;
        }

        public void BuildColumnsPortion(List<string> columns)
        {
            if (_verbPortionBuilt)
            {
                _query += String.Join(", ", columns.ToArray());
                _columnsPortionBuilt = true;
            }
        }

        public void BuildTablePortion(string table)
        {
            if (_columnsPortionBuilt)
            {
                _query += $" FROM {table} ";
                _tablePortionBuilt = true;
            }
        }

        public void BuildWherePortion(string condition)
        {
            if (_tablePortionBuilt)
            {
                _query += $"WHERE {condition}";
            }
        }
    }
}
