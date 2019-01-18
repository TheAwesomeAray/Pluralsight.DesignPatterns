﻿using System.Data;
using System.IO;

namespace Pluralsight.DesignPatterns
{
    public class Adapter
    { 
        public class DataRenderer
        {
            private readonly IDbDataAdapter _dataAdapter;

            public DataRenderer(IDbDataAdapter dataAdapter)
            {
                _dataAdapter = dataAdapter;
            }

            public void Render(TextWriter writer)
            {
                writer.WriteLine("Rendering Data");
                var dataSet = new DataSet();

                _dataAdapter.Fill(dataSet);

                foreach (DataTable table in dataSet.Tables)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        writer.Write(column.ColumnName.PadRight(20) + " ");
                    }
                    writer.WriteLine();
                    foreach (DataRow row in table.Rows)
                    {
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            writer.Write(row[i].ToString().PadRight(20) + " ");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
