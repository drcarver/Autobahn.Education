//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentGraduationPlan.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentGraduationPlan file
/// </summary>
public partial interface IK12studentGraduationPlan
{
    #region "IK12studentGraduationPlan Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? CreditsRequired { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12course"/> model
    /// </summary>
    Guid K12courseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
    /// </summary>
    Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    Guid? RefScedcourseSubjectAreaId { get; set; }

    #endregion
}
