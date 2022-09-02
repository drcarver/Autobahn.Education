//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElenrollmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollment file
/// </summary>
[Table("Elenrollment", Schema = "Common")]
public partial class ElenrollmentEntity : EntityBase, IElenrollment
{
    #region "IElenrollment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> model
    /// </summary>
    [ForeignKey("ElclassSection")]
    public Guid? ElclassSectionId { get; set; }

    public DateTime? EnrollmentDate { get; set; }

    public Decimal? NumberOfDaysInAttendance { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfederalFundingType"/> model
    /// </summary>
    [ForeignKey("RefElfederalFundingType")]
    public Guid? RefElfederalFundingTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceParticipation"/> model
    /// </summary>
    [ForeignKey("RefFoodServiceParticipation")]
    public Guid? RefFoodServiceParticipationId { get; set; }

    public Int32? RefIdeaenvironmentElid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    [ForeignKey("RefServiceOption")]
    public Guid? RefServiceOptionId { get; set; }

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
    /// Reference to an optional instance of the <see cref="IRefFoodServiceParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFoodServiceParticipationEntity RefFoodServiceParticipationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefServiceOption"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefServiceOptionEntity RefServiceOptionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElfederalFundingType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElfederalFundingTypeEntity RefElfederalFundingTypeEntity { get; set; }

    #endregion
}
