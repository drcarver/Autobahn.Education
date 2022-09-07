//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12schoolIndicatorStatus.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolIndicatorStatus file
/// </summary>
public partial interface IK12schoolIndicatorStatus
{
    #region "IK12schoolIndicatorStatus Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String IndicatorStatus { get; set; }

    System.String IndicatorStatusSubgroup { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
    /// </summary>
    Guid? RefIndicatorStateDefinedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
    /// </summary>
    Guid? RefIndicatorStatusCustomTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
    /// </summary>
    Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
    /// </summary>
    Guid RefIndicatorStatusTypeId { get; set; }

    #endregion
}
