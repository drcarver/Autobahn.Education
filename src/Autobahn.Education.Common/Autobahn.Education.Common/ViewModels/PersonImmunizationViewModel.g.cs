//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonImmunization file
/// </summary>
public partial class PersonImmunizationViewModel : ObservableValidator, IPersonImmunization
{
    #region "PersonImmunizationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonImmunizationViewModel Constructor
    /// </summary>
    public PersonImmunizationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonImmunizationViewModelConstruction();
    }

    /// <summary>
    /// PersonImmunizationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonImmunizationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonImmunization";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ImmunizationDate -- (backing property for Immunization Date)
    private System.DateTime immunizationDate;

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

    #region "IPersonImmunization Properties"
    /// <summary>
    /// Immunization Date
    /// <para>
    /// The year, month and day of an immunization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19306">Immunization Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Immunization Date")]
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime ImmunizationDate { get => immunizationDate; set => SetProperty(ref immunizationDate, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Immunization Type
    /// <para>
    /// An indication of the type of immunization that an individual has satisfactorily received. (Note: The International Classification of Diseases (ICD) is maintained by the World Health Organization. The ICD is revised periodically to incorporate changes in the medical field, the most updated and detailed list of International Statistical Classification of Diseases and Related Health Problems can be found at http://www.who.int/classifications/apps/icd/icd10online).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20214">Immunization Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Immunization Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefImmunizationTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonImmunization model)
    {
        IsBusy = true;
        Id = model.Id;
        ImmunizationDate = model.ImmunizationDate; // Immunization Date
        PersonId = model.PersonId; // 
        RefImmunizationTypeId = model.RefImmunizationTypeId; // Immunization Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
