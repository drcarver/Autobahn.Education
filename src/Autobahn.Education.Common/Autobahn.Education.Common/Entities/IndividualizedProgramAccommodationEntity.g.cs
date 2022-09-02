//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAccommodation file
/// </summary>
[Table("IndividualizedProgramAccommodation", Schema = "Common")]
public partial class IndividualizedProgramAccommodationEntity : EntityBase, IIndividualizedProgramAccommodation
{
    #region "IIndividualizedProgramAccommodation Properties"
    /// <summary>
    /// Individualized Program Accommodation Applicability
    /// <para>
    /// Circumstances in which the accommodation or change to standards or practices will be applied.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20667">Individualized Program Accommodation Applicability</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Circumstances in which the accommodation or change to standards or practices will be applied.")]
    public System.String Applicability { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Accommodation Type
    /// <para>
    /// The specific accommodation necessary for assessment or instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAccommodationType")]
    [Comment("The specific accommodation necessary for assessment or instruction.")]
    public Guid? RefAccommodationTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    /// <summary>
    /// The specific accommodation necessary for assessment or instruction.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAccommodationTypeEntity RefAccommodationTypeEntity { get; set; }

    #endregion
}
