using System.Text;
using Builder.Interfaces.Aggregations;

namespace Builder.Builders
{
    internal class InsertQueryBuilder : IInsertQueryBuilder
    {
        private string _query = new StringBuilder("").ToString();
        private bool _verbPortionBuilt;
        private bool _columnsToValuesPortionBuilt;
        private bool _tablePortionBuilt;

        public InsertQueryBuilder()
        {
            Reset();
        }

        private bool IsReady
        {
            get
            {
                return _verbPortionBuilt && _tablePortionBuilt && _columnsToValuesPortionBuilt;
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
                string result = new StringBuilder(_query).ToString();
                Reset();
                return result; 
            } 
        }

        public void Reset()
        {
            _query = new StringBuilder("").ToString();
            _verbPortionBuilt = false;
            _columnsToValuesPortionBuilt = false;
            _tablePortionBuilt = false;
        }

        public void BuildVerbPortion()
        {
            _query += "INSERT ";
            _verbPortionBuilt = true;
        }

        public void BuildTablePortion(string table)
        {
            if (_verbPortionBuilt)
            {
                _query += $"INTO {table} ";
                _tablePortionBuilt = true;
            }
        }

        public void BuildColumnsToValuesPortion(Dictionary<string, string> columnsToValuesMap)
        {
            if (_tablePortionBuilt)
            {
                string columnsString = $"({String.Join(", ", columnsToValuesMap.Keys.ToArray())})";
                string valuesString = $"(";
                foreach(KeyValuePair<string, string> entry in columnsToValuesMap)
                {
                    valuesString += $"'{entry.Value}', ";
                }
                valuesString = valuesString.Substring(0, valuesString.Length - 2);
                valuesString += ")";
                _query += $"{columnsString} VALUES {valuesString};";
                _columnsToValuesPortionBuilt = true;
            }
        }
    }
}
