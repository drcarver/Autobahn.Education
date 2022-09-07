//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   StaffTechnicalAssistanceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffTechnicalAssistance file
/// </summary>
public partial class StaffTechnicalAssistanceModel : AutobahnBaseModel, IStaffTechnicalAssistance
{
    #region "IStaffTechnicalAssistance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
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
    public Boolean? TechnicalAssistanceApprovedInd { get; set; }

    #endregion
}
