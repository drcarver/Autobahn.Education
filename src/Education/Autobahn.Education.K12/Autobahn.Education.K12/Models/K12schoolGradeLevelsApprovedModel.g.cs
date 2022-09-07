//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolGradeLevelsApprovedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolGradeLevelsApproved file
/// </summary>
public partial class K12schoolGradeLevelsApprovedModel : AutobahnBaseModel, IK12schoolGradeLevelsApproved
{
    #region "IK12schoolGradeLevelsApproved Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    public Guid RefGradeLevelId { get; set; }

    #endregion
}
