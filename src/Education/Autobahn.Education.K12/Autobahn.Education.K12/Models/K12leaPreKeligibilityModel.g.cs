//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaPreKeligibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaPreKeligibility file
/// </summary>
public partial class K12leaPreKeligibilityModel : AutobahnBaseModel, IK12leaPreKeligibility
{
    #region "IK12leaPreKeligibility Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leapreKeligibility"/> model
    /// </summary>
    public Guid K12leapreKeligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPrekindergartenEligibility"/> model
    /// </summary>
    public Guid RefPrekindergartenEligibilityId { get; set; }

    #endregion
}
