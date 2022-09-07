//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IServiceFrequency.g.cs
//***************************************************************************

/// <summary>
/// The IServiceFrequency file
/// </summary>
public partial interface IServiceFrequency
{
    #region "IServiceFrequency Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Duration Length in Minutes
    /// <para>
    /// The number of minutes in an instance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20697">Duration Length in Minutes</a>
    /// </para>
    /// </summary>
    Int32? DurationInMinutes { get; set; }

    /// <summary>
    /// Frequency Length
    /// <para>
    /// The number of units within a repeating cycle. Used with Frequency and Frequency Units elements to describe the occurrence of repeating events such as student services delivered 3 times a week for 16 weeks.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20696">Frequency Length</a>
    /// </para>
    /// </summary>
    Int32? FrequencyLength { get; set; }

    /// <summary>
    /// Frequency Instances Per Cycle
    /// <para>
    /// The number of recurrences within a cycle.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20695">Frequency Instances Per Cycle</a>
    /// </para>
    /// </summary>
    Int32? InstancesPerCycle { get; set; }

    /// <summary>
    /// Frequency Unit
    /// <para>
    /// The unit of time by which a cycle is defined.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20694">Frequency Unit</a>
    /// </para>
    /// </summary>
    Guid? RefFrequencyUnitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> model
    /// </summary>
    Guid ServicePlanId { get; set; }

    #endregion
}
