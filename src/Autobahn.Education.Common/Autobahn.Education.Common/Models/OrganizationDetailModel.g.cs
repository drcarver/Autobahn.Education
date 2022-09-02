//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationDetail file
/// </summary>
public partial class OrganizationDetailModel : AutobahnBaseModel, IOrganizationDetail
{
    #region "IOrganizationDetail Properties"
    /// <summary>
    /// Activity Title
    /// <para>
    /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19009">Activity Title</a>
    /// </para>
    /// </summary>
    public System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
    /// </summary>
    public Guid? RefOrganizationTypeId { get; set; }

    public System.String RegionGeoJson { get; set; }

    /// <summary>
    /// Short Name of Institution
    /// <para>
    /// The name of the institution, which may be the abbreviated form of the full legally accepted name.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20459">Short Name of Institution</a>
    /// </para>
    /// </summary>
    public System.String ShortName { get; set; }

    #endregion
}
