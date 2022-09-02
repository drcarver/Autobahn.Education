//***************************************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationCte file
/// </summary>
public partial class ProgramParticipationCteViewModel : ObservableValidator, IProgramParticipationCte
{
    #region "ProgramParticipationCteViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationCteViewModel Constructor
    /// </summary>
    public ProgramParticipationCteViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationCteViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationCteViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationCteViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationCte";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CareerPathwaysProgramParticipationExitDate -- (backing property for Career Pathways Program Participation Exit Date)
    private DateTime? careerPathwaysProgramParticipationExitDate;

    // CareerPathwaysProgramParticipationStartDate -- (backing property for Career Pathways Program Participation Start Date)
    private DateTime? careerPathwaysProgramParticipationStartDate;

    // CteCompleter -- (backing property for Career and Technical Education Completer)
    private Boolean? cteCompleter;

    // CteConcentrator -- (backing property for Career and Technical Education Concentrator)
    private Boolean? cteConcentrator;

    // CteNonTraditionalCompletion -- (backing property for Career and Technical Education Nontraditional Completion)
    private Boolean? cteNonTraditionalCompletion;

    // CteParticipant -- (backing property for Career and Technical Education Participant)
    private Boolean? cteParticipant;

    // DisplacedHomemakerIndicator -- (backing property for Career-Technical-Adult Education Displaced Homemaker Indicator)
    private Boolean? displacedHomemakerIndicator;

    // OutOfWorkforceIndicator -- (backing property for Out of Workforce Indicator)
    private Boolean? outOfWorkforceIndicator;

    // SingleParentOrSinglePregnantWoman -- (backing property for Single Parent or Single Pregnant Woman Status)
    private Boolean? singleParentOrSinglePregnantWoman;

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

    #region "IProgramParticipationCte Properties"
    /// <summary>
    /// Career Pathways Program Participation Exit Date
    /// <para>
    /// The year, month and day on which the person ceased to participate in a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20562">Career Pathways Program Participation Exit Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Career Pathways Program Participation Exit Date")]
    public DateTime? CareerPathwaysProgramParticipationExitDate { get => careerPathwaysProgramParticipationExitDate; set => SetProperty(ref careerPathwaysProgramParticipationExitDate, value, false); }

    /// <summary>
    /// Career Pathways Program Participation Start Date
    /// <para>
    /// The year, month and day on which the person began to participate in a career pathway program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20563">Career Pathways Program Participation Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Career Pathways Program Participation Start Date")]
    public DateTime? CareerPathwaysProgramParticipationStartDate { get => careerPathwaysProgramParticipationStartDate; set => SetProperty(ref careerPathwaysProgramParticipationStartDate, value, false); }

    /// <summary>
    /// Career and Technical Education Completer
    /// <para>
    /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19036">Career and Technical Education Completer</a>
    /// </para>
    /// </summary>
    [DisplayName("Career and Technical Education Completer")]
    public Boolean? CteCompleter { get => cteCompleter; set => SetProperty(ref cteCompleter, value, false); }

    /// <summary>
    /// Career and Technical Education Concentrator
    /// <para>
    /// An indication of a student who has met the state-defined threshold of career and technical education concentrators, as defined in the State's approved Perkins IV State Plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19037">Career and Technical Education Concentrator</a>
    /// </para>
    /// </summary>
    [DisplayName("Career and Technical Education Concentrator")]
    public Boolean? CteConcentrator { get => cteConcentrator; set => SetProperty(ref cteConcentrator, value, false); }

    /// <summary>
    /// Career and Technical Education Nontraditional Completion
    /// <para>
    /// An indication that the CTE student has completed a CTE program in a nontraditional field (where one gender comprises less than 25 percent of the persons employed in those occupations or fields of work).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19586">Career and Technical Education Nontraditional Completion</a>
    /// </para>
    /// </summary>
    [DisplayName("Career and Technical Education Nontraditional Completion")]
    public Boolean? CteNonTraditionalCompletion { get => cteNonTraditionalCompletion; set => SetProperty(ref cteNonTraditionalCompletion, value, false); }

    /// <summary>
    /// Career and Technical Education Participant
    /// <para>
    /// An indication a student has met the state-defined threshold of Career and Technical Education participation as defined in the State's approved Perkins IV State Plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19585">Career and Technical Education Participant</a>
    /// </para>
    /// </summary>
    [DisplayName("Career and Technical Education Participant")]
    public Boolean? CteParticipant { get => cteParticipant; set => SetProperty(ref cteParticipant, value, false); }

    /// <summary>
    /// Career-Technical-Adult Education Displaced Homemaker Indicator
    /// <para>
    /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19084">Career-Technical-Adult Education Displaced Homemaker Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Career-Technical-Adult Education Displaced Homemaker Indicator")]
    public Boolean? DisplacedHomemakerIndicator { get => displacedHomemakerIndicator; set => SetProperty(ref displacedHomemakerIndicator, value, false); }

    /// <summary>
    /// Out of Workforce Indicator
    /// <para>
    /// An individual: (A) who is a displaced homemaker, as defined in section 3 of the Workforce Innovation and Opportunity Act (29 U.S.C. 3102); or (B) who (i)(I) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills; or (II) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (ii) is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20908">Out of Workforce Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Out of Workforce Indicator")]
    public Boolean? OutOfWorkforceIndicator { get => outOfWorkforceIndicator; set => SetProperty(ref outOfWorkforceIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Career Technical Education Nontraditional Gender Status
    /// <para>
    /// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19581">Career Technical Education Nontraditional Gender Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Career Technical Education Nontraditional Gender Status")]
    public Guid? RefNonTraditionalGenderStatusId { get; set; }

    /// <summary>
    /// Work-based Learning Opportunity Type
    /// <para>
    /// The type of work-based learning opportunity a student participated in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Work-based Learning Opportunity Type")]
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    /// <summary>
    /// Single Parent or Single Pregnant Woman Status
    /// <para>
    /// A student who, at some time during the school year, is either a pregnant female student who is unmarried; or a male or female student who is unmarried or legally separated from a spouse and has a minor child or children.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19573">Single Parent or Single Pregnant Woman Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Single Parent or Single Pregnant Woman Status")]
    public Boolean? SingleParentOrSinglePregnantWoman { get => singleParentOrSinglePregnantWoman; set => SetProperty(ref singleParentOrSinglePregnantWoman, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationCte model)
    {
        IsBusy = true;
        Id = model.Id;
        CareerPathwaysProgramParticipationExitDate = model.CareerPathwaysProgramParticipationExitDate; // Career Pathways Program Participation Exit Date
        CareerPathwaysProgramParticipationStartDate = model.CareerPathwaysProgramParticipationStartDate; // Career Pathways Program Participation Start Date
        CteCompleter = model.CteCompleter; // Career and Technical Education Completer
        CteConcentrator = model.CteConcentrator; // Career and Technical Education Concentrator
        CteNonTraditionalCompletion = model.CteNonTraditionalCompletion; // Career and Technical Education Nontraditional Completion
        CteParticipant = model.CteParticipant; // Career and Technical Education Participant
        DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator; // Career-Technical-Adult Education Displaced Homemaker Indicator
        OutOfWorkforceIndicator = model.OutOfWorkforceIndicator; // Out of Workforce Indicator
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        RefNonTraditionalGenderStatusId = model.RefNonTraditionalGenderStatusId; // Career Technical Education Nontraditional Gender Status
        RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // Work-based Learning Opportunity Type
        SingleParentOrSinglePregnantWoman = model.SingleParentOrSinglePregnantWoman; // Single Parent or Single Pregnant Woman Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
