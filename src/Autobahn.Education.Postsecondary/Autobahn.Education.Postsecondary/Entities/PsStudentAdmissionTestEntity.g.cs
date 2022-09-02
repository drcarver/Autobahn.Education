//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentAdmissionTest file
/// </summary>
[Table("PsStudentAdmissionTest", Schema = "Postsecondary")]
public partial class PsStudentAdmissionTestEntity : EntityBase, IPsStudentAdmissionTest
{
    #region "IPsStudentAdmissionTest Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Standardized Admission Test Type
    /// <para>
    /// The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19266">Standardized Admission Test Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefStandardizedAdmissionTest")]
    [Comment("The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.")]
    public Guid RefStandardizedAdmissionTestId { get; set; }

    /// <summary>
    /// Standardized Admission Test Score
    /// <para>
    /// The quantitative score on a standardized admission test reported to a postsecondary institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19265">Standardized Admission Test Score</a>
    /// </para>
    /// </summary>
    [Comment("The quantitative score on a standardized admission test reported to a postsecondary institution.")]
    public Decimal? StandardizedAdmissionTestScore { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19266">Standardized Admission Test Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefStandardizedAdmissionTestEntity RefStandardizedAdmissionTestEntity { get; set; }

    #endregion
}
