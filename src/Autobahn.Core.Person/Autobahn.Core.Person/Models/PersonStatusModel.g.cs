//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonStatus file
/// </summary>
public partial class PersonStatusModel : AutobahnBaseModel, IPersonStatus
{
    #region "IPersonStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Economic Disadvantage Status
    /// <para>
    /// An indication that the student met the State criteria for classification as having an economic disadvantage.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19086">Economic Disadvantage Status</a>
    /// </para>
    /// </summary>
    public Guid RefPersonStatusTypeId { get; set; }

    /// <summary>
    /// Status End Date
    /// <para>
    /// The last year, month and day when a status applied to an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20193">Status End Date</a>
    /// </para>
    /// </summary>
    public DateTime? StatusEndDate { get; set; }

    /// <summary>
    /// Status Start Date
    /// <para>
    /// The year, month and day that a status became applicable to an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20192">Status Start Date</a>
    /// </para>
    /// </summary>
    public DateTime? StatusStartDate { get; set; }

    public System.Boolean StatusValue { get; set; }

    #endregion
}
