//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityHazard.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityHazard file
/// </summary>
public partial interface IFacilityHazard
{
    #region "IFacilityHazard Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Facility Hazardous Condition Expected Remediation Date
    /// <para>
    /// The month, day, and year by which a hazardous condition of a site or building is expected to be remediated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20823">Facility Hazardous Condition Expected Remediation Date</a>
    /// </para>
    /// </summary>
    DateTime? FacilityHazardousCondExpectedRemediationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Location of Hazardous Materials
    /// <para>
    /// The location at which the identified hazardous material is found.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20789">Facility Location of Hazardous Materials</a>
    /// </para>
    /// </summary>
    System.String FacilityLocationOfHazardousMaterials { get; set; }

    /// <summary>
    /// Facility Nearby Environmental Hazard Description
    /// <para>
    /// Description of any type of environmental hazards within range of the facility that has the potential to seriously affect the health, safety and operation of school facilities and their occupants.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20791">Facility Nearby Environmental Hazard Description</a>
    /// </para>
    /// </summary>
    System.String FacilityNearbyEnvHazardDescription { get; set; }

    /// <summary>
    /// Hazardous Material or Condition Description
    /// <para>
    /// A description of the seriousness a threat or hazardous material poses.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20825">Hazardous Material or Condition Description</a>
    /// </para>
    /// </summary>
    System.String HazardousMaterialOrConditionDescription { get; set; }

    /// <summary>
    /// Hazardous Material or Condition Testing Date
    /// <para>
    /// The month, day, and year that the site or building is tested for a specific hazardous material.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20826">Hazardous Material or Condition Testing Date</a>
    /// </para>
    /// </summary>
    DateTime? HazardousMaterialOrConditionTestingDate { get; set; }

    /// <summary>
    /// Facility Hazardous Materials or Condition Type
    /// <para>
    /// The type of hazardous materials or conditions tested for at a site or building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20855">Facility Hazardous Materials or Condition Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

    /// <summary>
    /// Facility Naturally Occurring Hazard Type
    /// <para>
    /// Type of natural hazard that can affect the health, safety and operation of school facilities and their occupants.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20858">Facility Naturally Occurring Hazard Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityNaturallyOccurringHazardTypeId { get; set; }

    #endregion
}
