//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentEmploymentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAeStudentEmployment file
/// </summary>
[Table("AeStudentEmployment", Schema = "AdultEducation")]
public partial class AeStudentEmploymentEntity : EntityBase, IAeStudentEmployment
{
    #region "IAeStudentEmployment Properties"
    /// <summary>
    /// Employment NAICS Code
    /// <para>
    /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20070">Employment NAICS Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The North American Industry Classification System (NAICS) code associated with an individual's employment.")]
    public System.String EmploymentNaicsCode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Employed After Exit
    /// <para>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19990">Employed After Exit</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefEmployedAfterExit")]
    [Comment("An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.")]
    public Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Employed While Enrolled
    /// <para>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19989">Employed While Enrolled</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefEmployedWhileEnrolled")]
    [Comment("An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.")]
    public Guid? RefEmployedWhileEnrolledId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19989">Employed While Enrolled</a>
    /// </para>
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployedWhileEnrolledEntity RefEmployedWhileEnrolledEntity { get; set; }

    /// <summary>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19990">Employed After Exit</a>
    /// </para>
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployedAfterExitEntity RefEmployedAfterExitEntity { get; set; }

    #endregion
}
