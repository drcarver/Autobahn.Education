//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonPersonalInformationVerificationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonPersonalInformationVerification file
/// </summary>
public partial class PersonPersonalInformationVerificationViewModel : ObservableValidator, IPersonPersonalInformationVerification
{
    #region "PersonPersonalInformationVerificationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonPersonalInformationVerificationViewModel Constructor
    /// </summary>
    public PersonPersonalInformationVerificationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonPersonalInformationVerificationViewModelConstruction();
    }

    /// <summary>
    /// PersonPersonalInformationVerificationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonPersonalInformationVerificationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonPersonalInformationVerification";

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

    #region "IPersonPersonalInformationVerification Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    public Guid? PersonAddressId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDetail"/> model
    /// </summary>
    public Guid? PersonDetailId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonTelephone"/> model
    /// </summary>
    public Guid? PersonTelephoneId { get; set; }

    /// <summary>
    /// Personal Information Type
    /// <para>
    /// The type of personal information verified through the Personal Information Verification evidence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20951">Personal Information Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Personal Information Type")]
    public Guid? RefPersonalInformationTypeId { get; set; }

    /// <summary>
    /// Personal Information Verification
    /// <para>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// </summary>
    [DisplayName("Personal Information Verification")]
    public Guid? RefPersonalInformationVerificationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonPersonalInformationVerification model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonAddressId = model.PersonAddressId; // 
        PersonDetailId = model.PersonDetailId; // 
        PersonId = model.PersonId; // 
        PersonTelephoneId = model.PersonTelephoneId; // 
        RefPersonalInformationTypeId = model.RefPersonalInformationTypeId; // Personal Information Type
        RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // Personal Information Verification
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
