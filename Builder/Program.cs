using Builder.Directors;
using Builder.Utils;

SelectQueryDirector selectQueryDirector = new SelectQueryDirector();
List<string> columns = new List<string>{"Name", "Surname"};
string table = "People";
string query = selectQueryDirector.RequestSimpleSelectQuery(columns: columns, table: table);
Console.ForegroundColor = RandomConsoleColorPicker.Pick;
Console.WriteLine(query);
query = selectQueryDirector.RequestSimpleSelectQuery(columns: new List<string> { "*" }, table: table);
Console.WriteLine(query);
Console.WriteLine();
string condition = "Name=\"Dasher\"";
query = selectQueryDirector.RequestConditionalSelectQuery(columns: columns, table: table, condition: condition);
Console.ForegroundColor = RandomConsoleColorPicker.Pick;
Console.WriteLine(query);
query = selectQueryDirector.RequestConditionalSelectQuery(columns: new List<string> { "*" }, table: table, condition: condition);
Console.WriteLine(query);
Console.WriteLine();

InsertQueryDirector insertQueryDirector = new InsertQueryDirector();
Dictionary<string, string> columnsToValuesMap = new Dictionary<string, string>()
{
    { "Name", "Dasher" },
    { "Surname", "Ishi" }
};
query = insertQueryDirector.RequestInsertQuery(table: table, columnsToValuesMap: columnsToValuesMap);
Console.ForegroundColor = RandomConsoleColorPicker.Pick;
Console.WriteLine(query);
Console.WriteLine();
Console.ResetColor();

