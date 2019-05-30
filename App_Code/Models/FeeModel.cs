using System;

/// <summary>
/// Summary description for FeeModel
/// </summary>
namespace Nits.Model
{
    public class FeeModel
    {
        public long FHID { get; set; }
        public string FHName { get; set; }
        public int FHType { get; set; }
        public string UserName { get; set; }
        public bool IdDeleted { get; set; }
        public DateTime UpdatedOn { get; set; }
        public String UpdatedBy { get; set; }
        public decimal FRate { get; set; }
        public int IsPrimary { get; set; }


    }
    public class FeeStructuree
    {
        public long FSID { get; set; }
        public long FHIDFK { get; set; }
        public long CIDFK { get; set; }
        public long SecIDFK { get; set; }
        public string Current_Session { get; set; }
        public decimal Amount { get; set; }
        public string UserName { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Updatedby { get; set; }
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Remarks { get; set; }


    }

    public class SearchStudent
    {
        public long AdminNo { get; set; }
        public long sCode { get; set; }
        public string SName { get; set; }
        public string Current_Session { get; set; }
        public int Check { get; set; }

    }
    public class Feedue
    {
        public long SFHLID { get; set; }
        public long CID { get; set; }
        public long SecID { get; set; }
        public long StudentID { get; set; }
        public long StudentInfoID { get; set; }
        public long FHID { get; set; }
        public long DID { get; set; }
        public string CSession { get; set; }
        public string FeeMonth { get; set; }
        public string FYear { get; set; }
        public string SystemMonth { get; set; }
        public string SystemYear { get; set; }
        public decimal FeeRate { get; set; }
        public decimal Rebate { get; set; }
        public string UserName { get; set; }
        public int IsApplicable { get; set; }
        public string Remarks { get; set; }
        public string FeeHeadName { get; set; }
        public int TType { get; set; }
        public string UpdatedBy { get; set; }
        public int IsPaid { get; set; }
        public decimal FeeDiscount { get; set; }
        public decimal FeeAdvanvce { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int FHType { get; set; }  //Feehead Type is montly , annualy,onetime 
        public long FSID { get; set; }  //Fee Structure ID
        public DateTime BillDate { get; set; }
        public DateTime DueDate { get; set; }
        public long DiscountDate { get; set; }
        public int Check { get; set; }





    }

    public class FeeAdvanceModel
    {
        public long FeeAdvanceID { get; set; }
        public long SIDFK { get; set; }
        public long AdmissionNo { get; set; }
        public long Scode { get; set; }
        public DateTime FADate { get; set; }
        public decimal FAamount { get; set; }
        public string CSession { get; set; }
        public string UserName { get; set; }
        public long CID { get; set; }
        public long SecID { get; set; }
        public long RecID { get; set; }
        public decimal FeeAdvance { get; set; }
        public decimal SectionAdvance { get; set; }
        public string Remarks { get; set; }
        public int Check { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public class FeeDiscountModel
    {
        public long FeeAdvanceID { get; set; }
        public long SIDFK { get; set; }
        public long AdmissionNo { get; set; }
        public long Scode { get; set; }
        public DateTime FADate { get; set; }
        public decimal FAamount { get; set; }
        public string CSession { get; set; }
        public string UserName { get; set; }
        public long CID { get; set; }
        public long SecID { get; set; }
        public long RecID { get; set; }
        public decimal FeeAdvance { get; set; }
        public decimal SectionAdvance { get; set; }
        public string Remarks { get; set; }
        public int Check { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }


    public class PayFeeModel
    {
        public long UID { get; set; }
        public string MonthName { get; set; }
        public string Current_Session { get; set; }
        public long LedgerID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public decimal Rebate { get; set; }
        public string FYear { get; set; }
        public string SystemMonth { get; set; }
        public string FeeMonth { get; set; }
        public string SystemYear { get; set; }
        public string UserName { get; set; }
        public long DID { get; set; }
        public long ClassID { get; set; }
        public long SectionID { get; set; }
        public decimal PreviousBalance { get; set; }
        public int ISDeleted { get; set; }
        public string Remarks { get; set; }
        public long SubAccountID { get; set; }
        public DateTime ReceiptDate { get; set; }
        public decimal Cashin { get; set; }
        public String MethodOfAdjustment { get; set; }
        public long FIIDFK { get; set; }
        public string ReceiptMode { get; set; }
        public string ChequeNo { get; set; }
        public DateTime ChequeDate { get; set; }
        public string Bank { get; set; }
        public string ReceiptYear { get; set; }
        public string ReceiptMonth { get; set; }
        public int ReceiptDeleted { get; set; }
        public long ReceiptNo { get; set; }
        public int ChequeStatus { get; set; }
        public string FeeheadNAme { get; set; }
        public decimal FeeDiscount { get; set; }
        public long FRIDFK { get; set; }
        public long FDIDFK { get; set; }
        public decimal FeeAdvance { get; set; }
        public long IPGNO { get; set; }
        public long TIDFK { get; set; }
        public long IsAdv { get; set; }
        public decimal RowPyable { get; set; }
        public long FHID { get; set; }
        public long SFHLID { get; set; }
        public Decimal TotalAdvance { get; set; }



    }

    public class StudentLaderModel
    {
        public long SLIDFK { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long UID { get; set; }

    }
    public class EditReceiptModel
    {
        public long SFHLID { get; set; }
        public long ReceipitNo { get; set; }
        public long UID { get; set; }
        public long SCode { get; set; }
        public long Admin { get; set; }
        public decimal FeeRate { get; set; }
        public decimal FeeAdvance { get; set; }
        public decimal Balance { get; set; }
        public int IsPaid { get; set; }
        public long FHID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Cashin { get; set; }
        public string UserName { get; set; }
        public DateTime CurrentDate { get; set; }
        public string UnPaid { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long Classid { get; set; }
        public long SecID { get; set; }
        public string CSession { get; set; }
        public long SIDFK { get; set; }
    }

    public class DepartmentCashCollectionModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string UserName { get; set; }
        public String CSession { get; set; }
        public long FHIDFK { get; set; }
        public string DIDFK { get; set; }
        public int Check { get; set; }
    }
    public class RebateModel
    {
        public int Check { get; set; }
        public long RID { get; set; }
        public string RName { get; set; }
        public DateTime RDate { get; set; }
        public string UserName { get; set; }
        public DateTime UpdatedOn { get; set; }
        public String UpdatedBy { get; set; }
        public decimal RRate { get; set; }
        public int IsPrimary { get; set; }

    }

    public class HalfAssignBusRateModel
    {
        public long SId { get; set; }
        public string CSession { get; set; }
        public long ClassID { get; set; }
        public long Section { get; set; }
        public long FHIDFK { get; set; }
        public string Month { get; set; }
        public decimal ActRate { get; set; }
        public int Check { get; set; }
    }

    public class CashCollectionMOdel
    {
        public long ID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string CSession { get; set; }
        public string UserName { get; set; }
        public long FHIDFK { get; set; }
        public string FeeHeadName { get; set; }
        public long ReceiptNo { get; set; }
        public long DIDFK { get; set; }
        public int Check { get; set; }
    }
    public class IncomeCertificateModel
    {
        public long UID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
    public class DefaultersMOdel
    {
        public long FHIDFK { get; set; }
        public string FHName { get; set; }
        public long StudentIDFK { get; set; }
        public long SFHLID { get; set; }
        public string PhoneNo { get; set; }
        public string ClassName { get; set; }
        public long Classid { get; set; }
        public long SectionName { get; set; }
        public long Sectionid { get; set; }
        public string CSession { get; set; }
        public string Months { get; set; }

    }
}