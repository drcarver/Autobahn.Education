//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonRelationship file
/// </summary>
public partial class PersonRelationshipViewModel : ObservableValidator, IPersonRelationship
{
    #region "PersonRelationshipViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonRelationshipViewModel Constructor
    /// </summary>
    public PersonRelationshipViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonRelationshipViewModelConstruction();
    }

    /// <summary>
    /// PersonRelationshipViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonRelationshipViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonRelationship";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ContactPriorityNumber -- (backing property for Person Relationship to Learner Contact Priority Number)
    private Int32? contactPriorityNumber;

    // ContactRestrictions -- (backing property for Person Relationship to Learner Contact Restrictions Description)
    private System.String contactRestrictions;

    // CustodialRelationshipIndicator -- (backing property for Custodial Parent or Guardian Indicator)
    private Boolean? custodialRelationshipIndicator;

    // EmergencyContactInd -- (backing property for Emergency Contact Indicator)
    private Boolean? emergencyContactInd;

    // LivesWithIndicator -- (backing property for Person Relationship to Learner Lives with Indicator)
    private Boolean? livesWithIndicator;

    // PrimaryContactIndicator -- (backing property for Primary Contact Indicator)
    private Boolean? primaryContactIndicator;

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

    #region "IPersonRelationship Properties"
    /// <summary>
    /// Person Relationship to Learner Contact Priority Number
    /// <para>
    /// The numeric order in the preferred sequence and priority for contacting a person related to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20392">Person Relationship to Learner Contact Priority Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Person Relationship to Learner Contact Priority Number")]
    public Int32? ContactPriorityNumber { get => contactPriorityNumber; set => SetProperty(ref contactPriorityNumber, value, false); }

    /// <summary>
    /// Person Relationship to Learner Contact Restrictions Description
    /// <para>
    /// Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20393">Person Relationship to Learner Contact Restrictions Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Person Relationship to Learner Contact Restrictions Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ContactRestrictions { get => contactRestrictions; set => SetProperty(ref contactRestrictions, value, true); }

    /// <summary>
    /// Custodial Parent or Guardian Indicator
    /// <para>
    /// An indication that a person has legal custody of a child.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19328">Custodial Parent or Guardian Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Custodial Parent or Guardian Indicator")]
    public Boolean? CustodialRelationshipIndicator { get => custodialRelationshipIndicator; set => SetProperty(ref custodialRelationshipIndicator, value, false); }

    /// <summary>
    /// Emergency Contact Indicator
    /// <para>
    /// Indicates whether or not the person is a designated emergency contact for the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20308">Emergency Contact Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Emergency Contact Indicator")]
    public Boolean? EmergencyContactInd { get => emergencyContactInd; set => SetProperty(ref emergencyContactInd, value, false); }

    /// <summary>
    /// Person Relationship to Learner Lives with Indicator
    /// <para>
    /// Indicates whether or not the learner lives with the related person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20394">Person Relationship to Learner Lives with Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Person Relationship to Learner Lives with Indicator")]
    public Boolean? LivesWithIndicator { get => livesWithIndicator; set => SetProperty(ref livesWithIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Primary Contact Indicator
    /// <para>
    /// Indicates that a person is a primary contact within the specified context, such as a primary parental contact specified in Person Relationship to Learner or a primary administrative contact for an organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20397">Primary Contact Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Primary Contact Indicator")]
    public Boolean? PrimaryContactIndicator { get => primaryContactIndicator; set => SetProperty(ref primaryContactIndicator, value, false); }

    /// <summary>
    /// Person Relationship Type
    /// <para>
    /// The nature of a person's relationship to another person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19415">Person Relationship Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Person Relationship Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefPersonRelationshipTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRelatedPerson"/> model
    /// </summary>
    public Guid RelatedPersonId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonRelationship model)
    {
        IsBusy = true;
        Id = model.Id;
        ContactPriorityNumber = model.ContactPriorityNumber; // Person Relationship to Learner Contact Priority Number
        ContactRestrictions = model.ContactRestrictions; // Person Relationship to Learner Contact Restrictions Description
        CustodialRelationshipIndicator = model.CustodialRelationshipIndicator; // Custodial Parent or Guardian Indicator
        EmergencyContactInd = model.EmergencyContactInd; // Emergency Contact Indicator
        LivesWithIndicator = model.LivesWithIndicator; // Person Relationship to Learner Lives with Indicator
        PersonId = model.PersonId; // 
        PrimaryContactIndicator = model.PrimaryContactIndicator; // Primary Contact Indicator
        RefPersonRelationshipTypeId = model.RefPersonRelationshipTypeId; // Person Relationship Type
        RelatedPersonId = model.RelatedPersonId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
