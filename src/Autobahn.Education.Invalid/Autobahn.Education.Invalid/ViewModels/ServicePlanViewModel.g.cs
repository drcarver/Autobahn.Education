//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ServicePlanViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IServicePlan file
/// </summary>
public partial class ServicePlanViewModel : ObservableValidator, IServicePlan
{
    #region "ServicePlanViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ServicePlanViewModel Constructor
    /// </summary>
    public ServicePlanViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnServicePlanViewModelConstruction();
    }

    /// <summary>
    /// ServicePlanViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnServicePlanViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ServicePlan";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DeclinedServicesDate -- (backing property for Declined Services Date)
    private DateTime? declinedServicesDate;

    // ExtendsOutsideSchoolYear -- (backing property for Service Extends Outside School Year)
    private Boolean? extendsOutsideSchoolYear;

    // InclusiveSettingIndicator -- (backing property for Inclusive Setting Indicator)
    private Boolean? inclusiveSettingIndicator;

    // ReasonForDeclinedServices -- (backing property for Reason for Declined Services)
    private System.String reasonForDeclinedServices;

    // SettingDescription -- (backing property for Service Setting Description)
    private System.String settingDescription;

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

    #region "IServicePlan Properties"
    /// <summary>
    /// Declined Services Date
    /// <para>
    /// The date recommended services were declined.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20693">Declined Services Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Declined Services Date")]
    public DateTime? DeclinedServicesDate { get => declinedServicesDate; set => SetProperty(ref declinedServicesDate, value, false); }

    /// <summary>
    /// Service Extends Outside School Year
    /// <para>
    /// Determination if this service continues outside school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20698">Service Extends Outside School Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Service Extends Outside School Year")]
    public Boolean? ExtendsOutsideSchoolYear { get => extendsOutsideSchoolYear; set => SetProperty(ref extendsOutsideSchoolYear, value, false); }

    /// <summary>
    /// Inclusive Setting Indicator
    /// <para>
    /// Indicates that services are provided to the child in a place where children of all abilities learn together.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Inclusive Setting Indicator")]
    public Boolean? InclusiveSettingIndicator { get => inclusiveSettingIndicator; set => SetProperty(ref inclusiveSettingIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reason for Declined Services
    /// <para>
    /// The reason given for declining the recommended services.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20460">Reason for Declined Services</a>
    /// </para>
    /// </summary>
    [DisplayName("Reason for Declined Services")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ReasonForDeclinedServices { get => reasonForDeclinedServices; set => SetProperty(ref reasonForDeclinedServices, value, true); }

    /// <summary>
    /// Service Setting Description
    /// <para>
    /// Description of the setting in which the services are delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20699">Service Setting Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Service Setting Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String SettingDescription { get => settingDescription; set => SetProperty(ref settingDescription, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IServicePlan model)
    {
        IsBusy = true;
        Id = model.Id;
        DeclinedServicesDate = model.DeclinedServicesDate; // Declined Services Date
        ExtendsOutsideSchoolYear = model.ExtendsOutsideSchoolYear; // Service Extends Outside School Year
        InclusiveSettingIndicator = model.InclusiveSettingIndicator; // Inclusive Setting Indicator
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        ReasonForDeclinedServices = model.ReasonForDeclinedServices; // Reason for Declined Services
        SettingDescription = model.SettingDescription; // Service Setting Description
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
