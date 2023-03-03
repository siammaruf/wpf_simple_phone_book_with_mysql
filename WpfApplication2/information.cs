using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class information
    {
        private String data1;
        private String data2;
        private String data3;
        private String data4;

        public String serverName
        {
            get { return data1; }
            set { data1 = value; }
        }

        public String databaseName
        {
            get { return data2; }
            set { data2 = value; }
        }

        public String DBUserName
        {
            get { return data3; }
            set { data3 = value; }
        }

        public String DBPassword
        {
            get { return data4; }
            set { data4 = value; }
        }
    }
}
