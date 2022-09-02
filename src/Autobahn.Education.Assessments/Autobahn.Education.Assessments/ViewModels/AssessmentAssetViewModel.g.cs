//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssetViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAsset file
/// </summary>
public partial class AssessmentAssetViewModel : ObservableValidator, IAssessmentAsset
{
    #region "AssessmentAssetViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentAssetViewModel Constructor
    /// </summary>
    public AssessmentAssetViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentAssetViewModelConstruction();
    }

    /// <summary>
    /// AssessmentAssetViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentAssetViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentAsset";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ContentMimeType -- (backing property for Assessment Asset Content Mime Type)
    private System.String contentMimeType;

    // ContentUrl -- (backing property for Assessment Asset Content URL)
    private System.String contentUrl;

    // member variable for the ContentXml property
    private System.String contentXml;

    // Identifier -- (backing property for Assessment Asset Identifier)
    private System.String identifier;

    // Name -- (backing property for Assessment Asset Name)
    private System.String name;

    // Owner -- (backing property for Assessment Asset Owner)
    private System.String owner;

    // PublishedDate -- (backing property for Assessment Asset Published Date)
    private DateTime? publishedDate;

    // RefAssessmentAssestIdentifierType -- (backing property for Assessment Asset Identifier Type)
    private Int32? refAssessmentAssestIdentifierType;

    // Version -- (backing property for Assessment Asset Version)
    private System.String version;

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

    #region "IAssessmentAsset Properties"
    /// <summary>
    /// Assessment Asset Content Mime Type
    /// <para>
    /// MIME type to specifically indicate the Assessment Asset content type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20154">Assessment Asset Content Mime Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Content Mime Type")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ContentMimeType { get => contentMimeType; set => SetProperty(ref contentMimeType, value, true); }

    /// <summary>
    /// Assessment Asset Content URL
    /// <para>
    /// The Uniform Resource Locator (URL) location of the external Assessment Asset content.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20155">Assessment Asset Content URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Content URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ContentUrl { get => contentUrl; set => SetProperty(ref contentUrl, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    public System.String ContentXml { get => contentXml; set => SetProperty(ref contentXml, value, true); }

    /// <summary>
    /// Assessment Asset Identifier
    /// <para>
    /// A unique code identifying the Assessment Asset provided by the authoring system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20149">Assessment Asset Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid? LearningResourceId { get; set; }

    /// <summary>
    /// Assessment Asset Name
    /// <para>
    /// The name of the Assessment Asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20151">Assessment Asset Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Assessment Asset Owner
    /// <para>
    /// The name of the ownership rights holder or publisher of the asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20152">Assessment Asset Owner</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Owner")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Owner { get => owner; set => SetProperty(ref owner, value, true); }

    /// <summary>
    /// Assessment Asset Published Date
    /// <para>
    /// The date that this version of the asset was made available for use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20148">Assessment Asset Published Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Published Date")]
    public DateTime? PublishedDate { get => publishedDate; set => SetProperty(ref publishedDate, value, false); }

    /// <summary>
    /// Assessment Asset Identifier Type
    /// <para>
    /// The type of identifier that is provided for this asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20150">Assessment Asset Identifier Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Identifier Type")]
    public Int32? RefAssessmentAssestIdentifierType { get => refAssessmentAssestIdentifierType; set => SetProperty(ref refAssessmentAssestIdentifierType, value, false); }

    /// <summary>
    /// Assessment Asset Type
    /// <para>
    /// Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20147">Assessment Asset Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Type")]
    public Guid? RefAssessmentAssetTypeId { get; set; }

    /// <summary>
    /// Assessment Language
    /// <para>
    /// The language in which the assessment form is designed to be delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20073">Assessment Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Language")]
    public Guid? RefAssessmentLanguageId { get; set; }

    /// <summary>
    /// Assessment Asset Version
    /// <para>
    /// A version number or label defined by the publisher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20146">Assessment Asset Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Asset Version")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentAsset model)
    {
        IsBusy = true;
        Id = model.Id;
        ContentMimeType = model.ContentMimeType; // Assessment Asset Content Mime Type
        ContentUrl = model.ContentUrl; // Assessment Asset Content URL
        ContentXml = model.ContentXml; // 
        Identifier = model.Identifier; // Assessment Asset Identifier
        LearningResourceId = model.LearningResourceId; // 
        Name = model.Name; // Assessment Asset Name
        Owner = model.Owner; // Assessment Asset Owner
        PublishedDate = model.PublishedDate; // Assessment Asset Published Date
        RefAssessmentAssestIdentifierType = model.RefAssessmentAssestIdentifierType; // Assessment Asset Identifier Type
        RefAssessmentAssetTypeId = model.RefAssessmentAssetTypeId; // Assessment Asset Type
        RefAssessmentLanguageId = model.RefAssessmentLanguageId; // Assessment Language
        Version = model.Version; // Assessment Asset Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
