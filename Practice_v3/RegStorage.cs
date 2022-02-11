using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_v3
{
    public class RegStorage
    {
        public int _currentValue { get; set; }

        public int _capacity { get; set; }

        public int _minConsumable { get; set; }

        public int _maxConsumable { get; set; }

        public int _id { get; set; }

        public int _supplyID { get; set; }

        public bool _isConsumable { get; set; }

        //История значений
        public List<int> ValueHistory { get; set; }

        public RegStorage(int capacity)
        {
            _capacity = capacity;
        }

        public RegStorage(int id, int supplyID, int capacity, bool isConsumable, int maxConsumable, int minConsumable)
        {
            _id = id;
            _supplyID = supplyID;
            _capacity = capacity;
            _currentValue = capacity;
            _isConsumable = isConsumable;
            if (isConsumable)
            {
                _minConsumable = minConsumable;
                _maxConsumable = maxConsumable;
            }
            else
            {
                _minConsumable = 0;
                _maxConsumable = 0;
            }
            ValueHistory = new List<int>();
            ValueHistory.Add(capacity);
        }
        //уменьшает количество на складе
        public void DecreaseCount(int Value)
        {
            _currentValue -= Value;
            if(_currentValue <= 0)
            {
                _currentValue = 0;
            }
            ValueHistory.Add(_currentValue);
        }

        //Увеличивает значение на значение одной поставки
        public void IncreaseValue(int Value)
        {
            _currentValue += Value;
            ValueHistory.Add(_currentValue);
        }

        public void DecreaseRandom()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            DecreaseCount(rand.Next(_minConsumable, _maxConsumable));
        }
    }
}
