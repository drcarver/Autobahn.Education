//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentSessionStaffRole.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSessionStaffRole file
/// </summary>
public partial interface IAssessmentSessionStaffRole
{
    #region "IAssessmentSessionStaffRole Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    Guid? AssessmentParticipantSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
    /// </summary>
    Guid? AssessmentSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Assessment Session Staff Role Type
    /// <para>
    /// The type of role served related to the administration of an assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    #endregion
}
