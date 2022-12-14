//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElclassSectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElclassSection file
/// </summary>
public partial class ElclassSectionViewModel : ObservableValidator, IElclassSection
{
    #region "ElclassSectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElclassSectionViewModel Constructor
    /// </summary>
    public ElclassSectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElclassSectionViewModelConstruction();
    }

    /// <summary>
    /// ElclassSectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElclassSectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElclassSection";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the DaysAvailablePerWeek property
    private Int32? daysAvailablePerWeek;

    // member variable for the ElprogramAnnualOperatingWeeks property
    private Int32? elprogramAnnualOperatingWeeks;

    // member variable for the GroupSize property
    private Int32? groupSize;

    // member variable for the HoursAvailablePerDay property
    private Decimal? hoursAvailablePerDay;

    // member variable for the LanguageTranslationPolicy property
    private Boolean? languageTranslationPolicy;

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

    #region "IElclassSection Properties"
    public Int32? DaysAvailablePerWeek { get => daysAvailablePerWeek; set => SetProperty(ref daysAvailablePerWeek, value, false); }

    public Int32? ElprogramAnnualOperatingWeeks { get => elprogramAnnualOperatingWeeks; set => SetProperty(ref elprogramAnnualOperatingWeeks, value, false); }

    public Int32? GroupSize { get => groupSize; set => SetProperty(ref groupSize, value, false); }

    public Decimal? HoursAvailablePerDay { get => hoursAvailablePerDay; set => SetProperty(ref hoursAvailablePerDay, value, false); }

    public Boolean? LanguageTranslationPolicy { get => languageTranslationPolicy; set => SetProperty(ref languageTranslationPolicy, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
    /// </summary>
    public Guid? RefEnvironmentSettingId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    public Guid? RefServiceOptionId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElclassSection model)
    {
        IsBusy = true;
        Id = model.Id;
        DaysAvailablePerWeek = model.DaysAvailablePerWeek; // 
        ElprogramAnnualOperatingWeeks = model.ElprogramAnnualOperatingWeeks; // 
        GroupSize = model.GroupSize; // 
        HoursAvailablePerDay = model.HoursAvailablePerDay; // 
        LanguageTranslationPolicy = model.LanguageTranslationPolicy; // 
        OrganizationId = model.OrganizationId; // 
        RefEnvironmentSettingId = model.RefEnvironmentSettingId; // 
        RefServiceOptionId = model.RefServiceOptionId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
