//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDisabilityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDisability file
/// </summary>
public partial class PersonDisabilityViewModel : ObservableValidator, IPersonDisability
{
    #region "PersonDisabilityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonDisabilityViewModel Constructor
    /// </summary>
    public PersonDisabilityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonDisabilityViewModelConstruction();
    }

    /// <summary>
    /// PersonDisabilityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonDisabilityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonDisability";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DisabilityStatus -- (backing property for Disability Status)
    private Boolean? disabilityStatus;

    // SignificantCognitiveDisabilityIndicator -- (backing property for Significant Cognitive Disability Indicator)
    private Boolean? significantCognitiveDisabilityIndicator;

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

    #region "IPersonDisability Properties"
    /// <summary>
    /// Disability Status
    /// <para>
    /// An indication of whether a person is classified as disabled under the American's with Disability Act (ADA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19569">Disability Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Disability Status")]
    public Boolean? DisabilityStatus { get => disabilityStatus; set => SetProperty(ref disabilityStatus, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Primary Disability Type
    /// <para>
    /// The major or overriding disability condition that best describes a person's impairment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19218">Primary Disability Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Primary Disability Type")]
    public Guid? PrimaryDisabilityTypeId { get; set; }

    /// <summary>
    /// Accommodations Needed Type
    /// <para>
    /// Codes identifying the set of health accommodations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20243">Accommodations Needed Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Accommodations Needed Type")]
    public Guid? RefAccommodationsNeededTypeId { get; set; }

    /// <summary>
    /// Disability Condition Status Type
    /// <para>
    /// A code indicating the disability condition status.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20285">Disability Condition Status Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Disability Condition Status Type")]
    public Guid? RefDisabilityConditionStatusCodeId { get; set; }

    /// <summary>
    /// Disability Condition Type
    /// <para>
    /// Codes identifying the set of disability conditions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20286">Disability Condition Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Disability Condition Type")]
    public Guid? RefDisabilityConditionTypeId { get; set; }

    /// <summary>
    /// Disability Determination Source Type
    /// <para>
    /// Codes identifying the set of disability determination sources.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20287">Disability Determination Source Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Disability Determination Source Type")]
    public Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeadisabilityType"/> model
    /// </summary>
    public Guid? RefIdeadisabilityTypeId { get; set; }

    /// <summary>
    /// Significant Cognitive Disability Indicator
    /// <para>
    /// Student has an existing IDEA disability with cognitive impairments which may prevent him/her from attaining grade-level achievement standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20746">Significant Cognitive Disability Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Significant Cognitive Disability Indicator")]
    public Boolean? SignificantCognitiveDisabilityIndicator { get => significantCognitiveDisabilityIndicator; set => SetProperty(ref significantCognitiveDisabilityIndicator, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonDisability model)
    {
        IsBusy = true;
        Id = model.Id;
        DisabilityStatus = model.DisabilityStatus; // Disability Status
        PersonId = model.PersonId; // 
        PrimaryDisabilityTypeId = model.PrimaryDisabilityTypeId; // Primary Disability Type
        RefAccommodationsNeededTypeId = model.RefAccommodationsNeededTypeId; // Accommodations Needed Type
        RefDisabilityConditionStatusCodeId = model.RefDisabilityConditionStatusCodeId; // Disability Condition Status Type
        RefDisabilityConditionTypeId = model.RefDisabilityConditionTypeId; // Disability Condition Type
        RefDisabilityDeterminationSourceTypeId = model.RefDisabilityDeterminationSourceTypeId; // Disability Determination Source Type
        RefIdeadisabilityTypeId = model.RefIdeadisabilityTypeId; // 
        SignificantCognitiveDisabilityIndicator = model.SignificantCognitiveDisabilityIndicator; // Significant Cognitive Disability Indicator
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
