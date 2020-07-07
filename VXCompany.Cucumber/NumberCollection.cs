using System.Collections.Generic;
using System.Linq;

namespace Cucumber.Demo
{
    public class NumberCollection
    {
        private readonly List<int> _numberList;


        public NumberCollection(int v)
        {
            _numberList = new List<int>
            {
                v
            };
        }

        public void Add(int v)
        {
            _numberList.Add(v);
        }

        public int Sum()
        {
            return _numberList.Sum();
        }
    }
}