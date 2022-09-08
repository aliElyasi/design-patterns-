using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Observer
{
    public interface Observer
    {
        public void update();

    }

    public class subject
    {
        List<Observer> observers = new List<Observer>();

        public void Addobserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void Removeobserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notify()
        {
            foreach (var item in observers)
                item.update();

        }
    }

    public class DataSource : subject
    {
        private int _dataValue;
        public int dataValue
        {
            get { return _dataValue; }
            set
            {
                _dataValue = value;
                notify();
            }


        }
    }


    public class SpreadSheet : Observer
    {
        private DataSource _dataSourse;
        public SpreadSheet(DataSource dataSourse)
        {
            _dataSourse = dataSourse;
        }
        public void update()
        {
            Console.WriteLine($"SpreadSheet value is ${_dataSourse.dataValue} ");
        }
    }

    public class chart : Observer
    {
        private DataSource _dataSourse;
        public chart(DataSource dataSourse)
        {
            _dataSourse = dataSourse;
        }
        public void update()
        {
            Console.WriteLine($"chart value is ${_dataSourse.dataValue} ");
        }
    }
}
