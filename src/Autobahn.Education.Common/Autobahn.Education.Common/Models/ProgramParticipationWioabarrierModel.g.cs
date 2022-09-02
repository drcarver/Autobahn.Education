//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWioabarrierEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationWioabarrier file
/// </summary>
public partial class ProgramParticipationWioabarrierModel : AutobahnBaseModel, IProgramParticipationWioabarrier
{
    #region "IProgramParticipationWioabarrier Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationWioabarriers"/> model
    /// </summary>
    public Guid ProgramParticipationWioabarriersId { get; set; }

    public System.Int32 ProgramParticipationWioaid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWioabarrierstoEmployment"/> model
    /// </summary>
    public Guid? RefWioabarrierstoEmploymentId { get; set; }

    #endregion
}
