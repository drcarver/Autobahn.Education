//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationCalendarCrisis.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarCrisis file
/// </summary>
public partial interface IOrganizationCalendarCrisis
{
    #region "IOrganizationCalendarCrisis Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Crisis Description
    /// <para>
    /// A description of the crisis that caused the displacement of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20526">Crisis Description</a>
    /// </para>
    /// </summary>
    System.String CrisisDescription { get; set; }

    /// <summary>
    /// Crisis End Date
    /// <para>
    /// The date on which the crisis ceased to affect the agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
    /// </para>
    /// </summary>
    DateTime? CrisisEndDate { get; set; }

    /// <summary>
    /// Crisis End Date
    /// <para>
    /// The date on which the crisis ceased to affect the agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
    /// </para>
    /// </summary>
    DateTime? EndDate { get; set; }

    /// <summary>
    /// Crisis Name
    /// <para>
    /// The name of the crisis that caused the displacement of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19605">Crisis Name</a>
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Crisis Start Date
    /// <para>
    /// The year, month and day on which the crisis affected the agency. This date may not be the same as the date the crisis occurred if evacuation orders are implemented in anticipation of a crisis.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19607">Crisis Start Date</a>
    /// </para>
    /// </summary>
    DateTime? StartDate { get; set; }

    /// <summary>
    /// Crisis Type
    /// <para>
    /// The type or category of crisis (ex., chemical, earthquake, flood, wildfire, etc.).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19606">Crisis Type</a>
    /// </para>
    /// </summary>
    System.String Type { get; set; }

    #endregion
}
