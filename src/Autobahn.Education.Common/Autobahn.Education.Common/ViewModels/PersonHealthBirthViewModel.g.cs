//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHealthBirth file
/// </summary>
public partial class PersonHealthBirthViewModel : ObservableValidator, IPersonHealthBirth
{
    #region "PersonHealthBirthViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonHealthBirthViewModel Constructor
    /// </summary>
    public PersonHealthBirthViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonHealthBirthViewModelConstruction();
    }

    /// <summary>
    /// PersonHealthBirthViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonHealthBirthViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonHealthBirth";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // MultipleBirthIndicator -- (backing property for Multiple Birth Indicator)
    private Boolean? multipleBirthIndicator;

    // WeeksOfGestation -- (backing property for Weeks of Gestation)
    private Int32? weeksOfGestation;

    // WeightAtBirth -- (backing property for Weight at Birth)
    private System.String weightAtBirth;

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

    #region "IPersonHealthBirth Properties"
    /// <summary>
    /// Multiple Birth Indicator
    /// <para>
    /// An indication that the person is a twin, triplet, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19421">Multiple Birth Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Multiple Birth Indicator")]
    public Boolean? MultipleBirthIndicator { get => multipleBirthIndicator; set => SetProperty(ref multipleBirthIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Trimester When Prenatal Care Began
    /// <para>
    /// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
    /// </para>
    /// </summary>
    [DisplayName("Trimester When Prenatal Care Began")]
    public Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

    /// <summary>
    /// Weeks of Gestation
    /// <para>
    /// The number of weeks during gestational period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19313">Weeks of Gestation</a>
    /// </para>
    /// </summary>
    [DisplayName("Weeks of Gestation")]
    public Int32? WeeksOfGestation { get => weeksOfGestation; set => SetProperty(ref weeksOfGestation, value, false); }

    /// <summary>
    /// Weight at Birth
    /// <para>
    /// The weight of a child at birth in pounds and ounces.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
    /// </para>
    /// </summary>
    [DisplayName("Weight at Birth")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String WeightAtBirth { get => weightAtBirth; set => SetProperty(ref weightAtBirth, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonHealthBirth model)
    {
        IsBusy = true;
        Id = model.Id;
        MultipleBirthIndicator = model.MultipleBirthIndicator; // Multiple Birth Indicator
        PersonId = model.PersonId; // 
        RefTrimesterWhenPrenatalCareBeganId = model.RefTrimesterWhenPrenatalCareBeganId; // Trimester When Prenatal Care Began
        WeeksOfGestation = model.WeeksOfGestation; // Weeks of Gestation
        WeightAtBirth = model.WeightAtBirth; // Weight at Birth
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
