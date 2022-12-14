//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RequiredImmunizationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRequiredImmunization file
/// </summary>
public partial class RequiredImmunizationViewModel : ObservableValidator, IRequiredImmunization
{
    #region "RequiredImmunizationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RequiredImmunizationViewModel Constructor
    /// </summary>
    public RequiredImmunizationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRequiredImmunizationViewModelConstruction();
    }

    /// <summary>
    /// RequiredImmunizationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRequiredImmunizationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RequiredImmunization";

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

    #region "IRequiredImmunization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Required Immunization
    /// <para>
    /// An indication that an immunization is specifically required by an organization or governing body.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19307">Required Immunization</a>
    /// </para>
    /// </summary>
    [DisplayName("Required Immunization")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefImmunizationTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IRequiredImmunization model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationId = model.OrganizationId; // 
        RefImmunizationTypeId = model.RefImmunizationTypeId; // Required Immunization
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
