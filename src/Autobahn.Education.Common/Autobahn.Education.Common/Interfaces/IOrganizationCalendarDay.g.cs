//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationCalendarDay.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarDay file
/// </summary>
public partial interface IOrganizationCalendarDay
{
    #region "IOrganizationCalendarDay Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Alternate Day Name
    /// <para>
    /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19591">Alternate Day Name</a>
    /// </para>
    /// </summary>
    System.String AlternateDayName { get; set; }

    System.String DayName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    Guid OrganizationCalendarId { get; set; }

    #endregion
}
