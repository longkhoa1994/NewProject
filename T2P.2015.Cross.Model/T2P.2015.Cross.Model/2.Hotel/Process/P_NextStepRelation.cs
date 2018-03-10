using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model
{

    public class P_NextSTepRelation
    {
        private B_Access b_Access;

        public B_Access B_Access
        {
            get { return b_Access; }
            set { b_Access = value; }
        }

        private List<I_Image> listInvoiceRelation;

        public List<I_Image> ListInvoiceRelation
        {
            get { return listInvoiceRelation; }
            set { listInvoiceRelation = value; }
        }


        private List<P_BookingStep> listBookingStepUpdate;

        public List<P_BookingStep> ListBookingStepUpdate
        {
            get { return listBookingStepUpdate; }
            set { listBookingStepUpdate = value; }
        }

        private List<P_BookingStep> listBookingStepDelete;

        public List<P_BookingStep> ListBookingStepDelete
        {
            get { return listBookingStepDelete; }
            set { listBookingStepDelete = value; }
        }

        private List<P_InvoiceStep> listStepInvoiceUpdate;

        public List<P_InvoiceStep> ListInvoiceStepUpdate
        {
            get { return listStepInvoiceUpdate; }
            set { listStepInvoiceUpdate = value; }
        }

        private List<P_InvoiceStep> listStepInvoiceDelete;

        public List<P_InvoiceStep> ListInvoiceStepDelete
        {
            get { return listStepInvoiceDelete; }
            set { listStepInvoiceDelete = value; }
        }

        private List<P_FinancialStep> listFinancialStepUpdate;

        public List<P_FinancialStep> ListFinancialStepUpdate
        {
            get { return listFinancialStepUpdate; }
            set { listFinancialStepUpdate = value; }
        }

        private List<P_FinancialStep> listFinancialStepDelete;

        public List<P_FinancialStep> ListFinancialStepDelete
        {
            get { return listFinancialStepDelete; }
            set { listFinancialStepDelete = value; }
        }

        private List<P_NextBookingStep> listBookingNextStepUpdate;

        public List<P_NextBookingStep> ListBookingNextStepUpdate
        {
            get { return listBookingNextStepUpdate; }
            set { listBookingNextStepUpdate = value; }
        }

        private List<P_NextBookingStep> listBookingNextStepDelete;

        public List<P_NextBookingStep> ListBookingNextStepDelete
        {
            get { return listBookingNextStepDelete; }
            set { listBookingNextStepDelete = value; }
        }

        private List<P_NextFinancialStep> listFINNextStepUpdate;

        public List<P_NextFinancialStep> ListFINNextStepUpdate
        {
            get { return listFINNextStepUpdate; }
            set { listFINNextStepUpdate = value; }
        }

        private List<P_NextFinancialStep> listFINNextStepDelete;

        public List<P_NextFinancialStep> ListFINNextStepDelete
        {
            get { return listFINNextStepDelete; }
            set { listFINNextStepDelete = value; }
        }


        private List<P_NextInvoiceStep> listInvoiceNextStepUpdate;

        public List<P_NextInvoiceStep> ListInvoiceNextStepUpdate
        {
            get { return listInvoiceNextStepUpdate; }
            set { listInvoiceNextStepUpdate = value; }
        }


        private List<P_NextInvoiceStep> listInvoiceNextStepDelelte;

        public List<P_NextInvoiceStep> ListInvoiceNextStepDelete
        {
            get { return listInvoiceNextStepDelelte; }
            set { listInvoiceNextStepDelelte = value; }
        }
        private List<N_Task> listN_Task;
        public List<N_Task> ListN_Task
        {
            get { return listN_Task; }
            set { listN_Task = value; }
        }
        private List<N_Task> listN_TaskDelete;
        public List<N_Task> ListN_TaskDelete
        {
            get { return listN_TaskDelete; }
            set { listN_TaskDelete = value; }
        }

        private List<F_Transaction> listF_Transaction;

        public List<F_Transaction> ListF_Transaction
        {
            get { return listF_Transaction; }
            set { listF_Transaction = value; }
        }

        private N_CostAcceptance costAcceptance;

        public N_CostAcceptance CostAcceptance
        {
            get { return costAcceptance; }
            set { costAcceptance = value; }
        }

        public P_NextSTepRelation()
        {
            this.B_Access = null;
            this.ListInvoiceRelation = new List<I_Image>();

            this.ListInvoiceStepUpdate = new List<P_InvoiceStep>();
            this.ListInvoiceStepDelete = new List<P_InvoiceStep>();
            this.ListFinancialStepUpdate = new List<P_FinancialStep>();
            this.ListFinancialStepDelete = new List<P_FinancialStep>();
            this.ListBookingStepUpdate = new List<P_BookingStep>();
            this.ListBookingStepDelete = new List<P_BookingStep>();



            this.ListBookingNextStepUpdate = new List<P_NextBookingStep>();
            this.ListBookingNextStepDelete = new List<P_NextBookingStep>();

            this.ListFINNextStepUpdate = new List<P_NextFinancialStep>();
            this.listFINNextStepDelete = new List<P_NextFinancialStep>();

            this.ListInvoiceNextStepUpdate = new List<P_NextInvoiceStep>();
            this.ListInvoiceNextStepDelete = new List<P_NextInvoiceStep>();

            this.ListN_Task = new List<N_Task>();
            this.ListN_TaskDelete = new List<N_Task>();
            this.ListF_Transaction = new List<F_Transaction>();
            this.CostAcceptance = null;
        }

    }
}

