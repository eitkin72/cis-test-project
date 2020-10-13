using System;

namespace CompanyInvoiceSystem.Entities.Enums
{
    [Flags]
    public enum InvoiceType
    {
        None        = 0b_0000_0000,  // 0
        Credit      = 0b_0000_0001,  // 1 
        Debit       = 0b_0000_0010,  // 2 
        Mixed       = 0b_0000_0100,  // 4
        Commercial  = 0b_0000_1000,  // 8
    }
}
