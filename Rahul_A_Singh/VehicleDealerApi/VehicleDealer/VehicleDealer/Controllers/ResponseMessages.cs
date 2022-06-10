namespace VehicleDealer.Controllers
{
    public static class ResponseMessages
    {
        public const string An_unhandled_error = "UnhandledErrorKey";
        public const string Field_validation_error = "FieldValidationErrorKey";
        public const string Invalid_username_or_password = "InvalidUsernamePasswordKey";
        public const string Password_not_Match = "Old Password Is Invalid.";

        public const string TypeCastingNotValidKey = "{0}TypeCastingNotValidKey";
        public const string Created_key = "CreatedKey";
        public const string production_prodtrans_internalreturn_Created = "production_prodtrans_internalreturn_Created";
        public const string sal_saldp_salereturnqc_CreatedKey = "sal_saldp_salereturnqc_CreatedKey";
        public const string eng_sales_salesdispatch_CreatedKey = "eng_sales_salesdispatch_CreatedKey";
        public const string Updated_key = "UpdatedKey";
        public const string Saved_key = "SavedKey";
        public const string Exist_key = "ExistKey";
        public const string Not_exist_key = "NotExistKey";
        public const string Deleted_key = "DeletedKey";
        public const string Description_Exist_key = "DescriptionExistKey";
        public const string DBExist_key = "DBExistKey";
        public const string Erorrin_DB_Create_key = "ErrorInDBCreateKey";
        public const string Erorrin_ExtFinDB_Create_key = "ErrorInExtFinDBCreateKey";
        public const string RefDataExists = "ReferenceDataExistsCanNotDelete";
        public const string UpperCase = "{{0}}_In_UpperCase";
        public const string NotValidData = "Records are not valid";
        public const string FinancePeriod_Must_be_greaterthanzero = "FinancePeriod Must be greater than zero";
        public const string CodeIsUsedKey = "CodeIsUsedKey";
        public const string pur_purmasters_pertaxrate_codeInUseKey = "pur_purmasters_pertaxrate_codeInUseKey";
        public const string qc_masters_inprocqcpara_ExistKey = "qc_masters_inprocqcpara_ExistKey";
        public const string purchase_masters_itempurchase_delete_exist_key = "purchase_masters_itempurchase_delete_exist_key";
        public const string Password_changed_sucessfully = "password_has_been_changed_sucessfully";
        public const string Notification_Deleted_Succesfully = "common_common_notificationdeletedsuccesfully";
        public const string Markred_Successfully = "message_status_updated_sucessfully";
        public const string Authorize_key = "common_AuthorizeMsgkey";
        public const string licensefile_Invalid = "license_missing_or_Invalid_key";
        public const string licensefile_expired = "license_expired";
        public const string Inserted_key = "Inserted_key";
        public const string IssueQtyGatePassAlreadyCreated = "IssueQtyGatePassAlreadyCreated";


        #region User Screen messages
        public const string User_min_password_len_key = "UserMinPasswordLenKey";//"Minimum Password Length Must Be {0} Characters";
        public const string User_max_password_len_key = "UserMaxPasswordLenKey";
        public const string User_used_password_key = "UserUsedPasswordKey";//"You Can Not Enter This Password As Used Previously {0} .";
        #endregion

        #region Company Messages
        public const string Companycode_firstlatter_key = "CompanyCodeFirstLatterKey";
        public const string Databasename_firstlatter_key = "DatabaseNameFirstLatterKey";
        public const string Databaseconnection_invalid_key = "DatabaseConnectionInvalidKey";
        public const string Databasename_invalid_key = "DatabaseNameInvalidKey";
        #endregion

        #region HSN Code Screen Messages
        public const string HSNfinalcode_notproper_key = "HSNFinalCodeNotProperKey";
        public const string HSN2nd_nonempty_key = "HSNCode2ndNonEmptyKey";
        #endregion

        #region Rate Structure
        public const string eng_engmasters_ratemstentry_ratecode_workcenter_CantDeleteKey = "eng_engmasters_ratemstentry_ratecode_workcenter_CantDeleteKey";
        public const string CantDeleteKey = "CantDeleteKey";
        public const string CantEditKey = "CantEditKey";
        public const string TaxValnotValidkey = "TaxValueMustBeLessorEqual999999999.9999";  //"TaxValueMustBeLessorEqual999999999.9999"
        public const string RateStructCodeMustBeInUpperCase = "RateStructCodeMustBeInUpperCase";
        public const string Select_Atleast_one_FlagtoUpdateData = "Select_Atleast_one_FlagtoUpdateData";
        public const string Select_Atleast_one_RateCode = "Select_Atleast_one_RateCode";
        public const string RateCodes_Should_Less_Than_10 = "RateCodes_Should_Less_Than_10";
        public const string Only_One_Foreign_Currency_will_be_Allowed_For_One_rate_Structure = "pur_purmasters_purrtestruct_foreigncurrency";
        public const string RatestructureisInactiveKey = "RatestructureisInactiveKey";
        public const string Include_SGST_UGST_Key = "Include_SGST_UGST_Key";
        public const string Include_CGST_Key = "Include_CGST_Key";
        public const string Include_SGST_Key = "Include_SGST_Key";
        public const string IncludeIGST_CGST_SGST_Key = "IncludeIGST_CGST_SGST_Key";
        public const string VerifyCess_GST_Key = "VerifyCess_GST_Key";
        public const string RatestructureCodeisUsedKey = "RatestructureCodeisUsedKey";
        public const string Ratecode_ExistKey = "pur_purmasters_purrtestruct_Ratecode_ExistKey";
        #endregion

        #region Cheque Book
        public const string ChequeTo_Shouldnotbe_LessThen_ChequeFrom = "ChequeToShouldnotbeLessThenChequeFrom";
        #endregion

        #region Custom Messages
        public const string RtCodeInUse_Key = "RtCodeInUseKey";
        public const string accounts_masters_tdsratestructure_RtCodeInUseKey = "accounts_masters_tdsratestructure_RtCodeInUseKey";
        public const string NTAvailInMaster = "Given item code is not available in master table";
        public const string ForeignCurZeroNotAllowed = "For Foreign Currency Tax Value Zero Is Not Allowed";
        public const string DcCodeonForCodeNotAllowed = "Domestic Currency Code As Inclusive On a Basic Value Of Foreign Currency Is Not Allowed";
        #endregion

        #region SMTP Mail Config
        public const string Test_Mail_Send_Successfully_Key = "Test_Mail_Send_Successfully_Key";       //"Test mail send successfully!";
        public const string Test_Mail_Not_Successfully_Send_Key = "Test_Mail_Not_Successfully_Send_Key";             //"SMTP test mail is not successfully send. Please enter correct data.";
        #endregion

        #region Exchange Rate Master
        public const string Domestic_Currency_Code_Cannot_be_Used = "Domestic Currency code cannot be used";  //"Domestic Currency Code cannot be used!"
        public const string Date_Shouldbe_Greaterthan_Last_EffDate = "Effective should be greater than Last Effective. Date"; //"Date should be greater than Last Eff. Date";
        public const string CurrencyCode_And_Date_Combination_Already_Exists = "Currency Code and Date Combination Already Exists!";  //"Currency Code and Date Combination Already Exists!";
        public const string CurrencyCode_Is_DifferentThan_DomesticCurrency = "CurrencyCode is different than domesticCurrency";  //"Currency Code and Date Combination Already Exists!";

        public const string Effective_Date_From_cannot_be_less_than_Starting_Period_Date = "Effective date cannotbe less than starting perioddate";  //"Effective Date From cannot be less than Starting Period Date!";
        public const string Date_Cannot_Be_Greater_Than_Current_Date = "Effective date cannot be greate than Current date";  //"Date Cannot Be Greater Than Current Date!";

        #endregion

        #region Vendor Master
        public const string VendorCode_MustbeIn_UpperCase = "VendorCodeMustbeInUpperCase";  //" Code must be in Upper Case !!"
        public const string RemittanceAddress1_Cannotbe_Empty = "RemittanceAddress1CannotbeEmpty"; //"Remittance Address 1 can not be empty !!";
        public const string CityCode_Mustbe_In_UpperCase = "CityCodeMustbeInUpperCase";  //"City Code must be in Upper Case !!";
        public const string CurrencyCode_Mustbe_In_UpperCase = "CurrencyCodeMustbeInUpperCase";  //"Currency Code must be in Upper Case !!";
        public const string pur_purmasters_ventmastent_delete_referror = "pur_purmasters_ventmastent_delete_referror";  //"Given_Vendor_Code_cannot_be_deleted_as_exist_in_Item_Vendor_Purchase_Master        
        #endregion

        #region Finance Period End Settings Validator
        public const string EndDate_Shouldnotbe_LessThen_StartDate = "EndDateShouldnotbeLessThenStartDate";  //" End Date should not be less then Start Date !"
        public const string SelectedSiteAlreadyExistKey = "admn_admmaster_prdenddatesetting_yralreadexst";
        #endregion

        #region Item Warehouse Physical Bin
        public const string Item_Must_Has_One_Location_IsDefaultYes_For_ItemCode = "Item_Must_Has_One_Location_IsDefaultYes_For_ItemCode";  //"Item must has one location is default Yes for Item code   !"
        public const string OnlyOneRowHaveDefaultYesKey = "OnlyOneRowHaveDefaultYesKey";  //" Only One row have default Yes  !"        
        public const string CanNotDeleteDefaultBinofItemKey = "CanNotDeleteDefaultBinofItemKey";  //" You can not delete default Bin of item  !"        
        public const string ItemBinCodeCombinationAlreadyExistKey = "ItemBinCodeCombinationAlreadyExistKey";  // "Entered Item and Bin Code Combination Already Exist  !"        
        public const string OnlyOneRowOfSameItemHaveDefaultYesKey = "OnlyOneRowOfSameHaveDefaultYesKey";  //" Only One row have default Yes  !"
        public const string Item_Already_Exists_in_warehouse_with_this_bin_Code = "Item_Already_Exists_in_warehouse_with_this_bin_Code";
        #endregion

        #region Feature Master
        public const string DefaultSelection = "DefaultSelection";
        #endregion

        #region Feature Master
        public const string DCAlreadyGeneratedKey = "DCAlreadyGeneratedKey";
        public const string SalesOrderAlreadyGeneratedKey = "SalesOrderAlreadyGeneratedKey";
        #endregion

        #region Item Master Service
        public const string CantDeletePOExistsKey = "CantDeletePOExistsKey";
        #endregion

        #region CCNApply Validation
        public const string CCNAIDAlreadyExist = "Could not process because Item Code has been already replaced at same position with Replace Item Code";
        #endregion

        #region ECN Entry
        public const string ECN_Group_Code_not_Found = "ECN_Group_Code_not_Found";
        public const string ECN_Location_Code_not_Found = "ECN_Location_Code_not_Found";
        public const string ECN_Number_Already_Exist = "ECN_Number_Already_Exist";
        public const string ECNNo_not_found_in_ECN_Detail = "ECNNo_not_found_in_ECN_Detail";
        public const string Status_Should_not_be_Blank_Null = "Status_Should_not_be_Blank_Null";
        public const string Replace_Child_Code_Should_not_be_Blank_Null = "Replace_Child_Code_Should_not_be_Blank_Null";
        public const string Child_Code_Should_not_be_Blank_Null = "Child_Code_Should_not_be_Blank_Null";
        public const string Parent_Code_Should_not_be_Blank_Null = "Parent_Code_Should_not_be_Blank_Null";
        public const string Reason_Code_Should_not_be_Blank_Null = "Reason_Code_Should_not_be_Blank_Null";
        public const string Quantity_Should_not_be_Blank_Zero = "Quantity_Should_not_be_Blank_Zero";
        public const string Position_Number_Should_not_be_Blank_Null = "Position_Number_Should_not_be_Blank_Null";
        public const string Global_Status_Should_not_be_Blank_Null = "Global_Status_Should_not_be_Blank_Null";
        public const string Global_Child_Code_Should_not_be_Blank_Null = "Global_Child_Code_Should_not_be_Blank_Null";
        public const string Global_Replace_Child_Code_Should_not_be_Blank_Null = "Global_Replace_Child_Code_Should_not_be_Blank_Null";
        public const string Global_Reason_Code_Should_not_be_Blank_Null = "Global_Reason_Code_Should_not_be_Blank_Null";
        public const string Item_wise_ECN_entry_details_or_Global_effects_should_not_be_blank = "Item_wise_ECN_entry_details_or_Global_effects_should_not_be_blank";
        public const string ItemType_Should_not_be_Blank_Null = "ItemType_Should_not_be_Blank_Null";
        public const string Child_Item_Code_of_Scrap_type_is_not_allowed = "Child_Item_Code_of_Scrap_type_is_ not_allowed";
        public const string Child_Item_Code_not_found_in_Item_Master = "Child_Item_Code_not_found_in_Item_Master";
        public const string Child_Code_has_no_Product_Structure_Freezed = "Child_Code_has_no_Product_Structure_Freezed";
        public const string This_Feature_Type_Item_Contain_Optional_Item_Having_Product_Structure_Not_Freezed = "This_Feature_Type_Item_Contain_Optional_Item_Having_Product_Structure_Not_Freezed";
        public const string Parent_Item_Code_of_Scrap_type_is_not_allowed = "Parent_Item_Code_of_Scrap_type_is_not_allowed";
        public const string Parent_Item_Code_not_found_in_Item_Master = "Parent_Item_Code_not_found_in_Item_Master";
        public const string Child_code_is_not_allowed_as_a_child_of_Parent = "Child_code_is_not_allowed_as_a_child_of_Parent";
        public const string Replace_Child_Item_Code_of_Scrap_type_is_not_allowed = "Replace_Child_Item_Code_of_Scrap_type_is_not_allowed";
        public const string Replace_Child_Item_Code_not_found_in_Item_Master = "Replace_Child_Item_Code_not_found_in_Item_Master";
        public const string Replace_Child_Code_has_no_Product_Structure_Freezed = "Replace_Child_Code_has_no_Product_Structure_Freezed";
        public const string Reason_Code_not_found_in_Codes_Master = "Reason_Code_not_found_in_Codes_Master";
        public const string Duplicate_Item_Code_For_Global_Effect_Not_Allow = "Duplicate_Item_Code_For_Global_Effect_Not_Allow";
        public const string Replace_Child_code_should_not_be_same_as_Child_Code = "Replace_Child_code_should_not_be_same_as_Child_Code";

        #endregion

        #region InquiryCloseEntry Validation
        public const string SelectAtleastOneEquiry = "Please_Select_Atleast_One_Inquiry_For_Closed";
        #endregion

        #region CCNApply Validation
        public const string NotProcced_ItemCode_Already_Replaced_At_Same_Postiton = "Could not process because Item Code has been already replaced at same position with Replace Item Code";
        public const string Success = "SUCCESS";
        public const string Could_Not_Procced_Structure_Different_For_Selected_SJO = "Could not process because Structure is not same for selected SJO ";
        public const string Parent_Code_Has_only_One_child = "Parent Code has only one child in CBOM of SJO :";
        public const string Only_One_Non_Vendor_Supplied_Child_CanNot_Delete = "There Is Only One Non Vendor Supplied Child So You Can Not Delete This Child.";
        public const string Labour_Entry_Avilable_WO = "Labour Production entry already available against the WO.";
        public const string Allocation_Already_Done_SJO = "Allocation is already done in SJO: ";
        public const string Item_Already_Issue_In_SJO = "Item already issued in SJO :";
        public const string Not_Process_Child_Item_Not_Exist = "Could not process because child item does not exist in Item Master!";
        public const string Not_Peocess_Item_Code_Deactive = "Could not process because  Entered Item Code is de-activated by ";
        public const string Not_Process_Child_Code_Same_Parent_Code = "Could not process because Child Code cannot be same as Parent Code!";
        public const string Item_Code_Can_Not_Be_As_Child = "Item Can Not Be Selected As Child Because Parent Code Exist As A Child In The Structure Of Child Item.";
        public const string Not_Process_Freezed_Prod_Structure = "Could not process because Freezed Product structure is not available for entered Child code.";
        public const string Open_Work_Order_Cancle_Work_Order = "Either of the item code has open work order, please cancel the work order first.";
        public const string Production_Booked_Deletion_Not_Allowed = "Want to allow Internal return note even though Production is booked is set to Yes. Child Code: is issued and Labour Production is booked. Hence deletion under this parent is not allowed.";
        public const string Replaced_Item_Issued = "Item to be Replaced is issued and hence cannot be replaced!";
        public const string Delete_Item_Issued = "Item to be Deleted is issued and hence cannot be deleted!";
        public const string Not_Process_Child_Code_Used_In_LJGP = "Could not process because Child Code is used in LJGP : ";
        public const string Issued_Doc_Not_Authorized_Can_Not_Delete = "Issue document has not been authorized, hence cannot delete this child item code.";
        public const string Return_Note_doc_Not_Authorized = "Return Note document has not been authorized, hence cannot delete this child item code.";
        public const string Labour_GatePass_Doc_Not_Authorized = "Labour Gatepass document has not been authorized, hence cannot delete this child item code.";
        public const string Internal_Rej_Doc_Not_Authorized = "Internal Rejection Note Document has not been Authorized,Please Authorize the Internal Rejection Note Document first.";
        public const string GRN_Doc_Not_Authorized = "GRN document has not been authorized, hence cannot delete this child item code.";
        public const string Work_Order_Made_More_Qty_Can_Not_Process = "Work Orders have been made by more Quantity than Replace Quantity For Child Item Code of Selected Position,hence you can not Proceed further.";
        public const string Replace_Qty_Not_Less_Than_Consumption_For_Child = "Replace Quantity Can not be less than Total Consumption Quantity For Child Item Code of Selected Position,hence you can not Proceed further.";
        public const string Replace_Qty_Less_Than_Issue_Qty = "Replace Quantity is less than Total Issued Quantity For Child Item Code!";
        public const string Labour_Gatepass_Made_More_Qty = "Labour Job Gate Pass has made of more quantity,hence you can not Proceed further!";
        public const string Replace_Qty_Less_Than_Issued_Qty = "Replace Quantity is less than Total Issued Quantity For Child Item Code of Selected Position!";
        public const string Sub_Contract_GRN_Made_For_Child_Can_Not_Process = "Sub Contracting GRN has been made for Selected Child Item Code,hence you can not Proceed further";
        public const string Not_Process_Item_Already_Issued_Auto_Return_Not_Generated = "Could not process because Item has alreay been issued,hence Auto Return Note is generated!";
        public const string Not_Proccess_Work_Order_Receipt_Created = "Could not process because work order receipt created.";
        public const string Not_Process_Scrap_Itm_Not_Allowed = "Could not process because Item Code of scrap type is not allowed!";
        public const string Either_Of_Itm_Has_Open_Work_Order = "Either of the item code has open work order, please cancel the work order first.";
        #endregion

        #region OAF Basic Purchase Entry
        public const string Select_Atleast_One_Item = "Please select at least one item";
        #endregion

        #region BOE AWB Entry
        public const string BOE_Number_required = "BOE Number Can Not Be Blank";
        public const string BOE_Date_required = "BOE Date Can Not Be Blank";
        public const string BOE_Amount_required = "BOE Amount Can Not Be Blank";
        public const string Bill_Amount_required = "Bill Amount Can Not Be Blank";
        public const string Net_Bill_Amount_required = "Net Bill Amount Can Not Be Blank";
        #endregion

        #region Delivery Challan General Entry
        public const string Please_Enter_Year_in_Proper_Format = "Please_Enter_Year_in_Proper_Format";
        public const string Invalid_Dc_Number = "Invalid_Dc_Number";
        public const string Invalid_Dc_Id = "Invalid_Dc_Id";
        public const string Invalid_Year = "Invalid_Year";
        public const string Invalid_group_code = "Invalid_group_code";
        public const string Invalid_site_code = "Invalid_site_code";
        public const string Reason_For_DC_Code_Value_Does_Not_Exist_in_Codes_Master = "Reason_For_DC_Code_Value_Does_Not_Exist_in_Codes_Master";
        public const string Customer_Vendor_Code_Not_Found = "Customer_Vendor_Code_Not_Found";
        public const string Employee_Code_Does_Not_Exist_in_Employee_Master = "Employee_Code_Does_Not_Exist_in_Employee_Master";
        public const string Mode_Of_Dispatch_Value_Does_Not_Exist = "Mode_Of_Dispatch_Value_Does_Not_Exist";
        public const string Gross_Weight_should_be_greater_than_or_equal_to_Net_Weight = "Gross_Weight_should_be_greater_than_or_equal_to_Net_Weight";
        public const string Please_Insert_Atleast_One_Row_In_Item_Details = "Please Insert Atleast One Row In Item Details";
        public const string Item_Code_Can_not_be_Blank_Null = "Item_Code_Can_not_be_Blank_Null";
        public const string Requisition_Quantity_Can_not_be_Zero = "Requisition_Quantity_Can_not_be_Zero";
        public const string Return_Date__Can_not_be_Blank_Null_in_case_of_Returnable = "Return_Date__Can_not_be_Blank_Null_in_case_of_Returnable";
        public const string Item_Rate_should_Not_Be_Blank = "Item_Rate_should_Not_Be_Blank";
        public const string Please_Select_Rejection_Number = "Internal Rejection Note Number cannot be blank";
        public const string WarehouseId_Can_Not_Be_Blank = "WarehouseId_Can_Not_Be_Blank";
        public const string Warehouse_Code_Can_Not_Be_Blank = "Warehouse_Code_Can_Not_Be_Blank";
        public const string WareHouse_Code_does_not_Exist_In_WareHouse_Master = "WareHouse_Code_does_not_Exist_In_WareHouse_Master";
        public const string Invalid_GST_HSN_Code = "Invalid_GST_HSN_Code";
        public const string HSN_Code_must_be_either_of_2_or_4_or_8_Digits = "HSN_Code_must_be_either_of_2_or_4_or_8_Digits";
        public const string HSN_code_does_not_exist = "HSN_code_does_not_exist";
        public const string Duplicate_Item_Code_WareHouse_Code_Combination_Not_Allow = "Duplicate_Item_Code_WareHouse_Code_Combination_Not_Allow";
        public const string Item_Code_does_not_Exists_in_Item_Master = "Item_Code_does_not_Exists_in_Item_Master";
        public const string Date_Can_Not_Be_Greater_Than_Today_Date = "Date_Can_Not_Be_Greater_Than_Today_Date";
        public const string Enter_Date_Between_financial_year = "Enter_Date_Between_financial_year";
        public const string sales_saledisp_dcgen_itemdet_CreatedKey = "sales_saledisp_dcgen_itemdet_CreatedKey";
        public const string Item_stock_does_not_available = "Item_stock_does_not_available";

        #endregion

        #region Document Control
        public const string UserCode_does_not_ExistsKey = "UserCode_does_not_ExistsKey";
        public const string Can_not_Enter_0_for_Level_Defined_as_Hierarchical_Flag_YesKey = "Can_not_Enter_0_for_Level_Defined_as_Hierarchical_Flag_YesKey";
        public const string SubLevel_Other_than_0_is_not_Valid_While_Hierarchical_Required_flag_Set_NoKey = "SubLevel_Other_than_0_is_not_Valid_While_Hierarchical_Required_flag_Set_NoKey";
        public const string Group_Code_does_not_Exist_in_Book_Master_for_this_transaction_typeKey = "Group_Code_does_not_Exist_in_Book_Master_for_this_transaction_typeKey";
        public const string Please_select_Hierarchical_Required_Option_in_Document_Level_GridKey = "Please_select_Hierarchical_Required_Option_in_Document_Level_GridKey";
        public const string Please_insert_Value_Limit_in_Document_Level_GridKey = "Please_insert_Value_Limit_in_Document_Level_GridKey";
        public const string Site_Code_can_not_be_BlankKey = "Site_Code_can_not_be_BlankKey";
        public const string Group_Code_can_not_be_BlankKey = "Group_Code_can_not_be_BlankKey";
        public const string Please_Insert_Atleast_One_Row_In_Document_Number_Generation_Details_GridKey = "Please_Insert_Atleast_One_Row_In_Document_Number_Generation_Details_GridKey";
        public const string Atleast_One_Document_String_must_have_Default_Flag_YesKey = "Atleast_One_Document_String_must_have_Default_Flag_YesKey";
        public const string Please_enter_Level_value_in_Document_User_Level_Authorization_DetailKey = "Please_enter_Level_value_in_Document_User_Level_Authorization_DetailKey";
        public const string Please_enter_Sub_Level_value_in_Document_User_Level_Authorization_DetailKey = "Please_enter_Sub_Level_value_in_Document_User_Level_Authorization_DetailKey";
        public const string Please_enter_User_Code_in_Document_User_Level_Authorization_DetailKey = "Please_enter_User_Code_in_Document_User_Level_Authorization_DetailKey";
        public const string Child_Document_Type_Details_For_Document_Already_Exists_Want_to_Overwrite_Child_DetailsKey = "Child_Document_Type_Details_For_Document_{0}_Already_Exists_Want_to_Overwrite_Child_DetailsKey";
        public const string No_User_Levels_Defined_For_LevelKey = "No_User_Levels_Defined_For_Level_{0}_Key";
        public const string Please_Enter_SubLevels_for_Level_in_Valid_SequenceKey = "Please Enter SubLevels for Level_{0}_in Valid Sequence";
        #endregion

        #region Bank Guarantee (BG) Entry
        public const string No_Details_Found_For_Entered_Financial_Year = "No_Details_Found_For_Entered_Financial_Year";
        public const string Invalid_Group_code = "Invalid_Group_code";
        public const string Location_Code_Not_Found = "Location_Code_Not_Found";
        public const string BG_Number_Sales_Order_Number_Not_Found = "BG_Number_Sales_Order_Number_Not_Found";
        public const string BG_Number_Can_Not_Be_Blank = "BG_Number_Can_Not_Be_Blank";
        public const string Bank_Name_Can_Not_Be_Blank = "Bank_Name_Can_Not_Be_Blank";
        public const string BG_Date_Can_Not_Be_Blank = "BG_Date_Can_Not_Be_Blank";
        public const string BG_Due_Date_Can_Not_Be_Blank = "BG_Due_Date_Can_Not_Be_Blank";
        public const string BG_Amount_Should_Not_Be_Blank_or_Zero = "BG_Amount_Should_Not_Be_Blank_or_Zero";
        public const string Customer_PO_Number_Can_Not_Be_Blank = "Customer_PO_Number_Can_Not_Be_Blank";
        public const string FDR_Number_Can_Not_Be_Blank = "FDR_Number_Can_Not_Be_Blank";
        public const string FD_Maturity_Date_Can_Not_Be_Blank = "FD_Maturity_Date_Can_Not_Be_Blank";
        public const string Amendment_Date_Can_Not_Be_Blank = "Amendment_Date_Can_Not_Be_Blank";
        public const string Can_Not_Insert_Duplicate_BG_Number = "Can_Not_Insert_Duplicate_BG_Number";
        public const string Name_of_Beneficiary_Can_Not_Be_Blank = "Name_of_Beneficiary_Can_Not_Be_Blank";
        public const string Claim_Expiry_Date_Can_Not_Be_Blank = "Claim_Expiry_Date_Can_Not_Be_Blank";
        public const string Bank_Guarantee_Details_Should_Not_Be_Blank = "Bank_Guarantee_Details_Should_Not_Be_Blank";
        #endregion

        #region Sales Allocation/Deallocation 
        public const string Allocation_Quantity_Can_Not_Be_Greater_Than_OAF_Already_Allocation_Quantity = "Allocation_Quantity_Can_Not_Be_Greater_Than_OAF_Already_Allocation_Quantity";
        public const string DeAllocation_Qty_Cannot_Be_Greater_Than_Pending_Qty_for_Deallocation = "DeAllocation_Qty_Cannot_Be_Greater_Than_Pending_Qty_for_Deallocation";
        #endregion

        #region
        public const string Item_Master_Purchase_Setting_Does_not_exist_Key = "Item_Master_Purchase_Setting_Does_not_exist_Key";
        #endregion

        #region Dispatch Instruction Note

        public const string No_Item_Found_For_Delete_Key = "No_Item_Found_For_Delete_Key";
        public const string Invalid_DetailId_Key = "Invalid_DetailId_Key";
        public const string No_Item_Found_For_Authorize_Key = "No_Item_Found_For_Authorize_Key";
        public const string AutoNumberRequired_field_should_be_Y_or_N_Key = "AutoNumberRequired_field_should_be_Y_or_N_Key";
        public const string SiteRequired_field_should_be_Y_or_N_Key = "SiteRequired_field_should_be_Y_or_N_Key";
        public const string AuthorizationRequired_field_should_be_Y_or_N_Key = "AuthorizationRequired_field_should_be_Y_or_N_Key";
        public const string Invalid_HeaderId_Key = "Invalid_HeaderId_Key";
        public const string Year_is_should_be_in_YY_YY_1_Key = "Year_is_should_be_in_YY_YY_1_Key";
        public const string Please_Enter_Year_in_Proper_Format_YY_YY_1_Key = "Please_Enter_Year_in_Proper_Format_YY_YY_1_Key";
        public const string Year_should_be_Current_Year_only_Key = "Year_should_be_Current_Year_only_Key";
        public const string Dispatch_Instruction_Date_Should_not_be_Greater_than_Current_Date_Key = "Dispatch_Instruction_Date_Should_not_be_Greater_than_Current_Date_Key";
        public const string Dispatch_Instruction_Date_Must_Be_Between_Current_Site_Period_Key = "Dispatch_Instruction_Date_Must_Be_Between_Current_Site_Period_Key";
        public const string Dispatch_Instruction_Number_Cannot_Be_Blank_Key = "Dispatch_Instruction_Number_Cannot_Be_Blank_Key";
        public const string DI_No_Already_Exist_Key = "DI_No_Already_Exist_Key";
        public const string Entered_DI_Number_Does_Not_Exist_Key = "Entered_DI_Number_Does_Not_Exist_Key";
        public const string Given_Dispatch_Instruction_Note_Already_Deleted_Key = "Given_Dispatch_Instruction_Note_Already_Deleted_Key";
        public const string Invalid_IO_Year_Key = "Invalid_IO_Year_Key";
        public const string IO_Group_code_is_Invalid_Key = "IO_Group_code_is_Invalid_Key";
        public const string IO_Number_is_not_Valid_Key = "IO_Number_is_not_Valid_Key";
        public const string Please_Fill_Dispatch_Instruction_Qty_Key = "Please_Fill_Dispatch_Instruction_Qty_Key";
        public const string Dispatch_Instruction_Qty_should_not_More_than_Pending_Dispatch_Instruction_Qty_Key = "Dispatch_Instruction_Qty_should_not_More_than_Pending_Dispatch_Instruction_Qty_Key";
        public const string Dispatch_Instruction_Qty_should_not_More_than_Pending_Delivery_Challan_Qty_Key = "Dispatch_Instruction_Qty_should_not_More_than_Pending_Delivery_Challan_Qty_Key";
        public const string Invalid_group_code_DINKey = "Invalid_group_code_DINKey";
        public const string Invalid_site_code_DINKey = "Invalid_site_code_DINKey";
        public const string DispatchInstructionNoteCreated = "DispatchInstructionNoteCreated";
        public const string Short_Close_Qty_can_not_greater_than_Maximum_Short_Close_Qty_Key = "Short_Close_Qty_can_not_greater_than_Maximum_Short_Close_Qty_Key";
        public const string Please_Fill_Short_Close_Qty_Key = "Please_Fill_Short_Close_Qty_Key";
        #endregion

        #region Short Close Return DC General
        public const string DCShortCloseNoCanNotBeBlank = "DCShortCloseNoCanNotBeBlankKey";
        public const string DCYearcannotbeblank = "DCYearcannotbeblankKey";
        public const string DCGroupcannotbeblank = "DCGroupcannotbeblankKey";
        public const string LocationCodecannotbeblank = "LocationCodecannotbeblankKey";
        public const string DCNumbercannotbeblank = "DCNumbercannotbeblankKey";
        public const string MiscellaneousConsumableShouldNotBeNullInFinancesPolicy = "MiscellaneousConsumableShouldNotBeNullInFinancesPolicyKey";
        public const string Short_Close_Return_For_Delivey_Challan_General_Done_successfullyKey = "Short_Close_Return_For_Delivey_Challan_General_Done_successfullyKey";
        public const string DeliveryChallanShortCloseNumberAlreadyExistKey = "DeliveryChallanShortCloseNumberAlreadyExistKey";
        #endregion

        #region Invoice Cancellation

        public const string AutoNumberRequired_field_should_be_Y_or_N_InvCanKey = "AutoNumberRequired_field_should_be_Y_or_N_InvCanKey";
        public const string SiteRequired_field_should_be_Y_or_N_InvCanKey = "SiteRequired_field_should_be_Y_or_N_InvCanKey";
        public const string Invalid_group_code_InvCanKey = "Invalid_group_code_InvCanKey";
        public const string Invalid_site_code_InvCanKey = "Invalid_site_code_InvCanKey";
        public const string Invoice_Cancellation_No_Can_Not_Be_Blank_InvCanKey = "Invoice_Cancellation_No_Can_Not_Be_Blank_InvCanKey";
        public const string Invoice_Cancellation_Number_Already_Exist_InvCanKey = "Invoice_Cancellation_Number_Already_Exist_InvCanKey";
        public const string Invoices_Cancellation_Date_cannot_be_greater_than_InvCanKey = "Invoices_Cancellation_Date_cannot_be_greater_than_InvCanKey";
        public const string Invoices_Cancellation_Date_must_be_Between_InvCanKey = "Invoices_Cancellation_Date_must_be_Between_InvCanKey";
        public const string Reason_For_DC_Code_Value_Does_Not_Exist_in_Codes_Master_InvCanKey = "Reason_For_DC_Code_Value_Does_Not_Exist_in_Codes_Master_InvCanKey";
        public const string CustomerCode_Does_not_exist_In_Invoice_InvCanKey = "CustomerCode_Does_not_exist_In_Invoice_InvCanKey";
        public const string Sales_Posting_of_Excise_entry_is_done_so_do_not_allow_to_invoice_cancellation_InvCanKey = "Sales_Posting_of_Excise_entry_is_done_so_do_not_allow_to_invoice_cancellation_InvCanKey";

        #endregion

        #region Copy Quotation Entry
        public const string NoActiveCustomerKey = "NoActiveCustomerKey";
        public const string NoQuotationLocationCodeKey = "NoQuotationLocationCodeKey";
        public const string NoLocationExistKey = "NoLocationExistKey";
        public const string NoGroupCodeExistKey = "NoGroupCodeExistKey";
        public const string Quotation_No_Created_key = "Quotation_No_Created_key";
        public const string QuotationNoisNotExistsKey = "QuotationNoisNotExistsKey";
        #endregion

        #region Delivery Challan Cancellation
        public const string No_Pending_DC_Found_For_DC_Cancellation_Till_DateKey = "No_Pending_DC_Found_For_DC_Cancellation_Till_DateKey";
        public const string Sales_Delivey_Challan_Cancellation_order_saved_successfullyKey = "Sales_Delivey_Challan_Cancellation_order_saved_successfullyKey";
        public const string DeliveryChallanCancellationNumberAlreadyExistKey = "DeliveryChallanCancellationNumberAlreadyExistKey";
        #endregion

        #region Packing Slip Entry
        public const string Enter_Site_Code = "Enter_Site_Code";
        public const string Enter_Group_Code = "Enter_Group_Code";
        public const string Value_of_control_property_should_be_NUMBER = "Value_of_control_property_should_be_NUMBER";
        public const string Value_of_control_property_should_be_SHOW = "Value_of_control_property_should_be_SHOW";
        public const string Serial_Number_can_not_be_blank = "Serial_Number_can_not_be_blank";
        public const string Case_Type_can_not_be_blank = "Case_Type_can_not_be_blank";
        public const string Case_Description_can_not_be_blank = "Case_Description_can_not_be_blank";
        public const string Net_weight_can_not_be_blank = "Net_weight_can_not_be_blank";
        public const string Gross_weight_can_not_be_blank = "Gross_weight_can_not_be_blank";
        public const string Packing_Quantity_can_not_be_blank = "Packing_Quantity_can_not_be_blank";
        public const string Packing_Slip_Successfully_Updated_for_Invoice_Number = "Packing_Slip_Successfully_Updated_for_Invoice_Number";
        public const string Packing_Slip_Successfully_Saved_for_Invoice_Number = "Packing_Slip_Successfully_Saved_for_Invoice_Number";
        #endregion

        #region Order Ack Entry
        public const string OAF_Number_Already_Exists = "OAF_Number_Already_Exists";
        public const string Invalid_OAF_Number_OAF_NotExists = "Invalid_OAF_Number_OAF_NotExists";
        public const string sal_slbk_oaf_createdkey = "sal_slbk_oaf_createdkey";
        #endregion

        #region Delivery Challan Update

        public const string Customer_Referance_Date_should_not_be_blank_DCUKey = "Customer_Referance_Date_should_not_be_blank_DCUKey";
        public const string Customer_Number_should_not_be_blank_DCUKey = "Customer_Number_should_not_be_blank_DCUKey";
        public const string Doc_Number_Is_Not_Exists_For_Edit_DCUKey = "Doc_Number_Is_Not_Exists_For_Edit_DCUKey";
        public const string Invalid_DCId_DCUKey = "Invalid_DCId_DCUKey";

        #endregion

        #region CCN Entry
        public const string CCNAlready_Exist_For_SJO_Key = "CCNAlready_Exist_For_SJO_Key#{0}"; //CCN already exists for SJO: {0} / {1} / {2} / {3} for Delete
        public const string Select_Atleast_One_Record_From_Grid_Key = "Select_Atleast_One_Record_From_Grid_Key"; //"Please select at least one record from the Grid!";
        public const string Use_Generate_BOM_Parent_Not_Freezed_Key = "Use_Generate_BOM_Parent_Not_Freezed_Key"; // "Please use generate BOM because parent is not freezed.";
        public const string Only_One_Non_Vendor_Suuplied_Child_Cannot_Delete_Key = "Only_One_Non_Vendor_Suuplied_Child_Cannot_Delete_Key"; // "There Is Only One Non Vendor Supplied Child So You Can Not Delete This Child";
        public const string Child_Code_Cannot_Be_Same_As_Parent_Key = "Child_Code_Cannot_Be_Same_As_Parent_Key";//"Child Code cannot be same as Parent Code";
        public const string Please_Select_Change_Required_By_Key = "Please_Select_Change_Required_By_Key";// "Please Select Change Require By";
        public const string Parent_Code_Has_Only_One_Child_In_CBOM_Key = "Parent_Code_Has_Only_One_Child_In_CBOM_Key#{0}";//"Parent Code has only one child in CBOM of SJO: ";


        public const string Please_Enter_Reason_Code_When_Change_Required_By_Is_Internal_Key = "Please_Enter_Reason_Code_When_Change_Required_By_Is_Internal_Key";//"Please Enter Reason Code When You Select Change Require By Is Internal";
        public const string Please_Enter_Remark_When_Change_Required_By_Is_Internal_Key = "Please_Enter_Remark_When_Change_Required_By_Is_Internal_Key";//"Please Enter Remark When You Select Change Require By Is Internal";
        public const string Please_Enter_Sales_Order_Detail_When_Change_Required_By_Is_Customer_Key = "Please_Enter_Sales_Order_Detail_When_Change_Required_By_Is_Customer_Key"; //"Please Enter Sales Order Details When You Select Change Require By Is Customer";
        public const string Old_Qty_And_New_Qty_Same_So_Cannot_Proceed_Key = "Old_Qty_And_New_Qty_Same_So_Cannot_Proceed_Key";//"Old and New Qty/Pieces are Same,So You can not Proceed further!";
        public const string Work_Order_Listed_Have_Been_Made_By_More_Qty_Than_Replace_Qty_Hence_Cannot_Proceed_Key = "Work_Order_Listed_Have_Been_Made_By_More_Qty_Than_Replace_Qty_Hence_Cannot_Proceed_Key";//"Work Orders Listed Below have been made by more Quantity than Replace Quantity For Child Item Code of Selected Position,hence you can not Proceed further";
        public const string Replace_Qty_Cannot_Be_Less_Than_Consumption_Qty_For_Child_So_Cannot_Proceed_Key = "Replace_Qty_Cannot_Be_Less_Than_Consumption_Qty_For_Child_So_Cannot_Proceed_Key";//"Replace Quantity Can not be less than Total Consumption Quantity For Child Item Code of Selected Position,hence you can not Proceed further";
        public const string Replace_Qty_Is_Less_Than_Total_Issued_Qty_for_Child_Key = "Replace_Qty_Is_Less_Than_Total_Issued_Qty_for_Child_Key";//"Replace Quantity is less than Total Issued Quantity For Child Item Code of Selected Position!";
        public const string Replace_Qty_Is_Greater_Than_Total_Issued_Qty_for_Child_Key = "Replace_Qty_Is_Greater_Than_Total_Issued_Qty_for_Child_Key";//"Replace Quantity is greater than Total Issued Quantity For Child Item Code of Selected Position!!";
        public const string Labour_Jov_Gate_Pass_Made_Of_More_Qty_Than_Replace_Qty_For_Child_Key = "Labour_Jov_Gate_Pass_Made_Of_More_Qty_Than_Replace_Qty_For_Child_Key";//"Labour Job Gate Pass has made of more Quantity then Replace Quantity For Child Item Code of Selected Position!!";
        public const string Sub_Contracting_GRN_Has_Been_Made_For_Child_So_Cannot_Proceed_Key = "Sub_Contracting_GRN_Has_Been_Made_For_Child_So_Cannot_Proceed_Key";//"Sub Contracting GRN has been made for Selected Child Item Code,hence you can not Proceed further";
        public const string Parent_Code_Only_One_Child_CBOM_Key = "Parent_Code_Only_One_Child_CBOM_Key#{0}"; //Parent Code has only one child in CBOM of SJO: {0} / {1} / {2} / {3} and hence deletion under this Parent is not possible.";;
        public const string Parent_Item_Is_Already_In_SJO_Key = "Parent_Item_Is_Already_In_SJO_Key#{0}"; //Parent item is already done in SJO: {0} / {1} / {2} / {3}"; 
        public const string Allocation_Already_Done_In_SJO_Key = "Allocation_Already_Done_In_SJO_Key#{0}"; //Allocation is already done in SJO:  {0} / {1} / {2} / {3}";
        public const string Item_Already_Issued_In_SJO_Key = "Item_Already_Issued_In_SJO_Key#{0}"; //Item already issued in SJO: {0} / {1} / {2} / {3}
        public const string Child_Already_Exsit_On_Entered_Pos_In_UnAuthorized_CCN_Key = "Child_Already_Exsit_On_Entered_Pos_In_UnAuthorized_CCN_Key#{0}"; //Child already exist on entered Position number in unauthorized CCN for SJO: {0} / {1} / {2} / {3};
        public const string Entered_Item_Code_does_not_exist_in_Item_Master = "Entered_Item_Code_does_not_exist_in_Item_Master";
        public const string Child_Already_Exsit_On_Entered_Pos_UnderParentCode_CCN_Key = "Child_Already_Exsit_On_Entered_Pos_UnderParentCode_CCN_Key#{0}";
        public const string CCN_Already_Exists_For_SJO_Key = "CCN_Already_Exists_For_SJO_Key#{0}"; //CCN already exists for SJO: {0} / {1} / {2} / {3} for Replace.
        public const string CCN_Already_Exists_For_SJO_Key_For_Change_Qty_Key = "CCN_Already_Exists_For_SJO_Key#{0}"; //CCN already exists for SJO: {0} / {1} / {2} / {3} for chnage qty.
        public const string Entered_Pos_Not_Present_Key = "Entered_Pos_Not_Present_Key#{0}"; // Entered Position number not present in SJO: {0} / {1} / {2} / {3} for Replace.
        public const string Want_To_allow_Internal_Note_Even_Production_Booked_Key = "Want_To_allow_Internal_Note_Even_Production_Booked_Key#{0} "; // Want to allow Internal return note even though Production is booked is set to Yes. Child Code: {0} is issued and Labour Production is booked. Hence deletion under this parent is not allowed.";
        public const string CCN_Date_Can_not_be_greater_than = "CCN_Date_Can_not_be_greater_than#{0}";
        public const string Ccn_date_must_be_between = "Ccn_date_must_be_between#{0}";
        public const string eng_prodstrumain_ccnentry_created_key = "eng_prodstrumain_ccnentry_created_key";

        #endregion

        #region Delivery Challan for Rejection
        public const string sale_saledp_dcsales_DCEntrysavedKey = "sale_saledp_dcsales_DCEntrysavedKey";
        public const string DCEntrydetailssuccessfullysavedKey = "DCEntrydetailssuccessfullysavedKey";
        public const string sale_saledp_dcsales_UpdateDCKey = "sale_saledp_dcsales_UpdateDCKey";
        public const string DCRejEntrydetailssuccessfullysavedKey = "DCRejEntrydetailssuccessfullysavedKey";
        #endregion

        #region Sales Order Cancellation
        public const string sales_saledispatch_canelsale_PleaseCheckReport = "sales_saledispatch_canelsale_PleaseCheckReport";
        #endregion

        #region Quotation Entry
        public const string AutoNumberRequired_field_should_be_Y_or_N_QEKey = "AutoNumberRequired_field_should_be_Y_or_N_QEKey";
        public const string SiteRequired_field_should_be_Y_or_N_QEKey = "SiteRequired_field_should_be_Y_or_N_QEKey";
        public const string AuthorizationRequired_field_should_be_Y_or_N_QEKey = "AuthorizationRequired_field_should_be_Y_or_N_QEKey";
        public const string No_Item_Found_For_Authorize_QEKey = "No_Item_Found_For_Authorize_QEKey";
        public const string Invalid_QuotationId_QEKey = "Invalid_QuotationId_QEKey";
        public const string Invalid_QuotationSiteId_QEKey = "Invalid_QuotationSiteId_QEKey";
        public const string QuotationDetails_not_found_QEKey = "QuotationDetails_not_found_QEKey";
        public const string Project_Item_Code_Can_Not_Be_Blank_QEKey = "Project_Item_Code_Can_Not_Be_Blank_QEKey";
        public const string Invalid_Project_Item_Code_QEKey = "Invalid_Project_Item_Code_QEKey";
        public const string Invalid_Customer_Code_QEKey = "Invalid_Customer_Code_QEKey";
        public const string Invalid_Bill_To_QEKey = "Invalid_Bill_To_QEKey";
        public const string Invalid_Salesman_Code_QEKey = "Invalid_Salesman_Code_QEKey";
        public const string Year_should_not_be_blank_QEKey = "Year_should_not_be_blank_QEKey";
        public const string Invalid_Year_QEKey = "Invalid_Year_QEKey";
        public const string Year_should_be_in_YY_YY_format_QEKey = "Year_should_be_in_YY_YY_format_QEKey";
        public const string Quotation_Group_Code_not_Found_QEKey = "Quotation_Group_Code_not_Found_QEKey";
        public const string Quotation_Site_Code_Not_Found_QEKey = "Quotation_Site_Code_Not_Found_QEKey";
        public const string Quotation_Number_can_not_be_null_blank_QEKey = "Quotation_Number_can_not_be_null_blank_QEKey";
        public const string Quotation_with_same_quotation_number_already_exists_QEKey = "Quotation_with_same_quotation_number_already_exists_QEKey";
        public const string Quotation_Number_Not_Found_QEKey = "Quotation_Number_Not_Found_QEKey";
        public const string Quotation_Date_cannot_be_greater_than_QEKey = "Quotation_Date_cannot_be_greater_than_QEKey";
        public const string Quotation_Date_must_be_greater_than_Inquiry_Date_QEKey = "Quotation_Date_must_be_greater_than_Inquiry_Date_QEKey";
        public const string Quotation_Date_must_Exist_in_Current_Period_Date_From_To_QEKey = "Quotation_Date_must_Exist_in_Current_Period_Date_From_To_QEKey";
        public const string Submitted_Date_must_be_greater_than_or_equal_to_Quotation_Date_QEKey = "Submitted_Date_must_be_greater_than_or_equal_to_Quotation_Date_QEKey";
        public const string Revision_Date_can_not_be_null_blank_QEKey = "Revision_Date_can_not_be_null_blank_QEKey";
        public const string Revision_Date_cannot_be_greater_than_todays_date_QEKey = "Revision_Date_cannot_be_greater_than_todays_date_QEKey";
        public const string Revision_Date_can_not_be_less_than_Quotation_Date_QEKey = "Revision_Date_can_not_be_less_than_Quotation_Date_QEKey";
        public const string Revision_Date_must_Exist_in_Current_Period_Date_From_To_QEKey = "Revision_Date_must_Exist_in_Current_Period_Date_From_To_QEKey";
        public const string Reason_Remark_can_not_be_null_or_blank_if_Quotation_status_is_Regret_Lost_or_Cancel = "Reason_Remark_can_not_be_null_or_blank_if_Quotation_status_is_Regret_Lost_or_Cancel";
        public const string Currency_code_does_not_exist = "Currency_code_does_not_exist";
        public const string System_Flag_details_not_found = "System_Flag_details_not_found";
        public const string Sales_item_code_should_not_be_blank_at_row_1_Alternatively_please_set_Quotation_Authorization_Required_Flag_to_Yes_to_save_Quotation_without_Sales_Item_QEKey = "Sales_item_code_should_not_be_blank_at_row_1_Alternatively_please_set_Quotation_Authorization_Required_Flag_to_Yes_to_save_Quotation_without_Sales_Item_QEKey";
        public const string Sales_item_code_should_not_be_blank_at_row_QEKey = "Sales_item_code_should_not_be_blank_at_row_QEKey";
        public const string Service_Type_Item_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order_QEKey = "Service_Type_Item_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order_QEKey";
        public const string QtySUOM_should_not_be_blank_or_Zero_at_row_QEKey = "QtySUOM_should_not_be_blank_or_Zero_at_row_QEKey";
        public const string Basic_Price_SUOM_should_not_be_blank_or_Zero_at_row_QEKey = "Basic_Price_SUOM_should_not_be_blank_or_Zero_at_row_QEKey";
        public const string Rate_Structure_Code_should_not_be_blank_at_row_QEKey = "Rate_Structure_Code_should_not_be_blank_at_row_QEKey";
        public const string Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot_QEKey = "Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot_QEKey";
        public const string Sales_Item_Code_not_found_in_Sales_Item_Master = "Sales_Item_Code_not_found_in_Sales_Item_Master";
        public const string The_selected_item_is_deactivated_You_cannot_save_the_data = "The_selected_item_is_deactivated_You_cannot_save_the_data";
        public const string The_selected_items_Invoice_Type_is_Lot_and_conversion_fector_is_not_equal_to_1 = "The_selected_items_Invoice_Type_is_Lot_and_conversion_fector_is_not_equal_to_1";
        public const string Item_is_linked_with_Internal_Item_and_having_Dispatch_Without_Mfg_Flag_Yes_So_Items_Invoice_Type_must_be_Lot_Please_delete_item_or_do_entry_again_with_proper_Invoice_Type = "Item_is_linked_with_Internal_Item_and_having_Dispatch_Without_Mfg_Flag_Yes_So_Items_Invoice_Type_must_be_Lot_Please_delete_item_or_do_entry_again_with_proper_Invoice_Type";
        public const string Item_is_linked_with_Internal_Item_and_having_Dispatch_Without_Mfg_Flag_No_So_Items_Invoice_Type_must_be_Regular_Please_delete_item_or_do_entry_again_with_proper_Invoice_Type = "Item_is_linked_with_Internal_Item_and_having_Dispatch_Without_Mfg_Flag_No_So_Items_Invoice_Type_must_be_Regular_Please_delete_item_or_do_entry_again_with_proper_Invoice_Type";
        public const string Service_Type_Item_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order = "Service_Type_Item_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order";
        public const string Duplicate_sales_item_not_allowed_QEKey = "Duplicate_sales_item_not_allowed_QEKey";
        public const string Discount_value_can_not_be_zero_or_blank_QEKey = "Discount_value_can_not_be_zero_or_blank_QEKey";
        public const string Discount_Value_entered_is_not_allowed_QEKey = "Discount_Value_entered_is_not_allowed_QEKey";
        public const string Total_Amount_After_Disc_Customer_Currency_can_not_be_greater_than_99999999999_QEKey = "Total_Amount_After_Disc_Customer_Currency_can_not_be_greater_than_99999999999_QEKey";
        public const string Total_Amount_After_Tax_Customer_Currency_can_not_be_greater_than_99999999999_QEKey = "Total_Amount_After_Tax_Customer_Currency_can_not_be_greater_than_99999999999_QEKey";
        public const string Agent_Code_cannot_be_blank_QEKey = "Agent_Code_cannot_be_blank_QEKey";
        public const string Invalid_Agent_Code_QEKey = "Invalid_Agent_Code_QEKey";
        public const string Item_Basic_Price_can_not_be_less_than_to_Agent_Commision_Value_QEKey = "Item_Basic_Price_can_not_be_less_than_to_Agent_Commision_Value_QEKey";
        public const string Agent_Commision_Value_can_not_be_zero_QEKey = "Agent_Commision_Value_can_not_be_zero_QEKey";
        public const string You_select_agent_Associate_Quotation_So_please_give_Agent_Commision_Value_for_atleast_one_Item_QEKey = "You_select_agent_Associate_Quotation_So_please_give_Agent_Commision_Value_for_atleast_one_Item_QEKey";
        public const string Subject_can_not_be_null_or_blank_QEKey = "Subject_can_not_be_null_or_blank_QEKey";
        public const string Only_NonExcisable_Rate_Structure_is_Allowed_For_ItemCode_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order = "Only_NonExcisable_Rate_Structure_is_Allowed_For_ItemCode_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order";
        public const string Total_Amount_After_Tax_Domestic_Currency_Amount_mismatch_QEKey = "Total_Amount_After_Tax_Domestic_Currency_Amount_mismatch_QEKey";
        public const string Total_Amount_After_Tax_Customer_Currency_Amount_mismatch_QEKey = "Total_Amount_After_Tax_Customer_Currency_Amount_mismatch_QEKey";
        public const string Total_Amount_After_Discount_Customer_Currency_Amount_mismatch_QEKey = "Total_Amount_After_Discount_Customer_Currency_Amount_mismatch_QEKey";
        public const string Qty_IUOM_Amount_mismatch_for_sales_item_QEKey = "Qty_IUOM_Amount_mismatch_for_sales_item_QEKey";
        public const string Basic_Price_IUOM_Amount_mismatch_for_sales_item_QEKey = "Basic_Price_IUOM_Amount_mismatch_for_sales_item_QEKey";
        public const string Discount_Amount_mismatch_for_sales_item_QEKey = "Discount_Amount_mismatch_for_sales_item_QEKey";
        public const string Item_Amount_After_Discount_mismatch_for_sales_item_QEKey = "Item_Amount_After_Discount_mismatch_for_sales_item_QEKey";
        public const string Rate_Amount_mismatch_for_sales_item_Rate_code_QEKey = "Rate_Amount_mismatch_for_sales_item_Rate_code_QEKey";
        public const string Period_end_settings_not_done_for_entered_site_code_QEKey = "Period_end_settings_not_done_for_entered_site_code_QEKey";
        #endregion

        #region PO Print
        public const string POPrint_Should_Be_Final_Key = "POPrint_Should_Be_Final_Key";

        #endregion

        #region class Sub Class 
        public const string Selected_Class_SubClass_Is_Used_So_It_Can_Not_be_Deleted = "Selected_Class_SubClass_Is_Used_So_It_Can_Not_be_Deleted";
        public const string Selected_Class_Is_Use_In_Item_Master = "Selected_Class_Is_Use_In_Item_Master";

        #endregion

        #region Caption Control
        public const string admn_admmaster_statcapdetail_CaptionIDUsedKey = "admn_admmaster_statcapdetail_CaptionIDUsedKey";
        #endregion

        #region Schedule VI Group Master
        public const string Used_in_account_master_So_can_not_be_deleted = "Used_in_account_master_So_can_not_be_deleted";
        #endregion

        #region Process Sheet master
        public const string eng_mast_process_timeinp_leadtimeexceedkey = "eng_mast_process_timeinp_leadtimeexceedkey";
        public const string eng_mast_process_timeinp_settingtimeexceedkey = "eng_mast_process_timeinp_settingtimeexceedkey";
        public const string eng_mast_process_timeinp_operationtimeexceedkey = "eng_mast_process_timeinp_operationtimeexceedkey";
        #endregion

        #region QC Entry for GRN
        public const string Please_Define_Rejection_Warehouse_in_Entered_Site_Code_Combination = "Please_Define_Rejection_Warehouse_in_Entered_Site_Code_Combination";
        public const string Item_Code_GRN_Number_and_Po_Number_Combination_Entry_Of_QC_is_Still_Pending_For_Authorization_So_First_Authorize_this_QC_entries = "Item_Code_GRN_Number_and_Po_Number_Combination_Entry_Of_QC_is_Still_Pending_For_Authorization_So_First_Authorize_this_QC_entries";
        public const string qc_qcfunctions_qcentrygrn_CreatedKey = "qc_qcfunctions_qcentrygrn_CreatedKey";

        #endregion

        #region QC for GRN of DC General
        public const string quality_qualitytrans_qcofdcgen_CreatedKey = "quality_qualitytrans_qcofdcgen_CreatedKey";
        public const string Save_key = "Save_Key";
        #endregion

        #region work order Maintenance
        public const string planning_planningtrans_orkorders_WorkorderCreated = "planning_planningtrans_orkorders_WorkorderCreated";
        public const string planning_planningtrans_orkorders_WorkorderUpdated = "planning_planningtrans_orkorders_WorkorderUpdated";
        #endregion
        #region Sales Invoice
        public const string sales_salesdispatch_salesinvoice_siCreated = "sales_salesdispatch_salesinvoice_siCreated";
        public const string sales_salesdispatch_salesinvoice_siUpdated = "sales_salesdispatch_salesinvoice_siUpdated";
        public const string SalesInvoiceNo_Exist_Key = "SalesInvoiceNo_Exist_Key";
        #endregion

        #region Inquiry Entry
        public const string Inquiry_details_SavedKey = "Inquiry_details_SavedKey";
        public const string Project_item_code_can_not_blank_IEKey = "Project_item_code_can_not_blank_IEKey";
        public const string Please_Enter_Valid_Project_Item_Code_IEKey = "Please_Enter_Valid_Project_Item_Code_IEKey";
        public const string Invalid_customer_code_IEKey = "Invalid_customer_code_IEKey";
        public const string Invalid_salesman_code_IEKey = "Invalid_salesman_code_IEKey";
        public const string Item_Code_can_not_blank_IEKey = "Item_Code_can_not_blank_IEKey";
        public const string Currency_Code_can_not_blank_IEKey = "Currency_Code_can_not_blank_IEKey";
        public const string Quantity_can_not_blank_IEKey = "Quantity_can_not_blank_IEKey";
        public const string Basic_Price_can_not_blank_IEKey = "Basic_Price_can_not_blank_IEKey";
        public const string Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot_IEKey = "Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot_IEKey";
        public const string Sales_Item_Code_not_found_in_Sales_Item_Master_IEKey = "Sales_Item_Code_not_found_in_Sales_Item_Master_IEKey";
        public const string Either_of_the_selected_items_are_deactivated_IEKey = "Either_of_the_selected_items_are_deactivated_IEKey";
        #endregion

        #region GRN Without PO 
        public const string GRNWithoutPOCreated = "GRNWithoutPOCreated";
        public const string GRNWithoutPOUpdate = "GRNWithoutPOUpdate";
        public const string GRNWithoutPODeleted = "GRNWithoutPODeleted";
        public const string Invalid_GRNWPO_GroupCode_Key = "Invalid_GRNWPO_GroupCode_Key";
        public const string Invalid_GRNWPO_DetailsItem_Key = "Invalid_GRNWPO_DetailsItem_Key";
        #endregion
        #region GRN entry
        public const string GRNCreated = "GRNCreated";
        public const string GRNUpdate = "GRNUpdate";
        public const string GRNDeleted = "GRNDeleted";
        public const string stores_inward_grn_challan_no_is_already_used_key = "stores_inward_grn_challan_no_is_already_used_key";
        public const string stores_inward_grn_invoice_no_is_already_used_key = "stores_inward_grn_invoice_no_is_already_used_key";
        #endregion
        #region SJO Packing entry
        public const string SJOPackCreated = "SJOPackingCreated";
        public const string SJOPackUpdate = "SJOPackingUpdate";
        #endregion
        #region Forecast Order
        public const string pln_salesshopodr_forcastodr_CreatedKey = "pln_salesshopodr_forcastodr_CreatedKey";
        #endregion

        #region Vendor rejection Note
        public const string VrDate_Between_financial_year_Key = "VrDate_Between_financial_year_Key"; // Vendor Rejection Date Should Fall In Current Period Between {0}
        public const string RejQty_CanNotBeBlank_Key = "RejQty_CanNotBeBlank_Key"; // Rejected Qty Can not be Blank Or Zero
        public const string PUOM_Invalid_Key = "PUOM_Invalid_Key"; //PUOM Can not be Blank.
        public const string Rej_warehouse_Notexists_Key = "Rej_warehouse_Notexists_Key"; //For this site first create rejection warehouse from Warehouse Master.
        public const string VRGroupCode_NotFound_Key = "VRGroupCode_NotFound_Key"; //Entered Vendor Rejection Group Code not Found
        public const string VRRejNumber_Exist_Key = "VRRejNumber_Exist_Key";//Vendor Rejection No Already Exist;
        public const string PeriodEndSettingNotDone_Key = "PeriodEndSettingNotDone_Key";//Period end settings not done for entered site code!
        public const string VRCode_NotFound_Key = "VRCode_NotFound_Key"; //Entered Vendor Code not Found
        public const string SiteCode_NotFound_Key = "SiteCode_NotFound_Key";  //Entered Vendor Rejection Site Code not Found
        public const string VendorRejectionNumber_Required_Key = "VendorRejectionNumber_Required_Key";//Please Enter Vendor Rejection No
        public const string ItemPUOMComb_NotFound_Key = "ItemPUOMComb_NotFound_Key";//Item code and PUOM Combination Not Found;
        public const string vrn_eng_sales_salesdispatch_CreatedKey = "vrn_eng_sales_salesdispatch_CreatedKey";
        public const string vrn_WarehouseId_Can_Not_Be_Blank = "vrn_WarehouseId_Can_Not_Be_Blank"; //"WarehouseId Can Not Be Blank"
        public const string vrn_Warehouse_Code_Can_Not_Be_Blank = "vrn_Warehouse_Code_Can_Not_Be_Blank"; //Warehouse Code Can Not Be Blank"
        public const string vrn_Item_Code_Can_not_be_Blank_Null = "vrn_Item_Code_Can_not_be_Blank_Null"; //Item Code Can not be Blank

        public const string RejIUOMQty_CanNotBeBlank_Key = "RejIUOMQty_CanNotBeBlank_Key";//Rejected IUOM Qty Can Not Be Zero!;
        public const string StkonHandZero_Key = "StkonHandZero_Key";//Stock Onhand Qauntity is Zero So You Can Not Do Vendor Rejection For This Item Combination";
        public const string StkonHandNotProper_Key = "StkonHandNotProper_Key"; //Stock onhand Qauntity is {0} Which is Less than Enter Qauntity So Please Enter Proper Qauntity Value";
        public const string SumNotExceed_Key = "SumNotExceed_Key";//The Sum of(Already Rejected IUOM + Rejected IUOM) must not exceed the Accepted Qty Of IUOM
        public const string IUOMinMultipleofFactor_Key = "IUOMinMultipleofFactor_Key";//QC Accepted IUOM Qty Must Be In Multiple Of Internal Conversion Factor {0}
        public const string RangeofWeight_Key = "RangeofWeight_Key";//"IUOM quantity weight should be in the range from {0} to {1} for entered PUOM quantity";
        public const string IUOMQtyNotValid_Key = "IUOMQtyNotValid_Key"; //Entered IUOM Qauntity is not Valid
        public const string RejIUOMQtyNotValid_Key = "RejIUOMQtyNotValid_Key";//Rejected IUOM Qty can not be greater than total Pending GRN Qty
        public const string vrn_Please_Insert_Atleast_One_Row_In_Item_Details = "vrn_Please_Insert_Atleast_One_Row_In_Item_Details";//Please Insert Atleast One Row In Item Details
        public const string vrn_Duplicate_Combination_Not_Allow = "vrn_Duplicate_Combination_Not_Allow";
        #endregion

        #region Item WareHouse Physical Bin
        //public const string Already_exist = "Alreadyexist";
        public const string Default_Yes = "DefaultYes";
        public const string Only_One_RowKey = "Only_One_RowKey";
        #endregion

        #region Inventory - OPBL Entry

        #endregion

        #region Internal Rejection Note
        public const string Quantity_key = "Quantity_key";
        #endregion

        #region Labour Production QC Entry
        public const string Internal_Rejection_Number_Already_Exist = "Internal_Rejection_Number_Already_Exist";
        public const string qc_qcfunctions_labprodqc_created = "qc_qcfunctions_labprodqc_created";
        #endregion

        #region Upload Code Master
        public const string dataupload_dataupload_uploadcodes_codetypeblankKey = "dataupload_dataupload_uploadcodes_codetypeblankKey";
        public const string dataupload_dataupload_uploadcodes_codevalblankKey = "dataupload_dataupload_uploadcodes_codevalblankKey";
        public const string dataupload_dataupload_uploadcodes_codetypecharlimit = "dataupload_dataupload_uploadcodes_codetypecharlimit";
        public const string dataupload_dataupload_uploadcodes_valcharlimit = "dataupload_dataupload_uploadcodes_valcharlimit";
        public const string dataupload_dataupload_uploadcodes_desccharlimit = "dataupload_dataupload_uploadcodes_desccharlimit";
        public const string dataupload_dataupload_uploadcodes_digitafterdecimalcharlimit = "dataupload_dataupload_uploadcodes_digitafterdecimalcharlimit";
        public const string dataupload_dataupload_uploadcodes_valdup = "dataupload_dataupload_uploadcodes_valdup";
        #endregion

        #region Allocation Work Order 
        public const string planning_planningtrans_allocationworkorders_Allocation_Qty_Must_Be_Positive = "planning_planningtrans_allocationworkorders_Allocation_Qty_Must_Be_Positive";
        public const string planning_planningtrans_allocationworkorders_Allocation_Qty_Must_Be_OnhandQty = "planning_planningtrans_allocationworkorders_Allocation_Qty_Must_Be_OnhandQty";
        public const string planning_planningtrans_allocationworkorders_Nodatatosave = "planning_planningtrans_allocationworkorders_Nodatatosave";
        public const string planning_planningtrans_allocationworkorders_Allocation_Qty_is_required = "planning_planningtrans_allocationworkorders_Allocation_Qty_is_required";
        public const string planning_planningtrans_allocationworkorders_AllocationnotgreaterthanMaxAlcQty = "planning_planningtrans_allocationworkorders_AllocationnotgreaterthanMaxAlcQty";
        public const string planning_planningtrans_allocationworkorders_Allocation_Item_Save = "planning_planningtrans_allocationworkorders_Allocation_Item_Save";
        #endregion

        #region Labour Production Entry
        public const string Please_Enter_End_Time = "Please Enter End Time!!!";
        public const string End_time_should_not_be_less_then_Start_Time = "End_time_should_not_be_less_then_Start_Time";
        public const string In_This_Work_Order_Child_Detail_there_is_Not_Enough_Issue_Quantity = "In_This_Work_Order_Child_Detail_there_is_Not_Enough_Issue_Quantity";
        public const string Please_Enter_SetUp_Time_Or_Operation_Time = "Please_Enter_SetUp_Time_Or_Operation_Time";
        public const string production_prodtrans_laborproduction_created_key = "production_prodtrans_laborproduction_created_key";
        #endregion
        #region Miscellaneous Production Entry
       
        public const string prd_prodfunc_miscprod_created_key = "prd_prodfunc_miscprod_created_key";
        public const string prd_prodfunc_miscprod_updated_key = "prd_prodfunc_miscprod_updated_key";
        public const string prd_prodfunc_miscprod_deleted_key = "prd_prodfunc_miscprod_deleted_key";

        #endregion
        #region Issuewise Time Booking Entry

        public const string prd_prodfunc_isstimebook_created_key = "prd_prodfunc_isstimebook_created_key";
        public const string prd_prodfunc_isstimebook_updated_key = "prd_prodfunc_isstimebook_updated_key";
        public const string prd_prodfunc_isstimebook_deleted_key = "prd_prodfunc_isstimebook_deleted_key";

        #endregion

        #region Forecast order cancellation
        public const string planning_planningtrans_cancelforecastorder_PleaseCheckReport = "planning_planningtrans_cancelforecastorder_PleaseCheckReport";
        #endregion

        #region WWarehouse Inventory
        public const string Warehouse_code_does_not_exist_WIKey = "Warehouse_code_does_not_exist_WIKey";
        public const string Item_code_does_not_exist_WIKey = "Item_code_does_not_exist_WIKey";
        public const string You_can_Enter_Only_Capital_Type_Item_Code_With_Capital_Type_Warehouse_WIKey = "You_can_Enter_Only_Capital_Type_Item_Code_With_Capital_Type_Warehouse_WIKey";
        public const string You_can_Enter_Only_Scrap_Type_Item_Code_With_Scrap_Type_Warehouse_WIKey = "You_can_Enter_Only_Scrap_Type_Item_Code_With_Scrap_Type_Warehouse_WIKey";
        public const string Item_code_is_Non_KANBAN_Item_so_you_cannot_associate_it_with_Kanban_WareHouse_WIKey = "Item_code_is_Non_KANBAN_Item_so_you_cannot_associate_it_with_Kanban_WareHouse_WIKey";
        public const string Entered_warehouse_is_not_associated_with_this_Item_WIKey = "Entered_warehouse_is_not_associated_with_this_Item_WIKey";
        public const string You_can_Enter_Only_Capital_Type_Item__With_Capital_Type_Warehouse_WIKey = "You_can_Enter_Only_Capital_Type_Item__With_Capital_Type_Warehouse_WIKey";
        public const string You_can_Enter_Only_Scrap_Type_Warehouse_With_Scrap_Type_Item_Code_WIKey = "You_can_Enter_Only_Scrap_Type_Warehouse_With_Scrap_Type_Item_Code_WIKey";
        public const string Entered_warehouse_is_not_Capital_Type_WIKey = "Entered_warehouse_is_not_Capital_Type_WIKey";
        public const string Entered_warehouse_is_not_Scrap_Type_WIKey = "Entered_warehouse_is_not_Scrap_Type_WIKey";
        public const string Entered_warehouse_is_not_Kanban_Type_WIKey = "Entered_warehouse_is_not_Kanban_Type_WIKey";
        public const string You_can_Enter_Only_Capital_Type_Warehouse_With_Capital_Type_Item_Code_WIKey = "You_can_Enter_Only_Capital_Type_Warehouse_With_Capital_Type_Item_Code_WIKey";
        public const string Item_code_is_KANBAN_Item_so_you_cannot_associate_it_with_Non_Kanban_WareHouse_WIKey = "Item_code_is_KANBAN_Item_so_you_cannot_associate_it_with_Non_Kanban_WareHouse_WIKey";
        public const string Entered_Item_is_not_Capital_Type_WIKey = "Entered_Item_is_not_Capital_Type_WIKey";
        public const string Entered_Item__is_not_Scrap_Type_WIKey = "Entered_Item__is_not_Scrap_Type_WIKey";
        public const string Entered_Item_is_not_Kanban_Type_WIKey = "Entered_Item_is_not_Kanban_Type_WIKey";
        public const string You_can_Enter_Only_Kanban_Type_Item_Code_With_Kanban_Type_Warehouse_WIKey = "You_can_Enter_Only_Kanban_Type_Item_Code_With_Kanban_Type_Warehouse_WIKey";
        public const string Invalid_Warehouse_Code_WIKey = "Invalid_Warehouse_Code_WIKey";
        #endregion

        #region SJO Entry
        public const string planning_planningtrans_sjo_createKey = "planning_planningtrans_sjo_createKey";
        #endregion

        #region Auto Allocation
        public const string Select_One_Warehouse_for_AllocationKey = "Select_One_Warehouse_for_AllocationKey";
        public const string planning_planningtrans_autoallocation_createdKey = "planning_planningtrans_autoallocation_createdKey";
        public const string planning_planningtrans_autodeallocation_createdKey = "planning_planningtrans_autodeallocation_createdKey";
        #endregion

        #region Send Email Report
        public const string Mail_Send_Successfully_Key = "mail_send_successfully_key";
        public const string Mail_Send_Failed_Key = "mail_send_failed_key";
        #endregion

        #region Internal Return Note Entry
        public const string Work_Order_Receipt_is_pending_to_be_Authorised = "Work_Order_Receipt_is_pending_to_be_Authorised";
        #endregion

        #region Issue To Shop Floor

        public const string AutoNumberRequired_field_should_be_Y_or_N_ITSFKey = "AutoNumberRequired_field_should_be_Y_or_N_ITSFKey";
        public const string SiteRequired_field_should_be_Y_or_N_ITSFKey = "SiteRequired_field_should_be_Y_or_N_ITSFKey";
        public const string AuthorizationRequired_field_should_be_Y_or_N_ITSFKey = "AuthorizationRequired_field_should_be_Y_or_N_ITSFKey";
        public const string Invalid_year_ITSFKey = "Invalid_year_ITSFKey";
        public const string Invalid_group_code_ITSFKey = "Invalid_group_code_ITSFKey";
        public const string Invalid_site_code_ITSFKey = "Invalid_site_code_ITSFKey";
        public const string Issue_number_cannot_be_blank_ITSFKey = "Issue_number_cannot_be_blank_ITSFKey";
        public const string Issue_number_already_exist_ITSFKey = "Issue_number_already_exist_ITSFKey";
        public const string Issue_number_already_exist_in_Work_Order_Receipt_Entry_ITSFKey = "Issue_number_already_exist_in_Work_Order_Receipt_Entry_ITSFKey";
        public const string Issue_number_does_not_exist_ITSFKey = "Issue_number_does_not_exist_ITSFKey";
        public const string Invalid_IssueId_ITSFKey = "Invalid_IssueId_ITSFKey";
        public const string Issue_date_cannot_be_blank_ITSFKey = "Issue_date_cannot_be_blank_ITSFKey";
        public const string Issue_Date_cannot_be_greater_than_Today_Date_ITSFKey = "Issue_Date_cannot_be_greater_than_Today_Date_ITSFKey";
        public const string Issue_date_must_be_between_and_ITSFKey = "Issue_date_must_be_between_and_ITSFKey";
        public const string Issue_to_Employee_code_does_not_exist_ITSFKey = "Issue_to_Employee_code_does_not_exist_ITSFKey";
        public const string Issue_to_and_Issue_by_cannot_be_same_ITSFKey = "Issue_to_and_Issue_by_cannot_be_same_ITSFKey";
        public const string Issue_by_Employee_code_does_not_exist_ITSFKey = "Issue_by_Employee_code_does_not_exist_ITSFKey";
        public const string No_data_to_save_Please_enter_issue_qty_in_item_detail_grid_ITSFKey = "No_data_to_save_Please_enter_issue_qty_in_item_detail_grid_ITSFKey";
        public const string Issue_number_yet_not_authorized_for_the_item_and_warehouse_combination_ITSFKey = "Issue_number_yet_not_authorized_for_the_item_and_warehouse_combination_ITSFKey";
        public const string Issue_details_successfully_saved_Issue_document_number_ITSFKey = "Issue_details_successfully_saved_Issue_document_number_ITSFKey";
        public const string Consumable_Account_group_And_Code_Should_Not_Be_Null_In_Finances_Policy_ITSFKey = "Consumable_Account_group_And_Code_Should_Not_Be_Null_In_Finances_Policy_ITSFKey";

        #endregion

        #region SCIndent Entry
        public const string Entered_Indent_Number_not_Found = "Entered_Indent_Number_not_Found";
        public const string Entered_Indent_Number_Already_Exist = "Entered_Indent_Number_Already_Exist";
        #endregion

        #region Indent Entry

        public const string purchase_indents_indententry_createdkey = "purchase_indents_indententry_createdkey"; //Indent : Saved Successfully
        public const string purchase_indents_indententry_updatedkey = "purchase_indents_indententry_updatedkey";
        public const string purchase_indents_indententry_delete_success = "purchase_indents_indententry_delete_success";
        public const string purchase_indents_indententry_DeletedKey = "purchase_indents_indententry_delete_success";
        public const string purchase_indents_indententry_updated_key = "purchase_indents_indententry_updated_key";
        public const string purchase_indents_indententry_quantity_mismatch = "purchase_indents_indententry_quantity_mismatch";

        #endregion



        #region Copy Item Master
        public const string Item_Details_not_found_CIKey = "Item_Details_not_found_CIKey";
        public const string Item_Code_Can_Not_Be_Blank_CIKey = "Item_Code_Can_Not_Be_Blank_CIKey";
        public const string Description_cannot_be_blank_CIKey = "Description_cannot_be_blank_CIKey";
        public const string Invalid_Request = "Invalid_Request";
        #endregion

        #region SJO Short close
        public const string Short_Close_Could_Not_Done_Key = "Short_Close_Could_Not_Done_Key";
        #endregion

        #region Service Indent Entry
        public const string pur_ind_servind_serindent_no_not_exists_key = "pur_ind_servind_serindent_no_not_exists_key";
        public const string pur_ind_servind_serindent_created_key = "pur_ind_servind_serindent_created_key";
        public const string pur_ind_servind_itemgridisrequired_key = "pur_ind_servind_itemgridisrequired_key";
        public const string pur_ind_servind_itemdeliverygridisrequired_key = "pur_ind_servind_itemdeliverygridisrequired_key";

        #endregion

        #region Customer Supplied GRN Entry
        public const string staninv_standinvmain_cstsullgrnent_CSPGRNCreated = "staninv_standinvmain_cstsullgrnent_CSPGRNCreated";
        public const string staninv_standinvmain_cstsullgrnent_CSPGRNUpdate = "staninv_standinvmain_cstsullgrnent_CSPGRNUpdate";
        #endregion

        #region Sales Order Receipt Amendment Entry
        public const string sale_salebk_saleodramendre_Authorization_Pending_For_Delivery_Challan = "sale_salebk_saleodramendre_Authorization_Pending_For_Delivery_Challan";
        public const string sale_salebk_saleodramendre_Authorization_Pending_For_Sales_Invoices_Entry = "sale_salebk_saleodramendre_Authorization_Pending_For_Sales_Invoices_Entry";
        public const string sale_salebk_saleodramendre_Sales_Order_Amendment_details_successfully_inserted = "sale_salebk_saleodramendre_Sales_Order_Amendment_details_successfully_inserted";
        public const string sale_salebk_saleodramendre_AutoNumberRequired_field_should_be_Y_or_N = "sale_salebk_saleodramendre_AutoNumberRequired_field_should_be_Y_or_N";
        public const string sale_salebk_saleodramendre_SiteRequired_field_should_be_Y_or_N = "sale_salebk_saleodramendre_SiteRequired_field_should_be_Y_or_N";
        public const string sale_salebk_saleodramendre_AuthorizationRequired_field_should_be_Y_or_N = "sale_salebk_saleodramendre_AuthorizationRequired_field_should_be_Y_or_N";
        public const string sale_salebk_saleodramendre_System_Flag_details_not_found = "sale_salebk_saleodramendre_System_Flag_details_not_found";
        public const string sale_salebk_saleodramendre_Sales_Policy_details_not_found = "sale_salebk_saleodramendre_Sales_Policy_details_not_found";
        public const string sale_salebk_saleodramendre_Project_Item_Code_Can_Not_Be_Blank = "sale_salebk_saleodramendre_Project_Item_Code_Can_Not_Be_Blank";
        public const string sale_salebk_saleodramendre_Please_Enter_Valid_Project_Item_Code = "sale_salebk_saleodramendre_Please_Enter_Valid_Project_Item_Code";
        public const string sale_salebk_saleodramendre_Salesman_0_does_not_exists_in_employee_master = "sale_salebk_saleodramendre_Salesman_0_does_not_exists_in_employee_master";
        public const string sale_salebk_saleodramendre_Sales_Order_Amendment_Group_can_not_be_null_or_blank = "sale_salebk_saleodramendre_Sales_Order_Amendment_Group_can_not_be_null_or_blank";
        public const string sale_salebk_saleodramendre_Group_Code_not_Found = "sale_salebk_saleodramendre_Group_Code_not_Found";
        public const string sale_salebk_saleodramendre_You_should_be_enter_reason_code = "sale_salebk_saleodramendre_You_should_be_enter_reason_code";
        public const string sale_salebk_saleodramendre_Site_Code_can_not_be_null_or_blank = "sale_salebk_saleodramendre_Site_Code_can_not_be_null_or_blank";
        public const string sale_salebk_saleodramendre_Site_code_not_found_in_location_master = "sale_salebk_saleodramendre_Site_code_not_found_in_location_master";
        public const string sale_salebk_saleodramendre_Amendment_Site_Code_must_be_same_as_Internal_Order_Site_Code_in_sales_order_Details = "sale_salebk_saleodramendre_Amendment_Site_Code_must_be_same_as_Internal_Order_Site_Code_in_sales_order_Details";
        public const string sale_salebk_saleodramendre_Entered_Sales_Amendement_Site_Code_not_Found = "sale_salebk_saleodramendre_Entered_Sales_Amendement_Site_Code_not_Found";
        public const string sale_salebk_saleodramendre_Sales_Order_Amendment_Number_can_not_be_null_or_blank = "sale_salebk_saleodramendre_Sales_Order_Amendment_Number_can_not_be_null_or_blank";
        public const string sale_salebk_saleodramendre_Sales_Order_Amendment_Number_already_exists = "sale_salebk_saleodramendre_Sales_Order_Amendment_Number_already_exists";
        public const string sale_salebk_saleodramendre_Entered_Sales_Amendement_Number_Not_Found = "sale_salebk_saleodramendre_Entered_Sales_Amendement_Number_Not_Found";
        public const string sale_salebk_saleodramendre_Sales_Order_Amendment_Date_can_not_be_null_or_blank = "sale_salebk_saleodramendre_Sales_Order_Amendment_Date_can_not_be_null_or_blank";
        public const string sale_salebk_saleodramendre_Internal_Order_date_can_not_be_greater_than_Todays_Date = "sale_salebk_saleodramendre_Internal_Order_date_can_not_be_greater_than_Todays_Date";
        public const string sale_salebk_saleodramendre_Period_end_settings_not_done_for_entered_site_code = "sale_salebk_saleodramendre_Period_end_settings_not_done_for_entered_site_code";
        public const string sale_salebk_saleodramendre_Order_Reciept_Date_must_be_in_between_0_And_1 = "sale_salebk_saleodramendre_Order_Reciept_Date_must_be_in_between_0_And_1";
        public const string sale_salebk_saleodramendre_Order_Amendment_Date_must_be_greater_than_Sales_Order_date = "sale_salebk_saleodramendre_Order_Amendment_Date_must_be_greater_than_Sales_Order_date";
        public const string sale_salebk_saleodramendre_Bill_To_Should_not_be_Blank_Null = "sale_salebk_saleodramendre_Bill_To_Should_not_be_Blank_Null";
        public const string sale_salebk_saleodramendre_Please_Enter_Valid_Bill_To = "sale_salebk_saleodramendre_Please_Enter_Valid_Bill_To";
        public const string sale_salebk_saleodramendre_Currency_Code_of_Bill_To_should_be_same_as_previously_selected_Bill_To_currency_code = "sale_salebk_saleodramendre_Currency_Code_of_Bill_To_should_be_same_as_previously_selected_Bill_To_currency_code";
        public const string sale_salebk_saleodramendre_Sales_item_code_should_not_be_blank_at_row_0 = "sale_salebk_saleodramendre_Sales_item_code_should_not_be_blank_at_row_0";
        public const string sale_salebk_saleodramendre_Sales_Item_Code_0_not_found_in_Sales_Item_Master = "sale_salebk_saleodramendre_Sales_Item_Code_0_not_found_in_Sales_Item_Master";
        public const string sale_salebk_saleodramendre_Sales_Item_Code_0_is_deactivated_You_cannot_save_the_data = "sale_salebk_saleodramendre_Sales_Item_Code_0_is_deactivated_You_cannot_save_the_data";
        public const string sale_salebk_saleodramendre_Service_Type_Item_0_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order = "sale_salebk_saleodramendre_Service_Type_Item_0_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order";
        public const string sale_salebk_saleodramendre_Qty_SUOM_should_not_be_blank_at_row_0 = "sale_salebk_saleodramendre_Qty_SUOM_should_not_be_blank_at_row_0";
        public const string sale_salebk_saleodramendre_Rate_Structure_Code_should_not_be_blank_at_row_0 = "sale_salebk_saleodramendre_Rate_Structure_Code_should_not_be_blank_at_row_0";
        public const string sale_salebk_saleodramendre_Since_the_Item_is_Free_Supply_Basic_Prise_SUOM_will_be_1_only_and_Discount_Type_will_not_be_applicable = "sale_salebk_saleodramendre_Since_the_Item_is_Free_Supply_Basic_Prise_SUOM_will_be_1_only_and_Discount_Type_will_not_be_applicable";
        public const string sale_salebk_saleodramendre_Since_the_Item_is_Free_Supply_Discount_Type_will_not_be_applicable = "sale_salebk_saleodramendre_Since_the_Item_is_Free_Supply_Discount_Type_will_not_be_applicable";
        public const string sale_salebk_saleodramendre_You_can_not_Change_Chargeable_Non_Chargeable_Type_when_Item_Is_Free_Supply = "sale_salebk_saleodramendre_You_can_not_Change_Chargeable_Non_Chargeable_Type_when_Item_Is_Free_Supply";
        public const string sale_salebk_saleodramendre_Basic_Price_SUOM_should_not_be_Blank_or_0_at_row_0 = "sale_salebk_saleodramendre_Basic_Price_SUOM_should_not_be_Blank_or_0_at_row_0";
        public const string sale_salebk_saleodramendre_Old_Sales_Order_Reference_or_Customer_PO_Reference_cannot_be_blank = "sale_salebk_saleodramendre_Old_Sales_Order_Reference_or_Customer_PO_Reference_cannot_be_blank";
        public const string sale_salebk_saleodramendre_Customer_PO_Reference_is_already_entered_So_you_cannot_enter_Old_Sales_Order_Reference = "sale_salebk_saleodramendre_Customer_PO_Reference_is_already_entered_So_you_cannot_enter_Old_Sales_Order_Reference";
        public const string sale_salebk_saleodramendre_Internal_Item_Code_cannot_be_blank = "sale_salebk_saleodramendre_Internal_Item_Code_cannot_be_blank";
        public const string sale_salebk_saleodramendre_Reason_Code_cannot_be_blank = "sale_salebk_saleodramendre_Reason_Code_cannot_be_blank";
        public const string sale_salebk_saleodramendre_Old_OAF_Reference_or_Customer_PO_Reference_is_only_Applicable_for_Free_Supply = "sale_salebk_saleodramendre_Old_OAF_Reference_or_Customer_PO_Reference_is_only_Applicable_for_Free_Supply";
        public const string sale_salebk_saleodramendre_Agent_Commission_Value_can_not_be_Null_or_blank = "sale_salebk_saleodramendre_Agent_Commission_Value_can_not_be_Null_or_blank";
        public const string sale_salebk_saleodramendre_Item_Basic_Price_can_not_be_less_than_to_Agent_Commission_Value = "sale_salebk_saleodramendre_Item_Basic_Price_can_not_be_less_than_to_Agent_Commission_Value";
        public const string sale_salebk_saleodramendre_Please_Select_Changed_CBOM_As_NotApplicable_When_You_Select_Chargeable_Non_Chargeable_As_NotApplicable = "sale_salebk_saleodramendre_Please_Select_Changed_CBOM_As_NotApplicable_When_You_Select_Chargeable_Non_Chargeable_As_NotApplicable";
        public const string sale_salebk_saleodramendre_Please_Enter_Remark_When_You_Select_Chargeable_Non_Chargeable_Type = "sale_salebk_saleodramendre_Please_Enter_Remark_When_You_Select_Chargeable_Non_Chargeable_Type";
        public const string sale_salebk_saleodramendre_Basic_Price_SUOM_Must_be_Changed_When_You_Select_Chargeable_Non_Chargeable_Type = "sale_salebk_saleodramendre_Basic_Price_SUOM_Must_be_Changed_When_You_Select_Chargeable_Non_Chargeable_Type";
        public const string sale_salebk_saleodramendre_Item_Basic_Price_can_not_be_changed_When_You_Select_Chargeable_Non_Chargeable_Type_as_NotApplicable_or_No_Basic_Price_will_remain_as_Original_Basic_Price_only_ie_0 = "sale_salebk_saleodramendre_Item_Basic_Price_can_not_be_changed_When_You_Select_Chargeable_Non_Chargeable_Type_as_NotApplicable_or_No_Basic_Price_will_remain_as_Original_Basic_Price_only_ie_0";
        public const string sale_salebk_saleodramendre_Please_Select_Sales_Order_Type_as_Regular_Sales_Order_Only = "sale_salebk_saleodramendre_Please_Select_Sales_Order_Type_as_Regular_Sales_Order_Only";
        public const string sale_salebk_saleodramendre_Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot = "sale_salebk_saleodramendre_Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot";
        public const string sale_salebk_saleodramendre_Item_Amount_After_Discount_should_not_be_less_then_Already_Invoice_Basic_Value_when_items_Invoice_Type_is_Lot = "sale_salebk_saleodramendre_Item_Amount_After_Discount_should_not_be_less_then_Already_Invoice_Basic_Value_when_items_Invoice_Type_is_Lot";
        public const string sale_salebk_saleodramendre_You_select_agent_Associate_Quotation_So_please_give_Agent_Commission_Value_for_atleast_one_Item = "sale_salebk_saleodramendre_You_select_agent_Associate_Quotation_So_please_give_Agent_Commission_Value_for_atleast_one_Item";
        public const string sale_salebk_saleodramendre_Shipment_code_should_not_be_blank_at_row_0 = "sale_salebk_saleodramendre_Shipment_code_should_not_be_blank_at_row_0";
        public const string sale_salebk_saleodramendre_Diffrent_Shipment_Code_Can_Not_Be_Allowed_if_SO_Type_is_Sales_In_Transit_or_High_Sea_Sales_Order = "sale_salebk_saleodramendre_Diffrent_Shipment_Code_Can_Not_Be_Allowed_if_SO_Type_is_Sales_In_Transit_or_High_Sea_Sales_Order";
        public const string sale_salebk_saleodramendre_Discount_value_can_not_be_zero_or_blank = "sale_salebk_saleodramendre_Discount_value_can_not_be_zero_or_blank";
        public const string sale_salebk_saleodramendre_Discount_amount_in_percentage_can_not_be_greater_than_100 = "sale_salebk_saleodramendre_Discount_amount_in_percentage_can_not_be_greater_than_100";
        public const string sale_salebk_saleodramendre_Discount_Value_entered_is_not_allowed = "sale_salebk_saleodramendre_Discount_Value_entered_is_not_allowed";
        public const string sale_salebk_saleodramendre_Payment_Schedule_total_value_not_matching_with_Sales_Order_total_value = "sale_salebk_saleodramendre_Payment_Schedule_total_value_not_matching_with_Sales_Order_total_value";
        public const string sale_salebk_saleodramendre_Please_Enter_Cust_PO_number_OR_LOI_number = "sale_salebk_saleodramendre_Please_Enter_Cust_PO_number_OR_LOI_number";
        public const string sale_salebk_saleodramendre_Customer_PO_Number_already_exists = "sale_salebk_saleodramendre_Customer_PO_Number_already_exists";
        public const string sale_salebk_saleodramendre_Cust_PO_Date_can_not_be_null_blank = "sale_salebk_saleodramendre_Cust_PO_Date_can_not_be_null_blank";
        public const string sale_salebk_saleodramendre_Customer_PO_Date_can_not_be_greater_than_todays_date = "sale_salebk_saleodramendre_Customer_PO_Date_can_not_be_greater_than_todays_date";
        public const string sale_salebk_saleodramendre_Customer_PO_Date_can_not_be_greater_than_order_date = "sale_salebk_saleodramendre_Customer_PO_Date_can_not_be_greater_than_order_date";
        public const string sale_salebk_saleodramendre_LOI_Date_can_not_be_null_blank = "sale_salebk_saleodramendre_LOI_Date_can_not_be_null_blank";
        public const string sale_salebk_saleodramendre_LOI_Date_can_not_be_greater_than_todays_date = "sale_salebk_saleodramendre_LOI_Date_can_not_be_greater_than_todays_date";
        public const string sale_salebk_saleodramendre_LOI_Date_can_not_be_greater_than_order_date = "sale_salebk_saleodramendre_LOI_Date_can_not_be_greater_than_order_date";
        public const string sale_salebk_saleodramendre_Sales_Order_Reference_Number_Can_not_be_blank = "sale_salebk_saleodramendre_Sales_Order_Reference_Number_Can_not_be_blank";
        public const string sale_salebk_saleodramendre_Sales_Order_Reference_Number_already_exists = "sale_salebk_saleodramendre_Sales_Order_Reference_Number_already_exists";
        public const string sale_salebk_saleodramendre_Item_Basic_Price_can_not_be_less_than_to_Agent_Commision_Value = "sale_salebk_saleodramendre_Item_Basic_Price_can_not_be_less_than_to_Agent_Commision_Value";
        public const string sale_salebk_saleodramendre_Agent_Commision_Value_can_not_be_zero = "sale_salebk_saleodramendre_Agent_Commision_Value_can_not_be_zero";

        #endregion

        #region Labour Job GatePass Entry
        public const string subcon_gatepass_ljgp_createdKey = "subcon_gatepass_ljgp_createdKey";
        public const string subcon_gatepass_ljgp_updatedKey = "subcon_gatepass_ljgp_updatedKey";
        public const string subcon_gatepass_ljgp_deletedKey = "subcon_gatepass_ljgp_deletedKey";
        #endregion

        #region GRN DC
        public const string GRNDCCreated = "GRNDCCreated";
        public const string GRNDCUpdate = "GRNDCUpdate";
        public const string stores_inward_grnofdcgen_wrhscdeblank = "stores_inward_grnofdcgen_wrhscdeblank";
        public const string stores_inward_grnofdcgen_yearblank = "stores_inward_grnofdcgen_yearblank";
        public const string stores_inward_grnofdcgen_groupblank = "stores_inward_grnofdcgen_groupblank";
        public const string stores_inward_grnofdcgen_grndateblank = "stores_inward_grnofdcgen_grndateblank";
        public const string stores_inward_grnofdcgen_siteblank = "stores_inward_grnofdcgen_siteblank";

        #endregion GRN DC

        #region Sales Order Receipt Entry
        public const string Order_Details_not_found_SOEKey = "Order_Details_not_found_SOEKey";
        public const string AutoNumberRequired_field_should_be_Y_or_N_SOEKey = "AutoNumberRequired_field_should_be_Y_or_N_SOEKey";
        public const string SiteRequired_field_should_be_Y_or_N_SOEKey = "SiteRequired_field_should_be_Y_or_N_SOEKey";
        public const string AuthorizationRequired_field_should_be_Y_or_N_SOEKey = "AuthorizationRequired_field_should_be_Y_or_N_SOEKey";
        public const string Order_details_successfully_inserted_SOEKey = "Order_details_successfully_inserted_SOEKey";
        public const string User_Locations_not_found_SOEKey = "User_Locations_not_found_SOEKey";
        public const string Sales_Policy_details_not_found_SOEKey = "Sales_Policy_details_not_found_SOEKey";
        public const string Project_Item_Code_Can_Not_Be_Blank_SOEKey = "Project_Item_Code_Can_Not_Be_Blank_SOEKey";
        public const string Please_Enter_Valid_Project_Item_Code_SOEKey = "Please_Enter_Valid_Project_Item_Code_SOEKey";
        public const string Customer_Code_Should_not_be_Blank_Null_SOEKey = "Customer_Code_Should_not_be_Blank_Null_SOEKey";
        public const string Customer_Code_not_found_in_customer_master_SOEKey = "Customer_Code_not_found_in_customer_master_SOEKey";
        public const string Bill_To_Should_not_be_Blank_Null_SOEKey = "Bill_To_Should_not_be_Blank_Null_SOEKey";
        public const string Invalid_Bill_To_SOEKey = "Invalid_Bill_To_SOEKey";
        public const string Salesman_does_not_exists_in_employee_master_SOEKey = "Salesman_does_not_exists_in_employee_master_SOEKey";
        public const string Order_Group_can_not_be_null_or_blank_SOEKey = "Order_Group_can_not_be_null_or_blank_SOEKey";
        public const string Group_Code_not_Found_SOEKey = "Group_Code_not_Found_SOEKey";
        public const string Sales_Order_Group_not_found_SOEKey = "Sales_Order_Group_not_found_SOEKey";
        public const string Location_Code_can_not_be_null_or_blank_SOEKey = "Location_Code_can_not_be_null_or_blank_SOEKey";
        public const string Site_Code_does_not_Exist_SOEKey = "Site_Code_does_not_Exist_SOEKey";
        public const string Order_Location_not_found_in_Location_Master_SOEKey = "Order_Location_not_found_in_Location_Master_SOEKey";
        public const string Internal_Order_Number_can_not_be_null_or_blank_SOEKey = "Internal_Order_Number_can_not_be_null_or_blank_SOEKey";
        public const string Internal_Order_Number_already_exists_SOEKey = "Internal_Order_Number_already_exists_SOEKey";
        public const string Order_No_not_found_SOEKey = "Order_No_not_found_SOEKey";
        public const string Internal_Order_Date_can_not_be_null_blank_SOEKey = "Internal_Order_Date_can_not_be_null_blank_SOEKey";
        public const string Internal_Order_Date_cannot_be_greater_than_SOEKey = "Internal_Order_Date_cannot_be_greater_than_SOEKey";
        public const string Order_Reciept_Date_must_be_in_between_And_SOEKey = "Order_Reciept_Date_must_be_in_between_And_SOEKey";
        public const string Internal_Order_Date_must_be_greater_than_Customer_PO_Date_SOEKey = "Internal_Order_Date_must_be_greater_than_Customer_PO_Date_SOEKey";
        public const string Internal_Order_Date_must_be_greater_than_Quotation_date_SOEKey = "Internal_Order_Date_must_be_greater_than_Quotation_date_SOEKey";
        public const string Please_Enter_Cust_PO_Date_SOEKey = "Please_Enter_Cust_PO_Date_SOEKey";
        public const string Please_Enter_Cust_LOI_Date_SOEKey = "Please_Enter_Cust_LOI_Date_SOEKey";
        public const string Please_Enter_Cust_PO_number_OR_LOI_number_SOEKey = "Please_Enter_Cust_PO_number_OR_LOI_number_SOEKey";
        public const string Please_Enter_Cust_LOI_number_SOEKey = "Please_Enter_Cust_LOI_number_SOEKey";
        public const string Please_Enter_Cust_PO_number_SOEKey = "Please_Enter_Cust_PO_number_SOEKey";
        public const string Customer_PO_Number_already_exists_SOEKey = "Customer_PO_Number_already_exists_SOEKey";
        public const string Cust_PO_Date_can_not_be_null_blank_SOEKey = "Cust_PO_Date_can_not_be_null_blank_SOEKey";
        public const string Customer_PO_Date_can_not_be_greater_than_todays_date_SOEKey = "Customer_PO_Date_can_not_be_greater_than_todays_date_SOEKey";
        public const string Customer_PO_Date_can_not_be_greater_than_order_date_SOEKey = "Customer_PO_Date_can_not_be_greater_than_order_date_SOEKey";
        public const string LOI_Date_can_not_be_null_blank_SOEKey = "LOI_Date_can_not_be_null_blank_SOEKey";
        public const string LOI_Date_can_not_be_greater_than_todays_date_SOEKey = "LOI_Date_can_not_be_greater_than_todays_date_SOEKey";
        public const string LOI_Date_can_not_be_greater_than_order_date_SOEKey = "LOI_Date_can_not_be_greater_than_order_date_SOEKey";
        public const string Sales_Order_Reference_Number_Can_not_be_blank_SOEKey = "Sales_Order_Reference_Number_Can_not_be_blank_SOEKey";
        public const string Sales_Order_Reference_Number_already_exists_SOEKey = "Sales_Order_Reference_Number_already_exists_SOEKey";
        public const string Exchange_Rate_Does_not_Exist_For_This_Currency_Code_Please_Enter_Exchange_Rate_From_Exchange_Rate_Master_Admin_Module_SOEKey = "Exchange_Rate_Does_not_Exist_For_This_Currency_Code_Please_Enter_Exchange_Rate_From_Exchange_Rate_Master_Admin_Module_SOEKey";
        public const string Sales_item_code_should_not_be_blank_at_row_SOEKey = "Sales_item_code_should_not_be_blank_at_row_SOEKey";
        public const string Sales_Item_Code_not_found_in_Sales_Item_Master_SOEKey = "Sales_Item_Code_not_found_in_Sales_Item_Master_SOEKey";
        public const string Sales_Item_Code_is_deactivated_You_cannot_save_the_data_SOEKey = "Sales_Item_Code_is_deactivated_You_cannot_save_the_data_SOEKey";
        public const string Service_Type_Item_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order_SOEKey = "Service_Type_Item_is_Not_Allowed_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order_SOEKey";
        public const string Qty_SUOM_should_not_be_blank_at_row_SOEKey = "Qty_SUOM_should_not_be_blank_at_row_SOEKey";
        public const string Since_the_Item_is_Free_Supply_Basic_Prise_SUOM_will_be_1_only_and_Discount_Type_will_not_be_applicable_SOEKey = "Since_the_Item_is_Free_Supply_Basic_Prise_SUOM_will_be_1_only_and_Discount_Type_will_not_be_applicable_SOEKey";
        public const string Since_the_Item_is_Free_Supply_Discount_Type_will_not_be_applicable_SOEKey = "Since_the_Item_is_Free_Supply_Discount_Type_will_not_be_applicable_SOEKey";
        public const string Basic_Price_SUOM_should_not_be_Blank_or_0_at_row_SOEKey = "Basic_Price_SUOM_should_not_be_Blank_or_0_at_row_SOEKey";
        public const string Rate_Structure_Code_should_not_be_blank_at_row_SOEKey = "Rate_Structure_Code_should_not_be_blank_at_row_SOEKey";
        public const string Sales_Item_is_not_mapped_with_Internal_Item_so_first_map_it_SOEKey = "Sales_Item_is_not_mapped_with_Internal_Item_so_first_map_it_SOEKey";
        public const string Old_Sales_Order_Reference_or_Customer_PO_Reference_cannot_be_blank_SOEKey = "Old_Sales_Order_Reference_or_Customer_PO_Reference_cannot_be_blank_SOEKey";
        public const string Customer_PO_Reference_is_already_entered_So_you_cannot_enter_Old_Sales_Order_Reference_SOEKey = "Customer_PO_Reference_is_already_entered_So_you_cannot_enter_Old_Sales_Order_Reference_SOEKey";
        public const string Internal_Item_Code_cannot_be_blank_SOEKey = "Internal_Item_Code_cannot_be_blank_SOEKey";
        public const string Reason_Code_cannot_be_blank_SOEKey = "Reason_Code_cannot_be_blank_SOEKey";
        public const string Old_OAF_Reference_or_Customer_PO_Reference_is_only_Applicable_for_Free_Supply_SOEKey = "Old_OAF_Reference_or_Customer_PO_Reference_is_only_Applicable_for_Free_Supply_SOEKey";
        public const string Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot_SOEKey = "Quantity_should_not_be_greater_then_1_when_Invoice_Type_is_Lot_SOEKey";
        public const string Shipment_code_should_not_be_blank_at_row_SOEKey = "Shipment_code_should_not_be_blank_at_row_SOEKey";
        public const string Diffrent_Shipment_Code_Can_Not_Be_Allowed_if_SO_Type_is_Sales_In_Transit_or_High_Sea_Sales_Order_SOEKey = "Diffrent_Shipment_Code_Can_Not_Be_Allowed_if_SO_Type_is_Sales_In_Transit_or_High_Sea_Sales_Order_SOEKey";
        public const string Discount_value_can_not_be_zero_or_blank_SOEKey = "Discount_value_can_not_be_zero_or_blank_SOEKey";
        public const string Discount_amount_in_percentage_can_not_be_greater_than_100_SOEKey = "Discount_amount_in_percentage_can_not_be_greater_than_100_SOEKey";
        public const string Discount_Value_entered_is_not_allowed_SOEKey = "Discount_Value_entered_is_not_allowed_SOEKey";
        public const string Currency_Code_cannot_be_blank_SOEKey = "Currency_Code_cannot_be_blank_SOEKey";
        public const string Currency_code_does_not_exist_SOEKey = "Currency_code_does_not_exist_SOEKey";
        public const string Book_Code_does_not_exist_SOEKey = "Book_Code_does_not_exist_SOEKey";
        public const string Total_Amount_After_Disc_Customer_Currency_can_not_be_greater_than_99999999999_99_SOEKey = "Total_Amount_After_Disc_Customer_Currency_can_not_be_greater_than_99999999999_99_SOEKey";
        public const string Total_Amount_After_Tax_Customer_Currency_can_not_be_greater_than_99999999999_99_SOEKey = "Total_Amount_After_Tax_Customer_Currency_can_not_be_greater_than_99999999999_99_SOEKey";
        public const string Advance_Payment_Amount_cannot_be_blank_or_zero_SOEKey = "Advance_Payment_Amount_cannot_be_blank_or_zero_SOEKey";
        public const string Advance_Mode_of_Payment_cannot_be_blank_SOEKey = "Advance_Mode_of_Payment_cannot_be_blank_SOEKey";
        public const string Advance_No_of_Days_cannot_be_blank_or_zero_SOEKey = "Advance_No_of_Days_cannot_be_blank_or_zero_SOEKey";
        public const string Advance_From_Date_cannot_be_blank_or_zero_SOEKey = "Advance_From_Date_cannot_be_blank_or_zero_SOEKey";
        public const string Retention_Payment_Amount_cannot_be_blank_or_zero_SOEKey = "Retention_Payment_Amount_cannot_be_blank_or_zero_SOEKey";
        public const string Retention_Mode_of_Payment_cannot_be_blank_SOEKey = "Retention_Mode_of_Payment_cannot_be_blank_SOEKey";
        public const string Retention_No_of_Days_cannot_be_blank_or_zero_SOEKey = "Retention_No_of_Days_cannot_be_blank_or_zero_SOEKey";
        public const string Retention_From_Date_cannot_be_blank_or_zero_SOEKey = "Retention_From_Date_cannot_be_blank_or_zero_SOEKey";
        public const string Against_Delivery_Payment_Amount_cannot_be_blank_or_zero_SOEKey = "Against_Delivery_Payment_Amount_cannot_be_blank_or_zero_SOEKey";
        public const string Against_Delivery_Mode_of_Payment_cannot_be_blank_SOEKey = "Against_Delivery_Mode_of_Payment_cannot_be_blank_SOEKey";
        public const string Against_Delivery_No_of_Days_cannot_be_blank_or_zero_SOEKey = "Against_Delivery_No_of_Days_cannot_be_blank_or_zero_SOEKey";
        public const string Against_Delivery_From_Date_cannot_be_blank_or_zero_SOEKey = "Against_Delivery_From_Date_cannot_be_blank_or_zero_SOEKey";
        public const string Payment_Type_cannot_be_blank_SOEKey = "Payment_Type_cannot_be_blank_SOEKey";
        public const string Payment_Amount_cannot_be_blank_or_zero_SOEKey = "Payment_Amount_cannot_be_blank_or_zero_SOEKey";
        public const string Mode_of_Payment_cannot_be_blank_SOEKey = "Mode_of_Payment_cannot_be_blank_SOEKey";
        public const string No_of_Days_cannot_be_blank_or_zero_SOEKey = "No_of_Days_cannot_be_blank_or_zero_SOEKey";
        public const string From_Date_cannot_be_blank_or_zero_SOEKey = "From_Date_cannot_be_blank_or_zero_SOEKey";
        public const string Payment_Schedule_total_value_not_matching_with_Sales_Order_total_value_SOEKey = "Payment_Schedule_total_value_not_matching_with_Sales_Order_total_value_SOEKey";
        public const string Agent_Code_cannot_be_blank_SOEKey = "Agent_Code_cannot_be_blank_SOEKey";
        public const string Invalid_Agent_Code_SOEKey = "Invalid_Agent_Code_SOEKey";
        public const string Item_Basic_Price_can_not_be_less_than_to_Agent_Commission_Value_SOEKey = "Item_Basic_Price_can_not_be_less_than_to_Agent_Commission_Value_SOEKey";
        public const string Agent_Commision_Value_can_not_be_zero_SOEKey = "Agent_Commision_Value_can_not_be_zero_SOEKey";
        public const string You_select_agent_Associate_Quotation_So_please_give_Agent_Commission_Value_for_atleast_one_Item_SOEKey = "You_select_agent_Associate_Quotation_So_please_give_Agent_Commission_Value_for_atleast_one_Item_SOEKey";
        public const string Only_Non_Excisable_Rate_Structure_is_Allowed_For_ItemCode_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order_SOEKey = "Only_Non_Excisable_Rate_Structure_is_Allowed_For_ItemCode_if_Sales_Order_Type_is_Sales_in_Transit_Or_High_Sea_Sales_Order_SOEKey";
        public const string Total_Balance_exceed_than_Credit_Limit_for_entered_Bill_to_SOEKey = "Total_Balance_exceed_than_Credit_Limit_for_entered_Bill_to_SOEKey";
        public const string Period_end_settings_not_done_for_entered_site_code_SOEKey = "Period_end_settings_not_done_for_entered_site_code_SOEKey";
        #endregion

        #region Sales Return Entry
        public const string sales_salesfunctions_salesreturnentry_created = "sales_salesfunctions_salesreturnentry_created";
        #endregion

        #region Debit note for rejected material
        public const string accounts_accountingtrans_rejdebitnote_debitnotalreadyexist = "accounts_accountingtrans_rejdebitnote_debitnotalreadyexist";
        #endregion

        #region Material Transfer Note Entry
        public const string stores_storestrans_whtrf_SaveSuccessmsg = "stores_storestrans_whtrf_SaveSuccessmsg";
        public const string stores_storestrans_whtrf_UpdateSuccessmsg = "stores_storestrans_whtrf_UpdateSuccessmsg";
        public const string stores_storestrans_whtrf_Deletemsg = "stores_storestrans_whtrf_Deletemsg";
        public const string stores_storestrans_whtrf_InterSaveSuccessmsg = "stores_storestrans_whtrf_InterSaveSuccessmsg";
        #endregion

        #region Gate Pass Return
        public const string AutoNumberRequired_field_should_be_Y_or_N_GPRKey = "AutoNumberRequired_field_should_be_Y_or_N_GPRKey";
        public const string SiteRequired_field_should_be_Y_or_N_GPRKey = "SiteRequired_field_should_be_Y_or_N_GPRKey";
        public const string AuthorizationRequired_field_should_be_Y_or_N_GPRKey = "AuthorizationRequired_field_should_be_Y_or_N_GPRKey";
        public const string Group_Code_can_not_be_Blank_GPRKey = "Group_Code_can_not_be_Blank_GPRKey";
        public const string Entered_Group_Code_not_Found_GPRKey = "Entered_Group_Code_not_Found_GPRKey";
        public const string Site_Code_can_not_be_Blank_GPRKey = "Site_Code_can_not_be_Blank_GPRKey";
        public const string Entered_Site_Code_not_Found_GPRKey = "Entered_Site_Code_not_Found_GPRKey";
        public const string Gate_Pass_Return_Number_can_not_be_Blank_GPRKey = "Gate_Pass_Return_Number_can_not_be_Blank_GPRKey";
        public const string Gate_Pass_Return_Number_Already_Exist_GPRKey = "Gate_Pass_Return_Number_Already_Exist_GPRKey";
        public const string Gate_Pass_Return_Date_can_not_be_blank_GPRKey = "Gate_Pass_Return_Date_can_not_be_blank_GPRKey";
        public const string GatePass_Return_Date_Should_Fall_In_Current_Period_Between_0_To_1_GPRKey = "GatePass_Return_Date_Should_Fall_In_Current_Period_Between_0_To_1_GPRKey";
        public const string Gate_Inward_Number_Cannot_Be_Blank_GPRKey = "Gate_Inward_Number_Cannot_Be_Blank_GPRKey";
        public const string Gate_Inward_Date_cannot_be_blank_GPRKey = "Gate_Inward_Date_cannot_be_blank_GPRKey";
        public const string Gate_Inward_Date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey = "Gate_Inward_Date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey";
        public const string Challan_Date_cannot_be_blank_GPRKey = "Challan_Date_cannot_be_blank_GPRKey";
        public const string Challan_Date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey = "Challan_Date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey";
        public const string First_Enter_Challan_Number_GPRKey = "First_Enter_Challan_Number_GPRKey";
        public const string Issue_Certificate_Date_cannot_be_blank_GPRKey = "Issue_Certificate_Date_cannot_be_blank_GPRKey";
        public const string Issue_Certificate_date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey = "Issue_Certificate_date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey";
        public const string First_Enter_Issue_Certificate_Detail_GPRKey = "First_Enter_Issue_Certificate_Detail_GPRKey";
        public const string Receipt_Certificate_Date_cannot_be_blank_GPRKey = "Receipt_Certificate_Date_cannot_be_blank_GPRKey";
        public const string Receipt_Certificate_date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey = "Receipt_Certificate_date_must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey";
        public const string First_Enter_Reaceipt_Certificate_Detail_GPRKey = "First_Enter_Reaceipt_Certificate_Detail_GPRKey";
        public const string Excise_Invoice_Number_Can_Not_Be_Blank_GPRKey = "Excise_Invoice_Number_Can_Not_Be_Blank_GPRKey";
        public const string Excise_Invoice_Date_Can_Not_Be_blank_GPRKey = "Excise_Invoice_Date_Can_Not_Be_blank_GPRKey";
        public const string Excise_Invoice_Date_Must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey = "Excise_Invoice_Date_Must_be_less_than_or_equal_to_the_GatePass_Return_Date_GPRKey";
        public const string First_Enter_Excise_Invoice_Number_GPRKey = "First_Enter_Excise_Invoice_Number_GPRKey";
        public const string Please_Enter_Return_Quantity_For_Atleast_one_Item_GPRKey = "Please_Enter_Return_Quantity_For_Atleast_one_Item_GPRKey";
        public const string Return_Quantity_can_not_be_Greater_than_Maximun_Return_Qty_GPRKey = "Return_Quantity_can_not_be_Greater_than_Maximun_Return_Qty_GPRKey";
        public const string GPId_should_not_be_blank_or_zero_at_row_0_GPRKey = "GPId_should_not_be_blank_or_zero_at_row_0_GPRKey";
        public const string LineId_should_not_be_blank_or_zero_at_row_0_GPRKey = "LineId_should_not_be_blank_or_zero_at_row_0_GPRKey";
        public const string Gate_Pass_Return_Number_Created_Successfully_GPRKey = "Gate_Pass_Return_Number_Created_Successfully_GPRKey";
        public const string Gate_Pass_Return_Number_Update_Successfully_GPRKey = "Gate_Pass_Return_Number_Update_Successfully_GPRKey";
        public const string Entered_Challan_No_is_Already_Used_GPRKey = "Entered_Challan_No_is_Already_Used_GPRKey";
        public const string Period_end_settings_not_done_for_entered_site_code_GPRKey = "Period_end_settings_not_done_for_entered_site_code_GPRKey";

        #endregion

        #region Cash Transaction
        public const string accounts_accountingtrans_cashentry_groupnotfound = "accounts_accountingtrans_cashentry_groupnotfound";
        public const string accounts_accountingtrans_cashentry_trannumberalreadyexists = "accounts_accountingtrans_cashentry_trannumberalreadyexists";
        #endregion

        #region Service PO Entry
        public const string pur_po_servpo_gst_crgandrcmtoyescombnotallow = "pur_po_servpo_gst_crgandrcmtoyescombnotallow";
        public const string pur_po_servpo_gst_notcrgandrcmtonocombnotallow = "pur_po_servpo_gst_notcrgandrcmtonocombnotallow";
        public const string pur_po_servpo_created_key = "pur_po_servpo_created_key";
        public const string pur_po_servpo_itemdeliverygridisrequired_key = "pur_po_servpo_itemdeliverygridisrequired_key";
        public const string pur_po_servpo_serpono_not_exists_key = "pur_po_servpo_serpono_not_exists_key";
        public const string pur_po_servpo_itemgridisrequired_key = "pur_po_servpo_itemgridisrequired_key";
        public const string pur_po_servpo_no_not_exists_key = "pur_po_servpo_no_not_exists_key";

        #endregion
        #region Service PO Amendment Entry
        public const string pur_purodr_servicepoamd_no_not_exists_key = "pur_purodr_servicepoamd_no_not_exists_key";
        public const string pur_purodr_servicepoamd_itemdeliverygridisrequired_key = "pur_purodr_servicepoamd_itemdeliverygridisrequired_key";
        public const string pur_purodr_servicepoamd_itemgridisrequired_key = "pur_purodr_servicepoamd_itemgridisrequired_key";
        public const string pur_purodr_servicepoamd_gst_crgandrcmtoyescombnotallow = "pur_purodr_servicepoamd_gst_crgandrcmtoyescombnotallow";
        public const string pur_purodr_servicepoamd_gst_notcrgandrcmtonocombnotallow = "pur_purodr_servicepoamd_gst_notcrgandrcmtonocombnotallow";
        public const string pur_purodr_servicepoamd_created_key = "pur_purodr_servicepoamd_created_key";
        #endregion

        #region Positive Material Adjustment Voucher
        public const string Positive_Material_Adjustment_Voucher_Save = "Positive_Material_Adjustment_Voucher_Save";
        public const string Positive_Material_Adjustment_Voucher_Update = "Positive_Material_Adjustment_Voucher_Update";
        public const string Positive_Material_Adjustment_Voucher_Delete = "Positive_Material_Adjustment_Voucher_Delete";
        #endregion

        #region purchase inquiry entry
        public const string pur_purodrfunction_purinqentrysec2_Save = "pur_purodrfunction_purinqentrysec2_Save";
        public const string pur_purodrfunction_purinqentrysec2_Update = "pur_purodrfunction_purinqentrysec2_Update";
       
        #endregion

        #region Open Work Order Entry   
        public const string stores_openwo_openwoentry_Open_Work_Order_Entry_Update = "stores_openwo_openwoentry_Open_Work_Order_Entry_Update";
        public const string stores_openwo_openwoentry_Open_Work_Order_Entry_Save = "stores_openwo_openwoentry_Open_Work_Order_Entry_Save";
        public const string stores_openwo_openwoentry_Open_Work_Order_Entry_Delete = "stores_openwo_openwoentry_Open_Work_Order_Entry_Delete";



        #endregion

        #region Gate Pass Cancel
        public const string subcon_gatepass_cancelljgp_Gate_Pass_Cancellation_Number_0_Gate_Pass_Return_Number_1_Created_Successfuly = "subcon_gatepass_cancelljgp_Gate_Pass_Cancellation_Number_0_Gate_Pass_Return_Number_1_Created_Successfuly";
        public const string subcon_gatepass_cancelljgp_AutoNumberRequired_field_should_be_Y_or_N = "subcon_gatepass_cancelljgp_AutoNumberRequired_field_should_be_Y_or_N";
        public const string subcon_gatepass_cancelljgp_SiteRequired_field_should_be_Y_or_N = "subcon_gatepass_cancelljgp_SiteRequired_field_should_be_Y_or_N";
        public const string subcon_gatepass_cancelljgp_AuthorizationRequired_field_should_be_Y_or_N = "subcon_gatepass_cancelljgp_AuthorizationRequired_field_should_be_Y_or_N";
        public const string subcon_gatepass_cancelljgp_ReturnSiteRequired_field_should_be_Y_or_N = "subcon_gatepass_cancelljgp_ReturnSiteRequired_field_should_be_Y_or_N";
        public const string subcon_gatepass_cancelljgp_ReturnAutoNumberRequired_field_should_be_Y_or_N = "subcon_gatepass_cancelljgp_ReturnAutoNumberRequired_field_should_be_Y_or_N";
        public const string subcon_gatepass_cancelljgp_Group_Code_can_not_be_Blank = "subcon_gatepass_cancelljgp_Group_Code_can_not_be_Blank";
        public const string subcon_gatepass_cancelljgp_Entered_Group_Code_not_Found = "subcon_gatepass_cancelljgp_Entered_Group_Code_not_Found";
        public const string subcon_gatepass_cancelljgp_Site_Code_can_not_be_Blank = "subcon_gatepass_cancelljgp_Site_Code_can_not_be_Blank";
        public const string subcon_gatepass_cancelljgp_Entered_Site_Code_not_Found = "subcon_gatepass_cancelljgp_Entered_Site_Code_not_Found";
        public const string subcon_gatepass_cancelljgp_Gate_Pass_Cancel_Number_can_not_be_Blank = "subcon_gatepass_cancelljgp_Gate_Pass_Cancel_Number_can_not_be_Blank";
        public const string subcon_gatepass_cancelljgp_Gate_Pass_Cancel_Number_Already_Exist = "subcon_gatepass_cancelljgp_Gate_Pass_Cancel_Number_Already_Exist";
        public const string subcon_gatepass_cancelljgp_Period_end_settings_not_done_for_entered_site_code = "subcon_gatepass_cancelljgp_Period_end_settings_not_done_for_entered_site_code";
        public const string subcon_gatepass_cancelljgp_Gate_Pass_cancel_Date_can_not_be_blank = "subcon_gatepass_cancelljgp_Gate_Pass_cancel_Date_can_not_be_blank";
        public const string subcon_gatepass_cancelljgp_GatePass_Cancel_Date_Should_Fall_In_Current_Period_Between_0_To_1 = "subcon_gatepass_cancelljgp_GatePass_Cancel_Date_Should_Fall_In_Current_Period_Between_0_To_1";
        public const string subcon_gatepass_cancelljgp_Return_Group_Code_can_not_be_blank = "subcon_gatepass_cancelljgp_Return_Group_Code_can_not_be_blank";
        public const string subcon_gatepass_cancelljgp_Entered_Return_Group_Code_Not_Found = "subcon_gatepass_cancelljgp_Entered_Return_Group_Code_Not_Found";
        public const string subcon_gatepass_cancelljgp_Return_Site_Code_can_not_be_blank = "subcon_gatepass_cancelljgp_Return_Site_Code_can_not_be_blank";
        public const string subcon_gatepass_cancelljgp_Entered_Return_Site_Code_Not_Found = "subcon_gatepass_cancelljgp_Entered_Return_Site_Code_Not_Found";
        public const string subcon_gatepass_cancelljgp_Return_Number_can_not_be_Blank = "subcon_gatepass_cancelljgp_Return_Number_can_not_be_Blank";
        public const string subcon_gatepass_cancelljgp_Entered_Return_Number_Already_Exist = "subcon_gatepass_cancelljgp_Entered_Return_Number_Already_Exist";
        public const string subcon_gatepass_cancelljgp_GPId_should_not_be_blank_or_zero_at_row_0 = "subcon_gatepass_cancelljgp_GPId_should_not_be_blank_or_zero_at_row_0";
        public const string subcon_gatepass_cancelljgp_LineId_should_not_be_blank_or_zero_at_row_0 = "subcon_gatepass_cancelljgp_LineId_should_not_be_blank_or_zero_at_row_0";
        #endregion

        #region POMaintenance
        public const string PODeleted = "purchase_purchaseorders_poentry_delete";
        #endregion

        #region Subcontrating GRN Entry
        public const string subcon_subcontrans_laborgrn_SUBGRNCreated = "subcon_subcontrans_laborgrn_SUBGRNCreated";
        public const string subcon_subcontrans_laborgrn_SUBGRNUpdate = "subcon_subcontrans_laborgrn_SUBGRNUpdate";
        public const string subcon_subcontrans_laborgrn_challan_no_is_already_used_grn_key = "subcon_subcontrans_laborgrn_challan_no_is_already_used_grn_key";
        #endregion


        #region Labour Rate Contract Entry
        public const string pur_purchase_pomaint_CreatedKey = "pur_purchase_pomaint_CreatedKey"; //Purchase order saved successfully! Purchase Order Number : 
        public const string pur_purchase_pomaint_UpdatedKey = "pur_purchase_pomaint_UpdatedKey"; //Purchase order saved successfully!        
        public const string pur_purchase_pomaint_DeletedKey = "pur_purchase_pomaint_DeletedKey"; //Purchase order deleted successfully! 
        public const string pur_purchase_pomaint_indentclose = "pur_purchase_pomaint_indentclose"; //Indent is close or Po Qty is more than indent qty.
        public const string pur_purchase_pomaint_discount_nonnagativeKey = "pur_purchase_pomaint_discount_nonnagative";//PO Basic Value After PO Discount Must Be Non Negative Value.;
        public const string pur_purchase_pomaint_qtypuomrequired = "pur_purchase_pomaint_qtypuomrequired";//Insert Qty(PUOM) First
        public const string pur_purchase_pomaint_qtyiuomrequired = "pur_purchase_pomaint_qtyiuomrequired";//Insert Qty(IUOM) First
        public const string pur_purchase_pomaint_yearrequired = "pur_purchase_pomaint_yearrequired"; //PO year cannot be blank!
        public const string pur_purchase_pomaint_invalidyear = "pur_purchase_pomaint_invalidyear"; //Invalid PO year
        public const string pur_purchase_pomaint_grouprequired = "pur_purchase_pomaint_grouprequired"; //PO group cannot be blank!
        public const string pur_purchase_pomaint_invalidgroup = "pur_purchase_pomaint_invalidgroup"; //Invalid PO group
        public const string pur_purchase_pomaint_siterequired = "pur_purchase_pomaint_siterequired"; //PO site cannot be blank!
        public const string pur_purchase_pomaint_invalidsite = "pur_purchase_pomaint_invalidsite"; //Invalid PO site
        public const string pur_purchase_pomaint_ponorequired = "pur_purchase_pomaint_ponorequired"; //PO Number cannot be blank!
        public const string pur_purchase_pomaint_invalidpono = "pur_purchase_pomaint_invalidpono"; //PO Number Already Exists!
        public const string pur_purchase_pomaint_podateequired = "pur_purchase_pomaint_podateequired"; //PO date cannot be blank!
        public const string pur_purchase_pomaint_periodendsettingnotdone = "pur_purchase_pomaint_periodendsettingnotdone";//Period end settings not done for entered site code!
        public const string pur_purchase_pomaint_datelessthentodaydate = "pur_purchase_pomaint_datelessthentodaydate"; //PO Date Can Not Be Greater than Today Date
        public const string pur_purchase_pomaint_date_between_financial_year_Key = "pur_purchase_pomaint_date_between_financial_year_Key"; //PO date must be between {0} and {1}!"
        public const string pur_purchase_pomaint_vendorcodeequired = "pur_purchase_pomaint_vendorcodeequired"; //Vendor Code cannot be blank!
        public const string pur_purchase_pomaint_invalidvendorcode = "pur_purchase_pomaint_invalidvendorcode"; //Invalid Vendor Code
        public const string pur_purchase_pomaint_currencycoderequired = "pur_purchase_pomaint_currencycoderequired"; //Currency Code cannot be blank!
        public const string pur_purchase_pomaint_invalidcurrency = "pur_purchase_pomaint_invalidcurrency"; //Invalid Currency Code

        public const string pur_purchase_pomaint_citycoderequired = "pur_purchase_pomaint_citycoderequired"; //City Code cannot be blank!
        public const string pur_purchase_pomaint_invalidcitycode = "pur_purchase_pomaint_invalidcitycode"; //Invalid City Code

        public const string pur_purchase_pomaint_ratecoderequired = "pur_purchase_pomaint_ratecoderequired"; //Rate structure cannot be blank!
        public const string pur_purchase_pomaint_invalidratecode = "pur_purchase_pomaint_invalidratecode"; //Invalid Rate Structure Code !
        public const string pur_purchase_pomaint_noavtiveratecode = "pur_purchase_pomaint_noavtiveratecode"; //No Active Rate Structure Found In Item Vendor Labour Master !
        public const string pur_purchase_pomaint_combnotallowedforrcmYes = "pur_purchase_pomaint_combnotallowedforrcmYes"; //GST is being charged and RCM is set to YES. This combination is not allowed.
        public const string pur_purchase_pomaint_combnotallowedforrcmNo = "pur_purchase_pomaint_combnotallowedforrcmNo"; //GST is NOT being charged and RCM is set to NO. This combination is not allowed.
        public const string pur_purchase_pomaint_invalidcontractdate = "pur_purchase_pomaint_invalidcontractdate"; //Contract Valid From Date must be Greater than or Equal to {0}
        public const string pur_purchase_pomaint_invalidcontractuptodate = "pur_purchase_pomaint_invalidcontractuptodate"; //Contract Valid Upto Date must be Greater than or Equal to {0}

        public const string pur_purchase_pomaint_buyercodeequired = "pur_purchase_pomaint_buyercodeequired"; //Buyer Code cannot be blank!
        public const string pur_purchase_pomaint_invalidbuyer = "pur_purchase_pomaint_invalidbuyer"; //Invalid Buyer Code
        public const string pur_purchase_pomaint_addoneequired = "pur_purchase_pomaint_addoneequired";//Address line one cannot be blank!

        public const string pur_purchase_pomaint_invalidoafyear = "pur_purchase_pomaint_invalidoafyear"; //Invalid OAF Year
        public const string pur_purchase_pomaint_invalidoafgroup = "pur_purchase_pomaint_invalidoafgroup"; //Invalid OAF Group
        public const string pur_purchase_pomaint_invalidoafsite = "pur_purchase_pomaint_invalidoafsite"; //Invalid OAF Site
        public const string pur_purchase_pomaint_invalidoafnumber = "pur_purchase_pomaint_invalidoafnumber"; //Invalid OAF Number

        public const string pur_purchase_pomaint_vendornotexist = "pur_purchase_pomaint_vendornotexist"; //Vendor Code does not exists in Item Vendor Labour Master !
        public const string pur_purchase_pomaint_vendornotactive = "pur_purchase_pomaint_vendornotactive";//No Active Vendor Code found in Item Vendor Labour Master!
        public const string pur_purchase_pomaint_vendornotactivate = "pur_purchase_pomaint_vendornotactivate"; //Vendor code is not Activate!

        public const string pur_purchase_pomaint_itemvendorsettingnotexist = "pur_purchase_pomaint_itemvendorsettingnotexist"; //Item Code does not exists in Item Vendor Labour Master !
        public const string pur_purchase_pomaint_duplicateitemsexists = "pur_purchase_pomaint_duplicateitemsexists"; //Duplicate Items Exists!
        public const string pur_purchase_pomaint_quantitypuomcannot = "pur_purchase_pomaint_quantitypuomcannot"; //Quantity PUOM cannot be blank or Zero!
        public const string pur_purchase_pomaint_warehouseblank = "pur_purchase_pomaint_warehouseblank"; //Warehouse code cannot be blank!
        public const string pur_purchase_pomaint_puomblank = "pur_purchase_pomaint_puomblank"; //PUOM cannot be blank!
        public const string pur_purchase_pomaint_itemcodeblank = "pur_purchase_pomaint_itemcodeblank"; //"Item code cannot be blank!"
        public const string pur_purchase_pomaint_operationcodeblank = "pur_purchase_pomaint_operationcodeblank"; //Operation Code cannot be blank!
        public const string pur_purchase_pomaint_Onedelivaryrequired = "pur_purchase_pomaint_Onedelivaryrequired"; //Operation Code cannot be blank!


        #endregion

        #region Freeze Product Structure
        public const string eng_engmasters_frzprdstr_Freeze_Not_Possible_Because_Child_is_of_Type_and_it_has_no_child = "eng_engmasters_frzprdstr_Freeze_Not_Possible_Because_Child_is_of_Type_and_it_has_no_child";
        #endregion

        #region Work Order Issue Entry
        public const string stores_openwo_openwoissue_successfully_saved = "stores_openwo_openwoissue_successfully_saved";
        public const string stores_openwo_openwoissue_successfully_updated = "stores_openwo_openwoissue_successfully_updated";
        public const string stores_openwo_openwoissue_successfully_deleted = "stores_openwo_openwoissue_successfully_deleted";
        public const string stores_openwo_openwoissueError_deleted = "stores_openwo_openwoissueError_deleted";


        #endregion
        #region OpenWorkOrderReceipt Entry
        public const string stores_openwo_openworeceipt_UpdateSuccess = "stores_openwo_openworeceipt_UpdateSuccess";
        public const string stores_openwo_openworeceipt_InsertSuccess = "stores_openwo_openworeceipt_InsertSuccess";
        public const string stores_openwo_openworeceipt_DeleteSuccess = "stores_openwo_openworeceipt_DeleteSuccess";
        public const string stores_openwo_openworeceipt_DeleteError = "stores_openwo_openworeceipt_DeleteError";
        public const string stores_openwo_openworeceipt_Authorize = "stores_openwo_openworeceipt_Authorize";

        #endregion



        #region Open Work Order Close Entry
        public const string Open_WorkOrder_Successfully_Closed = "Open WorkOrder Successfully Closed";
        #endregion
        #region PO Entry
        public const string pur_po_poentry_createpo_key = "pur_po_poentry_createpo_key";
        public const string pur_po_poentry_updatepo_key = "pur_po_poentry_updatepo_key";
        #endregion
        #region Service Bill Certification Entry
        public const string pur_purodr_bill_certificate_created_key = "pur_purodr_bill_certificate_created_key";
        public const string pur_purodr_bill_certificate_poitemgridisrequired_key = "pur_purodr_bill_certificate_poitemgridisrequired_key";

        #endregion


        #region Subcontrating QC Entry
        public const string subcon_subcontrans_laborqc_Inserted = "subcon_subcontrans_laborqc_Inserted";
        public const string subcon_subcontrans_laborqc_SUBQCUpdate = "subcon_subcontrans_laborqc_SUBQCUpdate";
        #endregion


        #region  Open Work Order Cancellation Entry 
        public const string OpenWorkOrderCancellation = "OpenWorkOrderCancellation";
        #endregion

        #region Open WorkOrder Return Entry
        public const string Open_Work_Order_Return_Entry_Update = "Open_Work_Order_Return_Entry_Update";
        public const string Open_Work_Order_Return_Entry_Save = "Open_Work_Order_Return_Entry_Save";
        #endregion
        #region Supplementary Requisition
        public const string production_prodtrans_supplementaryrequisition_createdkey = "production_prodtrans_supplementaryrequisition_createdkey";
        public const string production_prodtrans_supplementaryrequisition_updatedkey = "production_prodtrans_supplementaryrequisition_updatedkey";
        public const string production_prodtrans_supplementaryrequisition_deletedkey = "production_prodtrans_supplementaryrequisition_deletedkey";

        #endregion Supplementary Requisition

        public const string production_prodtrans_supplementaryreturn_createdKey = "production_prodtrans_supplementaryreturn_createdKey";
        public const string production_prodtrans_supplementaryreturn_updatedKey = "production_prodtrans_supplementaryreturn_updatedKey";
        public const string production_prodtrans_supplementaryreturn_deletedKey = "production_prodtrans_supplementaryreturn_deletedKey";

        public const string production_prodtrans_supplementaryrejection_pending_to_be_Authorised = "production_prodtrans_supplementaryrejection_pending_to_be_Authorised";

        #region Supplementary Issue To Shop Entry
        public const string stores_storestrans_supplementaryissue_autonumberrequired = "stores_storestrans_supplementaryissue_autonumberrequired";
        public const string stores_storestrans_supplementaryissue_siterequired = "stores_storestrans_supplementaryissue_siterequired";
        public const string stores_storestrans_supplementaryissue_authorizationrequired = "stores_storestrans_supplementaryissue_authorizationrequired";
        public const string stores_storestrans_supplementaryissue_consumableaccount = "stores_storestrans_supplementaryissue_consumableaccount";
        public const string stores_storestrans_supplementaryissue_invalidyear = "stores_storestrans_supplementaryissue_invalidyear";
        public const string stores_storestrans_supplementaryissue_invalidgroupcode = "stores_storestrans_supplementaryissue_invalidgroupcode";
        public const string stores_storestrans_supplementaryissue_invalidsitecode = "stores_storestrans_supplementaryissue_invalidsitecode";
        public const string stores_storestrans_supplementaryissue_issuenumbercannot = "stores_storestrans_supplementaryissue_issuenumbercannot";
        public const string stores_storestrans_supplementaryissue_issuenumberexist = "stores_storestrans_supplementaryissue_issuenumberexist";
        public const string stores_storestrans_supplementaryissue_issuenumberexistwo = "stores_storestrans_supplementaryissue_issuenumberexistwo";
        public const string stores_storestrans_supplementaryissue_issuenumberdoesnotexist = "stores_storestrans_supplementaryissue_issuenumberdoesnotexist";
        public const string stores_storestrans_supplementaryissue_invalidissueId = "stores_storestrans_supplementaryissue_invalidissueId";
        public const string stores_storestrans_supplementaryissue_dateblank = "stores_storestrans_supplementaryissue_dateblank";
        public const string stores_storestrans_supplementaryissue_datetodaygreater = "stores_storestrans_supplementaryissue_datetodaygreater";
        public const string stores_storestrans_supplementaryissue_datebetweeen = "stores_storestrans_supplementaryissue_datebetweeen";
        public const string stores_storestrans_supplementaryissue_issuetoblank = "stores_storestrans_supplementaryissue_issuetoblank";
        public const string stores_storestrans_supplementaryissue_issuetoandbynotsame = "stores_storestrans_supplementaryissue_issuetoandbynotsame";
        public const string stores_storestrans_supplementaryissue_issuebyblank = "stores_storestrans_supplementaryissue_issuebyblank";
        public const string stores_storestrans_supplementaryissue_nodatatosave = "stores_storestrans_supplementaryissue_nodatatosave";
        public const string stores_storestrans_supplementaryissue_issuenonoauthorize = "stores_storestrans_supplementaryissue_issuenonoauthorize";
        public const string stores_storestrans_supplementaryissue_supplementaryIssue = "stores_storestrans_supplementaryissue_supplementaryIssue";

        #endregion Supplementary Issue To Shop Entry

        #region Dis Assembly Entry
        public const string planning_planningtrans_disassembly_insertmsg = "planning_planningtrans_disassembly_insertmsg";
        public const string planning_planningtrans_disassembly_updatemsg = "planning_planningtrans_disassembly_updatemsg";
        public const string planning_planningtrans_disassembly_deletemsg = "planning_planningtrans_disassembly_deletemsg";
        #endregion
        #region Rejection to Scrap
        public const string stores_storestrans_rejectiontoscrapentry_insertmsg = "stores_storestrans_rejectiontoscrapentry_insertmsg";
        public const string stores_storestrans_rejectiontoscrapentry_updatemeesage = "stores_storestrans_rejectiontoscrapentry_updatemeesage";
        #endregion

        #region Scrap Receipt Entry
        public const string stores_storetrans_scrprcp_itemdetailrequired = "stores_storetrans_scrprcp_itemdetailrequired";
        public const string stores_storetrans_scrprcp_insertsuccessfully = "stores_storetrans_scrprcp_insertsuccessfully";

        #endregion

    }
}
