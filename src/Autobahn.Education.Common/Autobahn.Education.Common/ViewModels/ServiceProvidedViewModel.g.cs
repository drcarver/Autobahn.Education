//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServiceProvidedViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IServiceProvided file
/// </summary>
public partial class ServiceProvidedViewModel : ObservableValidator, IServiceProvided
{
    #region "ServiceProvidedViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ServiceProvidedViewModel Constructor
    /// </summary>
    public ServiceProvidedViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnServiceProvidedViewModelConstruction();
    }

    /// <summary>
    /// ServiceProvidedViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnServiceProvidedViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ServiceProvided";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IServiceProvided Properties"
    /// <summary>
    /// Early Childhood Services Received
    /// <para>
    /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19321">Early Childhood Services Received</a>
    /// </para>
    /// </summary>
    [DisplayName("Early Childhood Services Received")]
    public Guid? RefServicesId { get; set; }

    /// <summary>
    /// Student Support Service Type
    /// <para>
    /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Student Support Service Type")]
    public Guid? RefStudentSupportServiceTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
    /// </summary>
    public Guid ServicesReceivedId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IServiceProvided model)
    {
        IsBusy = true;
        Id = model.Id;
        RefServicesId = model.RefServicesId; // Early Childhood Services Received
        RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // Student Support Service Type
        ServicesReceivedId = model.ServicesReceivedId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
