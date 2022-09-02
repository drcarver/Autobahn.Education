//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAccommodation file
/// </summary>
public partial class IndividualizedProgramAccommodationViewModel : ObservableValidator, IIndividualizedProgramAccommodation
{
    #region "IndividualizedProgramAccommodationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramAccommodationViewModel Constructor
    /// </summary>
    public IndividualizedProgramAccommodationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramAccommodationViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramAccommodationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramAccommodationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgramAccommodation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Applicability -- (backing property for Individualized Program Accommodation Applicability)
    private System.String applicability;

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

    #region "IIndividualizedProgramAccommodation Properties"
    /// <summary>
    /// Individualized Program Accommodation Applicability
    /// <para>
    /// Circumstances in which the accommodation or change to standards or practices will be applied.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20667">Individualized Program Accommodation Applicability</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Accommodation Applicability")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Applicability { get => applicability; set => SetProperty(ref applicability, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Accommodation Type
    /// <para>
    /// The specific accommodation necessary for assessment or instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Accommodation Type")]
    public Guid? RefAccommodationTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgramAccommodation model)
    {
        IsBusy = true;
        Id = model.Id;
        Applicability = model.Applicability; // Individualized Program Accommodation Applicability
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        RefAccommodationTypeId = model.RefAccommodationTypeId; // Accommodation Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
