//***************************************************************************
//* DomainName: Common Models
//* FileName:   RequiredImmunizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRequiredImmunization file
/// </summary>
[Table("RequiredImmunization", Schema = "Common")]
public partial class RequiredImmunizationEntity : EntityBase, IRequiredImmunization
{
    #region "IRequiredImmunization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Required Immunization
    /// <para>
    /// An indication that an immunization is specifically required by an organization or governing body.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19307">Required Immunization</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefImmunizationType")]
    [Comment("An indication that an immunization is specifically required by an organization or governing body.")]
    public Guid RefImmunizationTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication that an immunization is specifically required by an organization or governing body.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19307">Required Immunization</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefImmunizationTypeEntity RefImmunizationTypeEntity { get; set; }

    #endregion
}
