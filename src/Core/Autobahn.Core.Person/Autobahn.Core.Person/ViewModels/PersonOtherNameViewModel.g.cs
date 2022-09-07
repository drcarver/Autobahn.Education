//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonOtherNameViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonOtherName file
/// </summary>
public partial class PersonOtherNameViewModel : ObservableValidator, IPersonOtherName
{
    #region "PersonOtherNameViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonOtherNameViewModel Constructor
    /// </summary>
    public PersonOtherNameViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonOtherNameViewModelConstruction();
    }

    /// <summary>
    /// PersonOtherNameViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonOtherNameViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonOtherName";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FirstName -- (backing property for Other First Name)
    private System.String firstName;

    // LastName -- (backing property for Other Last Name)
    private System.String lastName;

    // MiddleName -- (backing property for Other Middle Name)
    private System.String middleName;

    // OtherName -- (backing property for Other Name)
    private System.String otherName;

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

    #region "IPersonOtherName Properties"
    /// <summary>
    /// Other First Name
    /// <para>
    /// A first name given to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20486">Other First Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Other First Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FirstName { get => firstName; set => SetProperty(ref firstName, value, true); }

    /// <summary>
    /// Other Last Name
    /// <para>
    /// A last name given to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20485">Other Last Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Other Last Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LastName { get => lastName; set => SetProperty(ref lastName, value, true); }

    /// <summary>
    /// Other Middle Name
    /// <para>
    /// A middle name given to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20487">Other Middle Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Other Middle Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MiddleName { get => middleName; set => SetProperty(ref middleName, value, true); }

    /// <summary>
    /// Other Name
    /// <para>
    /// Previous, alternate or other names or aliases associated with the person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19206">Other Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Other Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OtherName { get => otherName; set => SetProperty(ref otherName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Other Name Type
    /// <para>
    /// The types of previous, alternate or other names for a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19627">Other Name Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Other Name Type")]
    public Guid? RefOtherNameTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonOtherName model)
    {
        IsBusy = true;
        Id = model.Id;
        FirstName = model.FirstName; // Other First Name
        LastName = model.LastName; // Other Last Name
        MiddleName = model.MiddleName; // Other Middle Name
        OtherName = model.OtherName; // Other Name
        PersonId = model.PersonId; // 
        RefOtherNameTypeId = model.RefOtherNameTypeId; // Other Name Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
