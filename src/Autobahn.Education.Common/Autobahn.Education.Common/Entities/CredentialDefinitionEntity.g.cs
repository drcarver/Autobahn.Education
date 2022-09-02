//***************************************************************************
//* DomainName: Common Models
//* FileName:   CredentialDefinitionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefinition file
/// </summary>
[Table("CredentialDefinition", Schema = "Common")]
public partial class CredentialDefinitionEntity : EntityBase, ICredentialDefinition
{
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.")]
    public System.String AlternateName { get; set; }

    /// <summary>
    /// Credential Definition Date Effective
    /// <para>
    /// Effective date of the content of a credential definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20891">Credential Definition Date Effective</a>
    /// </para>
    /// </summary>
    [Comment("Effective date of the content of a credential definition.")]
    public DateTime? CredentialDefDateEffective { get; set; }

    /// <summary>
    /// Credential Definition Terminal Degree Indicator
    /// <para>
    /// This degree is the highest degree that can be awarded in this classification of instructional programs field or program area.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20919">Credential Definition Terminal Degree Indicator</a>
    /// </para>
    /// </summary>
    [Comment("This degree is the highest degree that can be awarded in this classification of instructional programs field or program area.")]
    public Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CredentialNaicsindustryType { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EmploymentNaicscode { get; set; }

    /// <summary>
    /// Credential Image URL
    /// <para>
    /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19894">Credential Image URL</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the qualification, achievement, personal or organizational quality, or aspect of an identity.")]
    public System.String ImageUrl { get; set; }

    /// <summary>
    /// Credential Definition Jurisdiction Region
    /// <para>
    /// The geo-political region in which the credential is applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20724">Credential Definition Jurisdiction Region</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The geo-political region in which the credential is applicable.")]
    public System.String JurisdictionRegion { get; set; }

    /// <summary>
    /// Credential Definition Jurisdiction Region Exception
    /// <para>
    /// A geo-political region in which the credential does not apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20725">Credential Definition Jurisdiction Region Exception</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A geo-political region in which the credential does not apply.")]
    public System.String JurisdictionRegionException { get; set; }

    /// <summary>
    /// Credential Definition Keywords
    /// <para>
    /// Keywords or key phrases describing aspects of a credential considered useful for its discovery.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20726">Credential Definition Keywords</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Keywords or key phrases describing aspects of a credential considered useful for its discovery.")]
    public System.String Keywords { get; set; }

    /// <summary>
    /// Career Cluster
    /// <para>
    /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCareerCluster")]
    [Comment("The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.")]
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
    [ForeignKey("RefCipCode")]
    [Comment("A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.")]
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
    [ForeignKey("RefCredentialDefIntendedPurposeType")]
    [Comment("The intended type of application of the credential by the holder.")]
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
    [ForeignKey("RefCredentialDefStatusType")]
    [Comment("The status of the credential offered by a credentialing organization.")]
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
    [ForeignKey("RefCredentialDefVerificationType")]
    [Comment("A resource describing the means by which someone can verify whether a credential has been attained by a person.")]
    public Guid? RefCredentialDefVerificationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlaudienceLevelType"/> model
    /// </summary>
    [ForeignKey("RefCtdlaudienceLevelType")]
    public Guid? RefCtdlaudienceLevelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOnetsococcupationType"/> model
    /// </summary>
    [ForeignKey("RefOnetsococcupationType")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The title assigned to a qualification, achievement, personal or organizational quality, or aspect of an identity.")]
    public System.String Title { get; set; }

    /// <summary>
    /// Credential Definition Validation Method Description
    /// <para>
    /// Description of the methods used to evaluate the validity and reliability of a credential earned by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20733">Credential Definition Validation Method Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Description of the methods used to evaluate the validity and reliability of a credential earned by a person.")]
    public System.String ValidationMethodDescription { get; set; }

    /// <summary>
    /// Credential Definition Version
    /// <para>
    /// An alphanumeric identifier of a version of the credential being described that is unique within the organizational context.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20735">Credential Definition Version</a>
    /// </para>
    /// </summary>
    [Comment("An alphanumeric identifier of a version of the credential being described that is unique within the organizational context.")]
    public Decimal? Version { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCareerClusterEntity RefCareerClusterEntity { get; set; }

    /// <summary>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCipCodeEntity RefCipCodeEntity { get; set; }

    /// <summary>
    /// The intended type of application of the credential by the holder.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20730">Credential Definition Intended Purpose Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCredentialDefIntendedPurposeTypeEntity RefCredentialDefIntendedPurposeTypeEntity { get; set; }

    /// <summary>
    /// The status of the credential offered by a credentialing organization.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20721">Credential Definition Status Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCredentialDefStatusTypeEntity RefCredentialDefStatusTypeEntity { get; set; }

    /// <summary>
    /// A resource describing the means by which someone can verify whether a credential has been attained by a person.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20734">Credential Definition Verification Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCredentialDefVerificationTypeEntity RefCredentialDefVerificationTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefOnetsococcupationType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefOnetsococcupationTypeEntity RefOnetsococcupationTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCtdlaudienceLevelType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCtdlaudienceLevelTypeEntity RefCtdlaudienceLevelTypeEntity { get; set; }

    #endregion
}
