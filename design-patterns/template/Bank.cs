using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.template
{
    public abstract class Task
    {

        AuditTrail AuditTrail;
        public Task()
        {
            AuditTrail = new AuditTrail();
        }

        public void excute()
        {
            AuditTrail.record();
            doExcute();
        }

        protected abstract void doExcute();
    }

    public class AuditTrail
    {
        public void record()
        {
            Console.WriteLine("Recording the audit..");
        }
    }

    public class TransferMoney : Task
    {
        protected override void doExcute()
        {
            Console.Write("transfer Money");
        }
    }


    public class GenrateReport: Task
    {
        protected override void doExcute()
        {
            Console.Write("Genrate Report");
        }
    }
}