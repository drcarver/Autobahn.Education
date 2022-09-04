//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonFamilyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonFamily file
/// </summary>
[Table("PersonFamily", Schema = "Autobahn.Core.Person")]
public partial class PersonFamilyEntity : EntityBase, IPersonFamily
{
    #region "IPersonFamily Properties"
    /// <summary>
    /// Family Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to a family by a school, school system, a state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19784">Family Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique number or alphanumeric code assigned to a family by a school, school system, a state, or other agency or entity.")]
    public System.String FamilyIdentifier { get; set; }

    /// <summary>
    /// Family Income
    /// <para>
    /// Total income of family from all sources. Income includes money, wages or salary before deductions; net income from non-farm self-employment; net income from farm self-employment; regular payments from Social Security or railroad retirement; payments from unemployment compensation, strike benefits from union funds, workers' compensation, veterans benefits (with the exception noted below), public assistance (including Temporary Assistance for Needy Families, Supplemental Security Income, Emergency Assistance money payments, and non-Federally funded General Assistance or General Relief money payments); training stipends; alimony, child support, and military family allotments or other regular support from an absent family member or someone not living in the household; private pensions, government employee pensions (including military retirement pay), and regular insurance or annuity payments; college or university scholarships, grants, fellowships, and assistantships; and dividends, interest, net rental income, net royalties, and periodic receipts from estates or trusts; and net gambling or lottery winnings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19331">Family Income</a>
    /// </para>
    /// </summary>
    [Comment("Total income of family from all sources. Income includes money, wages or salary before deductions; net income from non-farm self-employment; net income from farm self-employment; regular payments from Social Security or railroad retirement; payments from unemployment compensation, strike benefits from union funds, workers' compensation, veterans benefits (with the exception noted below), public assistance (including Temporary Assistance for Needy Families, Supplemental Security Income, Emergency Assistance money payments, and non-Federally funded General Assistance or General Relief money payments); training stipends; alimony, child support, and military family allotments or other regular support from an absent family member or someone not living in the household; private pensions, government employee pensions (including military retirement pay), and regular insurance or annuity payments; college or university scholarships, grants, fellowships, and assistantships; and dividends, interest, net rental income, net royalties, and periodic receipts from estates or trusts; and net gambling or lottery winnings.")]
    public Decimal? FamilyIncome { get; set; }

    /// <summary>
    /// Included in Counted Family Size
    /// <para>
    /// Denotes whether this family member is counted in the family size as it pertains to the federal poverty level
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20591">Included in Counted Family Size</a>
    /// </para>
    /// </summary>
    [Comment("Denotes whether this family member is counted in the family size as it pertains to the federal poverty level")]
    public Boolean? IncludedInCountedFamilySize { get; set; }

    /// <summary>
    /// Number of Household College Students
    /// <para>
    /// Number of people, including the student, who will attend at least half-time in the current academic year, a program that leads to a college degree or certificate
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20950">Number of Household College Students</a>
    /// </para>
    /// </summary>
    [Comment("Number of people, including the student, who will attend at least half-time in the current academic year, a program that leads to a college degree or certificate")]
    public Int32? NumberOfHouseholdCollegeStudents { get; set; }

    /// <summary>
    /// Number of People in Family
    /// <para>
    /// Total number of persons in immediate family. Family means for the purposes of the regulations in this part all persons: (i) Living in the same household who are: (A) Supported by the income of the parent(s) or guardian(s) of the child enrolling or participating in the program; or (B) Related to the child by blood, marriage, or adoption; or &#x0D;
    /// </para>
    /// <para>
    /// <a href="">Number of People in Family</a>
    /// </para>
    /// </summary>
    [Comment("Total number of persons in immediate family. Family means for the purposes of the regulations in this part all persons: (i) Living in the same household who are: (A) Supported by the income of the parent(s) or guardian(s) of the child enrolling or participating in the program; or (B) Related to the child by blood, marriage, or adoption; or &#x0D;")]
    public Int32? NumberOfPeopleInFamily { get; set; }

    /// <summary>
    /// Number of People in Household
    /// <para>
    /// Total number of persons residing in the same household.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19330">Number of People in Household</a>
    /// </para>
    /// </summary>
    [Comment("Total number of persons residing in the same household.")]
    public Int32? NumberOfPeopleInHousehold { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Parent Communication Method
    /// <para>
    /// The types of communication methods with parents.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19857">Parent Communication Method</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCommunicationMethod")]
    [Comment("The types of communication methods with parents.")]
    public Guid? RefCommunicationMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramEligibility"/> model
    /// </summary>
    [ForeignKey("RefElprogramEligibility")]
    public Guid? RefElprogramEligibilityId { get; set; }

    /// <summary>
    /// Source of Family Income
    /// <para>
    /// Sources of total family income.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19332">Source of Family Income</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFamilyIncomeSource")]
    [Comment("Sources of total family income.")]
    public Guid? RefFamilyIncomeSourceId { get; set; }

    /// <summary>
    /// Highest Level of Education Completed
    /// <para>
    /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19141">Highest Level of Education Completed</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefHighestEducationLevelCompleted")]
    [Comment("The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).")]
    public Guid? RefHighestEducationLevelCompletedId { get; set; }

    /// <summary>
    /// Income Calculation Method
    /// <para>
    /// The calculation method used by a program to determine total family income.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19333">Income Calculation Method</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefIncomeCalculationMethod")]
    [Comment("The calculation method used by a program to determine total family income.")]
    public Guid? RefIncomeCalculationMethodId { get; set; }

    /// <summary>
    /// Proof of Residency Type
    /// <para>
    /// An accepted form of proof of residency in the district/county/other locality.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProofOfResidencyType")]
    [Comment("An accepted form of proof of residency in the district/county/other locality.")]
    public Guid? RefProofOfResidencyTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Sources of total family income.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19332">Source of Family Income</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefFamilyIncomeSourceEntity? RefFamilyIncomeSourceEntity { get; set; }

    /// <summary>
    /// The calculation method used by a program to determine total family income.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19333">Income Calculation Method</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefIncomeCalculationMethodEntity? RefIncomeCalculationMethodEntity { get; set; }

    /// <summary>
    /// An accepted form of proof of residency in the district/county/other locality.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefProofOfResidencyTypeEntity? RefProofOfResidencyTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElprogramEligibility"/> implementation
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefElprogramEligibilityEntity? RefElprogramEligibilityEntity { get; set; }

    /// <summary>
    /// The types of communication methods with parents.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19857">Parent Communication Method</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefCommunicationMethodEntity? RefCommunicationMethodEntity { get; set; }

    #endregion
}
