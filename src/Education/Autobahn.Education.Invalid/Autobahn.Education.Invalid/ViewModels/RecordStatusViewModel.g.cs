//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RecordStatusViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRecordStatus file
/// </summary>
public partial class RecordStatusViewModel : ObservableValidator, IRecordStatus
{
    #region "RecordStatusViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RecordStatusViewModel Constructor
    /// </summary>
    public RecordStatusViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRecordStatusViewModelConstruction();
    }

    /// <summary>
    /// RecordStatusViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRecordStatusViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RecordStatus";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // RecordStatusDate -- (backing property for Record Status Date)
    private DateTime? recordStatusDate;

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

    #region "IRecordStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecordStatusCreatorOrganization"/> model
    /// </summary>
    public Guid? RecordStatusCreatorOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecordStatusCreatorPerson"/> model
    /// </summary>
    public Guid? RecordStatusCreatorPersonId { get; set; }

    /// <summary>
    /// Record Status Date
    /// <para>
    /// The date the record was marked with the Record Status Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20957">Record Status Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Record Status Date")]
    public DateTime? RecordStatusDate { get => recordStatusDate; set => SetProperty(ref recordStatusDate, value, false); }

    /// <summary>
    /// Record Status Creator Entity
    /// <para>
    /// The type of entity that created or indicated the Record Status Type
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20956">Record Status Creator Entity</a>
    /// </para>
    /// </summary>
    [DisplayName("Record Status Creator Entity")]
    public Guid? RefRecordStatusCreatorEntityId { get; set; }

    /// <summary>
    /// Record Status Type
    /// <para>
    /// A process indicator of the level of stability, quality, and/or preparedness of the record.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20958">Record Status Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Record Status Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefRecordStatusTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IRecordStatus model)
    {
        IsBusy = true;
        Id = model.Id;
        RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId; // 
        RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId; // 
        RecordStatusDate = model.RecordStatusDate; // Record Status Date
        RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId; // Record Status Creator Entity
        RefRecordStatusTypeId = model.RefRecordStatusTypeId; // Record Status Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
