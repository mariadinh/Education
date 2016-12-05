using System;
using System.Collections.Generic;

namespace Practice
{
    abstract class Stock
    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _listInvestor = new List<IInvestor>();

        public string Symbol
        {
            get { return _symbol; }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                Notify();
            }
        }

        public Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public void Attach(IInvestor investor)
        {
            _listInvestor.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _listInvestor.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _listInvestor)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        
    }
}