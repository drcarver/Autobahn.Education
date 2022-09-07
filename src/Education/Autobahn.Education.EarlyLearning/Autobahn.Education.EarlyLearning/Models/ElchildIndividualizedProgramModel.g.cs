//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildIndividualizedProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildIndividualizedProgram file
/// </summary>
public partial class ElchildIndividualizedProgramModel : AutobahnBaseModel, IElchildIndividualizedProgram
{
    #region "IElchildIndividualizedProgram Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid? IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="Refeaiepstatus"/> model
    /// </summary>
    public Guid? RefIdeaiepstatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeapartCeligibilityCategory"/> model
    /// </summary>
    public Guid? RefIdeapartCeligibilityCategoryId { get; set; }

    #endregion
}
