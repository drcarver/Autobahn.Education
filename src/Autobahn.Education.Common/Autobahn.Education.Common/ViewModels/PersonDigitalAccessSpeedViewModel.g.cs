//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDigitalAccessSpeed file
/// </summary>
public partial class PersonDigitalAccessSpeedViewModel : ObservableValidator, IPersonDigitalAccessSpeed
{
    #region "PersonDigitalAccessSpeedViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonDigitalAccessSpeedViewModel Constructor
    /// </summary>
    public PersonDigitalAccessSpeedViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonDigitalAccessSpeedViewModelConstruction();
    }

    /// <summary>
    /// PersonDigitalAccessSpeedViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonDigitalAccessSpeedViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonDigitalAccessSpeed";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // InternetDownloadSpeed -- (backing property for Internet Download Speed)
    private Decimal? internetDownloadSpeed;

    // InternetSpeedTestDateTime -- (backing property for Internet Speed Test Date Time)
    private DateTime? internetSpeedTestDateTime;

    // InternetUploadSpeed -- (backing property for Internet Upload Speed)
    private Decimal? internetUploadSpeed;

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

    #region "IPersonDigitalAccessSpeed Properties"
    /// <summary>
    /// Internet Download Speed
    /// <para>
    /// The speed that data or information can be downloaded from a server on the internet to one's device in megabits per second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20938">Internet Download Speed</a>
    /// </para>
    /// </summary>
    [DisplayName("Internet Download Speed")]
    public Decimal? InternetDownloadSpeed { get => internetDownloadSpeed; set => SetProperty(ref internetDownloadSpeed, value, false); }

    /// <summary>
    /// Internet Speed Test Date Time
    /// <para>
    /// The date and, optionally, time that the information was gathered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20940">Internet Speed Test Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Internet Speed Test Date Time")]
    public DateTime? InternetSpeedTestDateTime { get => internetSpeedTestDateTime; set => SetProperty(ref internetSpeedTestDateTime, value, false); }

    /// <summary>
    /// Internet Upload Speed
    /// <para>
    /// The speed that data or information can be sent from one's device to another device or server on the internet in megabits per second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20941">Internet Upload Speed</a>
    /// </para>
    /// </summary>
    [DisplayName("Internet Upload Speed")]
    public Decimal? InternetUploadSpeed { get => internetUploadSpeed; set => SetProperty(ref internetUploadSpeed, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDigitalAccess"/> model
    /// </summary>
    public Guid? PersonDigitalAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonLearningDevice"/> model
    /// </summary>
    public Guid? PersonLearningDeviceId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonDigitalAccessSpeed model)
    {
        IsBusy = true;
        Id = model.Id;
        InternetDownloadSpeed = model.InternetDownloadSpeed; // Internet Download Speed
        InternetSpeedTestDateTime = model.InternetSpeedTestDateTime; // Internet Speed Test Date Time
        InternetUploadSpeed = model.InternetUploadSpeed; // Internet Upload Speed
        PersonDigitalAccessId = model.PersonDigitalAccessId; // 
        PersonLearningDeviceId = model.PersonLearningDeviceId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
