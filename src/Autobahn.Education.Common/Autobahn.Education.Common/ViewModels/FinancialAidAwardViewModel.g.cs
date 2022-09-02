//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAidAwardViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAidAward file
/// </summary>
public partial class FinancialAidAwardViewModel : ObservableValidator, IFinancialAidAward
{
    #region "FinancialAidAwardViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FinancialAidAwardViewModel Constructor
    /// </summary>
    public FinancialAidAwardViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFinancialAidAwardViewModelConstruction();
    }

    /// <summary>
    /// FinancialAidAwardViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFinancialAidAwardViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FinancialAidAward";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FinancialAidAwardAmount -- (backing property for Financial Aid Award Amount)
    private Decimal? financialAidAwardAmount;

    // FinancialAidYearDesignator -- (backing property for Financial Aid Year Designator)
    private System.String financialAidYearDesignator;

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

    #region "IFinancialAidAward Properties"
    /// <summary>
    /// Financial Aid Award Amount
    /// <para>
    /// The amount of financial aid awarded to a person for the term/year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19112">Financial Aid Award Amount</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Award Amount")]
    public Decimal? FinancialAidAwardAmount { get => financialAidAwardAmount; set => SetProperty(ref financialAidAwardAmount, value, false); }

    /// <summary>
    /// Financial Aid Year Designator
    /// <para>
    /// The school year for which the student's financial aid application and award data apply.  Generally, this is the 12-month period from July 1 to June 30.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20590">Financial Aid Year Designator</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Year Designator")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FinancialAidYearDesignator { get => financialAidYearDesignator; set => SetProperty(ref financialAidYearDesignator, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Financial Aid Award Type
    /// <para>
    /// The classification of financial aid awarded to a person for the academic term/year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19113">Financial Aid Award Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Award Type")]
    public Guid? RefFinancialAidAwardTypeId { get; set; }

    /// <summary>
    /// Financial Aid Award Status
    /// <para>
    /// An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19362">Financial Aid Award Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Award Status")]
    public Guid? RefFinancialAidStatusId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFinancialAidAward model)
    {
        IsBusy = true;
        Id = model.Id;
        FinancialAidAwardAmount = model.FinancialAidAwardAmount; // Financial Aid Award Amount
        FinancialAidYearDesignator = model.FinancialAidYearDesignator; // Financial Aid Year Designator
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefFinancialAidAwardTypeId = model.RefFinancialAidAwardTypeId; // Financial Aid Award Type
        RefFinancialAidStatusId = model.RefFinancialAidStatusId; // Financial Aid Award Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
