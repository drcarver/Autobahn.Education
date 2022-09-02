//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityEnergy file
/// </summary>
public partial class FacilityEnergyModel : AutobahnBaseModel, IFacilityEnergy
{
    #region "IFacilityEnergy Properties"
    /// <summary>
    /// Building Energy Service Company Name
    /// <para>
    /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20850">Building Energy Service Company Name</a>
    /// </para>
    /// </summary>
    public System.String BuildingEnergyServiceCompanyName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Energy Source Type
    /// <para>
    /// The source of energy that directly powers a school district facility or building system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20851">Building Energy Source Type</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingEnergySourceTypeId { get; set; }

    /// <summary>
    /// Facility Utility Provider Type
    /// <para>
    /// An indication of how utilities are supplied to a site or a building by a company or provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20859">Facility Utility Provider Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilityUtilityProviderTypeId { get; set; }

    /// <summary>
    /// Facility Utility Type
    /// <para>
    /// The type of utility used in the operation of a facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20860">Facility Utility Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilityUtilityTypeId { get; set; }

    #endregion
}
