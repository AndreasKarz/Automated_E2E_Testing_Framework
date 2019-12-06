using System.Data;

namespace Automated_E2E_Testing_Workshop
{
    public static class SpecFlowExtension
    {
        public static DataTable ToDataTable(this TechTalk.SpecFlow.Table table)
        {
            DataTable resultTable = new DataTable();

            foreach (var col in table.Header)
            {
                resultTable.Columns.Add(col, typeof(string));
            }

            foreach (var row in table.Rows)
            {
                var resRow = resultTable.NewRow();
                for (int i = 0; i < row.Count; i++)
                {
                    resRow[i] = row[i];
                }
                resultTable.Rows.Add(resRow);
            }

            return resultTable;
        }
    }
}
