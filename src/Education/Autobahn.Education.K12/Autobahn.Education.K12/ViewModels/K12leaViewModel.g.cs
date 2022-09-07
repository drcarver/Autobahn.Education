//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12lea file
/// </summary>
public partial class K12leaViewModel : ObservableValidator, IK12lea
{
    #region "K12leaViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12leaViewModel Constructor
    /// </summary>
    public K12leaViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12leaViewModelConstruction();
    }

    /// <summary>
    /// K12leaViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12leaViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12lea";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the CharterSchoolIndicator property
    private Boolean? charterSchoolIndicator;

    // member variable for the SupervisoryUnionIdentificationNumber property
    private System.String supervisoryUnionIdentificationNumber;

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

    #region "IK12lea Properties"
    public Boolean? CharterSchoolIndicator { get => charterSchoolIndicator; set => SetProperty(ref charterSchoolIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
    /// </summary>
    public Guid? RefCharterLeaStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
    /// </summary>
    public Guid? RefLeaImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaType"/> model
    /// </summary>
    public Guid? RefLeaTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
    /// </summary>
    public Guid? RefPublicSchoolChoiceStatusId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(3,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SupervisoryUnionIdentificationNumber { get => supervisoryUnionIdentificationNumber; set => SetProperty(ref supervisoryUnionIdentificationNumber, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12lea model)
    {
        IsBusy = true;
        Id = model.Id;
        CharterSchoolIndicator = model.CharterSchoolIndicator; // 
        OrganizationId = model.OrganizationId; // 
        RefCharterLeaStatusId = model.RefCharterLeaStatusId; // 
        RefLeaImprovementStatusId = model.RefLeaImprovementStatusId; // 
        RefLeaTypeId = model.RefLeaTypeId; // 
        RefPublicSchoolChoiceStatusId = model.RefPublicSchoolChoiceStatusId; // 
        SupervisoryUnionIdentificationNumber = model.SupervisoryUnionIdentificationNumber; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
