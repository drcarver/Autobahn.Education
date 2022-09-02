//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationEmployeeBenefit file
/// </summary>
[Table("OrganizationEmployeeBenefit", Schema = "Common")]
public partial class OrganizationEmployeeBenefitEntity : EntityBase, IOrganizationEmployeeBenefit
{
    #region "IOrganizationEmployeeBenefit Properties"
    /// <summary>
    /// Full-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for full-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    [Comment("The benefits offered by a program/facility/employer for full-time staff.")]
    public Boolean? FullTimeBenefitIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Part-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for part-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19867">Part-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    [Comment("The benefits offered by a program/facility/employer for part-time staff.")]
    public Boolean? PartTimeBenefitIndicator { get; set; }

    /// <summary>
    /// Full-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for full-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefEmployeeBenefit")]
    [Comment("The benefits offered by a program/facility/employer for full-time staff.")]
    public Guid? RefEmployeeBenefitId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The benefits offered by a program/facility/employer for full-time staff.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployeeBenefitEntity RefEmployeeBenefitEntity { get; set; }

    #endregion
}
