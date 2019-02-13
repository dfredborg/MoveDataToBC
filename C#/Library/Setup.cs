using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public enum Type { SQL, CSV, Excel }
    public class Setup
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string webServiceUrl { get; set; }
        public string server { get; set; }
        public string database { get; set; }
        public string sqlTable { get; set; }
        public string csvPath { get; set; }
        public string excelPath { get; set; }
        public Type type { get; set; }
        public bool direct { get; set; }
        public string function { get; set; }
    }
}
