//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramAmendmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAmendment file
/// </summary>
[Table("IndividualizedProgramAmendment", Schema = "Invalid")]
public partial class IndividualizedProgramAmendmentEntity : EntityBase, IIndividualizedProgramAmendment
{
    #region "IIndividualizedProgramAmendment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Amendment Reason Description
    /// <para>
    /// Description of the reason changes were made to the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20669">Individualized Program Service Plan Amendment Reason Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Description of the reason changes were made to the individualized program service plan.")]
    public System.String ReasonDescription { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    #endregion
}
