using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunBeam.Tool
{
   public class CreateController
    {
        private readonly string tableName;
        private List<TableSchema> tableSchema;
        private readonly TableSchema tablePk;
        private string currentPath;

        public CreateController(string tableName, List<TableSchema> tableSchema, string currentPath) {
            this.tableName = tableName;
            this.tableSchema = tableSchema;
            var firstOrDefault = tableSchema.FirstOrDefault(p => p.IsIdentity.ToLower() == "true");
            if (firstOrDefault != null)
                tablePk = firstOrDefault;
            if (tableName == "Customers" || tableName == "Customers")
                tablePk = tableSchema.ElementAt<TableSchema>(0);
            this.currentPath = currentPath + tableName;
        }

        private void WriteRepositoryClass(StreamWriter writer)
        {
            writer.WriteLine("using SunBeam.Common.Log;");
            writer.WriteLine("using SunBeam.Common.Utility;");
            writer.WriteLine("using SunBeam.Data.Infrastructure;");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Collections.Generic;");
            writer.WriteLine("using System.Data;");
            writer.WriteLine("using System.Data.SqlClient;");
            writer.WriteLine("using System.Threading.Tasks;");
            writer.WriteLine("using SunBeam.Data.Repositories.Interfaces;");
            writer.WriteLine("using SunBeam.Domain.Models;");
            writer.WriteLine("using SunBeam.Service.Interfaces;");
            writer.WriteLine(" ");

            writer.WriteLine("namespace SunBeam.Web.Controllers");
            writer.WriteLine("{");
            writer.WriteLine("public class "+ tableName.Remove(tableName.Length - 1) + "Controller");
            writer.WriteLine("{");

            writer.WriteLine("private readonly I"+ tableName + "BL repo;");
            writer.WriteLine("public "+ tableName.Remove(tableName.Length - 1) + "Controller(I"+ tableName+"BL _repo)");
            writer.WriteLine("{");

            writer.WriteLine("this.repo = _repo;");
            writer.WriteLine("}");
            writer.WriteLine(" ");
            writer.WriteLine(" ");


            writer.WriteLine("}");
            writer.WriteLine("}");
        }
        }
}
