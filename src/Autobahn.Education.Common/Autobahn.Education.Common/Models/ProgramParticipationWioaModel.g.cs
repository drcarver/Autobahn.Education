//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWioaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationWioa file
/// </summary>
public partial class ProgramParticipationWioaModel : AutobahnBaseModel, IProgramParticipationWioa
{
    #region "IProgramParticipationWioa Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    public System.Int32 ProgramParticipationWioaid { get; set; }

    public Boolean? WioacareerServices { get; set; }

    public Boolean? WioatrainingServices { get; set; }

    #endregion
}
