//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIndividualizedProgramMeetingAttendee.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramMeetingAttendee file
/// </summary>
public partial interface IIndividualizedProgramMeetingAttendee
{
    #region "IIndividualizedProgramMeetingAttendee Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramMeeting"/> model
    /// </summary>
    Guid IndividualizedProgramMeetingId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
