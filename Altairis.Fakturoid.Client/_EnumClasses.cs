using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    public class InvoiceStatus : Tuple<string> {
        public static readonly InvoiceStatus All = new InvoiceStatus(null);
        public static readonly InvoiceStatus Open = new InvoiceStatus("open");
        public static readonly InvoiceStatus Sent = new InvoiceStatus("sent");
        public static readonly InvoiceStatus Overdue = new InvoiceStatus("overdue");
        public static readonly InvoiceStatus Paid = new InvoiceStatus("paid");
        public static readonly InvoiceStatus Cancelled = new InvoiceStatus("cancelled");

        private InvoiceStatus(string value) : base(value) { }

        public override string ToString() {
            return base.Item1;
        }
    }

    public class InvoiceType : Tuple<string> {
        public static readonly InvoiceType All = new InvoiceType("invoices.json");
        public static readonly InvoiceType Proforma = new InvoiceType("invoices/proforma.json");
        public static readonly InvoiceType Regular = new InvoiceType("invoices/regular.json");

        private InvoiceType(string value) : base(value) { }

        public override string ToString() {
            return base.Item1;
        }
    }

    public class InvoiceAction : Tuple<string> {
        public static readonly InvoiceAction MarkAsSent = new InvoiceAction("mark_as_sent");
        public static readonly InvoiceAction Deliver = new InvoiceAction("deliver");
        public static readonly InvoiceAction Pay = new InvoiceAction("pay");
        public static readonly InvoiceAction PayProforma = new InvoiceAction("pay_proforma");
        public static readonly InvoiceAction PayPartialProforma = new InvoiceAction("pay_partial_proforma");
        public static readonly InvoiceAction RemovePayment = new InvoiceAction("remove_payment");
        public static readonly InvoiceAction DeliverReminder = new InvoiceAction("deliver_reminder");

        private InvoiceAction(string value) : base(value) { }

        public override string ToString() {
            return base.Item1;
        }
    }

}
