using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawDivIv
{
    public int Idnum { get; set; }

    public string CaseId { get; set; } = null!;

    public short? Division { get; set; }

    public string? AddessStreet1 { get; set; }

    public string? AddressStreet2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Instanter { get; set; }

    public decimal? PurgeContemptAmount { get; set; }

    public byte? WhcsJudgeOrdered { get; set; }

    public DateTime? WhcsOrderedDate { get; set; }

    public decimal? CurrentSupportAmount { get; set; }

    public string? AdditionalAmount { get; set; }

    public decimal? SupportArrearageAmount { get; set; }

    public DateTime? SupportArrearageAmountDate { get; set; }

    public decimal? PeriodicPaymentAmount { get; set; }

    public DateTime? PeriodicPaymentAmountDate { get; set; }

    public DateTime? PeriodicPaymentBeginDate { get; set; }

    public string? PeriodicPaymentsDue { get; set; }

    public decimal? IncomeDeductionAmount { get; set; }

    public byte? IncomeDeductionJudgeOrdered { get; set; }

    public DateTime? IncomeDeductionOrderedDate { get; set; }

    public string? SupportAccountNumber { get; set; }

    public decimal? AttachATotalAmountDue { get; set; }

    public string? AttachAPeriod { get; set; }

    public decimal? AttachAChildSupportAmount1 { get; set; }

    public decimal? AttachAChildSupportAmount2 { get; set; }

    public decimal? AttachAChildSupportAmount3 { get; set; }

    public decimal? AttachAAlimonyAmount1 { get; set; }

    public decimal? AttachAAlimonyAmount2 { get; set; }

    public decimal? AttachAAlimonyAmount3 { get; set; }

    public decimal? AttachAOtherAmount1 { get; set; }

    public decimal? AttachAOtherAmount2 { get; set; }

    public decimal? AttachAOtherAmount3 { get; set; }

    public decimal? AttachAPaymentFrequency { get; set; }

    public DateTime? AttachAPaymentsBeginDate { get; set; }

    public string? AttachAObligee { get; set; }

    public string? Finalize { get; set; }

    public string? Instructions { get; set; }

    public string? Other { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ChangeDate { get; set; }
}
