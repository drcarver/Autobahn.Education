//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   StaffTechnicalAssistanceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffTechnicalAssistance file
/// </summary>
[Table("StaffTechnicalAssistance", Schema = "Invalid")]
public partial class StaffTechnicalAssistanceEntity : EntityBase, IStaffTechnicalAssistance
{
    #region "IStaffTechnicalAssistance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Technical Assistance Delivery Type
    /// <para>
    /// The method of delivery of technical assistance received/provided
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20466">Technical Assistance Delivery Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTechnicalAssistanceDeliveryType")]
    [Comment("The method of delivery of technical assistance received/provided")]
    public Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

    /// <summary>
    /// Technical Assistance Type
    /// <para>
    /// The type of technical assistance provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20467">Technical Assistance Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTechnicalAssistanceType")]
    [Comment("The type of technical assistance provided.")]
    public Guid? RefTechnicalAssistanceTypeId { get; set; }

    /// <summary>
    /// Technical Assistance Approved Indicator
    /// <para>
    /// Indicates whether or not the technical assistance was approved.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20465">Technical Assistance Approved Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates whether or not the technical assistance was approved.")]
    public Boolean? TechnicalAssistanceApprovedInd { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of technical assistance provided.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20467">Technical Assistance Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefTechnicalAssistanceTypeEntity? RefTechnicalAssistanceTypeEntity { get; set; }

    /// <summary>
    /// The method of delivery of technical assistance received/provided
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20466">Technical Assistance Delivery Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefTechnicalAssistanceDeliveryTypeEntity? RefTechnicalAssistanceDeliveryTypeEntity { get; set; }

    #endregion
}
