using System.Collections.Generic;
using System.Data;
using System.IO;
using static Pluralsight.DesignPatterns.Adapter;

namespace Pluralsight.DesignPatterns.Domain
{
    public class PatternRenderer : IDataPatternRendererAdapter
    {
        private IDataPatternRendererAdapter _dataPatternRenderer;

        public PatternRenderer(IDataPatternRendererAdapter dataPatternRenderer)
        {
            _dataPatternRenderer = dataPatternRenderer;
        }

        public PatternRenderer() : this(new DataPatternRendererAdapter())
        { }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return _dataPatternRenderer.ListPatterns(patterns);
        }
    }

    public class DataPatternRendererAdapter : IDataPatternRendererAdapter
    {
        private DataRenderer _dataRenderer;

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            _dataRenderer = new DataRenderer(new PatternCollectionDbAdapter(patterns));
            var writer = new StringWriter();
            _dataRenderer.Render(writer);
            return writer.ToString();
        }

        internal class PatternCollectionDbAdapter : IDbDataAdapter
        {
            private IEnumerable<Pattern> _patterns;

            public PatternCollectionDbAdapter(IEnumerable<Pattern> patterns)
            {
                _patterns = patterns;
            }

            public int Fill(DataSet dataSet)
            {
                var dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Description", typeof(string)));

                foreach (var pattern in _patterns)
                {
                    var row = dataTable.NewRow();
                    row[0] = pattern.Id;
                    row[1] = pattern.Name;
                    row[2] = pattern.Description;
                    dataTable.Rows.Add(row);
                }

                dataSet.Tables.Add(dataTable);
                dataSet.AcceptChanges();

                return dataTable.Rows.Count;
            }

            #region NotImplemented
            public IDbCommand DeleteCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
            public IDbCommand InsertCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
            public IDbCommand SelectCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
            public IDbCommand UpdateCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
            public MissingMappingAction MissingMappingAction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
            public MissingSchemaAction MissingSchemaAction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

            public ITableMappingCollection TableMappings => throw new System.NotImplementedException();

            

            public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
            {
                throw new System.NotImplementedException();
            }

            public IDataParameter[] GetFillParameters()
            {
                throw new System.NotImplementedException();
            }

            public int Update(DataSet dataSet)
            {
                throw new System.NotImplementedException();
            }
            #endregion
        }
    }
}
