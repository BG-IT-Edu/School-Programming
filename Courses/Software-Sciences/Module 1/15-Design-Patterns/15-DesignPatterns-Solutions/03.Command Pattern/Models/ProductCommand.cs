using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Command_Pattern.Models
{
    public class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
            }
            else
            {
                _product.DecreasePrice(_amount);
            }
        }
    }
}
