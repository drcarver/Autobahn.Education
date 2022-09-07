//***************************************************************************
//* DomainName: Common Models
//* FileName:   ClassroomViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IClassroom file
/// </summary>
public partial class ClassroomViewModel : ObservableValidator, IClassroom
{
    #region "ClassroomViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ClassroomViewModel Constructor
    /// </summary>
    public ClassroomViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnClassroomViewModelConstruction();
    }

    /// <summary>
    /// ClassroomViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnClassroomViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Classroom";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ClassroomIdentifier -- (backing property for Classroom Identifier)
    private System.String classroomIdentifier;

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

    #region "IClassroom Properties"
    /// <summary>
    /// Classroom Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Classroom Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ClassroomIdentifier { get => classroomIdentifier; set => SetProperty(ref classroomIdentifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    public Guid LocationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IClassroom model)
    {
        IsBusy = true;
        Id = model.Id;
        ClassroomIdentifier = model.ClassroomIdentifier; // Classroom Identifier
        LocationId = model.LocationId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
