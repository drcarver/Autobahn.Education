//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationEmployeeBenefit.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationEmployeeBenefit file
/// </summary>
public partial interface IOrganizationEmployeeBenefit
{
    #region "IOrganizationEmployeeBenefit Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Full-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for full-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    Boolean? FullTimeBenefitIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Part-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for part-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19867">Part-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    Boolean? PartTimeBenefitIndicator { get; set; }

    /// <summary>
    /// Full-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for full-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    Guid? RefEmployeeBenefitId { get; set; }

    #endregion
}
