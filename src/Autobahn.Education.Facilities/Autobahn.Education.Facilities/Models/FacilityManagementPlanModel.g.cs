//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityManagementPlan file
/// </summary>
public partial class FacilityManagementPlanModel : AutobahnBaseModel, IFacilityManagementPlan
{
    #region "IFacilityManagementPlan Properties"
    /// <summary>
    /// Facilities Plan Description
    /// <para>
    /// A description of the management and accountability plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20863">Facilities Plan Description</a>
    /// </para>
    /// </summary>
    public System.String FacilitiesPlanDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityManagement"/> model
    /// </summary>
    public Guid FacilityManagementId { get; set; }

    /// <summary>
    /// Facilities Management Emergency Type
    /// <para>
    /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20852">Facilities Management Emergency Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

    /// <summary>
    /// Facilities Plan Type
    /// <para>
    /// The type of management and accountability plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20864">Facilities Plan Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilitiesPlanTypeId { get; set; }

    #endregion
}
