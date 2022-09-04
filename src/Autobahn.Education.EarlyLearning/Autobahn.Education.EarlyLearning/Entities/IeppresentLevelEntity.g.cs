//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IeppresentLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIeppresentLevel file
/// </summary>
[Table("IeppresentLevel", Schema = "EarlyLearning")]
public partial class IeppresentLevelEntity : EntityBase, IIeppresentLevel
{
    #region "IIeppresentLevel Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.String AcademicDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String FunctionalDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String GeneralEducationDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String ParentConcernDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String PreschoolDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String StudentConcernDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String StudentStrengthsDescription { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    #endregion
}
