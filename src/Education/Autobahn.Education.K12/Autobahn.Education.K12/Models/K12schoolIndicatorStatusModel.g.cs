//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolIndicatorStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolIndicatorStatus file
/// </summary>
public partial class K12schoolIndicatorStatusModel : AutobahnBaseModel, IK12schoolIndicatorStatus
{
    #region "IK12schoolIndicatorStatus Properties"
    public System.String IndicatorStatus { get; set; }

    public System.String IndicatorStatusSubgroup { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
    /// </summary>
    public Guid? RefIndicatorStateDefinedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
    /// </summary>
    public Guid? RefIndicatorStatusCustomTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
    /// </summary>
    public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
    /// </summary>
    public Guid RefIndicatorStatusTypeId { get; set; }

    #endregion
}
