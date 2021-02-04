using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.ViewModels
{
    public class PaymentViewModel : ObservableObject
    {   
        //Custumer information
        private double _total;
        private double _inserted;
        private double _change;
        //Machine information
        private double _bankTotal;

        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                OnPropertyChange("Total");
            }
        }
        public double Inserted
        {
            get
            {
                return _inserted;
            }
            set
            {
                _inserted = value;
                OnPropertyChange("Inserted");
            }
        }
        public double Change
        {
            get
            {
                return _change;
            }
            set
            {
                _change = value;
                OnPropertyChange("Change");
            }
        }
        public double BankTotal
        {
            get
            {
                return _bankTotal;
            }
            set
            {
                _bankTotal = value;
                OnPropertyChange("BankTotal");
            }
        }
        public PaymentViewModel()
        {
            Total = 0;
            Inserted = 0;
            Change = 0;
            BankTotal = 0;
        }

        //Insert momentary value
        public void Insert(double value)
        {
            Inserted += value;
        }
        //set the total the requested item costs
        public void SelectedPrice (double value)
        {
            Total = value;
        }
        //Confirm the payment can be make
        public bool Confirm()
        {
            if (Inserted >= Total)
                return true;

            return false;
        }
        //Finalize payment
        public void pay()
        {
            Change = Total - Inserted;
            BankTotal += Total;
            Inserted = 0;
            Total = 0;
        }
        public void Collect()
        {
            Console.WriteLine("Pagamento Recebido: $" + BankTotal);
            BankTotal = 0;
        }
    }
}
