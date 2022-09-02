//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaGradeOfferedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaGradeOffered file
/// </summary>
public partial class K12leaGradeOfferedModel : AutobahnBaseModel, IK12leaGradeOffered
{
    #region "IK12leaGradeOffered Properties"
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
