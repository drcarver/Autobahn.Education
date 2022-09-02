//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonHomelessnessEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHomelessness file
/// </summary>
public partial class PersonHomelessnessModel : AutobahnBaseModel, IPersonHomelessness
{
    #region "IPersonHomelessness Properties"
    /// <summary>
    /// Homelessness Status
    /// <para>
    /// Children and youth who lack a fixed, regular, and adequate nighttime residence. Homeless children and youth include: 1) children and youth who are sharing the housing of other persons due to loss of housing, economic hardship, or a similar reason; are living in motels, hotels, trailer parks, or camping grounds due to the lack of alternative adequate accommodations; are living in emergency or transitional shelters; are abandoned in hospitals; or are awaiting foster care placement; 2) children and youth who have a primary nighttime residence that is a public or private place not designed for or originally used as a regular sleeping accommodation for human beings; or 3) children and youths who are living in cars, parks, public spaces, abandoned buildings, substandard housing, bus or train stations, or similar settings. 4) migratory children who qualify as homeless because the children are living in circumstances described in the above. (See Section 103 of the McKinney Act for a more detailed description of this data element).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19149">Homelessness Status</a>
    /// </para>
    /// </summary>
    public System.Boolean HomelessnessStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Homeless Primary Nighttime Residence
    /// <para>
    /// The primary nighttime residence of the person at the time the person was identified as homeless.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19146">Homeless Primary Nighttime Residence</a>
    /// </para>
    /// </summary>
    public Guid RefHomelessNighttimeResidenceId { get; set; }

    #endregion
}
