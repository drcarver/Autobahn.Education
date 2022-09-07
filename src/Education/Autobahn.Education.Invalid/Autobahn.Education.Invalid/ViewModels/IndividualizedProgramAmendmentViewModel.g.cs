//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramAmendmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAmendment file
/// </summary>
public partial class IndividualizedProgramAmendmentViewModel : ObservableValidator, IIndividualizedProgramAmendment
{
    #region "IndividualizedProgramAmendmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramAmendmentViewModel Constructor
    /// </summary>
    public IndividualizedProgramAmendmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramAmendmentViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramAmendmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramAmendmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgramAmendment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ReasonDescription -- (backing property for Individualized Program Service Plan Amendment Reason Description)
    private System.String reasonDescription;

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

    #region "IIndividualizedProgramAmendment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Amendment Reason Description
    /// <para>
    /// Description of the reason changes were made to the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20669">Individualized Program Service Plan Amendment Reason Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Amendment Reason Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ReasonDescription { get => reasonDescription; set => SetProperty(ref reasonDescription, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgramAmendment model)
    {
        IsBusy = true;
        Id = model.Id;
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        ReasonDescription = model.ReasonDescription; // Individualized Program Service Plan Amendment Reason Description
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
