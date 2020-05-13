using System;
using System.Collections.Generic;
using System.Text;

namespace VXCompany.Cucumber
{
    public class Number
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }

        public Number Add(int value)
        {
            _value += value;
            return this;
        }
    }
}

