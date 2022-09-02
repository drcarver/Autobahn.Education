//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaGradeLevelsApprovedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaGradeLevelsApproved file
/// </summary>
public partial class K12leaGradeLevelsApprovedModel : AutobahnBaseModel, IK12leaGradeLevelsApproved
{
    #region "IK12leaGradeLevelsApproved Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    public Guid RefGradeLevelId { get; set; }

    #endregion
}
