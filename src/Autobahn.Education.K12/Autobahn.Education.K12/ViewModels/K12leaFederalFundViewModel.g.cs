//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalFundViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalFund file
/// </summary>
public partial class K12leaFederalFundViewModel : ObservableValidator, IK12leaFederalFund
{
    #region "K12leaFederalFundViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12leaFederalFundViewModel Constructor
    /// </summary>
    public K12leaFederalFundViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12leaFederalFundViewModelConstruction();
    }

    /// <summary>
    /// K12leaFederalFundViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12leaFederalFundViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12leaFederalFund";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the InnovativeDollarsSpent property
    private Decimal? innovativeDollarsSpent;

    // member variable for the InnovativeDollarsSpentOnStrategicPriorities property
    private Decimal? innovativeDollarsSpentOnStrategicPriorities;

    // member variable for the InnovativeProgramsFundsReceived property
    private Decimal? innovativeProgramsFundsReceived;

    // member variable for the ParentalInvolvementReservationFunds property
    private Decimal? parentalInvolvementReservationFunds;

    // member variable for the PublicSchoolChoiceFundsSpent property
    private Decimal? publicSchoolChoiceFundsSpent;

    // member variable for the SesFundsSpent property
    private Decimal? sesFundsSpent;

    // member variable for the SesSchoolChoice20PercentObligation property
    private Decimal? sesSchoolChoice20PercentObligation;

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

    #region "IK12leaFederalFund Properties"
    public Decimal? InnovativeDollarsSpent { get => innovativeDollarsSpent; set => SetProperty(ref innovativeDollarsSpent, value, false); }

    public Decimal? InnovativeDollarsSpentOnStrategicPriorities { get => innovativeDollarsSpentOnStrategicPriorities; set => SetProperty(ref innovativeDollarsSpentOnStrategicPriorities, value, false); }

    public Decimal? InnovativeProgramsFundsReceived { get => innovativeProgramsFundsReceived; set => SetProperty(ref innovativeProgramsFundsReceived, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leaFederalFunds"/> model
    /// </summary>
    public Guid K12leaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    public Guid OrganizationCalendarSessionId { get; set; }

    public Decimal? ParentalInvolvementReservationFunds { get => parentalInvolvementReservationFunds; set => SetProperty(ref parentalInvolvementReservationFunds, value, false); }

    public Decimal? PublicSchoolChoiceFundsSpent { get => publicSchoolChoiceFundsSpent; set => SetProperty(ref publicSchoolChoiceFundsSpent, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
    /// </summary>
    public Guid? RefRlisProgramUseId { get; set; }

    public Decimal? SesFundsSpent { get => sesFundsSpent; set => SetProperty(ref sesFundsSpent, value, false); }

    public Decimal? SesSchoolChoice20PercentObligation { get => sesSchoolChoice20PercentObligation; set => SetProperty(ref sesSchoolChoice20PercentObligation, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12leaFederalFund model)
    {
        IsBusy = true;
        Id = model.Id;
        InnovativeDollarsSpent = model.InnovativeDollarsSpent; // 
        InnovativeDollarsSpentOnStrategicPriorities = model.InnovativeDollarsSpentOnStrategicPriorities; // 
        InnovativeProgramsFundsReceived = model.InnovativeProgramsFundsReceived; // 
        K12leaFederalFundsId = model.K12leaFederalFundsId; // 
        OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
        ParentalInvolvementReservationFunds = model.ParentalInvolvementReservationFunds; // 
        PublicSchoolChoiceFundsSpent = model.PublicSchoolChoiceFundsSpent; // 
        RefRlisProgramUseId = model.RefRlisProgramUseId; // 
        SesFundsSpent = model.SesFundsSpent; // 
        SesSchoolChoice20PercentObligation = model.SesSchoolChoice20PercentObligation; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
