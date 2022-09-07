//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonHealthViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHealth file
/// </summary>
public partial class PersonHealthViewModel : ObservableValidator, IPersonHealth
{
    #region "PersonHealthViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonHealthViewModel Constructor
    /// </summary>
    public PersonHealthViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonHealthViewModelConstruction();
    }

    /// <summary>
    /// PersonHealthViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonHealthViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonHealth";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DentalScreeningDate -- (backing property for Dental Screening Date)
    private System.DateTime dentalScreeningDate;

    // HealthScreeningEquipmentUsed -- (backing property for Health Screening Equipment Used)
    private System.String healthScreeningEquipmentUsed;

    // HealthScreeningFollowUpRecommendation -- (backing property for Health Screening Follow-up Recommendation)
    private System.String healthScreeningFollowUpRecommendation;

    // HearingScreeningDate -- (backing property for Hearing Screening Date)
    private DateTime? hearingScreeningDate;

    // VisionScreeningDate -- (backing property for Vision Screening Date)
    private DateTime? visionScreeningDate;

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

    #region "IPersonHealth Properties"
    /// <summary>
    /// Dental Screening Date
    /// <para>
    /// The year, month and day of a dental screening
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19682">Dental Screening Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Dental Screening Date")]
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime DentalScreeningDate { get => dentalScreeningDate; set => SetProperty(ref dentalScreeningDate, value, true); }

    /// <summary>
    /// Health Screening Equipment Used
    /// <para>
    /// The screening equipment used for the hearing screening or the method used for the vision screening
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20325">Health Screening Equipment Used</a>
    /// </para>
    /// </summary>
    [DisplayName("Health Screening Equipment Used")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String HealthScreeningEquipmentUsed { get => healthScreeningEquipmentUsed; set => SetProperty(ref healthScreeningEquipmentUsed, value, true); }

    /// <summary>
    /// Health Screening Follow-up Recommendation
    /// <para>
    /// Recommendations for follow-up after a health screening.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20326">Health Screening Follow-up Recommendation</a>
    /// </para>
    /// </summary>
    [DisplayName("Health Screening Follow-up Recommendation")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String HealthScreeningFollowUpRecommendation { get => healthScreeningFollowUpRecommendation; set => SetProperty(ref healthScreeningFollowUpRecommendation, value, true); }

    /// <summary>
    /// Hearing Screening Date
    /// <para>
    /// The year, month and day of a hearing screening.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19681">Hearing Screening Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Hearing Screening Date")]
    public DateTime? HearingScreeningDate { get => hearingScreeningDate; set => SetProperty(ref hearingScreeningDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Dental Insurance Coverage Type
    /// <para>
    /// The source of insurance covering an person's dental care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19335">Dental Insurance Coverage Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Dental Insurance Coverage Type")]
    public Guid? RefDentalInsuranceCoverageTypeId { get; set; }

    /// <summary>
    /// Dental Screening Status
    /// <para>
    /// The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19310">Dental Screening Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Dental Screening Status")]
    public Guid? RefDentalScreeningStatusId { get; set; }

    /// <summary>
    /// Insurance Coverage
    /// <para>
    /// The nature of insurance covering an person's hospitalization and other health or medical care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19334">Insurance Coverage</a>
    /// </para>
    /// </summary>
    [DisplayName("Insurance Coverage")]
    public Guid? RefHealthInsuranceCoverageId { get; set; }

    /// <summary>
    /// Hearing Screening Status
    /// <para>
    /// Status of an examination used to measure a person's ability to perceive sounds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19309">Hearing Screening Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Hearing Screening Status")]
    public Guid? RefHearingScreeningStatusId { get; set; }

    /// <summary>
    /// Medical Alert Indicator
    /// <para>
    /// Alert indicator for a medical/health condition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19429">Medical Alert Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Medical Alert Indicator")]
    public Guid? RefMedicalAlertIndicatorId { get; set; }

    /// <summary>
    /// Vision Screening Status
    /// <para>
    /// Status of an examination used to measure a person's ability to see.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19308">Vision Screening Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Vision Screening Status")]
    public Guid? RefVisionScreeningStatusId { get; set; }

    /// <summary>
    /// Vision Screening Date
    /// <para>
    /// The year, month and day of a vision screening.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19680">Vision Screening Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Vision Screening Date")]
    public DateTime? VisionScreeningDate { get => visionScreeningDate; set => SetProperty(ref visionScreeningDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonHealth model)
    {
        IsBusy = true;
        Id = model.Id;
        DentalScreeningDate = model.DentalScreeningDate; // Dental Screening Date
        HealthScreeningEquipmentUsed = model.HealthScreeningEquipmentUsed; // Health Screening Equipment Used
        HealthScreeningFollowUpRecommendation = model.HealthScreeningFollowUpRecommendation; // Health Screening Follow-up Recommendation
        HearingScreeningDate = model.HearingScreeningDate; // Hearing Screening Date
        PersonId = model.PersonId; // 
        RefDentalInsuranceCoverageTypeId = model.RefDentalInsuranceCoverageTypeId; // Dental Insurance Coverage Type
        RefDentalScreeningStatusId = model.RefDentalScreeningStatusId; // Dental Screening Status
        RefHealthInsuranceCoverageId = model.RefHealthInsuranceCoverageId; // Insurance Coverage
        RefHearingScreeningStatusId = model.RefHearingScreeningStatusId; // Hearing Screening Status
        RefMedicalAlertIndicatorId = model.RefMedicalAlertIndicatorId; // Medical Alert Indicator
        RefVisionScreeningStatusId = model.RefVisionScreeningStatusId; // Vision Screening Status
        VisionScreeningDate = model.VisionScreeningDate; // Vision Screening Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
