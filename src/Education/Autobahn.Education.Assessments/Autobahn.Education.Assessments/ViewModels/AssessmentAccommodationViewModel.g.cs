//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAccommodationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAccommodation file
/// </summary>
public partial class AssessmentAccommodationViewModel : ObservableValidator, IAssessmentAccommodation
{
    #region "AssessmentAccommodationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentAccommodationViewModel Constructor
    /// </summary>
    public AssessmentAccommodationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentAccommodationViewModelConstruction();
    }

    /// <summary>
    /// AssessmentAccommodationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentAccommodationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentAccommodation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // OtherDescription -- (backing property for Accommodation Other Description)
    private System.String otherDescription;

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

    #region "IAssessmentAccommodation Properties"
    /// <summary>
    /// Accommodation Other Description
    /// <para>
    /// The description of the accommodation when 'Accommodation Type' is set to 'Other'.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20116">Accommodation Other Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Accommodation Other Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OtherDescription { get => otherDescription; set => SetProperty(ref otherDescription, value, true); }

    /// <summary>
    /// Accommodation Type
    /// <para>
    /// The specific accommodation necessary for assessment or instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Accommodation Type")]
    public Guid? RefAccommodationTypeId { get; set; }

    /// <summary>
    /// Assessment Accommodation Category
    /// <para>
    /// A category of accommodations needed for a given assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19374">Assessment Accommodation Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Accommodation Category")]
    public Guid? RefAssessmentAccommodationCategoryId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentAccommodation model)
    {
        IsBusy = true;
        Id = model.Id;
        OtherDescription = model.OtherDescription; // Accommodation Other Description
        RefAccommodationTypeId = model.RefAccommodationTypeId; // Accommodation Type
        RefAssessmentAccommodationCategoryId = model.RefAssessmentAccommodationCategoryId; // Assessment Accommodation Category
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
