
namespace Delegate
{

    public enum Operation
    {
        Sum,
        Subtract,
        Multiply

    }
    class OperationManager
    {
        private readonly int _first;
        private readonly int _second;
        private readonly ExcutionManager _excutionManager;
        public OperationManager(int first, int second, ExcutionManager excutionManager)
        {
            _first = first;
            _second = second;
            _excutionManager = excutionManager;
            _excutionManager.PopulateFunction(Sum, Subtract, Multiply);
            _excutionManager.PrepareExcution();
        }

        public OperationManager(int first, int second)
        {
            _first = first;
            _second = second;
        }

        private int Sum()
        {
            return _first + _second;
        }
        private int Subtract()
        {
            return _first - _second;
        }
        private int Multiply()
        {
            return _first * _second;
        }

        // with enum class
        public int Execute(Operation operation)
        {
            switch (operation)
            {
                case Operation.Sum:
                    return Sum();
                case Operation.Subtract:
                    return Subtract();
                case Operation.Multiply:
                    return Multiply();
                default:
                    return -1;

            }
        }

        // excution with class excution manager
        public int Execute2(Operation operation)
        {
            return _excutionManager.FuncExcution.ContainsKey(operation)
                ? _excutionManager.FuncExcution[operation]()
                : -1;
        }

        public static bool EmpCondition(Employee emp)
        {
            return emp.Salary > 2000;
        }


    }
}
