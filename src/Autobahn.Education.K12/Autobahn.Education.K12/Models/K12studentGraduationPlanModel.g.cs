//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentGraduationPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentGraduationPlan file
/// </summary>
public partial class K12studentGraduationPlanModel : AutobahnBaseModel, IK12studentGraduationPlan
{
    #region "IK12studentGraduationPlan Properties"
    public Decimal? CreditsRequired { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12course"/> model
    /// </summary>
    public Guid K12courseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
    /// </summary>
    public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    public Guid? RefScedcourseSubjectAreaId { get; set; }

    #endregion
}
