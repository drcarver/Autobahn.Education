//***************************************************************************
//* DomainName: Common Models
//* FileName:   IActivity.g.cs
//***************************************************************************

/// <summary>
/// The IActivity file
/// </summary>
public partial interface IActivity
{
    #region "IActivity Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Activity Description
    /// <para>
    /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20505">Activity Description</a>
    /// </para>
    /// </summary>
    System.String ActivityDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    #endregion
}
