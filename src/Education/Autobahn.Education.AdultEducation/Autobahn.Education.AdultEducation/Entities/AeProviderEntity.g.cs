//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAeProvider file
/// </summary>
[Table("AeProvider", Schema = "AdultEducation")]
public partial class AeProviderEntity : EntityBase, IAeProvider
{
    #region "IAeProvider Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Level of Institution
    /// <para>
    /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLevelOfInstitution")]
    [Comment("A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.")]
    public Guid RefLevelOfInstitutionId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
    /// </para>
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefLevelOfInstitutionEntity RefLevelOfInstitutionEntity { get; set; }

    #endregion
}
