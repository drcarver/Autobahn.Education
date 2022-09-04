//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDigitalAccessEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDigitalAccess file
/// </summary>
public partial class PersonDigitalAccessModel : AutobahnBaseModel, IPersonDigitalAccess
{
    #region "IPersonDigitalAccess Properties"
    /// <summary>
    /// Internet Access In Residence
    /// <para>
    /// An indication of whether the student is able to access the internet in their primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20936">Internet Access In Residence</a>
    /// </para>
    /// </summary>
    public Boolean? InternetAccessInResidence { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    public Guid? PersonAddressId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Barrier to Internet Access In Residence
    /// <para>
    /// An indication of the barrier to having internet access in the student's primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20916">Barrier to Internet Access In Residence</a>
    /// </para>
    /// </summary>
    public Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

    /// <summary>
    /// Internet Access Type In Residence
    /// <para>
    /// The primary type of internet service used in the student's primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20937">Internet Access Type In Residence</a>
    /// </para>
    /// </summary>
    public Guid? RefInternetAccessTypeInResidenceId { get; set; }

    /// <summary>
    /// Internet Performance In Residence
    /// <para>
    /// An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20939">Internet Performance In Residence</a>
    /// </para>
    /// </summary>
    public Guid? RefInternetPerformanceInResidenceId { get; set; }

    #endregion
}
