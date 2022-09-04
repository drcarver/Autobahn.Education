//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResource file
/// </summary>
[Table("LearningResource", Schema = "LearningResources")]
public partial class LearningResourceEntity : EntityBase, ILearningResource
{
    #region "ILearningResource Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AdaptedFromUrl { get; set; }

    /// <summary>
    /// Learning Resource Assistive Technologies Compatible Indicator
    /// <para>
    /// Indicates that the learning resource is compatible with assistive technologies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20362">Learning Resource Assistive Technologies Compatible Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that the learning resource is compatible with assistive technologies.")]
    public Boolean? AssistiveTechnologiesCompatibleInd { get; set; }

    /// <summary>
    /// Learning Resource Based on URL
    /// <para>
    /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19923">Learning Resource Based on URL</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A resource that was used in the creation of this resource. This term can be repeated for multiple sources.")]
    public System.String BasedOnUrl { get; set; }

    /// <summary>
    /// Learning Resource Concept Keyword
    /// <para>
    /// The significant topicality of the Learning Resource using free-text keywords and phrases.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20159">Learning Resource Concept Keyword</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The significant topicality of the Learning Resource using free-text keywords and phrases.")]
    public System.String ConceptKeyword { get; set; }

    /// <summary>
    /// Learning Resource Copyright Holder Name
    /// <para>
    /// The name(s) of the person(s) or organization(s) holding the copyright for the Learning Resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20157">Learning Resource Copyright Holder Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name(s) of the person(s) or organization(s) holding the copyright for the Learning Resource.")]
    public System.String CopyrightHolderName { get; set; }

    /// <summary>
    /// Learning Resource Copyright Year
    /// <para>
    /// The copyright year for the Learning Resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20158">Learning Resource Copyright Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The copyright year for the Learning Resource.")]
    public System.String CopyrightYear { get; set; }

    /// <summary>
    /// Learning Resource Creator
    /// <para>
    /// The name of a person or organization credited with the creation of the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19918">Learning Resource Creator</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of a person or organization credited with the creation of the resource.")]
    public System.String Creator { get; set; }

    /// <summary>
    /// Learning Resource Date Created
    /// <para>
    /// The date on which the resource was created.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19916">Learning Resource Date Created</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the resource was created.")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Learning Resource Author Email
    /// <para>
    /// An email address for the author of the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20544">Learning Resource Author Email</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An email address for the author of the learning resource.")]
    public System.String LearningResourceAuthorEmail { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourceAuthorUrl { get; set; }

    /// <summary>
    /// Learning Resource Date Modified
    /// <para>
    /// The most recent date that the learning resource was updated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20542">Learning Resource Date Modified</a>
    /// </para>
    /// </summary>
    [Comment("The most recent date that the learning resource was updated.")]
    public DateTime? LearningResourceDateModified { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourceLicenseUrl { get; set; }

    /// <summary>
    /// Learning Resource Publisher Email
    /// <para>
    /// An email address for the publisher of the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20545">Learning Resource Publisher Email</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An email address for the publisher of the learning resource.")]
    public System.String LearningResourcePublisherEmail { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourcePublisherUrl { get; set; }

    /// <summary>
    /// Learning Resource Peer Rating Sample Size
    /// <para>
    /// The sample size of a peer rating value. Only used when the Peer Rating Value is collected in aggregate as an average of multiple atomic/individual ratings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20369">Learning Resource Peer Rating Sample Size</a>
    /// </para>
    /// </summary>
    [Comment("The sample size of a peer rating value. Only used when the Peer Rating Value is collected in aggregate as an average of multiple atomic/individual ratings.")]
    public Int32? PeerRatingSampleSize { get; set; }

    /// <summary>
    /// Learning Resource Published Date
    /// <para>
    /// The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20135">Learning Resource Published Date</a>
    /// </para>
    /// </summary>
    [Comment("The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.")]
    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Learning Resource Publisher Name
    /// <para>
    /// The name of the organization credited with publishing the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19919">Learning Resource Publisher Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the organization credited with publishing the resource.")]
    public System.String PublisherName { get; set; }

    /// <summary>
    /// Learning Resource Language
    /// <para>
    /// The primary language of the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19920">Learning Resource Language</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLanguage")]
    [Comment("The primary language of the resource.")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearningResourceAccessApitype"/> model
    /// </summary>
    [ForeignKey("RefLearningResourceAccessApitype")]
    public Guid? RefLearningResourceAccessApitypeId { get; set; }

    /// <summary>
    /// Learning Resource Access Hazard Type
    /// <para>
    /// A characteristic of the described learning resource that is physiologically dangerous to some users.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20359">Learning Resource Access Hazard Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceAccessHazardType")]
    [Comment("A characteristic of the described learning resource that is physiologically dangerous to some users.")]
    public Guid? RefLearningResourceAccessHazardTypeId { get; set; }

    /// <summary>
    /// Learning Resource Access Mode Type
    /// <para>
    /// An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20360">Learning Resource Access Mode Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceAccessModeType")]
    [Comment("An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.")]
    public Guid? RefLearningResourceAccessModeTypeId { get; set; }

    /// <summary>
    /// Learning Resource Access Rights URL
    /// <para>
    /// A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20537">Learning Resource Access Rights URL</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceAccessRightsUrl")]
    [Comment("A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.")]
    public Guid? RefLearningResourceAccessRightsUrlId { get; set; }

    /// <summary>
    /// Learning Resource Author Type
    /// <para>
    /// The type of entity, organization or person, that authored the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20540">Learning Resource Author Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceAuthorType")]
    [Comment("The type of entity, organization or person, that authored the learning resource.")]
    public Guid? RefLearningResourceAuthorTypeId { get; set; }

    /// <summary>
    /// Learning Resource Book Format Type
    /// <para>
    /// Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20363">Learning Resource Book Format Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceBookFormatType")]
    [Comment("Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.")]
    public Guid? RefLearningResourceBookFormatTypeId { get; set; }

    /// <summary>
    /// Learning Resource Control Flexibility Type
    /// <para>
    /// Identifies a single input method that is sufficient to control the described learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20364">Learning Resource Control Flexibility Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceControlFlexibilityType")]
    [Comment("Identifies a single input method that is sufficient to control the described learning resource.")]
    public Guid? RefLearningResourceControlFlexibilityTypeId { get; set; }

    /// <summary>
    /// Learning Resource Digital Media Sub Type
    /// <para>
    /// The media or file subtype of the digital resource being based on the Media Types and Subtypes, formerly known as MIME types, defined by the Internet Assigned Numbers Authority (IANA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20365">Learning Resource Digital Media Sub Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceDigitalMediaSubType")]
    [Comment("The media or file subtype of the digital resource being based on the Media Types and Subtypes, formerly known as MIME types, defined by the Internet Assigned Numbers Authority (IANA).")]
    public Guid? RefLearningResourceDigitalMediaSubTypeId { get; set; }

    /// <summary>
    /// Learning Resource Digital Media Type
    /// <para>
    /// The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20366">Learning Resource Digital Media Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceDigitalMediaType")]
    [Comment("The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.")]
    public Guid? RefLearningResourceDigitalMediaTypeId { get; set; }

    /// <summary>
    /// Learning Resource Educational Use
    /// <para>
    /// The purpose of the work in the context of education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20005">Learning Resource Educational Use</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceEducationalUse")]
    [Comment("The purpose of the work in the context of education.")]
    public Guid? RefLearningResourceEducationalUseId { get; set; }

    /// <summary>
    /// Learning Resource Intended End User Role
    /// <para>
    /// The individual or group for which the resource was produced.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19924">Learning Resource Intended End User Role</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceIntendedEndUserRole")]
    [Comment("The individual or group for which the resource was produced.")]
    public Guid? RefLearningResourceIntendedEndUserRoleId { get; set; }

    /// <summary>
    /// Learning Resource Interaction Mode
    /// <para>
    /// The primary type of interaction, synchronous or asynchronous, defined for the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20543">Learning Resource Interaction Mode</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceInteractionMode")]
    [Comment("The primary type of interaction, synchronous or asynchronous, defined for the learning resource.")]
    public Guid? RefLearningResourceInteractionModeId { get; set; }

    /// <summary>
    /// Learning Resource Interactivity Type
    /// <para>
    /// The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19928">Learning Resource Interactivity Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceInteractivityType")]
    [Comment("The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.")]
    public Guid? RefLearningResourceInteractivityTypeId { get; set; }

    /// <summary>
    /// Learning Resource Type
    /// <para>
    /// The predominate type or kind characterizing the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19929">Learning Resource Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceType")]
    [Comment("The predominate type or kind characterizing the learning resource.")]
    public Guid? RefLearningResourceTypeId { get; set; }

    /// <summary>
    /// Learning Resource Subject Code
    /// <para>
    /// The code used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19914">Learning Resource Subject Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The code used to identify the organization of subject matter and related learning experiences addressed by the learning resource.")]
    public System.String SubjectCode { get; set; }

    /// <summary>
    /// Learning Resource Subject Code System
    /// <para>
    /// The system that is used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19915">Learning Resource Subject Code System</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The system that is used to identify the organization of subject matter and related learning experiences addressed by the learning resource.")]
    public System.String SubjectCodeSystem { get; set; }

    /// <summary>
    /// Learning Resource Subject Name
    /// <para>
    /// The descriptive name for the subject of the content for the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19913">Learning Resource Subject Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The descriptive name for the subject of the content for the learning resource.")]
    public System.String SubjectName { get; set; }

    /// <summary>
    /// Learning Resource Text Complexity System
    /// <para>
    /// The scaling system used to specify the text complexity of an Learning Resource
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19931">Learning Resource Text Complexity System</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The scaling system used to specify the text complexity of an Learning Resource")]
    public System.String TextComplexitySystem { get; set; }

    /// <summary>
    /// Learning Resource Text Complexity Value
    /// <para>
    /// The complexity of the text using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19930">Learning Resource Text Complexity Value</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The complexity of the text using the scaling system defined by Text Complexity System, e.g. Lexile(tm).")]
    public System.String TextComplexityValue { get; set; }

    /// <summary>
    /// Learning Resource Time Required
    /// <para>
    /// The approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19925">Learning Resource Time Required</a>
    /// </para>
    /// </summary>
    [Comment("The approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.")]
    public Decimal? TimeRequired { get; set; }

    /// <summary>
    /// Learning Resource Title
    /// <para>
    /// The title of the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19912">Learning Resource Title</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The title of the resource.")]
    public System.String Title { get; set; }

    /// <summary>
    /// Learning Resource Typical Age Range Maximum
    /// <para>
    /// The maximum for the typical range of ages of the content's intended end user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19927">Learning Resource Typical Age Range Maximum</a>
    /// </para>
    /// </summary>
    [Comment("The maximum for the typical range of ages of the content's intended end user.")]
    public Byte? TypicalAgeRangeMaximum { get; set; }

    /// <summary>
    /// Learning Resource Typical Age Range Minimum
    /// <para>
    /// The minimum for the typical range of ages of the content's intended end user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19926">Learning Resource Typical Age Range Minimum</a>
    /// </para>
    /// </summary>
    [Comment("The minimum for the typical range of ages of the content's intended end user.")]
    public Byte? TypicalAgeRangeMinimum { get; set; }

    /// <summary>
    /// Learning Resource URL
    /// <para>
    /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19911">Learning Resource URL</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.")]
    public System.String Url { get; set; }

    /// <summary>
    /// Learning Resource Version
    /// <para>
    /// Defines the version of the learning resource as defined by the publisher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20182">Learning Resource Version</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Defines the version of the learning resource as defined by the publisher.")]
    public System.String Version { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The predominate type or kind characterizing the learning resource.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19929">Learning Resource Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceTypeEntity? RefLearningResourceTypeEntity { get; set; }

    /// <summary>
    /// The individual or group for which the resource was produced.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19924">Learning Resource Intended End User Role</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceIntendedEndUserRoleEntity? RefLearningResourceIntendedEndUserRoleEntity { get; set; }

    /// <summary>
    /// The purpose of the work in the context of education.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20005">Learning Resource Educational Use</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceEducationalUseEntity? RefLearningResourceEducationalUseEntity { get; set; }

    /// <summary>
    /// The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19928">Learning Resource Interactivity Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceInteractivityTypeEntity? RefLearningResourceInteractivityTypeEntity { get; set; }

    /// <summary>
    /// The primary language of the resource.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19920">Learning Resource Language</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLanguageEntity? RefLanguageEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefLearningResourceAccessApitype"/> implementation
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceAccessApitypeEntity? RefLearningResourceAccessApitypeEntity { get; set; }

    /// <summary>
    /// A characteristic of the described learning resource that is physiologically dangerous to some users.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20359">Learning Resource Access Hazard Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceAccessHazardTypeEntity? RefLearningResourceAccessHazardTypeEntity { get; set; }

    /// <summary>
    /// An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20360">Learning Resource Access Mode Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceAccessModeTypeEntity? RefLearningResourceAccessModeTypeEntity { get; set; }

    /// <summary>
    /// Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20363">Learning Resource Book Format Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceBookFormatTypeEntity? RefLearningResourceBookFormatTypeEntity { get; set; }

    /// <summary>
    /// Identifies a single input method that is sufficient to control the described learning resource.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20364">Learning Resource Control Flexibility Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceControlFlexibilityTypeEntity? RefLearningResourceControlFlexibilityTypeEntity { get; set; }

    /// <summary>
    /// The media or file subtype of the digital resource being based on the Media Types and Subtypes, formerly known as MIME types, defined by the Internet Assigned Numbers Authority (IANA).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20365">Learning Resource Digital Media Sub Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceDigitalMediaSubTypeEntity? RefLearningResourceDigitalMediaSubTypeEntity { get; set; }

    /// <summary>
    /// The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20366">Learning Resource Digital Media Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceDigitalMediaTypeEntity? RefLearningResourceDigitalMediaTypeEntity { get; set; }

    /// <summary>
    /// A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20537">Learning Resource Access Rights URL</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceAccessRightsUrlEntity? RefLearningResourceAccessRightsUrlEntity { get; set; }

    /// <summary>
    /// The type of entity, organization or person, that authored the learning resource.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20540">Learning Resource Author Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceAuthorTypeEntity? RefLearningResourceAuthorTypeEntity { get; set; }

    /// <summary>
    /// The primary type of interaction, synchronous or asynchronous, defined for the learning resource.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20543">Learning Resource Interaction Mode</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceInteractionModeEntity? RefLearningResourceInteractionModeEntity { get; set; }

    #endregion
}
