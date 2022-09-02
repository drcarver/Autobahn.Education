//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12schoolCorrectiveAction.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolCorrectiveAction file
/// </summary>
public partial interface IK12schoolCorrectiveAction
{
    #region "IK12schoolCorrectiveAction Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectiveActionType"/> model
    /// </summary>
    Guid RefCorrectiveActionTypeId { get; set; }

    #endregion
}
