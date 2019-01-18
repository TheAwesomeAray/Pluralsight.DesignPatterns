using Moq;
using Pluralsight.DesignPatterns.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Xunit;
using static Pluralsight.DesignPatterns.Adapter;

namespace DesignPatternTests
{
    public class AdapterTests
    {
        [Fact]
        public void Render_GivenDataAdapter_RenderRows()
        {
            var stubAdapter = new Mock<IDbDataAdapter>();
            stubAdapter.Setup(s => s.Fill(It.IsAny<DataSet>()))
                       .Callback<DataSet>(x => 
                       {
                           x.Tables.Add(RendererTestData.GetData());
                           x.AcceptChanges();
                       });     
            var dataRenderer = new DataRenderer(stubAdapter.Object);
            var writer = new StringWriter();

            dataRenderer.Render(writer);
            var result = writer.ToString();

            Assert.Equal(3, result.Count(c => c == '\n'));
        }

        [Fact]
        public void PatterList_CanUseAdapter_ReturnsCorrectLineCount()
        {
            var patterns = new List<Pattern>()
            {
                new Pattern() { Id = 1, Name = "Adapter", Description = "Make it fit" },
                new Pattern() { Id = 1, Name = "Singleton", Description = "There can only be one" }
            };

            var patternRenderer = new PatternRenderer();
            var result = patternRenderer.ListPatterns(patterns);

            Assert.Equal(4, result.Count(c => c == '\n'));
        }

        public static class RendererTestData
        {
            public static DataTable GetData()
            {
                var dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Description", typeof(string)));

                var row = dataTable.NewRow();
                row[0] = 1;
                row[1] = "Name";
                row[2] = "Description";
                dataTable.Rows.Add(row);

                return dataTable;
            }
        }
    }
}
