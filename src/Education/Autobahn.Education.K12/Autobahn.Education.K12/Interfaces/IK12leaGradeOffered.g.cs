//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaGradeOffered.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaGradeOffered file
/// </summary>
public partial interface IK12leaGradeOffered
{
    #region "IK12leaGradeOffered Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    Guid RefGradeLevelId { get; set; }

    #endregion
}
