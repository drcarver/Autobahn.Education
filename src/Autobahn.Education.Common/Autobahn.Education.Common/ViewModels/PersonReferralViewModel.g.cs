//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonReferral file
/// </summary>
public partial class PersonReferralViewModel : ObservableValidator, IPersonReferral
{
    #region "PersonReferralViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonReferralViewModel Constructor
    /// </summary>
    public PersonReferralViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonReferralViewModelConstruction();
    }

    /// <summary>
    /// PersonReferralViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonReferralViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonReferral";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Reason -- (backing property for Referral Reason)
    private System.String reason;

    // ReferralDate -- (backing property for Referral Date)
    private DateTime? referralDate;

    // ReferralTypeReceived -- (backing property for Referral Type Received)
    private System.String referralTypeReceived;

    // ReferredTo -- (backing property for Referred To)
    private System.String referredTo;

    // Source -- (backing property for Referral Source)
    private System.String source;

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

    #region "IPersonReferral Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Referral Reason
    /// <para>
    /// The reason for the referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20455">Referral Reason</a>
    /// </para>
    /// </summary>
    [DisplayName("Referral Reason")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Reason { get => reason; set => SetProperty(ref reason, value, true); }

    /// <summary>
    /// Referral Date
    /// <para>
    /// The date of referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20453">Referral Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Referral Date")]
    public DateTime? ReferralDate { get => referralDate; set => SetProperty(ref referralDate, value, false); }

    /// <summary>
    /// Referral Type Received
    /// <para>
    /// A type of service that a child or family has received a referral for.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20457">Referral Type Received</a>
    /// </para>
    /// </summary>
    [DisplayName("Referral Type Received")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ReferralTypeReceived { get => referralTypeReceived; set => SetProperty(ref referralTypeReceived, value, true); }

    /// <summary>
    /// Referred To
    /// <para>
    /// The program or organization to which the child/family was referred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20458">Referred To</a>
    /// </para>
    /// </summary>
    [DisplayName("Referred To")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ReferredTo { get => referredTo; set => SetProperty(ref referredTo, value, true); }

    /// <summary>
    /// Referral Outcome
    /// <para>
    /// The outcome of the referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20454">Referral Outcome</a>
    /// </para>
    /// </summary>
    [DisplayName("Referral Outcome")]
    public Guid? RefReferralOutcomeId { get; set; }

    /// <summary>
    /// Referral Source
    /// <para>
    /// The person, program, or organization making the initial referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20456">Referral Source</a>
    /// </para>
    /// </summary>
    [DisplayName("Referral Source")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Source { get => source; set => SetProperty(ref source, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonReferral model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonId = model.PersonId; // 
        Reason = model.Reason; // Referral Reason
        ReferralDate = model.ReferralDate; // Referral Date
        ReferralTypeReceived = model.ReferralTypeReceived; // Referral Type Received
        ReferredTo = model.ReferredTo; // Referred To
        RefReferralOutcomeId = model.RefReferralOutcomeId; // Referral Outcome
        Source = model.Source; // Referral Source
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
