//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentFinancialAid file
/// </summary>
public partial class PsStudentFinancialAidViewModel : ObservableValidator, IPsStudentFinancialAid
{
    #region "PsStudentFinancialAidViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentFinancialAidViewModel Constructor
    /// </summary>
    public PsStudentFinancialAidViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentFinancialAidViewModelConstruction();
    }

    /// <summary>
    /// PsStudentFinancialAidViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentFinancialAidViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentFinancialAid";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FinancialAidApplicant -- (backing property for Financial Aid Applicant)
    private Boolean? financialAidApplicant;

    // FinancialAidIncomeLevel -- (backing property for Financial Aid Income Level)
    private Decimal? financialAidIncomeLevel;

    // FinancialNeed -- (backing property for Financial Need)
    private Decimal? financialNeed;

    // member variable for the TitleIvparticipantAndRecipient property
    private Boolean? titleIvparticipantAndRecipient;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

    #region "IPsStudentFinancialAid Properties"
    /// <summary>
    /// Financial Aid Applicant
    /// <para>
    /// Any applicant who submits any one of the institutionally required financial aid applications/forms, such as the  Free Application for Federal Student Aid (FAFSA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19745">Financial Aid Applicant</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Applicant")]
    public Boolean? FinancialAidApplicant { get => financialAidApplicant; set => SetProperty(ref financialAidApplicant, value, false); }

    /// <summary>
    /// Financial Aid Income Level
    /// <para>
    /// The income level of an individual that is used by an institution's financial aid office to determine an individual's Expected Family Contribution (EFC).  For dependent students this will include the parents' adjusted gross income and the student's adjusted gross income.  For independent students this will include the student's adjusted gross income.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20319">Financial Aid Income Level</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Income Level")]
    public Decimal? FinancialAidIncomeLevel { get => financialAidIncomeLevel; set => SetProperty(ref financialAidIncomeLevel, value, false); }

    /// <summary>
    /// Financial Need
    /// <para>
    /// The amount of financial need as determined by an institution using the federal methodology and/or your institution's own standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19747">Financial Need</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Need")]
    public Decimal? FinancialNeed { get => financialNeed; set => SetProperty(ref financialNeed, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Financial Aid Veteran's Benefit Status
    /// <para>
    /// An indication of whether a person is receiving Veteran's benefits.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20588">Financial Aid Veteran's Benefit Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Veteran's Benefit Status")]
    public Guid? RefFinancialAidVeteransBenefitStatusId { get; set; }

    /// <summary>
    /// Financial Aid Veteran's Benefit Type
    /// <para>
    /// The type of Veteran's benefits a person is receiving.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20589">Financial Aid Veteran's Benefit Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Veteran's Benefit Type")]
    public Guid? RefFinancialAidVeteransBenefitTypeId { get; set; }

    /// <summary>
    /// Financial Need Determination Methodology
    /// <para>
    /// The methodology used to determine an individual's financial need.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20188">Financial Need Determination Methodology</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Need Determination Methodology")]
    public Guid? RefNeedDeterminationMethodId { get; set; }

    public Boolean? TitleIvparticipantAndRecipient { get => titleIvparticipantAndRecipient; set => SetProperty(ref titleIvparticipantAndRecipient, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentFinancialAid model)
    {
        IsBusy = true;
        Id = model.Id;
        FinancialAidApplicant = model.FinancialAidApplicant; // Financial Aid Applicant
        FinancialAidIncomeLevel = model.FinancialAidIncomeLevel; // Financial Aid Income Level
        FinancialNeed = model.FinancialNeed; // Financial Need
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefFinancialAidVeteransBenefitStatusId = model.RefFinancialAidVeteransBenefitStatusId; // Financial Aid Veteran's Benefit Status
        RefFinancialAidVeteransBenefitTypeId = model.RefFinancialAidVeteransBenefitTypeId; // Financial Aid Veteran's Benefit Type
        RefNeedDeterminationMethodId = model.RefNeedDeterminationMethodId; // Financial Need Determination Methodology
        TitleIvparticipantAndRecipient = model.TitleIvparticipantAndRecipient; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
