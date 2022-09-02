//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElclassSectionServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElclassSectionService file
/// </summary>
[Table("ElclassSectionService", Schema = "Common")]
public partial class ElclassSectionServiceEntity : EntityBase, IElclassSectionService
{
    #region "IElclassSectionService Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElclassGroupCurriculumType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ElclassSection")]
    public Guid ElclassSectionId { get; set; }

    public Int32? OldestAgeServed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElgroupSizeStandardMet"/> model
    /// </summary>
    [ForeignKey("RefElgroupSizeStandardMet")]
    public Guid? RefElgroupSizeStandardMetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFrequencyOfService"/> model
    /// </summary>
    [ForeignKey("RefFrequencyOfService")]
    public Guid? RefFrequencyOfServiceId { get; set; }

    public Boolean? ServesChildrenWithSpecialNeeds { get; set; }

    public Int32? YoungestAgeServed { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ElclassSectionEntity ElclassSectionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElgroupSizeStandardMet"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElgroupSizeStandardMetEntity RefElgroupSizeStandardMetEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefFrequencyOfService"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFrequencyOfServiceEntity RefFrequencyOfServiceEntity { get; set; }

    #endregion
}
