//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDigitalAccessViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDigitalAccess file
/// </summary>
public partial class PersonDigitalAccessViewModel : ObservableValidator, IPersonDigitalAccess
{
    #region "PersonDigitalAccessViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonDigitalAccessViewModel Constructor
    /// </summary>
    public PersonDigitalAccessViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonDigitalAccessViewModelConstruction();
    }

    /// <summary>
    /// PersonDigitalAccessViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonDigitalAccessViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonDigitalAccess";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // InternetAccessInResidence -- (backing property for Internet Access In Residence)
    private Boolean? internetAccessInResidence;

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

    #region "IPersonDigitalAccess Properties"
    /// <summary>
    /// Internet Access In Residence
    /// <para>
    /// An indication of whether the student is able to access the internet in their primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20936">Internet Access In Residence</a>
    /// </para>
    /// </summary>
    [DisplayName("Internet Access In Residence")]
    public Boolean? InternetAccessInResidence { get => internetAccessInResidence; set => SetProperty(ref internetAccessInResidence, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    public Guid? PersonAddressId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Barrier to Internet Access In Residence
    /// <para>
    /// An indication of the barrier to having internet access in the student's primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20916">Barrier to Internet Access In Residence</a>
    /// </para>
    /// </summary>
    [DisplayName("Barrier to Internet Access In Residence")]
    public Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

    /// <summary>
    /// Internet Access Type In Residence
    /// <para>
    /// The primary type of internet service used in the student's primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20937">Internet Access Type In Residence</a>
    /// </para>
    /// </summary>
    [DisplayName("Internet Access Type In Residence")]
    public Guid? RefInternetAccessTypeInResidenceId { get; set; }

    /// <summary>
    /// Internet Performance In Residence
    /// <para>
    /// An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20939">Internet Performance In Residence</a>
    /// </para>
    /// </summary>
    [DisplayName("Internet Performance In Residence")]
    public Guid? RefInternetPerformanceInResidenceId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonDigitalAccess model)
    {
        IsBusy = true;
        Id = model.Id;
        InternetAccessInResidence = model.InternetAccessInResidence; // Internet Access In Residence
        PersonAddressId = model.PersonAddressId; // 
        PersonId = model.PersonId; // 
        RefBarrierToInternetAccessInResidenceId = model.RefBarrierToInternetAccessInResidenceId; // Barrier to Internet Access In Residence
        RefInternetAccessTypeInResidenceId = model.RefInternetAccessTypeInResidenceId; // Internet Access Type In Residence
        RefInternetPerformanceInResidenceId = model.RefInternetPerformanceInResidenceId; // Internet Performance In Residence
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
