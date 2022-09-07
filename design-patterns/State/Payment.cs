using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.State
{
    public interface IPayment
    {
        public void doPay();
    }

    public class btcPayment : IPayment
    {
        public void doPay()
        {
            throw new NotImplementedException();
        }
    }

    public class WalletPayment : IPayment
    {
        public void doPay()
        {
            throw new NotImplementedException();
        }
    }


    public class transaction
    {

        public void AcceptPayment(IPayment payment)
        {
            payment.doPay();


        }

    }

}
