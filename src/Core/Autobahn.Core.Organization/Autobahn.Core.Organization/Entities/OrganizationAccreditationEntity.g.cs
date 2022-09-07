//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationAccreditationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationAccreditation file
/// </summary>
[Table("OrganizationAccreditation", Schema = "Organization")]
public partial class OrganizationAccreditationEntity : EntityBase, IOrganizationAccreditation
{
    #region "IOrganizationAccreditation Properties"
    /// <summary>
    /// Accreditation Agency Name
    /// <para>
    /// The full name of an agency that accredited a school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The full name of an agency that accredited a school.")]
    public System.String AccreditationAgencyName { get; set; }

    /// <summary>
    /// Accreditation Award Date
    /// <para>
    /// The year, month and day when an accreditation was awarded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19840">Accreditation Award Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day when an accreditation was awarded.")]
    public DateTime? AccreditationAwardDate { get; set; }

    /// <summary>
    /// Accreditation Expiration Date
    /// <para>
    /// The year, month and day when an accreditation expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19841">Accreditation Expiration Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day when an accreditation expires.")]
    public DateTime? AccreditationExpirationDate { get; set; }

    public Boolean? AccreditationStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Accreditation Agency
    /// <para>
    /// The agency that accredited a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19983">Accreditation Agency</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAccreditationAgency")]
    [Comment("The agency that accredited a program.")]
    public Guid? RefAccreditationAgencyId { get; set; }

    /// <summary>
    /// Higher Education Institution Accreditation Status
    /// <para>
    /// An indication of the accreditation status of a higher education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefHigherEducationInstitutionAccreditationStatus")]
    [Comment("An indication of the accreditation status of a higher education institution.")]
    public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    /// <summary>
    /// Organization Seeking Accreditation Date
    /// <para>
    /// The date in which accreditation process was started (but not officially approved or denied)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20388">Organization Seeking Accreditation Date</a>
    /// </para>
    /// </summary>
    [Comment("The date in which accreditation process was started (but not officially approved or denied)")]
    public DateTime? SeekingAccreditationDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The agency that accredited a program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19983">Accreditation Agency</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefAccreditationAgencyEntity? RefAccreditationAgencyEntity { get; set; }

    /// <summary>
    /// An indication of the accreditation status of a higher education institution.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefHigherEducationInstitutionAccreditationStatusEntity? RefHigherEducationInstitutionAccreditationStatusEntity { get; set; }

    #endregion
}
