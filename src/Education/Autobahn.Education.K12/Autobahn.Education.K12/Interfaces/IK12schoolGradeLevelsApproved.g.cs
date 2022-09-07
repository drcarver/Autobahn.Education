//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12schoolGradeLevelsApproved.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolGradeLevelsApproved file
/// </summary>
public partial interface IK12schoolGradeLevelsApproved
{
    #region "IK12schoolGradeLevelsApproved Properties"
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
