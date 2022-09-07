//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12schoolGradeOffered.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolGradeOffered file
/// </summary>
public partial interface IK12schoolGradeOffered
{
    #region "IK12schoolGradeOffered Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    Guid RefGradeLevelId { get; set; }

    #endregion
}
