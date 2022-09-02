//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendar file
/// </summary>
public partial class OrganizationCalendarModel : AutobahnBaseModel, IOrganizationCalendar
{
    #region "IOrganizationCalendar Properties"
    /// <summary>
    /// Calendar Code
    /// <para>
    /// A unique number assigned by a school district to a school calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
    /// </para>
    /// </summary>
    public System.String CalendarCode { get; set; }

    /// <summary>
    /// Calendar Description
    /// <para>
    /// A description or identification of the calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19486">Calendar Description</a>
    /// </para>
    /// </summary>
    public System.String CalendarDescription { get; set; }

    /// <summary>
    /// School Year
    /// <para>
    /// The year for a reported school session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
    /// </para>
    /// </summary>
    public System.String CalendarYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    #endregion
}
