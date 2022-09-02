//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramMeetingAttendeeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramMeetingAttendee file
/// </summary>
public partial class IndividualizedProgramMeetingAttendeeModel : AutobahnBaseModel, IIndividualizedProgramMeetingAttendee
{
    #region "IIndividualizedProgramMeetingAttendee Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramMeeting"/> model
    /// </summary>
    public Guid IndividualizedProgramMeetingId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
