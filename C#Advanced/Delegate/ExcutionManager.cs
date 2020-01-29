
using System;
using System.Collections.Generic;

namespace Delegate
{
    class ExcutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExcution { get; set; }

        private Func<int> _sum;
        private Func<int> _subtract;
        private Func<int> _muliply;

        public ExcutionManager(Func<int> sum, Func<int> subtract, Func<int> muliply)
        {
            _sum = sum;
            _subtract = subtract;
            _muliply = muliply;
        }

        public ExcutionManager()
        {
            FuncExcution = new Dictionary<Operation, Func<int>>(3);
        }

        public void PopulateFunction(Func<int> sum, Func<int> subtract, Func<int> multiply)
        {
            _sum = sum;
            _subtract = subtract;
            _muliply = multiply;
        }

        public void PrepareExcution()
        {
            FuncExcution.Add(Operation.Sum, _sum);
            FuncExcution.Add(Operation.Multiply, _muliply);
            FuncExcution.Add(Operation.Subtract, _subtract);
        }

    }
}
