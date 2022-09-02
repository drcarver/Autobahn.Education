//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationAttainmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAttainment file
/// </summary>
public partial class ProgramParticipationAttainmentViewModel : ObservableValidator, IProgramParticipationAttainment
{
    #region "ProgramParticipationAttainmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationAttainmentViewModel Constructor
    /// </summary>
    public ProgramParticipationAttainmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationAttainmentViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationAttainmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationAttainmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationAttainment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AecredentialAttainmentEmployedIndicator property
    private Boolean? aecredentialAttainmentEmployedIndicator;

    // member variable for the AecredentialAttainmentPscredentialIndicator property
    private Boolean? aecredentialAttainmentPscredentialIndicator;

    // member variable for the AecredentialAttainmentPsenrollmentIndicator property
    private Boolean? aecredentialAttainmentPsenrollmentIndicator;

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

    #region "IProgramParticipationAttainment Properties"
    public Boolean? AecredentialAttainmentEmployedIndicator { get => aecredentialAttainmentEmployedIndicator; set => SetProperty(ref aecredentialAttainmentEmployedIndicator, value, false); }

    public Boolean? AecredentialAttainmentPscredentialIndicator { get => aecredentialAttainmentPscredentialIndicator; set => SetProperty(ref aecredentialAttainmentPscredentialIndicator, value, false); }

    public Boolean? AecredentialAttainmentPsenrollmentIndicator { get => aecredentialAttainmentPsenrollmentIndicator; set => SetProperty(ref aecredentialAttainmentPsenrollmentIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// EDFacts Academic or Career and Technical Outcome Exit Type
    /// <para>
    /// The type of academic or career and technical outcome attained up to 90 days after exiting the facility or program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20927">EDFacts Academic or Career and Technical Outcome Exit Type</a>
    /// </para>
    /// </summary>
    [DisplayName("EDFacts Academic or Career and Technical Outcome Exit Type")]
    public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

    /// <summary>
    /// EDFacts Academic or Career and Technical Outcome Type
    /// <para>
    /// The type of academic or career and technical outcome attained while enrolled in the program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20928">EDFacts Academic or Career and Technical Outcome Type</a>
    /// </para>
    /// </summary>
    [DisplayName("EDFacts Academic or Career and Technical Outcome Type")]
    public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationAttainment model)
    {
        IsBusy = true;
        Id = model.Id;
        AecredentialAttainmentEmployedIndicator = model.AecredentialAttainmentEmployedIndicator; // 
        AecredentialAttainmentPscredentialIndicator = model.AecredentialAttainmentPscredentialIndicator; // 
        AecredentialAttainmentPsenrollmentIndicator = model.AecredentialAttainmentPsenrollmentIndicator; // 
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId; // EDFacts Academic or Career and Technical Outcome Exit Type
        RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId; // EDFacts Academic or Career and Technical Outcome Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
