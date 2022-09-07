//***************************************************************************
//* DomainName: Organization Models
//* FileName:   ActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IActivity file
/// </summary>
public partial class ActivityModel : AutobahnBaseModel, IActivity
{
    #region "IActivity Properties"
    /// <summary>
    /// Activity Description
    /// <para>
    /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20505">Activity Description</a>
    /// </para>
    /// </summary>
    public System.String ActivityDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    #endregion
}
