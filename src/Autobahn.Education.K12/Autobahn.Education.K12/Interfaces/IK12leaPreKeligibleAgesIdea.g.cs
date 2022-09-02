//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaPreKeligibleAgesIdea.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaPreKeligibleAgesIdea file
/// </summary>
public partial interface IK12leaPreKeligibleAgesIdea
{
    #region "IK12leaPreKeligibleAgesIdea Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    Guid K12leaId { get; set; }

    System.Int32 K12leapreKeligibleAgesIdeaid { get; set; }

    System.Int32 RefPreKeligibleAgesNonIdeaid { get; set; }

    #endregion
}
