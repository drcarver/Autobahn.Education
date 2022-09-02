//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolGradeOfferedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolGradeOffered file
/// </summary>
public partial class K12schoolGradeOfferedModel : AutobahnBaseModel, IK12schoolGradeOffered
{
    #region "IK12schoolGradeOffered Properties"
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
