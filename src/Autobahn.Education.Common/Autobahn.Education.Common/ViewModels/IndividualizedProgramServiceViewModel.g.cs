//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramServiceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramService file
/// </summary>
public partial class IndividualizedProgramServiceViewModel : ObservableValidator, IIndividualizedProgramService
{
    #region "IndividualizedProgramServiceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramServiceViewModel Constructor
    /// </summary>
    public IndividualizedProgramServiceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramServiceViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramServiceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramServiceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgramService";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // PlannedServiceDuration -- (backing property for Individualized Program Planned Service Duration)
    private Decimal? plannedServiceDuration;

    // PlannedServiceStartDate -- (backing property for Individualized Program Planned Service Start Date)
    private DateTime? plannedServiceStartDate;

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

    #region "IIndividualizedProgramService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Individualized Program Planned Service Duration
    /// <para>
    /// The length, in hours, that delivery of the service is planned.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20493">Individualized Program Planned Service Duration</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Planned Service Duration")]
    public Decimal? PlannedServiceDuration { get => plannedServiceDuration; set => SetProperty(ref plannedServiceDuration, value, false); }

    /// <summary>
    /// Individualized Program Planned Service Start Date
    /// <para>
    /// The date the service is planned to begin.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20350">Individualized Program Planned Service Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Planned Service Start Date")]
    public DateTime? PlannedServiceStartDate { get => plannedServiceStartDate; set => SetProperty(ref plannedServiceStartDate, value, false); }

    /// <summary>
    /// Individualized Program Planned Service Type
    /// <para>
    /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing special education because of a delay or disability.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20352">Individualized Program Planned Service Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Planned Service Type")]
    public Guid? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

    /// <summary>
    /// Method of Service Delivery
    /// <para>
    /// The method by which the services will be provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20482">Method of Service Delivery</a>
    /// </para>
    /// </summary>
    [DisplayName("Method of Service Delivery")]
    public Guid? RefMethodOfServiceDeliveryId { get; set; }

    /// <summary>
    /// Individualized Program Planned Service Frequency
    /// <para>
    /// The frequency that a service is planned to be provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20492">Individualized Program Planned Service Frequency</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Planned Service Frequency")]
    public Guid? RefServiceFrequencyId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgramService model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonId = model.PersonId; // 
        PlannedServiceDuration = model.PlannedServiceDuration; // Individualized Program Planned Service Duration
        PlannedServiceStartDate = model.PlannedServiceStartDate; // Individualized Program Planned Service Start Date
        RefIndividualizedProgramPlannedServiceTypeId = model.RefIndividualizedProgramPlannedServiceTypeId; // Individualized Program Planned Service Type
        RefMethodOfServiceDeliveryId = model.RefMethodOfServiceDeliveryId; // Method of Service Delivery
        RefServiceFrequencyId = model.RefServiceFrequencyId; // Individualized Program Planned Service Frequency
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
