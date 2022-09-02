//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarDayEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarDay file
/// </summary>
public partial class OrganizationCalendarDayModel : AutobahnBaseModel, IOrganizationCalendarDay
{
    #region "IOrganizationCalendarDay Properties"
    /// <summary>
    /// Alternate Day Name
    /// <para>
    /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19591">Alternate Day Name</a>
    /// </para>
    /// </summary>
    public System.String AlternateDayName { get; set; }

    public System.String DayName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    public Guid OrganizationCalendarId { get; set; }

    #endregion
}
