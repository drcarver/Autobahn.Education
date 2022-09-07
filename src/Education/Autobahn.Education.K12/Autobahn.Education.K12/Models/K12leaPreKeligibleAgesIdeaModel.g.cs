//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaPreKeligibleAgesIdeaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaPreKeligibleAgesIdea file
/// </summary>
public partial class K12leaPreKeligibleAgesIdeaModel : AutobahnBaseModel, IK12leaPreKeligibleAgesIdea
{
    #region "IK12leaPreKeligibleAgesIdea Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    public System.Int32 K12leapreKeligibleAgesIdeaid { get; set; }

    public System.Int32 RefPreKeligibleAgesNonIdeaid { get; set; }

    #endregion
}
