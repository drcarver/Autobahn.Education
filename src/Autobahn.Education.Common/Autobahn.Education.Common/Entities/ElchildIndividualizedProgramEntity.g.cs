//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildIndividualizedProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildIndividualizedProgram file
/// </summary>
[Table("ElchildIndividualizedProgram", Schema = "Common")]
public partial class ElchildIndividualizedProgramEntity : EntityBase, IElchildIndividualizedProgram
{
    #region "IElchildIndividualizedProgram Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [ForeignKey("IndividualizedProgram")]
    public Guid? IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="Refeaiepstatus"/> model
    /// </summary>
    [Obsolete("The Refeaiepstatus property is obsolete and will be removed in a later version")]
    [ForeignKey("Refeaiepstatus")]
    public Guid? RefIdeaiepstatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeapartCeligibilityCategory"/> model
    /// </summary>
    [Obsolete("The RefeapartCeligibilityCategory property is obsolete and will be removed in a later version")]
    [ForeignKey("RefeapartCeligibilityCategory")]
    public Guid? RefIdeapartCeligibilityCategoryId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    #endregion
}
