using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Vending_Machine.Models;

namespace Vending_Machine.ViwersModels
{
    public class ProductViewModel : ObservableObject
    {
        //Modell the product model represents
        private VendingItem _model;
        //Maximu number of itens allowed in this view model
        private const int _maxQuantity = 10;
        //Corrent quantity in the view model
        private int _quantity;

        public int Id
        {
            get { return _model.Id; }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }

            private set
            {
                _quantity = value;
                OnPropertyChange("OutofStockMessage");
                OnPropertyChange("InventoryDisplay");
                OnPropertyChange("Quantity");
            }
        }
        //Formata a messagem do display sobre a quantidade de produtos
        //Ex: "coca-cola = 7"
        public string InventoryDisplay
        {
            get
            {
                return _model.Name + ": " + _quantity;
            }
        }
        //returna uma copia do modelo valor
        public VendingItem information
        {
            get
            {
                return _model;
            }
        }
        //Determina se nos precisamos mostrar uma mensagem de "Fora de estoque"
        public Visibility OutOfStockMessage
        {
            get
            {
                if (Quantity > 0)

                    return Visibility.Hidden;

                return Visibility.Visible;
            }
        }
        public ProductViewModel(int id, string name, double price)
        {
            _model = new VendingItem(id, name, price);
            Quantity = 0;
        }
        public int Refill()
        {
            var amount = _maxQuantity - Quantity;
            Quantity += amount;
            return amount;
        }
        public int Empty()
        {
            var amount = Quantity;
            Quantity = 0;
            return amount;
        }
        public bool Dispense()
        {
            if(Quantity > 0)
            {
                Quantity --;
                return true;
            }
            return false;
        }
    }
}
