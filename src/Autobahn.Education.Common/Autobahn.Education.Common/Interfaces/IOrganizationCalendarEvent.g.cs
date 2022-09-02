//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationCalendarEvent.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarEvent file
/// </summary>
public partial interface IOrganizationCalendarEvent
{
    #region "IOrganizationCalendarEvent Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// End Time
    /// <para>
    /// The ending hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
    /// </para>
    /// </summary>
    TimeSpan? EndTime { get; set; }

    /// <summary>
    /// Calendar Event Date
    /// <para>
    /// The date of the scheduled or unscheduled calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20241">Calendar Event Date</a>
    /// </para>
    /// </summary>
    System.DateTime EventDate { get; set; }

    /// <summary>
    /// Calendar Event Day Name
    /// <para>
    /// A name used for the day of the calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20242">Calendar Event Day Name</a>
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    Guid OrganizationCalendarId { get; set; }

    /// <summary>
    /// Calendar Event Type
    /// <para>
    /// A type of scheduled or unscheduled calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19596">Calendar Event Type</a>
    /// </para>
    /// </summary>
    Int32? RefCalendarEventType { get; set; }

    /// <summary>
    /// Start Time
    /// <para>
    /// The starting hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
    /// </para>
    /// </summary>
    TimeSpan? StartTime { get; set; }

    #endregion
}
