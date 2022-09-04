//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationCalendar.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendar file
/// </summary>
public partial interface IOrganizationCalendar
{
    #region "IOrganizationCalendar Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Calendar Code
    /// <para>
    /// A unique number assigned by a school district to a school calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
    /// </para>
    /// </summary>
    System.String CalendarCode { get; set; }

    /// <summary>
    /// Calendar Description
    /// <para>
    /// A description or identification of the calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19486">Calendar Description</a>
    /// </para>
    /// </summary>
    System.String CalendarDescription { get; set; }

    /// <summary>
    /// School Year
    /// <para>
    /// The year for a reported school session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
    /// </para>
    /// </summary>
    System.String CalendarYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    #endregion
}
