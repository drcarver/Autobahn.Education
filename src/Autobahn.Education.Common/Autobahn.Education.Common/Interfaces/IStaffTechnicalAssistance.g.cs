//***************************************************************************
//* DomainName: Common Models
//* FileName:   IStaffTechnicalAssistance.g.cs
//***************************************************************************

/// <summary>
/// The IStaffTechnicalAssistance file
/// </summary>
public partial interface IStaffTechnicalAssistance
{
    #region "IStaffTechnicalAssistance Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Technical Assistance Delivery Type
    /// <para>
    /// The method of delivery of technical assistance received/provided
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20466">Technical Assistance Delivery Type</a>
    /// </para>
    /// </summary>
    Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

    /// <summary>
    /// Technical Assistance Type
    /// <para>
    /// The type of technical assistance provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20467">Technical Assistance Type</a>
    /// </para>
    /// </summary>
    Guid? RefTechnicalAssistanceTypeId { get; set; }

    /// <summary>
    /// Technical Assistance Approved Indicator
    /// <para>
    /// Indicates whether or not the technical assistance was approved.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20465">Technical Assistance Approved Indicator</a>
    /// </para>
    /// </summary>
    Boolean? TechnicalAssistanceApprovedInd { get; set; }

    #endregion
}
