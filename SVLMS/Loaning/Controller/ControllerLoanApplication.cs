using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning;
using System.Windows.Forms;
using SVLMS.Loaning.View;
using SVLMS.Loaning.Controller;
using SVLMS.Loaning.Model;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Loaning.Controller
{
      
    class ControllerLoanApplication
    {
        TransactionLoanApplicationView view;
        ModelLoanApplication model;

        TransactionComakerFamily viewfamily;
        TransactionComakerMember viewmember;

        ModelCollateral mc = new ModelCollateral();
        ModelLoanType mlt = new ModelLoanType();
        
        public string family = "";
        public string member = "";

        public ControllerLoanApplication(ModelLoanApplication model, TransactionLoanApplicationView view)
        {
            this.model = model;
            this.view = view;
            
            view.setComakerFamily(family);
            view.setDgMembers(model.getMembers());
            view.cboLoanTypeSelectionChangedEvent(cboLoanTypeChanged);
            view.setBtnSaveEvent(BtnSaveClicked);
            view.setBtnClearEvent(BtnClearClicked);
            view.setDataGridEvent(dgClicked);
            view.setBtnComakerFamilyEvent(btnFamilyClicked);
            view.setBtnComakerMemberFamily(btnMemberClicked);
            view.setTextSearchEvent(searchPressed);
            view.setBtnComputeAmortization(BtnComputeAmortizationClicked);
            view.setCboOperationEvent(CboOperationSelectionChangedCommitted);
            view.setCboStatusEvent(CboStatusSelectionChanged);
            view.hideDataGridColumnIndex(3);
            this.RefreshFields();
            view.Show();
        }

        public void CboStatusSelectionChanged(object sender, EventArgs e)
        {
            if (view.getStatus() == "2")
            {
                view.enableApprovedAmount();
            }

            else
            {
                view.disableApprovedAmount();
            }
        }

        public void CboOperationSelectionChangedCommitted(object sender, EventArgs e)
        {
            if (view.getCboOperationIndex() == 0)
            {
                view.setDgMembers(model.getMembers());
                view.hideDataGridColumnIndex(3);
                view.searchByCreate();
            }

            else
            {
                view.setDgMembers(model.getLoanApplicationRecords());
                view.searchByUpdate();
            }
            this.RefreshFields();
        }

        public void searchPressed(object sender, EventArgs e)
        {
            if (view.getCboOperationIndex() == 0)
            {
                if (view.getSearchBy() == "Account No")
                {
                    model.accountNo = view.getTxtSearch();
                    view.setDgMembers(model.searchByAccountNo());
                }

                else if (view.getSearchBy() == "Member Name")
                {
                    model.memberName = view.getTxtSearch();
                    view.setDgMembers(model.searchByMemberName());
                }
            }

            else if (view.getCboOperationIndex() == 1)
            {
                ModelLoan ml = new ModelLoan();
                
                if (view.getSearchBy() == "Loan No")
                {
                    ml.loanNo = view.getTxtSearch();
                    view.setDgMembers(ml.SearchByLoanApplicationUpdate(1));
                }

                else if (view.getSearchBy() == "Member Name")
                {
                    ml.memberName = view.getTxtSearch();
                    view.setDgMembers(ml.SearchByLoanApplicationUpdate(2));
                }
            }
        }

        public void BtnComputeAmortizationClicked(object sender, EventArgs e)
        {
            ModelLoanRates ratesModel = new ModelLoanRates();
            AmortizationCalculator ac = new AmortizationCalculator();

            if (this.validateComputeAmortization())
            {
                //Set values to calculator
                ac.loanAmount = Convert.ToDouble(view.getComputeLoanAmount());
                ac.termsOfPayment = Convert.ToInt32(view.getComputeTermsOfPayment());
                ac.termsOfPaymentDays = ac.termsOfPayment * 30;
                ac.paymentIntervalDays = ModelUser.getIntervalInDays(view.getComputeInterval());
                ac.loanDate = view.getDateOfApplication();
                ratesModel.loanTypeID = view.getComputeLoanType();
                ratesModel.setLoanRatesValuesByLoanType();
                ac.interestRate = Convert.ToDouble(ratesModel.interestRate);
                ac.isPercentageInterest = Convert.ToInt32(ratesModel.isPercentageInterest);
                ac.capitalRate = Convert.ToDouble(ratesModel.shareRate);
                ac.isPercentageShare = Convert.ToInt32(ratesModel.isPercentageShare);

                //if (view.getSavingsAccount().Trim().Length != 0)
                //{
                //    ac.savingsRate = Convert.ToDouble(ratesModel.savingsRate);
                //    ac.isPercentageSavings = Convert.ToInt32(ratesModel.isPercentageSavings);
                //}

                string[,] amortSched = ac.getAmortizationSchedule(view.getComputeLoanAmount());
                view.setDataGridAmortization(amortSched);
                view.setLblLoanAmount(ac.loanAmount.ToString());
                //view.setlblSavings(ac.totalSavings.ToString());
                view.setLblShareCapital(ac.totalShare.ToString());
                view.setLblTotalInterest(ac.totalInterest.ToString());
                view.setLblTotalAmount(ac.paymentTotalAmount.ToString());
                view.focusTabAmortization();
            }
        }

        public void BtnClearClicked(object sender, EventArgs e)
        {
            this.RefreshFields();
        }

        public void BtnSaveClicked(object sender, EventArgs e)
        {
            if (this.validateSaveLoanApplication())
            {
                bool isContinue = true;
                if (view.getStatus() == "3" || view.getStatus() == "4")
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to reject/cancel this loan?", "Reject/Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        isContinue = true;
                    }

                    else
                    {
                        isContinue = false;
                    }
                }

                if (isContinue == true)
                {
                    model.dateOfApplication = view.getDateOfApplication();
                    model.requestedAmount = view.getRequestedAmount();
                    model.termsofPayment = view.getTermsOfPayment();
                    model.intervalPayment = view.getIntervalOfPayment();
                    model.loanTypeID = view.getApplicableLoanType();
                    model.userID = ModelUser.userID;
                    model.status = view.getStatus();
                    model.remarks = view.getRemarks();
                    model.approvedAmount = view.getApprovedAmount();
                    //model.savingsAccountNo = view.getSavingsAccount();

                    if (view.getCboOperationIndex() == 0)
                    {
                        //Insert loan application
                        model.insertLoanApplication();
                    }

                    else if (view.getCboOperationIndex() == 1)
                    {
                        //Update loan application
                        model.updateLoanApplication();
                    }

                    if (model.hasCollateral())
                    {
                        mc.collateralName = view.getCollateral();
                        mc.collateralDesc = view.getCollateralDescription();
                        mc.loanNo = view.getLoanNo();
                        if (String.IsNullOrEmpty(mc.collateralId))
                            mc.insertCollateral();
                        else
                            mc.updateCollateral();
                    }

                    else
                    {
                        if (view.getCboOperationIndex() == 1)
                            mc.deleteCollateral();
                    }

                    if (model.hasComaker())
                    {
                        model.loanNo = view.getLoanNo();
                        model.comemberID = member;
                        model.familyID = family;
                        model.blkNoAddressFamily = view.getBlkNo();
                        model.streetAddressFamily = view.getStreet();
                        model.brgyAddressFamily = view.getBrgy();
                        model.cityAddressFamily = view.getCity();
                        if (String.IsNullOrEmpty(model.comakerID))
                            model.insertComakers();
                        else
                            model.updateComakers();
                    }

                    else
                    {
                        if (view.getCboOperationIndex() == 1)
                            model.deleteComakers();
                    }

                    MessageBox.Show("Loan Application Saved!");
                    this.RefreshFields();
                }
            }
        }

        public void cboLoanTypeChanged(object sender,EventArgs e)
        {
            this.setCollateralComaker();

            //Set the tooltips
            mlt.loanId = view.getCboLoanType().Row["loanTypeID"].ToString();
            mlt.searchLoanType();
            view.setTermsTooltip("Maximum Term: " + mlt.maxTerm + " month/s");
            view.setRequestedAmountTooltip("Minimum Amount: P " + Validator.amountFormatter(mlt.minAmount) + "\nMaximum Amount: P " + Validator.amountFormatter(mlt.maxAmount));
        }


        public void dgClicked(object sender, EventArgs e)
        {
            DataGridView dg = view.getdgMembers();
            int row = dg.CurrentCell.RowIndex;
            this.RefreshFields();
            model.familyName = "";

            if (view.getCboOperationIndex() == 0)
            {
                model.accountNo = dg.Rows[row].Cells[0].Value.ToString();
                model.memberType = dg.Rows[row].Cells[3].Value.ToString();
                model.getMemberInfo();
                view.setAccountNo(model.accountNo);
                view.setMemberName(model.memberName);
                //view.setCboSavingsAccount(model.getSavingsAccount());
                view.setCboApplicableLoans(model.getCboLoanType());
                this.setCollateralComaker();
            }

            else
            {
                model.loanNo = dg.Rows[row].Cells[0].Value.ToString();
                SqlDataReader reader = model.searchLoanApplication();
                if (reader.Read())
                {
                    model.memberType = reader["memberTypeID"].ToString();
                    model.accountNo = reader["accountNo"].ToString();
                    //view.setCboSavingsAccount(model.getSavingsAccount());
                    view.setCboApplicableLoans(model.getCboLoanType());
                    
                    
                    view.setAccountNo(reader["accountNo"].ToString());
                    view.setMemberName(reader["MemberName"].ToString());
                    mc.collateralId = reader["collateralID"].ToString();
                    view.setCollateral(reader["collateralName"].ToString());
                    view.setCollateralDescription(reader["collateralDesc"].ToString());
                    view.setLoanNo(reader["loanNo"].ToString());
                    view.setDateOfApplication(reader["loanDate"].ToString());
                    view.setLoanTypeValue(reader["loanTypeID"].ToString());
                    this.setCollateralComaker();
                    view.setRequestedAmount(reader["requestedAmount"].ToString());
                    view.setTermsOfPayment(reader["termsOfPayment"].ToString());
                    view.setIntervalOfPayment(reader["paymentInterval"].ToString());
                    view.setStatus((Convert.ToInt32(reader["status"])-1).ToString());
                    view.setApprovedAmount(reader["approvedAmount"].ToString());
                    view.setRemarks(reader["remarks"].ToString());
                    //view.setSavingsAccount(reader["savingsAccountNo"].ToString());
                    view.setRequestedAmount(reader["requestedAmount"].ToString());
                    family = reader["familyComaker"].ToString();
                    view.setComakerFamily(reader["FamilyComakerName"].ToString());
                    member = reader["memberComaker"].ToString();
                    view.setComakerMember(reader["MemberComakerName"].ToString());
                    model.comakerID = reader["comakerID"].ToString();
                    view.setBlkNo(reader["blkNoAddressFamily"].ToString());
                    view.setStreet(reader["streetAddressFamily"].ToString());
                    view.setBrgy(reader["brgyAddressFamily"].ToString());
                    view.setCity(reader["cityAddressFamily"].ToString());
                }
            }

            //Set the tooltips
            mlt.loanId = view.getCboLoanType().Row["loanTypeID"].ToString();
            mlt.searchLoanType();
            view.setTermsTooltip("Maximum Term: "+mlt.maxTerm + " month/s");
            view.setRequestedAmountTooltip("Minimum Amount: P " + Validator.amountFormatter(mlt.minAmount) + "\nMaximum Amount: P " + Validator.amountFormatter(mlt.maxAmount));
            
            //Set Previous Loan
            ModelShareCapitalTransaction modelShare = new ModelShareCapitalTransaction();
            modelShare.accountNo = model.accountNo;
            view.setShareCapital(modelShare.getShareCapitalBalance().ToString());

            view.setLblEligibility("The member is eligible for loan application.");
            view.enableBtnSave();

            //If member has outstanding (approved or pending) loan application.
            if (model.hasOutstandingLoanApplication() && view.getCboOperationIndex() == 0) 
            {
                view.setLblEligibility("The member has a pending loan application.");
                view.disableBtnSave();
            }

            SqlDataReader readerPrevious = model.getPreviousLoan();
            if (readerPrevious.Read())
            {
                model.loanNo = readerPrevious["loanNo"].ToString();
                view.setLoanNoPrevious(model.loanNo);
                view.setLoanTypePrevious(readerPrevious["loanName"].ToString());
                view.setCurrentBalancePrevious(model.getLoanBalance().ToString());
                view.setMaturityDatePrevious(model.getMaturityDate());

                if (model.isMemberEligible())
                {
                    view.setLblEligibility("The member is eligible for loan application.");
                    view.enableBtnSave();
                }

                else
                {
                    view.setLblEligibility("The previous loan must be " + Validator.amountFormatter(model.loanEligibility) + "% paid to apply for another loan."); ;
                    view.disableBtnSave();
                }
            }
        }

        public void setCollateralComaker()
        {
            model.loanTypeID = view.getApplicableLoanType();
            if (model.hasCollateral())
            {
                view.enableCollateral();
            }

            else
            {
                view.disableCollateral();
            }

            if (model.hasComaker())
            {
                view.enableComaker();
            }

            else
            {
                view.disableComaker();
            }
        }

        public void btnFamilyClicked(object sender, EventArgs e)
        {
            TransactionComakerFamily tcf = new TransactionComakerFamily();
            this.viewfamily = tcf;
            viewfamily.setFamily(model.getFamily());
            this.viewfamily.Show();
            this.viewfamily.dgFamilyClicked += new EventHandler(dgFamilyClicked);
        }

        public void dgFamilyClicked(object sender,EventArgs e)
        {
            DataGridView dg = viewfamily.getFamily();
            int row = dg.CurrentCell.RowIndex;
            model.familyID = dg.Rows[row].Cells[0].Value.ToString();
            model.familyName = dg.Rows[row].Cells[1].Value.ToString();
            family = model.familyID;
            view.setComakerFamily(model.familyName);
            viewfamily.Hide();
                         
         }

        public void btnMemberClicked(object sender,EventArgs e)
        {
            TransactionComakerMember tcm = new TransactionComakerMember();
            this.viewmember = tcm;
            this.viewmember.setMember(model.getcoMembers());
            this.viewmember.Show();
            this.viewmember.dgMemberClicked += new EventHandler(dgMemberClicked);
        }

        public void dgMemberClicked(object sender, EventArgs e)
        {
            DataGridView dg = viewmember.getMember();
            int row = dg.CurrentCell.RowIndex;
            model.comemberID = dg.Rows[row].Cells[0].Value.ToString();
            model.comemberName = dg.Rows[row].Cells[1].Value.ToString();
            member = model.comemberID;
            view.setComakerMember(model.comemberName);
            viewmember.Hide();
        }

        public bool validateComputeAmortization()
        {
            double loanAmount = 0;
            int terms = 0;
            bool check = false;
            if (Double.TryParse(view.getComputeLoanAmount(), out loanAmount) && Convert.ToDouble(view.getComputeLoanAmount()) > 0)
            {
                if (Int32.TryParse(view.getComputeTermsOfPayment(), out terms) && Convert.ToInt32(view.getComputeTermsOfPayment()) > 0)
                {
                    check = true;
                }

                else
                {
                    MessageBox.Show("Invalid value in terms of payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Invalid value for the loan amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public bool validateSaveLoanApplication()
        {
            bool check = false;
            if (validateLoanFields())
            {
                check = true;
                if (model.hasComaker())
                {
                    if (this.validateComaker())
                    {
                        check = true;
                        if (model.hasCollateral())
                        {
                            if (this.validateCollateral())
                            {
                                check = true;
                            }

                            else
                            {
                                check = false;
                            }
                        }
                    }

                    else
                    {
                        check = false;
                    }
                }

                if (model.hasCollateral())
                {
                    if (this.validateCollateral())
                    {
                        check = true;
                        if (model.hasComaker())
                        {
                            if (this.validateComaker())
                            {
                                check = true;
                            }

                            else
                            {
                                check = false;
                            }
                        }
                    }

                    else
                    {
                        check = false;
                        MessageBox.Show("Invalid value for collateral.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return check;
        }

        public bool validateComaker()
        {
            bool check = false;
            string text = "";
            int value = 0;
            model.loanTypeID = view.getApplicableLoanType();
            if (view.getComakerMember().Trim().Length != 0 && view.getComakerFamily().Trim().Length != 0)
            {
                if (view.getBlkNo().Trim().Length != 0 )
                {
                    text = view.getStreet();
                    if (view.getStreet().Trim().Length != 0 && !Int32.TryParse(text,out value))
                    {
                        text = view.getBrgy();
                        if (view.getBrgy().Trim().Length != 0 && !Int32.TryParse(text, out value))
                        {
                            text = view.getCity();
                            if (view.getCity().Trim().Length != 0 && !Int32.TryParse(text, out value))
                            {
                                check = true;
                            }

                            else
                            {
                                MessageBox.Show("Invalid value for city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalid value for subd/brgy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid value for street.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
                }

                else
                {
                    MessageBox.Show("Invalid value for Blk/Lot No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                check = false;
                MessageBox.Show("Please select a comaker for family and member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        public bool validateCollateral()
        {
            bool check = false;
            model.loanTypeID = view.getApplicableLoanType();
            if (Validator.isAlphanumeric(view.getCollateral()) && Validator.isAlphanumeric(view.getCollateralDescription()) && view.getCollateral().Trim().Length > 0 && view.getCollateral().Trim().Length <= 50 && view.getCollateralDescription().Trim().Length > 0 && view.getCollateralDescription().Trim().Length <= 200)
            {
                check = true;
            }

            else
            {
                check = false;
            }
            return check;
        }

        public bool validateLoanFields()
        {
            
            ModelShareCapitalTransaction msct = new ModelShareCapitalTransaction();
            bool check = false;
            SqlDataReader readerPrevious = model.getPreviousLoan();
            if (readerPrevious.Read())
            {
                model.loanNo = readerPrevious["loanNo"].ToString();
            }
            if (view.getAccountNo().Trim().Length != 0)
            {
                if (Validator.isValidAmount(view.getRequestedAmount()) && view.getRequestedAmount().Trim().Length < 16)
                {
                    if (Convert.ToDouble(view.getRequestedAmount()) >= model.getLoanBalance())
                    {
                        if (Validator.isValidDigit(view.getTermsOfPayment()))
                        {
                            double requestedAmount = Convert.ToDouble(view.getRequestedAmount());
                            int termsOfPayment = Convert.ToInt32(view.getTermsOfPayment());
                            mlt.loanId = view.getCboLoanType().Row["loanTypeID"].ToString();
                            mlt.searchLoanType();
                            msct.accountNo = view.getAccountNo();
                            double shareCapital = Convert.ToDouble(msct.getShareCapitalBalance());
                            double loanEntitlement = shareCapital * (Convert.ToDouble(mlt.loanEntitlement) / 100);
                            int maxTerm = Convert.ToInt32(mlt.maxTerm);
                            int termsOfPaymentDays = termsOfPayment*30;
                            int intervalOfPaymentDays = ModelUser.getIntervalInDays(view.getIntervalOfPayment());
                            if (requestedAmount >= Convert.ToDouble(mlt.minAmount) && requestedAmount <= Convert.ToDouble(mlt.maxAmount))
                            {
                                if (termsOfPayment <= maxTerm)
                                {
                                    if (Convert.ToDouble(view.getRequestedAmount()) <= loanEntitlement || loanEntitlement == 0)
                                    {
                                        if (termsOfPaymentDays >= intervalOfPaymentDays)
                                        {
                                            if (view.getStatus() == "2")
                                            {
                                                if (Validator.isValidAmount(view.getApprovedAmount()))
                                                {
                                                    if (Convert.ToDouble(view.getApprovedAmount()) <= Convert.ToDouble(view.getRequestedAmount()))
                                                    {
                                                        check = true;
                                                    }

                                                    else
                                                    {
                                                        MessageBox.Show("Approved amount must be less than or equal to the requested amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }

                                                else
                                                {
                                                    MessageBox.Show("Invalid value in approved amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }

                                            else
                                            {
                                                check = true;
                                            }
                                        
                                        }

                                        else
                                        {
                                            MessageBox.Show("Interval of payment must be less than or equal to the terms of payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("The member has a current share capital of P " + Validator.amountFormatter(msct.getShareCapitalBalance()) + ". The maximum loanable amount allowed for this member is P "+Validator.amountFormatter(loanEntitlement.ToString())+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("The maximum term for this loan is "+mlt.maxTerm+" month/s.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            else
                            {
                                MessageBox.Show("The amount required for this loan is from P " + Validator.amountFormatter(mlt.minAmount) + " to P "+Validator.amountFormatter(mlt.maxAmount)+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalid number for the terms of payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("The loan amount must be less than the balance of the previous loan (" + Validator.amountFormatter(model.getLoanBalance().ToString()) + ").", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid value for the requested amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please choose a member first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return check;
        }

        public void RefreshFields()
        {
            //DataSet ds = null;
            view.setTermsOfPayment("");
            //view.setCboSavingsAccount(ds);
            //view.setIntervalOfPayment(null);
            view.disableCollateral();
            view.disableComaker();
            view.setLoanNo(model.getNextLoanNumber());
            view.setLblShareCapital("---");
            view.setLblShareCapital("---");
            view.setLblTotalAmount("---");
            view.setLblTotalInterest("---");
            view.setLblLoanAmount("---");
            //view.setlblSavings("---");
            view.setRequestedAmount("");
            view.setComakerFamily("");
            view.setComakerMember("");
            view.setStatus("1");
            view.disableApprovedAmount();
            view.clearAmortization();
            view.setCboLoanType(new ModelLoanType().getLoanTypes());
            view.setCboApplicableLoans(null);
            view.setAccountNo("");
            view.setMemberName("");
            //view.setIntervalOfPayment(ModelUser.getIntervalOfPayments());
            view.setStatus("0");
            view.setRemarks("");
            view.setApprovedAmount("");
            view.setLoanNoPrevious("");
            view.setCurrentBalancePrevious("");
            view.setMaturityDatePrevious("");
            view.setLoanTypePrevious("");
            view.setLblEligibility("");
            view.enableBtnSave();
            view.setShareCapital("");
        }
    }
}
