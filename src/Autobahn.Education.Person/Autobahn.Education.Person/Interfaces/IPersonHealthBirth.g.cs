//***************************************************************************
//* DomainName: Person Models
//* FileName:   IPersonHealthBirth.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHealthBirth file
/// </summary>
public partial interface IPersonHealthBirth
{
    #region "IPersonHealthBirth Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Multiple Birth Indicator
    /// <para>
    /// An indication that the person is a twin, triplet, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19421">Multiple Birth Indicator</a>
    /// </para>
    /// </summary>
    Boolean? MultipleBirthIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Trimester When Prenatal Care Began
    /// <para>
    /// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
    /// </para>
    /// </summary>
    Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

    /// <summary>
    /// Weeks of Gestation
    /// <para>
    /// The number of weeks during gestational period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19313">Weeks of Gestation</a>
    /// </para>
    /// </summary>
    Int32? WeeksOfGestation { get; set; }

    /// <summary>
    /// Weight at Birth
    /// <para>
    /// The weight of a child at birth in pounds and ounces.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
    /// </para>
    /// </summary>
    System.String WeightAtBirth { get; set; }

    #endregion
}
