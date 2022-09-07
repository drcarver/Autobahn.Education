//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDemographicRaceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDemographicRace file
/// </summary>
public partial class PersonDemographicRaceViewModel : ObservableValidator, IPersonDemographicRace
{
    #region "PersonDemographicRaceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonDemographicRaceViewModel Constructor
    /// </summary>
    public PersonDemographicRaceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonDemographicRaceViewModelConstruction();
    }

    /// <summary>
    /// PersonDemographicRaceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonDemographicRaceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonDemographicRace";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FederalRaceAndEthnicityDeclined -- (backing property for Federal Race and Ethnicity Declined)
    private Boolean? federalRaceAndEthnicityDeclined;

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

    #region "IPersonDemographicRace Properties"
    /// <summary>
    /// Federal Race and Ethnicity Declined
    /// <para>
    /// A parent, guardian, or student declined to report sufficient information for identifying a student's federal race and/or ethnicity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20932">Federal Race and Ethnicity Declined</a>
    /// </para>
    /// </summary>
    [DisplayName("Federal Race and Ethnicity Declined")]
    public Boolean? FederalRaceAndEthnicityDeclined { get => federalRaceAndEthnicityDeclined; set => SetProperty(ref federalRaceAndEthnicityDeclined, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRace"/> model
    /// </summary>
    public Guid RefRaceId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonDemographicRace model)
    {
        IsBusy = true;
        Id = model.Id;
        FederalRaceAndEthnicityDeclined = model.FederalRaceAndEthnicityDeclined; // Federal Race and Ethnicity Declined
        PersonId = model.PersonId; // 
        RefRaceId = model.RefRaceId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
