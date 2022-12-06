using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_SupplyStacks
{
    public class SupplyStack
    {
        private Stack<string> _stack;
        private List<string> _list;

        public SupplyStack(List<string> list)
        {
            _stack = new Stack<string>(list);
            _list = list;
        }

        public void AddAmountTo(int amount, SupplyStack targetStack)
        {
            for (int i = 0; i < amount; i++)
            {
                targetStack._stack.Push(_stack.Pop());
            }
        }

        public void AddMultipleTo(int amount, SupplyStack targetStack)
        {
            for (int i = _list.Count - amount; i < _list.Count; i++)
            {
                targetStack._list.Add(_list[i]);
                
            }
            _list = _list.GetRange(0, _list.Count - amount);
        }

        public override string ToString()
        {
            var result = "";
            foreach (var item in _list)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}
