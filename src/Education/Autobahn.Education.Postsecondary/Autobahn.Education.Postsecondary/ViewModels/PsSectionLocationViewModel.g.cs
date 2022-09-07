//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsSectionLocation file
/// </summary>
public partial class PsSectionLocationViewModel : ObservableValidator, IPsSectionLocation
{
    #region "PsSectionLocationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsSectionLocationViewModel Constructor
    /// </summary>
    public PsSectionLocationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsSectionLocationViewModelConstruction();
    }

    /// <summary>
    /// PsSectionLocationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsSectionLocationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsSectionLocation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CourseInstructionSiteName -- (backing property for Course Instruction Site Name)
    private System.String courseInstructionSiteName;

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

    #region "IPsSectionLocation Properties"
    /// <summary>
    /// Course Instruction Site Name
    /// <para>
    /// The name of the location at which the course is taught.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20275">Course Instruction Site Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Instruction Site Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseInstructionSiteName { get => courseInstructionSiteName; set => SetProperty(ref courseInstructionSiteName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsSection"/> model
    /// </summary>
    public Guid PsSectionId { get; set; }

    /// <summary>
    /// Course Instruction Site Type
    /// <para>
    /// An indication of the type of location at which the course is taught.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Instruction Site Type")]
    public Guid? RefCourseInstructionSiteTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsSectionLocation model)
    {
        IsBusy = true;
        Id = model.Id;
        CourseInstructionSiteName = model.CourseInstructionSiteName; // Course Instruction Site Name
        PsSectionId = model.PsSectionId; // 
        RefCourseInstructionSiteTypeId = model.RefCourseInstructionSiteTypeId; // Course Instruction Site Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
