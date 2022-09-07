//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIsupportServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaTitleIsupportService file
/// </summary>
public partial class K12leaTitleIsupportServiceModel : AutobahnBaseModel, IK12leaTitleIsupportService
{
    #region "IK12leaTitleIsupportService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12leaTitleIsupportService"/> model
    /// </summary>
    public Guid RefK12leaTitleIsupportServiceId { get; set; }

    #endregion
}
