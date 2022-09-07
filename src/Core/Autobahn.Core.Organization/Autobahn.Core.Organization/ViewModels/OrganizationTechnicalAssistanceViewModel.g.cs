//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationTechnicalAssistanceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationTechnicalAssistance file
/// </summary>
public partial class OrganizationTechnicalAssistanceViewModel : ObservableValidator, IOrganizationTechnicalAssistance
{
    #region "OrganizationTechnicalAssistanceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationTechnicalAssistanceViewModel Constructor
    /// </summary>
    public OrganizationTechnicalAssistanceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationTechnicalAssistanceViewModelConstruction();
    }

    /// <summary>
    /// OrganizationTechnicalAssistanceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationTechnicalAssistanceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationTechnicalAssistance";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // TechnicalAssistanceApprovedInd -- (backing property for Technical Assistance Approved Indicator)
    private Boolean? technicalAssistanceApprovedInd;

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

    #region "IOrganizationTechnicalAssistance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Technical Assistance Delivery Type
    /// <para>
    /// The method of delivery of technical assistance received/provided
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20466">Technical Assistance Delivery Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Technical Assistance Delivery Type")]
    public Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

    /// <summary>
    /// Technical Assistance Type
    /// <para>
    /// The type of technical assistance provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20467">Technical Assistance Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Technical Assistance Type")]
    public Guid? RefTechnicalAssistanceTypeId { get; set; }

    /// <summary>
    /// Technical Assistance Approved Indicator
    /// <para>
    /// Indicates whether or not the technical assistance was approved.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20465">Technical Assistance Approved Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Technical Assistance Approved Indicator")]
    public Boolean? TechnicalAssistanceApprovedInd { get => technicalAssistanceApprovedInd; set => SetProperty(ref technicalAssistanceApprovedInd, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationTechnicalAssistance model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationId = model.OrganizationId; // 
        RefTechnicalAssistanceDeliveryTypeId = model.RefTechnicalAssistanceDeliveryTypeId; // Technical Assistance Delivery Type
        RefTechnicalAssistanceTypeId = model.RefTechnicalAssistanceTypeId; // Technical Assistance Type
        TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd; // Technical Assistance Approved Indicator
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
