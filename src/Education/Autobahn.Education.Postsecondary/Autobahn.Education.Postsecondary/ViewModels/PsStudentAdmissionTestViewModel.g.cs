//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentAdmissionTest file
/// </summary>
public partial class PsStudentAdmissionTestViewModel : ObservableValidator, IPsStudentAdmissionTest
{
    #region "PsStudentAdmissionTestViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentAdmissionTestViewModel Constructor
    /// </summary>
    public PsStudentAdmissionTestViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentAdmissionTestViewModelConstruction();
    }

    /// <summary>
    /// PsStudentAdmissionTestViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentAdmissionTestViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentAdmissionTest";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // StandardizedAdmissionTestScore -- (backing property for Standardized Admission Test Score)
    private Decimal? standardizedAdmissionTestScore;

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

    #region "IPsStudentAdmissionTest Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Standardized Admission Test Type
    /// <para>
    /// The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19266">Standardized Admission Test Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Standardized Admission Test Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefStandardizedAdmissionTestId { get; set; }

    /// <summary>
    /// Standardized Admission Test Score
    /// <para>
    /// The quantitative score on a standardized admission test reported to a postsecondary institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19265">Standardized Admission Test Score</a>
    /// </para>
    /// </summary>
    [DisplayName("Standardized Admission Test Score")]
    public Decimal? StandardizedAdmissionTestScore { get => standardizedAdmissionTestScore; set => SetProperty(ref standardizedAdmissionTestScore, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentAdmissionTest model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefStandardizedAdmissionTestId = model.RefStandardizedAdmissionTestId; // Standardized Admission Test Type
        StandardizedAdmissionTestScore = model.StandardizedAdmissionTestScore; // Standardized Admission Test Score
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
