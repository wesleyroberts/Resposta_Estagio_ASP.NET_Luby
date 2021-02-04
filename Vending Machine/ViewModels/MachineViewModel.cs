using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Vending_Machine.ViwersModels;

namespace Vending_Machine.ViewModels
{
     public class MachineViewModel:ObservableObject
    {
        public ObservableCollection<ProductViewModel>Items { get; private set; }
        public PaymentViewModel Bank { get; private set; }
        public MachineViewModel()
        {
            Bank = new PaymentViewModel();
            Items = new ObservableCollection<ProductViewModel>()
            {
                new ProductViewModel(1, "Coca-cola", 2.50),
                new ProductViewModel(1, "Fanta Uva", 1.50),
                new ProductViewModel(1, "Fanta laranja", 0.50),
                new ProductViewModel(1, "Sprite", 0.25),
                new ProductViewModel(1, "Antartica", 1.00)
            };

        }
        public void Purchase(object item)
        {
            var requestedItem = item as ProductViewModel;
            Bank.SelectedPrice(requestedItem.information.Price);
            if (Bank.Confirm())
            {
                if (requestedItem.Dispense())
                {
                    Bank.pay();
                    Console.WriteLine("Aproveite sua bebida!");
                }
            }
        }
        public void InsertChange(double value)
        {
            Bank.Insert(value);
        }
        public void CollectPayments()
        {
            Bank.Collect();
        }
        public void Refill()
        {
            foreach (var i in Items)
            {
                i.Refill();
            }
            Console.WriteLine("A máquina foi reabastecida");
        }
        public void Empty()
        {
            foreach (var i in Items)
            {
                i.Empty();
            }
            Console.WriteLine("A máquina foi esvaziada!");
        }
    }
}
