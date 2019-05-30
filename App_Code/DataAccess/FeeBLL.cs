using Nits.Common;
using Nits.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;

/// <summary>
/// Summary description for FeeBLL
/// </summary>
namespace Nits.BLL
{
    public class FeeBLL
    {
        public string InsertIntoFeeHead(FeeModel Fee)
        {
            try
            {
                SqlParameter[] sp =
           {
                new SqlParameter("@FHName",Fee.FHName),
                new SqlParameter("@FHType",Fee.FHType),
                new SqlParameter("@UserName",Fee.UserName),
                new SqlParameter("@Frate",Fee.FRate),
               new SqlParameter("@isprimay",Fee.IsPrimary)
            };

                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "InsertIntoFeeHeads", sp);
                if (returnValue > 0)
                {
                    return "Transaction Successful";
                }
                else
                {
                    return "Fee Head Alrady Exists";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DataSet LoadFeeDue(Feedue feed)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@StudentID",feed.StudentID),
                new SqlParameter("@CSession",feed.CSession)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select SFHLID,StudentIDFK,FeeMonth, FeeHeadName,FHIDFK,FHType, AdmissionNo from StudentFeeHeadList inner join Students on Students.StudentID = StudentFeeHeadList.StudentIDFK where StudentIDFK = @StudentID and Current_Session = @CSession and IsPaid=0", sp);
            return ds;
        }
       
        public DataSet CheckFHTypeByFHID(long FHID)
        {
            SqlParameter[] sp =
           {
                new SqlParameter("@FHID",FHID)

            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FHID,FHType from Feeheads where FHID=@FHID", sp);
            return ds;
        }
        public string deleteFeeDueById(long SFHLID)
        {
            try
            {
                SqlParameter[] sp =
           {
                new SqlParameter("@SFHLID",SFHLID)

            };
                int rv = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "delete StudentFeeHeadList where SFHLID=@SFHLID and IsPaid=0", sp);
                if (rv > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }
        public DataSet getFeeHeads()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FHID,FHName,UserName from Feeheads where IsDeleted=0");
            return ds;
        }
        public DataSet editFeehead(long FHID)
        {
            SqlParameter[] sp =
         {
                new SqlParameter("@FHID",FHID)

            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FHID,FHName,FHType,UserName from Feeheads where IsDeleted=0 and FHID=@FHID", sp);
            return ds;
        }
        public string UpdateFeeHeads(FeeModel FM)
        {
            try
            {

                SqlParameter[] sp =
                {
                new SqlParameter("@FHID",FM.FHID),
                new SqlParameter("@FHName",FM.FHName),
                new SqlParameter("@UpdatedBy",FM.UpdatedBy),
                new SqlParameter("@UpdatedOn",FM.UpdatedOn)
            };
                int retuenValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "UpdateFeeHeads", sp);
                if (retuenValue > 0)
                {
                    return "Transaction Updated Successful";
                }
                else
                {
                    return "Fee Head Alrady Exists ";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public string DeleteFeeHEads(long Id)
        {
            try
            {
                SqlParameter[] sp =
        {
                new SqlParameter("@FHID",Id)
            };
                int retuenValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "update Feeheads set IsDeleted=1 where FHID=@FHID and FHID not in (1,2,3,4)", sp);
                if (retuenValue > 0)
                {
                    return "Successfully Deleted";
                }
                else
                {
                    return "Primary Fee Head Cannot be deleted";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        ///Fee Structure
        public DataSet getClasses(string CurrentSession)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@CurrentSession",CurrentSession)
            };
            DataSet ReturnValue = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select ClassId,ClassName from Classes where Current_Session=@CurrentSession", sp);
            return ReturnValue;
        }
        public DataSet GetClassSection(long ClassID)
        {

            SqlParameter[] sp =
            {
                new SqlParameter("@ClassID",ClassID)
            };
            DataSet ReturnValue = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select SectionID,SectionName from Sections where ClassId=@ClassID", sp);
            return ReturnValue;

        }
        public DataSet GetFeeHeads()
        {


            DataSet ReturnValue = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FHID,FHName from feeheads where IsDeleted=0");
            return ReturnValue;

        }
        public string InsertIntoFeeStructure(FeeStructuree FeeS)
        {
            try
            {

                SqlParameter[] sp =
                {
                new SqlParameter("@CIDFK",FeeS.CIDFK),
                new SqlParameter("@FHIDFK",FeeS.FHIDFK),
                new SqlParameter("@Current_Session",FeeS.Current_Session),
                new SqlParameter("@Amount",FeeS.Amount),
                new SqlParameter("@UserName",FeeS.UserName),
                new SqlParameter("@Title",FeeS.Title),
                new SqlParameter("@Remarks",FeeS.Remarks),
            };

                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "InsertIntoFeeStructure", sp);

                if (returnValue > 0)
                {
                    return "Transaction Updated Successful";
                }
                else
                {
                    return "Fee Head Alrady Exists ";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public DataSet getFeestructure(long FSID)
        {
            SqlParameter[] var =
            {
                new SqlParameter("@FSID",FSID)
            };

            DataSet ReturnValue = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select CIDFK,FHIDFK,Amount,Title,Remarks from FeeStructure where FSID=@FSID and IsDeleted=0",var);
            return ReturnValue;

        }
        public DataSet GetAllFeeStructure(long CID)
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select Feeheads.FHID,Feeheads.FHName, FeeStructure.FSID ,FeeStructure.FHIDFK," +
                "FeeStructure.Amount, FeeStructure.UserName, FeeStructure.Title,FeeStructure.CSession, FeeStructure.Remarks from feestructure inner join Feeheads on " +
                "Feeheads.FHID = FeeStructure.FHIDFK where FeeStructure.CIDFK=   " + CID + "and  FeeStructure.IsDeleted=" + 0);
            return ds;
        }
        public DataSet getClassName(long DCID)
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select ClassId , ClassName from Classes where ClassId=" + DCID);
            return ds;
        }
        public string UpdateFeeStructure(long FSID, FeeStructuree FS)
        {
            try
            {
                SqlParameter[] sp =
          {
                new SqlParameter("@FSID",FSID),
                new SqlParameter("@Amount",FS.Amount),
                new SqlParameter("@Title",FS.Title),
                new SqlParameter("@Remarks",FS.Remarks),
                new SqlParameter("@UpdatedOn",FS.UpdatedOn),
                new SqlParameter("@UpdatedBy",FS.Updatedby),
            };

                int rv = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "UpdateFeeStructure", sp);
                if (rv > 0)
                {
                    return "Transaction Updated Successful";
                }
                else
                {
                    return "Fee Head Alrady Exists ";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }
        public String DeleteFeeStructure(long FSID)
        {
            try
            {

                int retuenValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "update FeeStructure set IsDeleted=1  where FSID=" + FSID);
                if (retuenValue > 0)
                {
                    return "SUccessfully Deleted";
                }
                else
                {
                    return "SomeThing Went Wrong";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public DataSet searchStudent(SearchStudent SSModel)
        {

            SqlParameter[] sp =
       {
                new SqlParameter("@check",SSModel.Check),
                new SqlParameter("@sCode",SSModel.sCode),
                new SqlParameter("@AdminNo",SSModel.AdminNo),
                new SqlParameter("@SName",SSModel.SName),
                new SqlParameter("@CSession",SSModel.Current_Session)
            };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "GetStudentDetails", sp);
            return ds;

        }
        public DataSet getFeeheads()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FHName,FHType,FHID from Feeheads where IsDeleted=0");
            return ds;
        }
        public DataSet getFHType(Feedue fd)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@FHID",fd.FHID),
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FHName,FHType,FHID from Feeheads where FHID=@FHID", sp);
            return ds;
        }
        public DataSet getSessionMonths()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select Smid,MonthName,MonthNo,ShortName  from SessionMonths");

            return ds;
        }
        public SqlDataReader GetFSAmount(Feedue fd)
        {

            SqlParameter[] sp =
            {
                new SqlParameter("@Scode",fd.StudentID),
                new SqlParameter("@FHID",fd.FHID),
                new SqlParameter("@Csession",fd.CSession)
            };

            SqlDataReader Dr = SqlHelper.ExecuteReader(SqlHelper.Connect, CommandType.StoredProcedure, "getFeeheadAmount", sp);
            Dr.Read();
            return Dr;
        }
        public SqlDataReader getFSAmountByCID(Feedue fd)
        {

            SqlParameter[] sp =
            {
                new SqlParameter("@Classid",fd.CID),
                new SqlParameter("@FHID",fd.FHID),
                new SqlParameter("@Csession",fd.CSession)
            };
            SqlDataReader Dr = SqlHelper.ExecuteReader(SqlHelper.Connect, CommandType.Text, "select Amount from FeeStructure where FHIDFK=@FHID and CIDFK= @Classid and IsDeleted=0 ", sp);
            Dr.Read();
            return Dr;
        }
    }

    public class SFeeDue
    {
        public DataSet studentInfobyID(Feedue fD)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@CSession",fD.CSession),
                new SqlParameter("@StudentID",fD.StudentID),
                new SqlParameter("@FHID",fD.FHID),
                new SqlParameter("@check",fD.Check)
            };

            DataSet dsStudents = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "getSStudentByDetails", sp);
            return dsStudents;

        }
        public DataSet studentInfobyCID(Feedue fD)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@CSession",fD.CSession),
                new SqlParameter("@CID",fD.CID),
                new SqlParameter("@SecID",fD.SecID),
                new SqlParameter("@FHID",fD.FHID),
                new SqlParameter("@check",fD.Check)

            };

            DataSet dsStudents = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "getSStudentByClass", sp);
            return dsStudents;

        }
        public string feeDueInduviual(Feedue fd)
        {

            try
            {
                SqlParameter[] var =
                               {
                        new SqlParameter("@ClassIDFK",fd.CID),
                        new SqlParameter("@SectionIDFK",fd.SecID),
                        new SqlParameter("@StudentIDFK",fd.StudentID),
                        new SqlParameter("@StudentInfoIDFk",fd.StudentInfoID),
                        new SqlParameter("@FHID",fd.FHID),
                        new SqlParameter("@DID",fd.DID),
                        new SqlParameter("@Current_Session",fd.CSession),
                        new SqlParameter("@FeeMonth",fd.FeeMonth),
                        new SqlParameter("@FYear",fd.FYear),
                        new SqlParameter("@SystemMonth",fd.SystemMonth),
                        new SqlParameter("@SystemYear",fd.SystemYear),
                        new SqlParameter("@FeeRate",fd.FeeRate),
                        new SqlParameter("@Rebate",fd.Rebate),
                        new SqlParameter("@UserName",fd.UserName),
                        new SqlParameter("@IsApplicable",fd.IsApplicable),
                        new SqlParameter("@Remarks",fd.Remarks),
                        new SqlParameter("@FeeHeadName",fd.FeeHeadName),
                        new SqlParameter("@TType",fd.TType),
                        new SqlParameter("@IsPaid",Convert.ToInt16(0)),
                        new SqlParameter("FHType",fd.FHType),
                        new SqlParameter("@DueDate",Convert.ToDateTime(fd.DueDate)),
                        new SqlParameter("@Billdate",Convert.ToDateTime(fd.BillDate)),
                        new SqlParameter("@FSID",fd.FSID),
                };

                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, "AddStudentFeeHeads", var);

                if (returnValue > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }



        }
        public string rateByStopId(long StopID)
        {
            try
            {
                SqlParameter[] sp =
           {
                new SqlParameter("@busStopId",StopID)
            };

                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select BusRate from BusStops where BusStopID=@busStopId", sp);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    decimal BRate = Convert.ToDecimal(dr["BusRate"]);
                    return BRate.ToString(); ;

                }
                else
                {
                    return "-1";
                }

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
        public DataSet classes(Feedue classfee)
        {
            try
            {

                SqlParameter[] sp =
                {
                    new SqlParameter("@CSession",classfee.CSession)
                };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select ClassId,ClassName from Classes where Current_Session=@CSession", sp);
                return ds;


            }
            catch (Exception ex)
            {

                throw new ExecutionEngineException();
            }
        }
        public DataSet Sections(Feedue fee)
        {
            try
            {

                SqlParameter[] sp =
                {
                    new SqlParameter("@cid",fee.CID)

                };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select SectionID, SectionName from Sections where ClassId =@cid ", sp);

                return ds;

            }
            catch (Exception ex)
            {

                throw new ExecutionEngineException();
            }
        }
        public DataSet gStudent(Feedue gs)
        {
            try
            {

                SqlParameter[] sp =
                {
                    new SqlParameter("@cid",gs.CID),
                    new SqlParameter("@secid",gs.SecID)

                };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select Students.StudentName, Students.StudentID from StudentInfo inner join Students on Students.StudentID = StudentInfo.StudentId where StudentInfo.ClassID = @cid and StudentInfo.SectionID = @secid ", sp);

                return ds;

            }
            catch (Exception ex)
            {

                throw new ExecutionEngineException();
            }
        }
        public DataSet getCSName(long Secid)
        {
            SqlParameter[] sp =
     {
                new SqlParameter("@SecID",Secid)
            };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select SectionName,ClassName from Sections where SectionID=@SecID", sp);
            return ds;
        }


    }
    // BLL class for Fee Advance
    public class FeeAdvance
    {
        public DataSet GetStudentFeeAdvance(FeeAdvanceModel FDM)
        {

            SqlParameter[] sp =
            {
                new SqlParameter("@UID",FDM.SIDFK)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FAAmount from FeeAdvance where SIDFK=@UID", sp);

            return ds;
        }
        public int addSectionAdvance(FeeAdvanceModel FDM)
        {

            SqlParameter[] sp =
            {                   new SqlParameter("@SIDFK",FDM.SIDFK),
                                new SqlParameter("@AdminNo",FDM.AdmissionNo),
                                new SqlParameter("@Scode",FDM.Scode),
                                new SqlParameter("@Date",FDM.FADate),
                                new SqlParameter("@FeeAdvAmt",FDM.FAamount),
                                new SqlParameter("@Current_session",FDM.CSession),
                                new SqlParameter("@UserName",FDM.UserName),
                                new SqlParameter("@ClassId",FDM.CID),
                                new SqlParameter("@SecID",FDM.SecID),
                                new SqlParameter("@FeeAdvance",FDM.FeeAdvance),
                                new SqlParameter("@SectionAdvance",FDM.SectionAdvance),
                                new SqlParameter("@Check",FDM.Check),
                                new SqlParameter("@Remarks",FDM.Remarks),
                                new SqlParameter("@updatedBy",FDM.UpdatedBy),
                                new SqlParameter("@updatedOn",FDM.UpdatedOn)

            };
            int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "AddAdvance", sp);

            return returnValue;
        }
        public DataSet studentInfoByAdmin(FeeAdvanceModel FDM)
        {

            SqlParameter[] sp =
           {
                new SqlParameter("@UID",FDM.SIDFK),
                new SqlParameter("@Csession",FDM.CSession)
            };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select Students.StudentId,StudentName,Students.AdmissionNo,rollno,classes.ClassId,classes.classname,Sections.SectionID,SectionName from Students inner join StudentInfo on Students.StudentID=StudentInfo.StudentId inner join Classes on Classes.ClassId=StudentInfo.ClassID inner join Sections on Sections.SectionID=StudentInfo.SectionID where StudentInfo.StudentId=@UID and StudentInfo.Current_Session=@Csession", sp);
            return ds;
        }
        public DataSet updateByAdminNo(long UID)
        {

            SqlParameter[] sp =
     {
            new SqlParameter("@UID",UID)
        };
            DataSet rds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select distinct(SectionDiscount),AdminNoFK from FeeAdvance where SIDFK=@UID", sp);
            return rds;
        }
    }
    // BLL class for Fee Discount
    public class FeeDiscount
    {
        public DataSet GetStudentDiscount(FeeDiscountModel FDM)
        {

            SqlParameter[] sp =
            {
                new SqlParameter("@UID",FDM.Scode)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select isnull(sum(FDAmount),0) as amount from FeeDiscount where SIDFK=@UID", sp);

            return ds;
        }
        public int addSectionAdvance(FeeDiscountModel FDM)
        {

            SqlParameter[] sp =
            {                   new SqlParameter("@SIDFK",FDM.SIDFK),
                                new SqlParameter("@AdminNo",FDM.AdmissionNo),
                                new SqlParameter("@Scode",FDM.Scode),
                                new SqlParameter("@Date",FDM.FADate),
                                new SqlParameter("@FeeAdvAmt",FDM.FAamount),
                                new SqlParameter("@Current_session",FDM.CSession),
                                new SqlParameter("@UserName",FDM.UserName),
                                new SqlParameter("@ClassId",FDM.CID),
                                new SqlParameter("@SecID",FDM.SecID),
                                new SqlParameter("@FeeAdvance",FDM.FeeAdvance),
                                new SqlParameter("@SectionAdvance",FDM.SectionAdvance),
                                new SqlParameter("@Check",FDM.Check),
                                new SqlParameter("@Remarks",FDM.Remarks),
                                new SqlParameter("@updatedBy",FDM.UpdatedBy),
                                new SqlParameter("@updatedOn",FDM.UpdatedOn)

            };
            int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "AddDsicount", sp);

            return returnValue;
        }
        public DataSet studentInfoByUId(FeeDiscountModel FDM)
        {

            SqlParameter[] sp =
           {
                new SqlParameter("@Uid",FDM.AdmissionNo),
                new SqlParameter("@Csession",FDM.CSession)
            };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select Students.StudentId,StudentName,Students.AdmissionNo,rollno,classes.ClassId,classes.classname,Sections.SectionID,SectionName from Students inner join StudentInfo on Students.StudentID=StudentInfo.StudentId inner join Classes on Classes.ClassId=StudentInfo.ClassID inner join Sections on Sections.SectionID=StudentInfo.SectionID where StudentInfo.StudentId=@Uid and StudentInfo.Current_Session=@Csession", sp);
            return ds;
        }
        public DataSet updateByUIDNo(long UId)
        {

            SqlParameter[] sp =
     {
            new SqlParameter("@UID",UId)
        };
            DataSet rds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select distinct(SectionDiscount),AdminNoFK from FeeDiscount where SIDFK=@UID", sp);
            return rds;
        }
    }
    // Pay Fee Data Access
    public class PayFeeBLL
    {
        public DataSet monthListStatusByUID(long UID)
        {
            SqlParameter[] sp =
            {
              new SqlParameter("@Uid",UID)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select distinct StudentFeeHeadList.FeeMonth, SessionMonths.MonthName,SessionMonths.MonthNo, SessionMonths.SMID from StudentFeeHeadList inner join SessionMonths on SessionMonths.MonthName = StudentFeeHeadList.FeeMonth where StudentFeeHeadList.StudentIDFK = @Uid and StudentFeeHeadList.IsPaid in (0, 2) order by SessionMonths.SMID", sp);
            return ds;
        }
        public DataSet getFeeOnMonths(PayFeeModel pf)
        {
            long x = pf.UID;
            string n = pf.MonthName;
            string cs = pf.Current_Session;
            SqlParameter[] sp =
            {
                new SqlParameter("@UID",Convert.ToInt64(pf.UID)),
                new SqlParameter("@MName",pf.MonthName),
                new SqlParameter("@CSession",pf.Current_Session)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "getFeeOnMonths", sp);
            return ds;
        }
        public string payReceipt(PayFeeModel payFee, DataTable dt, DataRow drr)
        {
            int retuenValue = 0;
            string msg = "";

            try
            {

                HttpContext.Current.Session["Receipt"] = drr["ReceiptNo"];



                foreach (DataRow dr in dt.Rows)
                {

                    SqlParameter[] sp =
                    {
                     new SqlParameter("@LIDFK",payFee.LedgerID),
                     new SqlParameter("@subAccountID",payFee.SubAccountID),
                     new SqlParameter("@receiptDate",payFee.ReceiptDate),
                     new SqlParameter("@cashin",Convert.ToDecimal(dr["Paid"])),
                     new SqlParameter("@MOAdj",payFee.MethodOfAdjustment),
                     new SqlParameter("@FIID",Convert.ToInt64(drr["FIID"])),
                     new SqlParameter("@UserName",payFee.UserName),
                     new SqlParameter("@FeeReceiptYear",payFee.SystemYear),
                     new SqlParameter("@FeeReceiptMonth",payFee.SystemMonth),
                     new SqlParameter("@DidFK",payFee.DID),
                     new SqlParameter("@SIDFK",payFee.UID),
                     new SqlParameter("@FYear",payFee.FYear),
                     new SqlParameter("@FRID",Convert.ToInt64(drr["FRID"])),
                     new SqlParameter("@FHName",dr["FeeHeadName"].ToString()),
                     new SqlParameter("@FHIDFK",Convert.ToInt64(dr["FHID"])),
                     new SqlParameter("@FeeDISC",payFee.FeeDiscount),
                     new SqlParameter("@SFHLID",Convert.ToInt64(dr["SFHLID"])),
                     new SqlParameter("@receiptNo",Convert.ToInt64(drr["ReceiptNo"])),
                     new SqlParameter("@Advance",dr["FeeAdvance"].ToString()),
                     new SqlParameter("@IsAdv",payFee.IsAdv),
                     new SqlParameter("@Pyable",payFee.TotalAmount),
                     new SqlParameter("@Remarks",dr["Remarks"].ToString())
                    };
                    retuenValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "addReceiptItems", sp);
                    if (retuenValue > 0)
                    {
                        msg = "-2";
                    }
                    else
                    {
                        msg = "-1";
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public string PayFee(PayFeeModel payFee, DataTable dt)
        {
            try
            {
                SqlParameter[] sp =
                {
                new SqlParameter("@LIDFK",payFee.LedgerID),
                 new SqlParameter("@SIDFK",payFee.UID),
                 new SqlParameter("@TAmount",payFee.TotalAmount),
                 new SqlParameter("@PAmount",payFee.AmountPaid),
                 new SqlParameter("@Balance",payFee.Balance),
                 new SqlParameter("@Rebate",payFee.Rebate),
                 new SqlParameter("@FYear",payFee.FYear),
                 new SqlParameter("@SystemMonth",payFee.SystemMonth),
                 new SqlParameter("@FeeMonth",payFee.FeeMonth),
                 new SqlParameter("@CSession",payFee.Current_Session),
                 new SqlParameter("@SystemYear",payFee.SystemYear),
                 new SqlParameter("@UserName",payFee.UserName),
                 new SqlParameter("@Date",payFee.ChequeDate),
                 new SqlParameter("@DidFK",payFee.DID),
                 new SqlParameter("@ClassID",payFee.ClassID),
                 new SqlParameter("@SectionID",payFee.SectionID),
                 new SqlParameter("@PreviousBal",payFee.PreviousBalance),
                 new SqlParameter("@Remarks",payFee.Remarks),
                 new SqlParameter("@subAccountID",payFee.SubAccountID),
                 new SqlParameter("@receiptDate",payFee.ReceiptDate),
                 new SqlParameter("@cashin",payFee.Cashin),
                 new SqlParameter("@MOAdj",payFee.MethodOfAdjustment),
                 new SqlParameter("@ReceiptMode",payFee.ReceiptMode),
                 new SqlParameter("@chequeNo",payFee.ChequeNo),
                 new SqlParameter("@bank",payFee.Bank),
                 new SqlParameter("@receiptDeleted",0),
                 new SqlParameter("@receiptNo",payFee.ReceiptNo),
                 new SqlParameter("@FHName",payFee.FeeheadNAme),
                 new SqlParameter("@FeeDISC",payFee.FeeDiscount),
                 new SqlParameter("@FDIDFK",payFee.SFHLID),
                 new SqlParameter("@FHIDFK",payFee.FHID),
                 new SqlParameter("@Advance",payFee.FeeAdvance),
                 new SqlParameter("@TotalAdvance",payFee.TotalAdvance)
            };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "PayNow", sp);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow drr = ds.Tables[0].Rows[0];

                    string returnMessage = payReceipt(payFee, dt, drr);

                    return returnMessage;
                }
                else
                {
                    return "-3";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
    }
    // Receipt Data Access
    public class Receipt
    {
        public DataSet generateReceipt(long ReceiptNo, long UID, long DID)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@receiptNo",ReceiptNo),
                new SqlParameter("@UID",UID),
                new SqlParameter("@DIDFK",DID)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FeeReceiptItems.FeeReceiptMonth,FeeReceiptItems.Cashin as rate,FeeReceiptItems.FeeHeadName,FeeReceiptItems.FeeReceiptIDFK,FeeReceiptItems.Remarks,FeeReceipt.Cashin as tpotalcash,FeeIncome.TotalAmount,Students.FathersName, Students.StudentID,FeeIncome.AmountPaid, FeeIncome.Balance, FeeIncome.Classid, FeeIncome.Current_Session, Convert(varchar(16), FeeIncome.Date, 103) aS DATE, FeeIncome.LedgerIDFK, FeeIncome.PreviousBalance, FeeIncome.Sectionid, FeeIncome.StudentIDFK, FeeIncome.TotalRebate, FeeIncome.Username, Classes.ClassName, Sections.SectionName, Students.StudentName, StudentInfo.RollNo,StudentFeeHeadList.FeeRate,StudentFeeHeadList.FHIDFK,StudentInfo.AdmissionNo from FeeReceiptItems inner join FeeReceipt on FeeReceipt.RecptNo = FeeReceiptItems.FeeReceiptIDFK inner join FeeIncome on FeeIncome.FIID = FeeReceiptItems.FIIDFK inner join StudentInfo on StudentInfo.StudentId = FeeIncome.StudentIDFK inner join Classes on Classes.ClassId = StudentInfo.Classid inner join Sections on Sections.SectionID = StudentInfo.Sectionid inner join Students on Students.StudentID = StudentInfo.StudentID inner join StudentFeeHeadList on StudentFeeHeadList.SFHLID = FeeReceiptItems.FDueIDFK inner join SessionMonths on SessionMonths.MonthName = StudentFeeHeadList.FeeMonth where FeeReceiptItems.FeeReceiptIDFK = @receiptNo and FeeReceipt.DIDFK=@DIDFK  and StudentInfoID = (select max(StudentInfoID) from StudentInfo where StudentId = @UID) and FeeReceiptItems.IsDeleted = 0 order by StudentFeeHeadList.FeeHeadName,SessionMonths.SMID", sp);
            return ds;

        }
    }
    // Ledger
    public class Ledger
    {
        public DataSet studentLedger(StudentLaderModel stdLadger)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@fromDate",stdLadger.FromDate),
                new SqlParameter("@toDate",stdLadger.ToDate),
                new SqlParameter("@UID",stdLadger.UID)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "studentLedger", sp);
            return ds;
        }
    }

    public class EditFee
    {
        public DataSet getFeeFromSFHL(long FeeMOnth, long UID)
        {

            SqlParameter[] sp =
            {
                new SqlParameter("@FHID",FeeMOnth),
                new SqlParameter("@UID",UID)
            };
            return SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FeeRate,FYear,Rebate,SystemYear,FeeMonth,IsPaid,SFHLID  from StudentFeeHeadList where FHIDFK=@FHID and StudentIDFK=@UID ", sp);





        }
        public DataSet getFeeByMonths(long FHID, string FH, long UID)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@FHID",FHID),
                new SqlParameter("@FM",FH),
                new SqlParameter("@UID",UID)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FeeRate,FYear,Rebate,SystemYear,FeeMonth,IsPaid,SFHLID  from StudentFeeHeadList where FHIDFK=@FHID and FeeMonth=@FM and StudentIDFK=@UID", sp);
            return ds;
        }

        public string UpdateFeeRateNew(decimal FeeRate, decimal Rebate, decimal SFHID)
        {
            try
            {
                SqlParameter[] var =
           {
                            new SqlParameter("@FeeRate",FeeRate),
                            new SqlParameter("@Rebate",Rebate),
                            new SqlParameter("@SFHID",SFHID)

                        };
                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "UpdateFeeRateNew", var);
                if (returnValue > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }

        }

    }
    public class EditReceiptBLL
    {
        public DataSet getAllReceipt(EditReceiptModel eReceipt)
        {
            SqlParameter[] sp =
          {

                new SqlParameter("@UID",eReceipt.UID)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FRID,RecptNo,FIIDFK,DIDFK,ReceiptDate,Cashin from FeeReceipt where StudentID=@UID and ReceiptDeleted=0  order by ReceiptDate ", sp);
            return ds;
        }
        public DataSet getFRByDate(EditReceiptModel EditRFM)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@fromDate",EditRFM.FromDate),
                new SqlParameter("@toDate",EditRFM.ToDate),
                new SqlParameter("@UID",EditRFM.UID)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select RecptNo,ReceiptDate,Cashin,DIDFK from FeeReceipt where ReceiptDate between @fromDate and @toDate and StudentID=@UID order by ReceiptDate", sp);
            return ds;
        }
        public DataSet LoadReceiptDetails(long ReceiptNo, long DID, long UID)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@receiptNo",ReceiptNo),
                new SqlParameter("@UID",UID),
                new SqlParameter("@DID",DID)
            };
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FeeReceiptItems.FeeReceiptMonth,FeeReceiptItems.Cashin as RDCashin,FeeReceiptItems.FeeHeadName,FeeReceiptItems.FeeReceiptIDFK,FeeReceipt.RecptNo,FeeReceiptItems.Remarks,FeeReceipt.Cashin as totalcash,FeeIncome.TotalAmount, FeeIncome.AmountPaid, FeeIncome.Balance, FeeIncome.Classid, FeeIncome.Current_Session, Convert(varchar(16), FeeIncome.Date, 103) aS DATE, FeeIncome.LedgerIDFK, FeeIncome.PreviousBalance, FeeIncome.Sectionid, FeeIncome.StudentIDFK, FeeIncome.TotalRebate, FeeIncome.Username, Classes.ClassName, Sections.SectionName, Students.StudentName,FeeReceiptItems.Advance, StudentInfo.RollNo,StudentFeeHeadList.FeeRate,StudentFeeHeadList.FeeAdvance,StudentFeeHeadList.FeeDiscount,FeeIncome.Balance,StudentFeeHeadList.SFHLID,StudentFeeHeadList.Rebate,StudentFeeHeadList.FeeMonth,StudentFeeHeadList.FHIDFK,FeeReceipt.RecptNo,StudentFeeHeadList.FeeAdvance as advance, FeeReceiptItems.DIDFK,FeeReceipt.DIDFK as did  from FeeReceiptItems inner join FeeReceipt on FeeReceipt.RecptNo = FeeReceiptItems.FeeReceiptIDFK inner join FeeIncome on FeeIncome.FIID = FeeReceiptItems.FIIDFK inner join StudentInfo on StudentInfo.StudentId = FeeIncome.StudentIDFK inner join Classes on Classes.ClassId = StudentInfo.Classid inner join Sections on Sections.SectionID = StudentInfo.Sectionid inner join Students on Students.StudentID = StudentInfo.StudentID inner join StudentFeeHeadList on StudentFeeHeadList.SFHLID = FeeReceiptItems.FDueIDFK where FeeReceiptItems.FeeReceiptIDFK = @receiptNo and StudentInfoID = (select max(StudentInfoID) from StudentInfo where StudentId = @UID)  and FeeReceiptItems.IsDeleted=0 and FeeReceipt.DIDFK=@DID", sp);
            return ds;
        }
        public string DeleteReceipt(long ReceiptNo, long DID, long UID, long FIID, long FRID)
        {
            try
            {
                SqlParameter[] sp =
          {
                new SqlParameter("@receiptNo",ReceiptNo),
                new SqlParameter("@UID",UID),
                new SqlParameter("@DID",DID),
                new SqlParameter("@FIID",FIID),
                new SqlParameter("@FRID",FRID)
            };
                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "DeleteReceipt", sp);
                if (returnValue > 1)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string EditFeeReceipt(EditReceiptModel ERM)
        {
            try
            {
                SqlParameter[] sp =
           {
                new SqlParameter("@SFHLID",ERM.SFHLID),
                new SqlParameter("@ReceiptNo",ERM.ReceipitNo),
                new SqlParameter("@FeeRate",ERM.FeeRate),
                new SqlParameter("@FeeAdvance",ERM.FeeAdvance),
                new SqlParameter("@Balance",ERM.Balance),
                new SqlParameter("@Ispaid",ERM.IsPaid),
                new SqlParameter("@FHID",ERM.FHID),
                new SqlParameter("@TotalAmount",ERM.TotalAmount),
                new SqlParameter("@Cashin",ERM.Cashin),
                new SqlParameter("@UserName",ERM.UserName),
                new SqlParameter("@CDate",ERM.CurrentDate),
                new SqlParameter("@UnPaid",ERM.UnPaid),
                new SqlParameter("@CSession",ERM.CSession),
                new SqlParameter("@StudentsIDFK",ERM.SIDFK),
                new SqlParameter("@Classid",ERM.Classid),
                new SqlParameter("@secID",ERM.SecID),


            };

                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "UpdateFeeReceipt", sp);
                if (returnValue > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }


        }
    }
    public class RebateBll
    {

        public DataSet getAllRebate()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select FRIID,FrName,FRRate,FRDate,FRUsername from FeeRebateType");
            return ds;
        }
        public string FeeRebate(RebateModel FeeRebate)
        {
            try
            {
                SqlParameter[] sp =
                {
                new SqlParameter("@RName",FeeRebate.RName),
                new SqlParameter("@Rate",FeeRebate.RRate),
                new SqlParameter("@RDate",FeeRebate.RDate),
                new SqlParameter("@UserName",FeeRebate.UserName),
                new SqlParameter("@isprimay",FeeRebate.IsPrimary),
                new SqlParameter("@UpdatedBy",FeeRebate.UpdatedBy),
                new SqlParameter("@UpdatedOn",FeeRebate.UpdatedOn),
                new SqlParameter("@check",FeeRebate.Check),
                new SqlParameter("@FRIID",FeeRebate.RID)

                };

                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.StoredProcedure, "IUDFeeRebate", sp);
                if (returnValue > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
    public class HalfAssignBusRate
    {
        public DataSet LoadCLases(HalfAssignBusRateModel Model)
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "SELECT * FROM CLASSES  WHERE  Current_Session = '" + Model.CSession + "'");
            return ds;
        }

        public DataSet LoadFeeHeads()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "SELECT * FROM Feeheads where isDeleted=0  and FHID=2");
            return ds;
        }
        public DataSet LoadSection(HalfAssignBusRateModel Model)
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "SELECT * FROM Sections where ClassID = " + Model.ClassID + " and Current_Session =  '" + Model.CSession + "'");
            return ds;
        }
        //public DataSet LoadFeeCategory()
        //{
        //    DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select * from FeeCategory where IsDeleted = 0");
        //    return ds;
        //}
        public DataSet BindGrid(HalfAssignBusRateModel Model)
        {
            if (Model.Check == 1)
            {
                SqlParameter[] var =
             {
                new SqlParameter("@FHIDFK",Model.FHIDFK),
                new SqlParameter("@Month",Model.Month),
                new SqlParameter("@CSession",Model.CSession),
                new SqlParameter("@SID",Model.SId),
            };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text,
           "Select Students.*,studentfeeheadlist.FHIDFK, studentfeeheadlist.FeeMonth, studentfeeheadlist.FeeRate  from Students inner join studentfeeheadlist on studentfeeheadlist.StudentIDFK = Students.StudentID  where studentfeeheadlist.FHIDFK =@FHIDFK and studentfeeheadlist.IsPaid = 0 and studentfeeheadlist.FeeMonth =@Month and studentfeeheadlist.current_session=@CSession and Students.StudentID=@SID", var);
                return ds;
            }
            else
            {
                SqlParameter[] var =
            {
                new SqlParameter("@FHIDFK",Model.FHIDFK),
                new SqlParameter("@ClassID",Model.ClassID),
                new SqlParameter("@Section",Model.Section),
                new SqlParameter("@Month",Model.Month),
                new SqlParameter("@CSession",Model.CSession),
            };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text,
           "Select Students.*,studentfeeheadlist.FHIDFK, studentfeeheadlist.FeeMonth, studentfeeheadlist.FeeRate  from Students inner join studentfeeheadlist on studentfeeheadlist.StudentIDFK = Students.StudentID  where studentfeeheadlist.FHIDFK =@FHIDFK and studentfeeheadlist.IsPaid = 0 and studentfeeheadlist.ClassIDFK =@ClassID and studentfeeheadlist.SectionIDFK =@Section and studentfeeheadlist.FeeMonth =@Month and studentfeeheadlist.current_session=@CSession", var);
                return ds;
            }
        }

        public string updateBussRate(HalfAssignBusRateModel UModel)
        {
            try
            {
                if (UModel.Check == 1)
                {
                    SqlParameter[] var =
                {
                    new SqlParameter("@ActRate", UModel.ActRate),
                    new SqlParameter("@FHIDFK", UModel.FHIDFK),
                    new SqlParameter("@Month", UModel.Month),
                    new SqlParameter("@CSession", UModel.CSession),
                    new SqlParameter("@SID", UModel.SId)
                };

                    int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "UPDATE studentfeeheadlist set FeeRate =@ActRate where studentfeeheadlist.FHIDFK =@FHIDFK and studentfeeheadlist.IsPaid = 0  and studentfeeheadlist.FeeMonth =@Month and studentfeeheadlist.current_session=@CSession and StudentFeeHeadList.StudentIDFK=@SID", var);
                    if (returnValue > 0)
                    {
                        return "1";
                    }
                    else
                    {
                        return "0";
                    }
                }
                else
                {
                    SqlParameter[] var =
                    {
                    new SqlParameter("@ActRate", UModel.ActRate),
                    new SqlParameter("@FHIDFK", UModel.FHIDFK),
                    new SqlParameter("@CID", UModel.ClassID),
                    new SqlParameter("@SecID", UModel.Section),
                    new SqlParameter("@Month", UModel.Month),
                    new SqlParameter("@CSession", UModel.CSession),
                    new SqlParameter("@SID", UModel.SId)
                    };
                    int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "UPDATE studentfeeheadlist set FeeRate =@ActRate where studentfeeheadlist.FHIDFK =@FHIDFK and studentfeeheadlist.IsPaid = 0 and studentfeeheadlist.ClassIDFK = @CID and studentfeeheadlist.SectionIDFK =@SecID and studentfeeheadlist.FeeMonth =@Month and studentfeeheadlist.current_session=@CSession and Studentidfk=@SID", var);

                    if (returnValue > 0)
                    {
                        return "1";
                    }
                    else
                    {
                        return "0";
                    }

                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

    }
    public class CashCollection
    {
        public DataSet GetUsers()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select distinct UserName from FeeReceipt");
            return ds;
        }

        public DataSet getFeeHeads()
        {
            DataSet dsFeeHead = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select * from feeheads where FHType!=3 and IsDeleted=0");
            return dsFeeHead;
        }

        public DataSet getReceiptDetails(CashCollectionMOdel model)
        {
            SqlParameter[] var =
           {
                new SqlParameter ("@From",model.DateFrom),
                new SqlParameter ("@To",model.DateTo ),
                new SqlParameter ("@CurrentSession",model.CSession),
                new SqlParameter ("@DIDFK",model.DIDFK),
                new SqlParameter ("@UserName",model.UserName),
                new SqlParameter ("@Check",model.Check)
            };

            DataSet dsFeeReceipt = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "CashCollection", var);
            return dsFeeReceipt;
        }

        public DataSet getReceiptItems(CashCollectionMOdel mm)
        {
            SqlParameter[] var =
            {
                new SqlParameter ("@FHID",mm.FHIDFK),
                new SqlParameter ("@FeeReceiptID",mm.ReceiptNo)
            };

            DataSet dsFee = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select  Sum (Cashin) as CashIn  from FeeReceiptItems where FeeHeadIDFK =@FHID and FeeReceiptIDFK =@FeeReceiptID ", var);
            return dsFee;
        }

        public DataSet getFeeIncome(long VoucherNo)
        {
            DataSet dss = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "Select  FeeRebate,FeeReceipt.GeneralIncomeID,CurrentBalance,previousbalance,FeeReceipt.RecptNo,TotalAmountwithPB,rollno,Students.StudentId,Students.studentname,Students.FathersName,FeeIncome.classname,sectionname,current_session,(select convert(varchar,date,106))as date,Totalamount,amountpaid,FeeIncome.username from FeeIncome  inner join Students on Students.StudentID=FeeIncome.StudentID  inner join FeeReceipt on FeeReceipt.GeneralIncomeID=FeeIncome.GID  where FeeReceipt.FeeReceiptID=" + VoucherNo + "");
            return dss;
        }

    }
    public class DayBook
    {
        public DataSet GetUsers()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select distinct UserName from FeeReceipt");
            return ds;
        }

        public DataSet getFeeHeads()
        {
            DataSet dsFeeHead = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select * from feeheads where FHType!=3 and IsDeleted=0");
            return dsFeeHead;
        }

        public DataSet getReceiptDetails(CashCollectionMOdel model)
        {
            SqlParameter[] var =
           {
                new SqlParameter ("@From",model.DateFrom),
                new SqlParameter ("@To",model.DateTo ),
                new SqlParameter ("@CurrentSession",model.CSession),
                new SqlParameter ("@DIDFK",model.DIDFK),
                new SqlParameter ("@UserName",model.UserName),
                new SqlParameter ("@Check",model.Check)
            };

            DataSet dsFeeReceipt = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.StoredProcedure, "dayBook", var);
            return dsFeeReceipt;
        }

        public DataSet getReceiptItems(CashCollectionMOdel mm)
        {
            SqlParameter[] var =
            {
                new SqlParameter ("@FHID",mm.FHIDFK),
                new SqlParameter ("@FeeReceiptID",mm.ReceiptNo)
            };

            DataSet dsFee = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select  isnull(Sum (Cashin),0)  as CashIn  from FeeReceiptItems where FeeHeadIDFK =@FHID and FeeReceiptIDFK =@FeeReceiptID and DIDFK=@DIDFK and isdeleted=0  ", var);
            return dsFee;
        }

        public DataSet getFeeIncome(long VoucherNo)
        {
            DataSet dss = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "Select  FeeRebate,FeeReceipt.GeneralIncomeID,CurrentBalance,previousbalance,FeeReceipt.RecptNo,TotalAmountwithPB,rollno,Students.StudentId,Students.studentname,Students.FathersName,FeeIncome.classname,sectionname,current_session,(select convert(varchar,date,106))as date,Totalamount,amountpaid,FeeIncome.username from FeeIncome  inner join Students on Students.StudentID=FeeIncome.StudentID  inner join FeeReceipt on FeeReceipt.GeneralIncomeID=FeeIncome.GID  where FeeReceipt.FeeReceiptID=" + VoucherNo + "");
            return dss;
        }

    }
    public class MagangeTransFee
    {
        public DataSet allTransFee(long UID)
        {

            SqlParameter[] sp =
           {
                new SqlParameter("@UID",UID)


                };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select * from  StudentFeeHeadList where FHIDFK=2 and StudentIDFK=@UID order by SFHLID", sp);
            return ds;

        }
        public string applicable(long SFHLID, bool active)
        {
            try
            {
                SqlParameter[] sp =
                              {
                new SqlParameter("@SFHLID",SFHLID),
                new SqlParameter("@APP",active)
                };

                int rv = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "update StudentFeeHeadList set IsApplicable = @APP where SFHLID = @SFHLID and IsPaid in (0, 2)", sp);
                if (rv > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public DataSet getAllBUsses(string cSession)
        {
            SqlParameter[] sp =
                             {
                new SqlParameter("@cSession",cSession)
                };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select * from Transport where Current_Session = @cSession", sp);
            return ds;
        }
        public DataSet getAllBUssStops(long RouteID)
        {
            SqlParameter[] sp =
                             {
                new SqlParameter("@RouteID",RouteID)
                };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select BusStopID, BusStop from BusStops where  RouteID=@RouteID", sp);
            return ds;
        }

        public DataSet getAllBUssStops(long BussID, long RouteID)
        {
            SqlParameter[] sp =
                             {
                new SqlParameter("@BussID",BussID),
                new SqlParameter("@RouteID",RouteID)
                };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select BusRate from BusStops where BusStopID=@BussID and RouteID=@RouteID ", sp);
            return ds;
        }

        public string UpdateBuss(long BussID, long RouteID, long UID, string CSession)
        {
            try
            {
                SqlParameter[] sp =
                                            {
                new SqlParameter("@BussID",BussID),
                new SqlParameter("@RouteID",RouteID),
                new SqlParameter("@UID",UID),
                new SqlParameter("@CSession",CSession)
                };

                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "update StudentInfo set BusStopID=@BussID , RouteID=@RouteID where StudentId=@UID and Current_Session=@CSession", sp);
                if (returnValue > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public decimal getFeeRate(long BSID)
        {
            SqlParameter[] sp =
                                               {
                new SqlParameter("@BSID",BSID),
                };
            decimal FeeRate = Convert.ToDecimal(SqlHelper.ExecuteScalar(SqlHelper.Connect, CommandType.Text, "Select ISNULL(BusRate,0) from BusStops where BusStopID =@BSID ", sp));
            return FeeRate;
        }
        public int getcurrentMonths(int date)
        {
            SqlParameter[] sp =
                                                  {
                new SqlParameter("@date",date),
                };
            int SMID = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.Connect, CommandType.Text, "Select SMID from SessionMonths WHERE MonthNo=@date", sp));
            return SMID;
        }
        //------------------------------for Transport UPDATE MONTHS WHICH ARE UNPAID CURRENT MONTH PLUS NEXT UNPAID--------------------------------
        public DataSet getFDueDetails(long UID, string CSession, int SMID)
        {

            SqlParameter[] var =
            {
                    new SqlParameter("@StudentID", UID),
                    new SqlParameter("@Current_Session",CSession),
                    new SqlParameter("@SMID", SMID),
             };


            DataSet dsFeeMonths = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "Select SFHLID from StudentFeeHeadList inner join SessionMonths on StudentFeeHeadList.FeeMonth=SessionMonths.MonthName where StudentFeeHeadList.FHIDFK=2 and StudentFeeHeadList.IsPaid=0 and StudentFeeHeadList.StudentIDFK=@StudentID and StudentFeeHeadList.current_session=@Current_Session and SessionMonths.SMID >= @SMID", var);
            return dsFeeMonths;
        }

        public string UpdateFeerate(long SFHID, decimal FeeRate)
        {
            try
            {
                SqlParameter[] var =
            {
                new SqlParameter("@SFHID", SFHID),
                new SqlParameter("@FeeRate", FeeRate)
            };
                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.Connect, CommandType.Text, "Update StudentFeeHeadList set FeeRate=@FeeRate, Rebate = 0 where SFHLID=@SFHID and IsPaid=0", var);
                if (returnValue > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }
    public class IncomeCertificate 
    {
        public DataSet getICD(IncomeCertificateModel model)
        {
            SqlParameter[] var =
          {
                    new SqlParameter("@DateFrom", model.DateFrom),
                    new SqlParameter("@DateTo",model.DateTo),
                    new SqlParameter("@UID", model.UID),
             };


            DataSet dsFeeMonths = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select sum(FeeRate) as total from StudentFeeHeadList where BillDate between @DateFrom and @DateTo  and StudentIDFK=@UID and FHIDFK!=2", var);
            return dsFeeMonths;
        }
    }

    public class Defaulters
    {
        public DataSet getFeeHeads()
        {
            DataSet dsFeeHead = SqlHelper.ExecuteDataset(SqlHelper.Connect,CommandType.Text,"select * from Feeheads where IsDeleted=0");
            return dsFeeHead;
        }
        public DataSet getStudentDetails(DefaultersMOdel DModel)
        {
            SqlParameter[] var =
            {
                new SqlParameter("@CSession",DModel.CSession),
                new SqlParameter("@Classid",DModel.Classid),
                new SqlParameter("@Sectionid",DModel.Sectionid),
            };
            DataSet dsStudetns = SqlHelper.ExecuteDataset(SqlHelper.Connect,CommandType.Text, "select * , Studentinfo.AdmissionNo from students inner join studentinfo on students.studentid =studentinfo.studentid inner join classes on classes.classid = studentinfo.classid  inner join sections on sections.sectionid =studentinfo.sectionid  where studentinfo.current_Session =@CSession and studentinfo.ClassID =@Classid and studentinfo.SectionID =@Sectionid order by StudentInfo.AdmissionNo", var);
            return dsStudetns;
        }
        public DataSet totalAmount(DefaultersMOdel DModel)
        {

            SqlParameter[] var =
            {
                new SqlParameter ("@studentid",DModel.StudentIDFK),
                new SqlParameter("@session",DModel.CSession),
                new SqlParameter ("@FHIDFK",DModel.FHIDFK),
                new SqlParameter ("@Montid",DModel.Months),
            };
            DataSet dsDue = SqlHelper.ExecuteDataset(SqlHelper.Connect,CommandType.Text,"select (isnull(sum(FeeRate),0) - isnull(sum(Rebate),0)) as Due from StudentFeeHeadList where studentIdfk =@studentid and FHIDFK = @FHIDFK and (current_Session = @session and FeeMonth in (" + DModel.Months + ") or Current_Session < @session)", var);
            return dsDue;
        }
        public DataSet getSFHLID(string Months,long SID,long FHIDFK,string CSession)
        {
            SqlParameter[] var =
            {
                new SqlParameter ("@studentid",SID),
                new SqlParameter ("@FHIDFK",FHIDFK),
                new SqlParameter ("@CSession",CSession)
            };
            DataSet dsSfhids = SqlHelper.ExecuteDataset(SqlHelper.Connect,CommandType.Text, "select SFHLID from StudentFeeHeadList where studentIdfk = @studentid and FHIDFK = @FHIDFK and (current_Session = @CSession and FeeMonth in (" + Months + ") or Current_Session < @CSession)", var);
            return dsSfhids;
        }
        public DataSet getreceiptItems(string SFHIDs , long FHIDFK)
        {
            SqlParameter[] var =
              {
                new SqlParameter ("@FHIDFK",FHIDFK)
            };
            DataSet dsPay = SqlHelper.ExecuteDataset(SqlHelper.Connect,CommandType.Text, "select isnull(sum(cashin),0) as Pay from FeeReceiptItems where IsDeleted = 0 and FeeHeadIDFK = @FHIDFK and FDueIDFK in (" + SFHIDs + ")",var);
            return dsPay;
        }
        public DataSet classes(Feedue classfee)
        {
            try
            {

                SqlParameter[] sp =
                {
                    new SqlParameter("@CSession",classfee.CSession)
                };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select ClassId,ClassName from Classes where Current_Session=@CSession", sp);
                return ds;


            }
            catch (Exception ex)
            {

                throw new ExecutionEngineException();
            }
        }
        public DataSet Sections(Feedue fee)
        {
            try
            {

                SqlParameter[] sp =
                {
                    new SqlParameter("@cid",fee.CID)

                };
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select SectionID, SectionName from Sections where ClassId =@cid ", sp);

                return ds;

            }
            catch (Exception ex)
            {

                throw new ExecutionEngineException();
            }
        }

        public DataSet getSessionMonths()
        {
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.Connect, CommandType.Text, "select Smid,MonthName,MonthNo,ShortName  from SessionMonths");

            return ds;
        }
    }
}
