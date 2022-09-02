//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaGradeLevelsApproved.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaGradeLevelsApproved file
/// </summary>
public partial interface IK12leaGradeLevelsApproved
{
    #region "IK12leaGradeLevelsApproved Properties"
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
