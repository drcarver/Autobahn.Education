//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramEligibility file
/// </summary>
public partial class IndividualizedProgramEligibilityViewModel : ObservableValidator, IIndividualizedProgramEligibility
{
    #region "IndividualizedProgramEligibilityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramEligibilityViewModel Constructor
    /// </summary>
    public IndividualizedProgramEligibilityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramEligibilityViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramEligibilityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramEligibilityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgramEligibility";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ConsentToEvaluateDate -- (backing property for Consent to Evaluation Date)
    private DateTime? consentToEvaluateDate;

    // ConsentToEvaluateIndicator -- (backing property for Consent to Evaluation Indicator)
    private Boolean? consentToEvaluateIndicator;

    // ParentObservations -- (backing property for Eligibility Parent Observations Explanation)
    private System.String parentObservations;

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

    #region "IIndividualizedProgramEligibility Properties"
    /// <summary>
    /// Consent to Evaluation Date
    /// <para>
    /// The date the consent to evaluation occurred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20708">Consent to Evaluation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Consent to Evaluation Date")]
    public DateTime? ConsentToEvaluateDate { get => consentToEvaluateDate; set => SetProperty(ref consentToEvaluateDate, value, false); }

    /// <summary>
    /// Consent to Evaluation Indicator
    /// <para>
    /// Indication parent agreed to evaluate student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20707">Consent to Evaluation Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Consent to Evaluation Indicator")]
    public Boolean? ConsentToEvaluateIndicator { get => consentToEvaluateIndicator; set => SetProperty(ref consentToEvaluateIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Eligibility Parent Observations Explanation
    /// <para>
    /// Explanation of parent's observations of student's characteristics and history used for determining eligibility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20713">Eligibility Parent Observations Explanation</a>
    /// </para>
    /// </summary>
    [DisplayName("Eligibility Parent Observations Explanation")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ParentObservations { get => parentObservations; set => SetProperty(ref parentObservations, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgramEligibility model)
    {
        IsBusy = true;
        Id = model.Id;
        ConsentToEvaluateDate = model.ConsentToEvaluateDate; // Consent to Evaluation Date
        ConsentToEvaluateIndicator = model.ConsentToEvaluateIndicator; // Consent to Evaluation Indicator
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        ParentObservations = model.ParentObservations; // Eligibility Parent Observations Explanation
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
