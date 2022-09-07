//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolCorrectiveActionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolCorrectiveAction file
/// </summary>
public partial class K12schoolCorrectiveActionModel : AutobahnBaseModel, IK12schoolCorrectiveAction
{
    #region "IK12schoolCorrectiveAction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectiveActionType"/> model
    /// </summary>
    public Guid RefCorrectiveActionTypeId { get; set; }

    #endregion
}
