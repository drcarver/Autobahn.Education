//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IStaffEvaluationPart file
/// </summary>
public partial class StaffEvaluationPartViewModel : ObservableValidator, IStaffEvaluationPart
{
    #region "StaffEvaluationPartViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// StaffEvaluationPartViewModel Constructor
    /// </summary>
    public StaffEvaluationPartViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnStaffEvaluationPartViewModelConstruction();
    }

    /// <summary>
    /// StaffEvaluationPartViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnStaffEvaluationPartViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from StaffEvaluationPart";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // PartName -- (backing property for Staff Evaluation Part Name)
    private System.String partName;

    // Scale -- (backing property for Staff Evaluation Part Scale)
    private System.String scale;

    // ScoreOrRating -- (backing property for Staff Evaluation Part Score or Rating)
    private System.String scoreOrRating;

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

    #region "IStaffEvaluationPart Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Staff Evaluation Part Name
    /// <para>
    /// The name of the component part that is being evaluated and scored.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20965">Staff Evaluation Part Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Evaluation Part Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String PartName { get => partName; set => SetProperty(ref partName, value, true); }

    /// <summary>
    /// Staff Evaluation Part Scale
    /// <para>
    /// The quantitative or qualitative range of possible scores/rating for a person's performance on a component part (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20966">Staff Evaluation Part Scale</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Evaluation Part Scale")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Scale { get => scale; set => SetProperty(ref scale, value, true); }

    /// <summary>
    /// Staff Evaluation Part Score or Rating
    /// <para>
    /// The actual quantitative or qualitative assessment of a person's performance on a component part that is being evaluated. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20967">Staff Evaluation Part Score or Rating</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Evaluation Part Score or Rating")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScoreOrRating { get => scoreOrRating; set => SetProperty(ref scoreOrRating, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEvaluation"/> model
    /// </summary>
    public Guid? StaffEvaluationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IStaffEvaluationPart model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        PartName = model.PartName; // Staff Evaluation Part Name
        Scale = model.Scale; // Staff Evaluation Part Scale
        ScoreOrRating = model.ScoreOrRating; // Staff Evaluation Part Score or Rating
        StaffEvaluationId = model.StaffEvaluationId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
