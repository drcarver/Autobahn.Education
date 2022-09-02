//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   PersonViewModel.cs
//***************************************************************************

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// The Person View Model
/// </summary>
public partial class PersonViewModel : ObservableValidator, IPerson
{
    #region "PersonViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonViewModel Constructor
    /// </summary>
    public PersonViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonViewModelConstruction();
    }

    /// <summary>
    /// PersonDetailViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Person";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Birthdate -- (backing property for Birthdate)
    private DateTime? birthdate;

    // Birthdate -- (backing property for Deathdate)
    private DateTime? deathdate;

    // FirstName -- (backing property for First Name)
    private System.String firstName;

    // GenerationCode -- (backing property for Generation Code or Suffix)
    private System.String generationCode;

    // LastName -- (backing property for Last or Surname)
    private System.String lastName;

    // MiddleName -- (backing property for Middle Name)
    private System.String middleName;

    // Prefix -- (backing property for Personal Title or Prefix)
    private System.String prefix;
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
    [Key]
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

    #region "IPerson Properties"
    /// <summary>
    /// Birthdate
    /// <para>
    /// The year, month and day on which a person was born.
    /// </para>
    /// </summary>
    [DisplayName("Birthdate")]
    public DateTime? Birthdate { get => birthdate; set => SetProperty(ref birthdate, value, false); }

    /// <summary>
    /// Deathdate
    /// <para>
    /// The year, month and day on which a person died.
    /// </para>
    /// </summary>
    [DisplayName("Deathdate")]
    public DateTime? Deathdate { get => deathdate; set => SetProperty(ref deathdate, value, false); }

    /// <summary>
    /// First Name
    /// <para>
    /// The full legal first name given to a person at birth, 
    /// baptism, or through legal change.
    /// </para>
    /// </summary>
    [DisplayName("First Name")]
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(75, ErrorMessage = "The {0} must be less then {1} characters.")]
    public System.String FirstName { get => firstName; set => SetProperty(ref firstName, value, true); }

    /// <summary>
    /// Generation Code or Suffix
    /// <para>
    /// An appendage, if any, used to denote a person's generation 
    /// in his family (e.g., Jr., Sr., III).
    /// </para>
    /// </summary>
    [DisplayName("Generation Code or Suffix")]
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(10, ErrorMessage = "The {0} must be less then {1} characters.")]
    public System.String GenerationCode { get => generationCode; set => SetProperty(ref generationCode, value, true); }

    /// <summary>
    /// Last or Surname
    /// <para>
    /// The full legal last name borne in common by members of a family.
    /// </para>
    /// </summary>
    [DisplayName("Last or Surname")]
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(75, ErrorMessage = "The {0} must be less then {1} characters.")]
    public System.String LastName { get => lastName; set => SetProperty(ref lastName, value, true); }

    /// <summary>
    /// Middle Name
    /// <para>
    /// A full legal middle name given to a person at birth, baptism, or through legal change.
    /// </para>
    /// </summary>
    [DisplayName("Middle Name")]
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(75, ErrorMessage = "The {0} must be less then {1} characters.")]
    public System.String MiddleName { get => middleName; set => SetProperty(ref middleName, value, true); }

    /// <summary>
    /// Personal Title or Prefix
    /// <para>
    /// An appellation, if any, used to denote rank, placement, or status (e.g., Mr., Ms., Reverend, Sister, Dr., Colonel).
    /// </para>
    /// </summary>
    [DisplayName("Personal Title or Prefix")]
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(30, ErrorMessage = "The {0} must be less then {1} characters.")]
    public System.String Prefix { get => prefix; set => SetProperty(ref prefix, value, true); }

    /// <summary>
    /// Sex
    /// <para>
    /// The concept describing the biological traits that distinguish the males and females of a species.
    /// </para>
    /// </summary>
    [DisplayName("Sex")]
    public Guid? RefSexId { get; set; }
    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPerson model)
    {
        IsBusy = true;
        Id = model.Id;
        Birthdate = model.Birthdate; // Birthdate
        Deathdate = model.Deathdate; // Deathdate
        FirstName = model.FirstName; // First Name
        GenerationCode = model.GenerationCode; // Generation Code or Suffix
        LastName = model.LastName; // Last or Surname
        MiddleName = model.MiddleName; // Middle Name
        Prefix = model.Prefix; // Personal Title or Prefix
        RefSexId = model.RefSexId; // Sex
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
