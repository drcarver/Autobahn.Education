//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12federalFundAllocationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12federalFundAllocation file
/// </summary>
public partial class K12federalFundAllocationViewModel : ObservableValidator, IK12federalFundAllocation
{
    #region "K12federalFundAllocationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12federalFundAllocationViewModel Constructor
    /// </summary>
    public K12federalFundAllocationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12federalFundAllocationViewModelConstruction();
    }

    /// <summary>
    /// K12federalFundAllocationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12federalFundAllocationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12federalFundAllocation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the FederalProgramCode property
    private System.String federalProgramCode;

    // member variable for the FederalProgramsFundingAllocation property
    private Decimal? federalProgramsFundingAllocation;

    // member variable for the FundsTransferAmount property
    private Decimal? fundsTransferAmount;

    // member variable for the LeaTransferabilityOfFunds property
    private Boolean? leaTransferabilityOfFunds;

    // member variable for the NumberOfImmigrantProgramSubgrants property
    private Int32? numberOfImmigrantProgramSubgrants;

    // member variable for the SchoolImprovementAllocation property
    private Decimal? schoolImprovementAllocation;

    // member variable for the SchoolImprovementReservedPercent property
    private Decimal? schoolImprovementReservedPercent;

    // member variable for the SesPerPupilExpenditure property
    private Decimal? sesPerPupilExpenditure;

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

    #region "IK12federalFundAllocation Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FederalProgramCode { get => federalProgramCode; set => SetProperty(ref federalProgramCode, value, true); }

    public Decimal? FederalProgramsFundingAllocation { get => federalProgramsFundingAllocation; set => SetProperty(ref federalProgramsFundingAllocation, value, false); }

    public Decimal? FundsTransferAmount { get => fundsTransferAmount; set => SetProperty(ref fundsTransferAmount, value, false); }

    public Boolean? LeaTransferabilityOfFunds { get => leaTransferabilityOfFunds; set => SetProperty(ref leaTransferabilityOfFunds, value, false); }

    public Int32? NumberOfImmigrantProgramSubgrants { get => numberOfImmigrantProgramSubgrants; set => SetProperty(ref numberOfImmigrantProgramSubgrants, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    public Guid OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
    /// </summary>
    public Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
    /// </summary>
    public Guid? RefLeaFundsTransferTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
    /// </summary>
    public Guid? RefReapAlternativeFundingStatusId { get; set; }

    public Decimal? SchoolImprovementAllocation { get => schoolImprovementAllocation; set => SetProperty(ref schoolImprovementAllocation, value, false); }

    public Decimal? SchoolImprovementReservedPercent { get => schoolImprovementReservedPercent; set => SetProperty(ref schoolImprovementReservedPercent, value, false); }

    public Decimal? SesPerPupilExpenditure { get => sesPerPupilExpenditure; set => SetProperty(ref sesPerPupilExpenditure, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12federalFundAllocation model)
    {
        IsBusy = true;
        Id = model.Id;
        FederalProgramCode = model.FederalProgramCode; // 
        FederalProgramsFundingAllocation = model.FederalProgramsFundingAllocation; // 
        FundsTransferAmount = model.FundsTransferAmount; // 
        LeaTransferabilityOfFunds = model.LeaTransferabilityOfFunds; // 
        NumberOfImmigrantProgramSubgrants = model.NumberOfImmigrantProgramSubgrants; // 
        OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
        RefFederalProgramFundingAllocationTypeId = model.RefFederalProgramFundingAllocationTypeId; // 
        RefLeaFundsTransferTypeId = model.RefLeaFundsTransferTypeId; // 
        RefReapAlternativeFundingStatusId = model.RefReapAlternativeFundingStatusId; // 
        SchoolImprovementAllocation = model.SchoolImprovementAllocation; // 
        SchoolImprovementReservedPercent = model.SchoolImprovementReservedPercent; // 
        SesPerPupilExpenditure = model.SesPerPupilExpenditure; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
