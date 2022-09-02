//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElstaffEducationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEducation file
/// </summary>
public partial class ElstaffEducationViewModel : ObservableValidator, IElstaffEducation
{
    #region "ElstaffEducationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElstaffEducationViewModel Constructor
    /// </summary>
    public ElstaffEducationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElstaffEducationViewModelConstruction();
    }

    /// <summary>
    /// ElstaffEducationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElstaffEducationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElstaffEducation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the EcdegreeOrCertificateHolder property
    private Boolean? ecdegreeOrCertificateHolder;

    // member variable for the SchoolAgeEducationPscredits property
    private Decimal? schoolAgeEducationPscredits;

    // member variable for the TotalApprovedEccreditsEarned property
    private Decimal? totalApprovedEccreditsEarned;

    // member variable for the TotalCollegeCreditsEarned property
    private Decimal? totalCollegeCreditsEarned;

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

    #region "IElstaffEducation Properties"
    public Boolean? EcdegreeOrCertificateHolder { get => ecdegreeOrCertificateHolder; set => SetProperty(ref ecdegreeOrCertificateHolder, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElstaff"/> model
    /// </summary>
    public Guid ElstaffId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEllevelOfSpecialization"/> model
    /// </summary>
    public Guid? RefEllevelOfSpecializationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprofessionalDevelopmentTopicArea"/> model
    /// </summary>
    public Guid? RefElprofessionalDevelopmentTopicAreaId { get; set; }

    public Decimal? SchoolAgeEducationPscredits { get => schoolAgeEducationPscredits; set => SetProperty(ref schoolAgeEducationPscredits, value, false); }

    public Decimal? TotalApprovedEccreditsEarned { get => totalApprovedEccreditsEarned; set => SetProperty(ref totalApprovedEccreditsEarned, value, false); }

    public Decimal? TotalCollegeCreditsEarned { get => totalCollegeCreditsEarned; set => SetProperty(ref totalCollegeCreditsEarned, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElstaffEducation model)
    {
        IsBusy = true;
        Id = model.Id;
        EcdegreeOrCertificateHolder = model.EcdegreeOrCertificateHolder; // 
        ElstaffId = model.ElstaffId; // 
        RefEllevelOfSpecializationId = model.RefEllevelOfSpecializationId; // 
        RefElprofessionalDevelopmentTopicAreaId = model.RefElprofessionalDevelopmentTopicAreaId; // 
        SchoolAgeEducationPscredits = model.SchoolAgeEducationPscredits; // 
        TotalApprovedEccreditsEarned = model.TotalApprovedEccreditsEarned; // 
        TotalCollegeCreditsEarned = model.TotalCollegeCreditsEarned; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
