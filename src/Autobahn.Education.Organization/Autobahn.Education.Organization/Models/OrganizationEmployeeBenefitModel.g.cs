//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationEmployeeBenefitEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationEmployeeBenefit file
/// </summary>
public partial class OrganizationEmployeeBenefitModel : AutobahnBaseModel, IOrganizationEmployeeBenefit
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
    public Boolean? FullTimeBenefitIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
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
    public Guid? RefEmployeeBenefitId { get; set; }

    #endregion
}
