//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IStaffEvaluation file
/// </summary>
public partial class StaffEvaluationViewModel : ObservableValidator, IStaffEvaluation
{
    #region "StaffEvaluationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// StaffEvaluationViewModel Constructor
    /// </summary>
    public StaffEvaluationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnStaffEvaluationViewModelConstruction();
    }

    /// <summary>
    /// StaffEvaluationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnStaffEvaluationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from StaffEvaluation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Outcome -- (backing property for Staff Evaluation Outcome)
    private System.String outcome;

    // Scale -- (backing property for Staff Evaluation Scale)
    private System.String scale;

    // ScoreOrRating -- (backing property for Staff Evaluation Score or Rating)
    private System.String scoreOrRating;

    // System -- (backing property for Staff Evaluation System)
    private System.String system;

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

    #region "IStaffEvaluation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Staff Evaluation Outcome
    /// <para>
    /// The result of an assessment of a person's performance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19102">Staff Evaluation Outcome</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Evaluation Outcome")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Outcome { get => outcome; set => SetProperty(ref outcome, value, true); }

    /// <summary>
    /// Faculty and Administration Performance Level
    /// <para>
    /// The levels used in district evaluation systems for assigning teacher or principal performance ratings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19582">Faculty and Administration Performance Level</a>
    /// </para>
    /// </summary>
    [DisplayName("Faculty and Administration Performance Level")]
    public Guid? RefStaffPerformanceLevelId { get; set; }

    /// <summary>
    /// Staff Evaluation Scale
    /// <para>
    /// The quantitative or qualitative range of possible scores/rating for a person's overall performance (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19103">Staff Evaluation Scale</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Evaluation Scale")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Scale { get => scale; set => SetProperty(ref scale, value, true); }

    /// <summary>
    /// Staff Evaluation Score or Rating
    /// <para>
    /// The actual quantitative or qualitative assessment of a person's overall performance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19104">Staff Evaluation Score or Rating</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Evaluation Score or Rating")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScoreOrRating { get => scoreOrRating; set => SetProperty(ref scoreOrRating, value, true); }

    /// <summary>
    /// Staff Evaluation System
    /// <para>
    /// The instrument and/or set of procedures with which a person's performance is assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19105">Staff Evaluation System</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Evaluation System")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String System { get => system; set => SetProperty(ref system, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IStaffEvaluation model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        Outcome = model.Outcome; // Staff Evaluation Outcome
        RefStaffPerformanceLevelId = model.RefStaffPerformanceLevelId; // Faculty and Administration Performance Level
        Scale = model.Scale; // Staff Evaluation Scale
        ScoreOrRating = model.ScoreOrRating; // Staff Evaluation Score or Rating
        System = model.System; // Staff Evaluation System
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
