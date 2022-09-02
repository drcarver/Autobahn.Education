//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAidApplicationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAidApplication file
/// </summary>
public partial class FinancialAidApplicationViewModel : ObservableValidator, IFinancialAidApplication
{
    #region "FinancialAidApplicationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FinancialAidApplicationViewModel Constructor
    /// </summary>
    public FinancialAidApplicationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFinancialAidApplicationViewModelConstruction();
    }

    /// <summary>
    /// FinancialAidApplicationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFinancialAidApplicationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FinancialAidApplication";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IFinancialAidApplication Properties"
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
    /// Financial Aid Application Type
    /// <para>
    /// The type of financial application completed by an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20186">Financial Aid Application Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Aid Application Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefFinancialAidApplicationTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFinancialAidApplication model)
    {
        IsBusy = true;
        Id = model.Id;
        FinancialAidYearDesignator = model.FinancialAidYearDesignator; // Financial Aid Year Designator
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefFinancialAidApplicationTypeId = model.RefFinancialAidApplicationTypeId; // Financial Aid Application Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
