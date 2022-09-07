//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonHealthBirthEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHealthBirth file
/// </summary>
public partial class PersonHealthBirthModel : AutobahnBaseModel, IPersonHealthBirth
{
    #region "IPersonHealthBirth Properties"
    /// <summary>
    /// Multiple Birth Indicator
    /// <para>
    /// An indication that the person is a twin, triplet, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19421">Multiple Birth Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? MultipleBirthIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Trimester When Prenatal Care Began
    /// <para>
    /// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
    /// </para>
    /// </summary>
    public Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

    /// <summary>
    /// Weeks of Gestation
    /// <para>
    /// The number of weeks during gestational period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19313">Weeks of Gestation</a>
    /// </para>
    /// </summary>
    public Int32? WeeksOfGestation { get; set; }

    /// <summary>
    /// Weight at Birth
    /// <para>
    /// The weight of a child at birth in pounds and ounces.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
    /// </para>
    /// </summary>
    public System.String WeightAtBirth { get; set; }

    #endregion
}
