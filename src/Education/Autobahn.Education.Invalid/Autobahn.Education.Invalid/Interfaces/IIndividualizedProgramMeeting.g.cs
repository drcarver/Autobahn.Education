//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIndividualizedProgramMeeting.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramMeeting file
/// </summary>
public partial interface IIndividualizedProgramMeeting
{
    #region "IIndividualizedProgramMeeting Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Meeting Date
    /// <para>
    /// The date on which a child's service plan meeting is held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20665">Individualized Program Service Plan Meeting Date</a>
    /// </para>
    /// </summary>
    DateTime? MeetingDate { get; set; }

    #endregion
}
