//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentActivity file
/// </summary>
[Table("K12studentActivity", Schema = "K12")]
public partial class K12studentActivityEntity : EntityBase, IK12studentActivity
{
    #region "IK12studentActivity Properties"
    public Decimal? ActivityTimeInvolved { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
    /// </summary>
    [ForeignKey("RefActivityTimeMeasurementType")]
    public Guid? RefActivityTimeMeasurementTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefActivityTimeMeasurementType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefActivityTimeMeasurementTypeEntity? RefActivityTimeMeasurementTypeEntity { get; set; }

    #endregion
}
