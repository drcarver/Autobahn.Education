//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefAssociation file
/// </summary>
public partial class CompetencyDefAssociationViewModel : ObservableValidator, ICompetencyDefAssociation
{
    #region "CompetencyDefAssociationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CompetencyDefAssociationViewModel Constructor
    /// </summary>
    public CompetencyDefAssociationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCompetencyDefAssociationViewModelConstruction();
    }

    /// <summary>
    /// CompetencyDefAssociationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCompetencyDefAssociationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CompetencyDefAssociation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the CompetencyDefAssociationIdentifierUri property
    private System.String competencyDefAssociationIdentifierUri;

    // ConnectionCitation -- (backing property for Competency Association Connection Citation)
    private System.String connectionCitation;

    // DestinationNodeName -- (backing property for Competency Association Destination Node Name)
    private System.String destinationNodeName;

    // member variable for the DestinationNodeUri property
    private System.String destinationNodeUri;

    // OriginNodeName -- (backing property for Competency Association Origin Node Name)
    private System.String originNodeName;

    // member variable for the OriginNodeUri property
    private System.String originNodeUri;

    // Weight -- (backing property for Competency Association Weight)
    private Decimal? weight;

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

    #region "ICompetencyDefAssociation Properties"
    /// <summary>
    /// Competency Definition Prerequisite Identifier
    /// <para>
    /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
    /// </para>
    /// <para>
    /// <a href="">Competency Definition Prerequisite Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Prerequisite Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid AssociatedEntityId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CompetencyDefAssociationIdentifierUri { get => competencyDefAssociationIdentifierUri; set => SetProperty(ref competencyDefAssociationIdentifierUri, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    public Guid CompetencyDefinitionId { get; set; }

    /// <summary>
    /// Competency Association Connection Citation
    /// <para>
    /// Any citation appropriate to evidence the connection between nodes
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20371">Competency Association Connection Citation</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Association Connection Citation")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ConnectionCitation { get => connectionCitation; set => SetProperty(ref connectionCitation, value, true); }

    /// <summary>
    /// Competency Association Destination Node Name
    /// <para>
    /// Name of the destination node when the Competency Association is used as a connector in a learning map.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20372">Competency Association Destination Node Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Association Destination Node Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DestinationNodeName { get => destinationNodeName; set => SetProperty(ref destinationNodeName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DestinationNodeUri { get => destinationNodeUri; set => SetProperty(ref destinationNodeUri, value, true); }

    /// <summary>
    /// Competency Association Origin Node Name
    /// <para>
    /// Name of the origin node when the Competency Association is used as a connector in a learning map.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20374">Competency Association Origin Node Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Association Origin Node Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OriginNodeName { get => originNodeName; set => SetProperty(ref originNodeName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OriginNodeUri { get => originNodeUri; set => SetProperty(ref originNodeUri, value, true); }

    /// <summary>
    /// Competency Association Type
    /// <para>
    /// Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19869">Competency Association Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Association Type")]
    public Guid? RefCompetencyDefAssociationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEntityType"/> model
    /// </summary>
    public Guid RefEntityTypeId { get; set; }

    /// <summary>
    /// Learning Resource Competency Alignment Type
    /// <para>
    /// The alignment relationship between the resource and a competency definition object.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19879">Learning Resource Competency Alignment Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Competency Alignment Type")]
    public Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

    /// <summary>
    /// Competency Association Weight
    /// <para>
    /// Indicates the relative significance this connection has for the destination node in a learning map.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20376">Competency Association Weight</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Association Weight")]
    public Decimal? Weight { get => weight; set => SetProperty(ref weight, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICompetencyDefAssociation model)
    {
        IsBusy = true;
        Id = model.Id;
        AssociatedEntityId = model.AssociatedEntityId; // Competency Definition Prerequisite Identifier
        CompetencyDefAssociationIdentifierUri = model.CompetencyDefAssociationIdentifierUri; // 
        CompetencyDefinitionId = model.CompetencyDefinitionId; // 
        ConnectionCitation = model.ConnectionCitation; // Competency Association Connection Citation
        DestinationNodeName = model.DestinationNodeName; // Competency Association Destination Node Name
        DestinationNodeUri = model.DestinationNodeUri; // 
        OriginNodeName = model.OriginNodeName; // Competency Association Origin Node Name
        OriginNodeUri = model.OriginNodeUri; // 
        RefCompetencyDefAssociationTypeId = model.RefCompetencyDefAssociationTypeId; // Competency Association Type
        RefEntityTypeId = model.RefEntityTypeId; // 
        RefLearningResourceCompetencyAlignmentTypeId = model.RefLearningResourceCompetencyAlignmentTypeId; // Learning Resource Competency Alignment Type
        Weight = model.Weight; // Competency Association Weight
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
