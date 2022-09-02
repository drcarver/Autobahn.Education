//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTitleIEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTitleI file
/// </summary>
public partial class ProgramParticipationTitleIModel : AutobahnBaseModel, IProgramParticipationTitleI
{
    #region "IProgramParticipationTitleI Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    public System.Int32 ProgramParticipationTitleIid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIindicator"/> model
    /// </summary>
    public Guid? RefTitleIindicatorId { get; set; }

    #endregion
}
