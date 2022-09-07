//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaTitleIsupportService.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaTitleIsupportService file
/// </summary>
public partial interface IK12leaTitleIsupportService
{
    #region "IK12leaTitleIsupportService Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12leaTitleIsupportService"/> model
    /// </summary>
    Guid RefK12leaTitleIsupportServiceId { get; set; }

    #endregion
}
