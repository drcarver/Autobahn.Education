//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   PdactivityEducationLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPdactivityEducationLevel file
/// </summary>
[Table("PdactivityEducationLevel", Schema = "EarlyLearning")]
public partial class PdactivityEducationLevelEntity : EntityBase, IPdactivityEducationLevel
{
    #region "IPdactivityEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProfessionalDevelopmentActivity")]
    public Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityEducationLevelsAddressed"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefPdactivityEducationLevelsAddressed")]
    public Guid RefPdactivityEducationLevelsAddressedId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual ProfessionalDevelopmentActivityEntity ProfessionalDevelopmentActivityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPdactivityEducationLevelsAddressed"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefPdactivityEducationLevelsAddressedEntity RefPdactivityEducationLevelsAddressedEntity { get; set; }

    #endregion
}
