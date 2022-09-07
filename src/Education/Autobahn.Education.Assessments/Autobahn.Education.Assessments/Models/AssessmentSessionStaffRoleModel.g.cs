//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSessionStaffRole file
/// </summary>
public partial class AssessmentSessionStaffRoleModel : AutobahnBaseModel, IAssessmentSessionStaffRole
{
    #region "IAssessmentSessionStaffRole Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    public Guid? AssessmentParticipantSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
    /// </summary>
    public Guid? AssessmentSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Assessment Session Staff Role Type
    /// <para>
    /// The type of role served related to the administration of an assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    #endregion
}
