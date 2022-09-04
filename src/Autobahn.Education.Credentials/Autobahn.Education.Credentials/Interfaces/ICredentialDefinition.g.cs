//***************************************************************************
//* DomainName: Credentials
//* FileName:   ICredentialDefinition.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefinition file
/// </summary>
public partial interface ICredentialDefinition
{
    #region "ICredentialDefinition Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Credential Definition Alternate Name
    /// <para>
    /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
    /// </para>
    /// </summary>
    System.String AlternateName { get; set; }

    /// <summary>
    /// Credential Definition Date Effective
    /// <para>
    /// Effective date of the content of a credential definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20891">Credential Definition Date Effective</a>
    /// </para>
    /// </summary>
    DateTime? CredentialDefDateEffective { get; set; }

    /// <summary>
    /// Credential Definition Terminal Degree Indicator
    /// <para>
    /// This degree is the highest degree that can be awarded in this classification of instructional programs field or program area.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20919">Credential Definition Terminal Degree Indicator</a>
    /// </para>
    /// </summary>
    Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

    System.String CredentialNaicsindustryType { get; set; }

    System.String EmploymentNaicscode { get; set; }

    /// <summary>
    /// Credential Image URL
    /// <para>
    /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19894">Credential Image URL</a>
    /// </para>
    /// </summary>
    System.String ImageUrl { get; set; }

    /// <summary>
    /// Credential Definition Jurisdiction Region
    /// <para>
    /// The geo-political region in which the credential is applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20724">Credential Definition Jurisdiction Region</a>
    /// </para>
    /// </summary>
    System.String JurisdictionRegion { get; set; }

    /// <summary>
    /// Credential Definition Jurisdiction Region Exception
    /// <para>
    /// A geo-political region in which the credential does not apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20725">Credential Definition Jurisdiction Region Exception</a>
    /// </para>
    /// </summary>
    System.String JurisdictionRegionException { get; set; }

    /// <summary>
    /// Credential Definition Keywords
    /// <para>
    /// Keywords or key phrases describing aspects of a credential considered useful for its discovery.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20726">Credential Definition Keywords</a>
    /// </para>
    /// </summary>
    System.String Keywords { get; set; }

    /// <summary>
    /// Career Cluster
    /// <para>
    /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
    /// </para>
    /// </summary>
    Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Classification of Instructional Program Code
    /// <para>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// </summary>
    Guid? RefCipCodeId { get; set; }

    /// <summary>
    /// Credential Definition Intended Purpose Type
    /// <para>
    /// The intended type of application of the credential by the holder.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20730">Credential Definition Intended Purpose Type</a>
    /// </para>
    /// </summary>
    Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

    /// <summary>
    /// Credential Definition Status Type
    /// <para>
    /// The status of the credential offered by a credentialing organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20721">Credential Definition Status Type</a>
    /// </para>
    /// </summary>
    Guid? RefCredentialDefStatusTypeId { get; set; }

    /// <summary>
    /// Credential Definition Verification Type
    /// <para>
    /// A resource describing the means by which someone can verify whether a credential has been attained by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20734">Credential Definition Verification Type</a>
    /// </para>
    /// </summary>
    Guid? RefCredentialDefVerificationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlaudienceLevelType"/> model
    /// </summary>
    Guid? RefCtdlaudienceLevelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOnetsococcupationType"/> model
    /// </summary>
    Guid? RefOnetsococcupationTypeId { get; set; }

    /// <summary>
    /// Credential Definition Title
    /// <para>
    /// The title assigned to a qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19893">Credential Definition Title</a>
    /// </para>
    /// </summary>
    System.String Title { get; set; }

    /// <summary>
    /// Credential Definition Validation Method Description
    /// <para>
    /// Description of the methods used to evaluate the validity and reliability of a credential earned by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20733">Credential Definition Validation Method Description</a>
    /// </para>
    /// </summary>
    System.String ValidationMethodDescription { get; set; }

    /// <summary>
    /// Credential Definition Version
    /// <para>
    /// An alphanumeric identifier of a version of the credential being described that is unique within the organizational context.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20735">Credential Definition Version</a>
    /// </para>
    /// </summary>
    Decimal? Version { get; set; }

    #endregion
}
