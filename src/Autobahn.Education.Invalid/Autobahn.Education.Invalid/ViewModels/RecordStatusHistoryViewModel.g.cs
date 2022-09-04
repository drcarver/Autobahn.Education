//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RecordStatusHistoryViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRecordStatusHistory file
/// </summary>
public partial class RecordStatusHistoryViewModel : ObservableValidator, IRecordStatusHistory
{
    #region "RecordStatusHistoryViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RecordStatusHistoryViewModel Constructor
    /// </summary>
    public RecordStatusHistoryViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRecordStatusHistoryViewModelConstruction();
    }

    /// <summary>
    /// RecordStatusHistoryViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRecordStatusHistoryViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RecordStatusHistory";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the RecordPkcolumn property
    private System.String recordPkcolumn;

    // RecordStatusDate -- (backing property for Record Status Date)
    private DateTime? recordStatusDate;

    // member variable for the RecordTable property
    private System.String recordTable;

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

    #region "IRecordStatusHistory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecord"/> model
    /// </summary>
    public Guid RecordId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RecordPkcolumn { get => recordPkcolumn; set => SetProperty(ref recordPkcolumn, value, true); }

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

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RecordTable { get => recordTable; set => SetProperty(ref recordTable, value, true); }

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
    public void Load(IRecordStatusHistory model)
    {
        IsBusy = true;
        Id = model.Id;
        RecordId = model.RecordId; // 
        RecordPkcolumn = model.RecordPkcolumn; // 
        RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId; // 
        RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId; // 
        RecordStatusDate = model.RecordStatusDate; // Record Status Date
        RecordTable = model.RecordTable; // 
        RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId; // Record Status Creator Entity
        RefRecordStatusTypeId = model.RefRecordStatusTypeId; // Record Status Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
