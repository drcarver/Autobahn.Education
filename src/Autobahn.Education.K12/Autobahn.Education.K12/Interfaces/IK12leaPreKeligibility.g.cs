//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaPreKeligibility.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaPreKeligibility file
/// </summary>
public partial interface IK12leaPreKeligibility
{
    #region "IK12leaPreKeligibility Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leapreKeligibility"/> model
    /// </summary>
    Guid K12leapreKeligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPrekindergartenEligibility"/> model
    /// </summary>
    Guid RefPrekindergartenEligibilityId { get; set; }

    #endregion
}
