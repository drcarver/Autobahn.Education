//***************************************************************************
//* DomainName: Common Models
//* FileName:   CredentialDefinitionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefinition file
/// </summary>
public partial class CredentialDefinitionViewModel : ObservableValidator, ICredentialDefinition
{
    #region "CredentialDefinitionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialDefinitionViewModel Constructor
    /// </summary>
    public CredentialDefinitionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialDefinitionViewModelConstruction();
    }

    /// <summary>
    /// CredentialDefinitionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialDefinitionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialDefinition";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AlternateName -- (backing property for Credential Definition Alternate Name)
    private System.String alternateName;

    // CredentialDefDateEffective -- (backing property for Credential Definition Date Effective)
    private DateTime? credentialDefDateEffective;

    // CredentialDefinitionTerminalDegreeIndicator -- (backing property for Credential Definition Terminal Degree Indicator)
    private Boolean? credentialDefinitionTerminalDegreeIndicator;

    // member variable for the CredentialNaicsindustryType property
    private System.String credentialNaicsindustryType;

    // member variable for the EmploymentNaicscode property
    private System.String employmentNaicscode;

    // ImageUrl -- (backing property for Credential Image URL)
    private System.String imageUrl;

    // JurisdictionRegion -- (backing property for Credential Definition Jurisdiction Region)
    private System.String jurisdictionRegion;

    // JurisdictionRegionException -- (backing property for Credential Definition Jurisdiction Region Exception)
    private System.String jurisdictionRegionException;

    // Keywords -- (backing property for Credential Definition Keywords)
    private System.String keywords;

    // Title -- (backing property for Credential Definition Title)
    private System.String title;

    // ValidationMethodDescription -- (backing property for Credential Definition Validation Method Description)
    private System.String validationMethodDescription;

    // Version -- (backing property for Credential Definition Version)
    private Decimal? version;

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

    #region "ICredentialDefinition Properties"
    /// <summary>
    /// Credential Definition Alternate Name
    /// <para>
    /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Alternate Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AlternateName { get => alternateName; set => SetProperty(ref alternateName, value, true); }

    /// <summary>
    /// Credential Definition Date Effective
    /// <para>
    /// Effective date of the content of a credential definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20891">Credential Definition Date Effective</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Date Effective")]
    public DateTime? CredentialDefDateEffective { get => credentialDefDateEffective; set => SetProperty(ref credentialDefDateEffective, value, false); }

    /// <summary>
    /// Credential Definition Terminal Degree Indicator
    /// <para>
    /// This degree is the highest degree that can be awarded in this classification of instructional programs field or program area.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20919">Credential Definition Terminal Degree Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Terminal Degree Indicator")]
    public Boolean? CredentialDefinitionTerminalDegreeIndicator { get => credentialDefinitionTerminalDegreeIndicator; set => SetProperty(ref credentialDefinitionTerminalDegreeIndicator, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CredentialNaicsindustryType { get => credentialNaicsindustryType; set => SetProperty(ref credentialNaicsindustryType, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EmploymentNaicscode { get => employmentNaicscode; set => SetProperty(ref employmentNaicscode, value, true); }

    /// <summary>
    /// Credential Image URL
    /// <para>
    /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19894">Credential Image URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Image URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ImageUrl { get => imageUrl; set => SetProperty(ref imageUrl, value, true); }

    /// <summary>
    /// Credential Definition Jurisdiction Region
    /// <para>
    /// The geo-political region in which the credential is applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20724">Credential Definition Jurisdiction Region</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Jurisdiction Region")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String JurisdictionRegion { get => jurisdictionRegion; set => SetProperty(ref jurisdictionRegion, value, true); }

    /// <summary>
    /// Credential Definition Jurisdiction Region Exception
    /// <para>
    /// A geo-political region in which the credential does not apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20725">Credential Definition Jurisdiction Region Exception</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Jurisdiction Region Exception")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String JurisdictionRegionException { get => jurisdictionRegionException; set => SetProperty(ref jurisdictionRegionException, value, true); }

    /// <summary>
    /// Credential Definition Keywords
    /// <para>
    /// Keywords or key phrases describing aspects of a credential considered useful for its discovery.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20726">Credential Definition Keywords</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Keywords")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Keywords { get => keywords; set => SetProperty(ref keywords, value, true); }

    /// <summary>
    /// Career Cluster
    /// <para>
    /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
    /// </para>
    /// </summary>
    [DisplayName("Career Cluster")]
    public Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Classification of Instructional Program Code
    /// <para>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Classification of Instructional Program Code")]
    public Guid? RefCipCodeId { get; set; }

    /// <summary>
    /// Credential Definition Intended Purpose Type
    /// <para>
    /// The intended type of application of the credential by the holder.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20730">Credential Definition Intended Purpose Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Intended Purpose Type")]
    public Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

    /// <summary>
    /// Credential Definition Status Type
    /// <para>
    /// The status of the credential offered by a credentialing organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20721">Credential Definition Status Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Status Type")]
    public Guid? RefCredentialDefStatusTypeId { get; set; }

    /// <summary>
    /// Credential Definition Verification Type
    /// <para>
    /// A resource describing the means by which someone can verify whether a credential has been attained by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20734">Credential Definition Verification Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Verification Type")]
    public Guid? RefCredentialDefVerificationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlaudienceLevelType"/> model
    /// </summary>
    public Guid? RefCtdlaudienceLevelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOnetsococcupationType"/> model
    /// </summary>
    public Guid? RefOnetsococcupationTypeId { get; set; }

    /// <summary>
    /// Credential Definition Title
    /// <para>
    /// The title assigned to a qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19893">Credential Definition Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    /// <summary>
    /// Credential Definition Validation Method Description
    /// <para>
    /// Description of the methods used to evaluate the validity and reliability of a credential earned by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20733">Credential Definition Validation Method Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Validation Method Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ValidationMethodDescription { get => validationMethodDescription; set => SetProperty(ref validationMethodDescription, value, true); }

    /// <summary>
    /// Credential Definition Version
    /// <para>
    /// An alphanumeric identifier of a version of the credential being described that is unique within the organizational context.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20735">Credential Definition Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Version")]
    public Decimal? Version { get => version; set => SetProperty(ref version, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialDefinition model)
    {
        IsBusy = true;
        Id = model.Id;
        AlternateName = model.AlternateName; // Credential Definition Alternate Name
        CredentialDefDateEffective = model.CredentialDefDateEffective; // Credential Definition Date Effective
        CredentialDefinitionTerminalDegreeIndicator = model.CredentialDefinitionTerminalDegreeIndicator; // Credential Definition Terminal Degree Indicator
        CredentialNaicsindustryType = model.CredentialNaicsindustryType; // 
        EmploymentNaicscode = model.EmploymentNaicscode; // 
        ImageUrl = model.ImageUrl; // Credential Image URL
        JurisdictionRegion = model.JurisdictionRegion; // Credential Definition Jurisdiction Region
        JurisdictionRegionException = model.JurisdictionRegionException; // Credential Definition Jurisdiction Region Exception
        Keywords = model.Keywords; // Credential Definition Keywords
        RefCareerClusterId = model.RefCareerClusterId; // Career Cluster
        RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
        RefCredentialDefIntendedPurposeTypeId = model.RefCredentialDefIntendedPurposeTypeId; // Credential Definition Intended Purpose Type
        RefCredentialDefStatusTypeId = model.RefCredentialDefStatusTypeId; // Credential Definition Status Type
        RefCredentialDefVerificationTypeId = model.RefCredentialDefVerificationTypeId; // Credential Definition Verification Type
        RefCtdlaudienceLevelTypeId = model.RefCtdlaudienceLevelTypeId; // 
        RefOnetsococcupationTypeId = model.RefOnetsococcupationTypeId; // 
        Title = model.Title; // Credential Definition Title
        ValidationMethodDescription = model.ValidationMethodDescription; // Credential Definition Validation Method Description
        Version = model.Version; // Credential Definition Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
