//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServiceFrequencyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServiceFrequency file
/// </summary>
[Table("ServiceFrequency", Schema = "Common")]
public partial class ServiceFrequencyEntity : EntityBase, IServiceFrequency
{
    #region "IServiceFrequency Properties"
    /// <summary>
    /// Duration Length in Minutes
    /// <para>
    /// The number of minutes in an instance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20697">Duration Length in Minutes</a>
    /// </para>
    /// </summary>
    [Comment("The number of minutes in an instance.")]
    public Int32? DurationInMinutes { get; set; }

    /// <summary>
    /// Frequency Length
    /// <para>
    /// The number of units within a repeating cycle. Used with Frequency and Frequency Units elements to describe the occurrence of repeating events such as student services delivered 3 times a week for 16 weeks.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20696">Frequency Length</a>
    /// </para>
    /// </summary>
    [Comment("The number of units within a repeating cycle. Used with Frequency and Frequency Units elements to describe the occurrence of repeating events such as student services delivered 3 times a week for 16 weeks.")]
    public Int32? FrequencyLength { get; set; }

    /// <summary>
    /// Frequency Instances Per Cycle
    /// <para>
    /// The number of recurrences within a cycle.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20695">Frequency Instances Per Cycle</a>
    /// </para>
    /// </summary>
    [Comment("The number of recurrences within a cycle.")]
    public Int32? InstancesPerCycle { get; set; }

    /// <summary>
    /// Frequency Unit
    /// <para>
    /// The unit of time by which a cycle is defined.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20694">Frequency Unit</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFrequencyUnit")]
    [Comment("The unit of time by which a cycle is defined.")]
    public Guid? RefFrequencyUnitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ServicePlan")]
    public Guid ServicePlanId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ServicePlanEntity ServicePlanEntity { get; set; }

    /// <summary>
    /// The unit of time by which a cycle is defined.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20694">Frequency Unit</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFrequencyUnitEntity RefFrequencyUnitEntity { get; set; }

    #endregion
}
