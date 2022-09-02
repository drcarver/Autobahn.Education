//***************************************************************************
//* DomainName: Common Models
//* FileName:   ApipInteractionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IApipInteraction file
/// </summary>
public partial class ApipInteractionViewModel : ObservableValidator, IApipInteraction
{
    #region "ApipInteractionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ApipInteractionViewModel Constructor
    /// </summary>
    public ApipInteractionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnApipInteractionViewModelConstruction();
    }

    /// <summary>
    /// ApipInteractionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnApipInteractionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ApipInteraction";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ApipinteractionSequenceNumber property
    private Decimal? apipinteractionSequenceNumber;

    // member variable for the SequenceNumber property
    private Int32? sequenceNumber;

    // Xml -- (backing property for Assessment Item Body Custom Interaction XML)
    private System.String xml;

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

    #region "IApipInteraction Properties"
    public Decimal? ApipinteractionSequenceNumber { get => apipinteractionSequenceNumber; set => SetProperty(ref apipinteractionSequenceNumber, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
    /// </summary>
    public Guid AssessmentItemApipId { get; set; }

    /// <summary>
    /// Assessment Item Body Drawing Interaction XML
    /// <para>
    /// The drawing interaction allows the candidate to use a common set of drawing tools to modify a given graphical image (the canvas). It must be bound to a response variable with base-type file and single cardinality. The result is a file in the same format as the original image. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20080">Assessment Item Body Drawing Interaction XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Body Drawing Interaction XML")]
    public Guid? RefApipInteractionTypeId { get; set; }

    public Int32? SequenceNumber { get => sequenceNumber; set => SetProperty(ref sequenceNumber, value, false); }

    /// <summary>
    /// Assessment Item Body Custom Interaction XML
    /// <para>
    /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20079">Assessment Item Body Custom Interaction XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Body Custom Interaction XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Xml { get => xml; set => SetProperty(ref xml, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IApipInteraction model)
    {
        IsBusy = true;
        Id = model.Id;
        ApipinteractionSequenceNumber = model.ApipinteractionSequenceNumber; // 
        AssessmentItemApipId = model.AssessmentItemApipId; // 
        RefApipInteractionTypeId = model.RefApipInteractionTypeId; // Assessment Item Body Drawing Interaction XML
        SequenceNumber = model.SequenceNumber; // 
        Xml = model.Xml; // Assessment Item Body Custom Interaction XML
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
