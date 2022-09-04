//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationDetail.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationDetail file
/// </summary>
public partial interface IOrganizationDetail
{
    #region "IOrganizationDetail Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Activity Title
    /// <para>
    /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19009">Activity Title</a>
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
    /// </summary>
    Guid? RefOrganizationTypeId { get; set; }

    System.String RegionGeoJson { get; set; }

    /// <summary>
    /// Short Name of Institution
    /// <para>
    /// The name of the institution, which may be the abbreviated form of the full legally accepted name.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20459">Short Name of Institution</a>
    /// </para>
    /// </summary>
    System.String ShortName { get; set; }

    #endregion
}
