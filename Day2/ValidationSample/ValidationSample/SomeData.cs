using System;
using System.ComponentModel;

namespace ValidationSample
{
    public class SomeData : IDataErrorInfo
    {
        private int _x1;

        public int X1
        {
            get { return _x1; }
            set
            {
                if (value > 50) throw new Exception("bad value");
                _x1 = value;
            }
        }

        public int X2 { get; set; }

        public string this[string columnName]
        {
            get
            {
                string result = null;
                switch (columnName)
                {
                    case "X2":
                        if (X2 > 50) result = "wrong value with X2";
                        break;
                    default:
                        break;
                }
                return result;
            }
        }



        public string Error => throw new NotImplementedException();
    }
}
